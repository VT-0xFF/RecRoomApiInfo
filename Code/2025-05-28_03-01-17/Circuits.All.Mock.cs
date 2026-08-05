using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x27B9250", Offset = "0x27B8050", VA = "0x1827B9250")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct NCJNGKJKCOE
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class AFBDDPOLEOM : FACHCHBHOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public AFBDDPOLEOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030", Slot = "4")]
		public FACHCHBHOJO GCEFBOFNDNM(string MAKJJJECHHB, string OAIIHELJHLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030", Slot = "5")]
		public FACHCHBHOJO PPCELFBEKKG(string MAKJJJECHHB, string[] OAIIHELJHLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xCA1030", Offset = "0xC9FE30", VA = "0x180CA1030", Slot = "6")]
		public FACHCHBHOJO DFIJNCNKKLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
		public void JPGAHJPOIJM()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[CIJGJFAEBAA("We should move most methods which create objects to their respective type.")]
[CIJGJFAEBAA("All of the methods in this type should use named parameters for clarity.")]
[IICOIOJKHLE("CircuitsMockUtil")]
public static class ILHELPKJFBC
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class AFINICJPPDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public OIAFHNGDCKD roomRestrictionsManager;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public AFINICJPPDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x27AC480", Offset = "0x27AB280", VA = "0x1827AC480")]
		internal OIOBLJKDDDM KEHOAGMJIJC(GKMMMOPALMB i)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LJDGMNIKNFN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public AsyncTaskMethodBuilder<EKFLBFBLJAN<OEDPLFAIDAD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public OIAFHNGDCKD roomRestrictionsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private TaskAwaiter<EKFLBFBLJAN<JAMKBHIIBJJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x27B7DC0", Offset = "0x27B6BC0", VA = "0x1827B7DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x27B8310", Offset = "0x27B7110", VA = "0x1827B8310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct KNEAPDFEFCO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public AsyncTaskMethodBuilder<JAMKBHIIBJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public IKMAMAHLHMO dependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public EHDNNCCPOFO network;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public FJFOJKNNALJ? registry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public LCBOCOCABKH? registryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public bool autoInitialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC8")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private TaskAwaiter<JAMKBHIIBJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x27B6D30", Offset = "0x27B5B30", VA = "0x1827B6D30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x27B7380", Offset = "0x27B6180", VA = "0x1827B7380", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct JCEMJEKNAOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<JAMKBHIIBJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EHDNNCCPOFO network;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public IKMAMAHLHMO dependencies;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public FJFOJKNNALJ registry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public LCBOCOCABKH registryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BB0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public BIHBDMOHDCK<KBIOCKDGHCK>? rootObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BB8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public bool autoInitialize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private JAMKBHIIBJJ <creationArgs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BE8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private HBDCLDOGDAK <root>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BF0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskAwaiter<JAMKBHIIBJJ> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BF8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter<bool> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x27B23D0", Offset = "0x27B11D0", VA = "0x1827B23D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x27B2990", Offset = "0x27B1790", VA = "0x1827B2990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x27B1C80", Offset = "0x27B0A80", VA = "0x1827B1C80")]
	[AsyncStateMachine(typeof(LJDGMNIKNFN))]
	public static Task<EKFLBFBLJAN<OEDPLFAIDAD>>? BCGPLOOEGCK([Optional] OIAFHNGDCKD? CGGBFEODBBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x27B1E40", Offset = "0x27B0C40", VA = "0x1827B1E40")]
	[IICOIOJKHLE("NewCircuits")]
	[AsyncStateMachine(typeof(KNEAPDFEFCO))]
	public static Task<JAMKBHIIBJJ> MIFFABLOHDO(EHDNNCCPOFO OEPNGJCDPGI, [Optional] IKMAMAHLHMO? NMFFKEACGFO, [Optional] FJFOJKNNALJ? ENALCCBHCIF, [Optional] LCBOCOCABKH? GPFGJHBJKPA, bool FELGKKBCOCC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x27B2000", Offset = "0x27B0E00", VA = "0x1827B2000")]
	[IICOIOJKHLE("NewCircuits")]
	[AsyncStateMachine(typeof(JCEMJEKNAOP))]
	public static Task<JAMKBHIIBJJ> MIFFABLOHDO(EHDNNCCPOFO OEPNGJCDPGI, IKMAMAHLHMO NMFFKEACGFO, FJFOJKNNALJ ENALCCBHCIF, LCBOCOCABKH GPFGJHBJKPA, BIHBDMOHDCK<KBIOCKDGHCK>? BMOINBMGGDF, bool FELGKKBCOCC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x27B1D70", Offset = "0x27B0B70", VA = "0x1827B1D70")]
	public static (CJEBIFMAOMH, MJGLOKLKDPM) BHHNBIDGKGF()
	{
		return default((CJEBIFMAOMH, MJGLOKLKDPM));
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x27B21D0", Offset = "0x27B0FD0", VA = "0x1827B21D0")]
	public static (CDHGLHIHFJF, FBDGPOAGLJJ) MPMDICFOFGG()
	{
		return default((CDHGLHIHFJF, FBDGPOAGLJJ));
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x27B22D0", Offset = "0x27B10D0", VA = "0x1827B22D0")]
	[IICOIOJKHLE("NewCircuitsNetwork")]
	public static EHDNNCCPOFO OGJIIOKHNPK(int INAJLBMHABM = 10240, int LILJFCLKDHC = 204800, int MDLFBJNKAMJ = 358400)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class AOLDBECPPJF
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate OIOBLJKDDDM DANBPCGMIPF(GKMMMOPALMB LBJPOLMJJBE);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct MNLCHPECHMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AsyncTaskMethodBuilder<EKFLBFBLJAN<JAMKBHIIBJJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public AOLDBECPPJF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<JAMKBHIIBJJ> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x27B89A0", Offset = "0x27B77A0", VA = "0x1827B89A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x27B8FB0", Offset = "0x27B7DB0", VA = "0x1827B8FB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly EHDNNCCPOFO BAOONLFKBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private DANBPCGMIPF? HOCOHEHPJGL;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	private AOLDBECPPJF(EHDNNCCPOFO OEPNGJCDPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x27AC980", Offset = "0x27AB780", VA = "0x1827AC980")]
	public static AOLDBECPPJF ANBHKEFMDCN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x27ACA40", Offset = "0x27AB840", VA = "0x1827ACA40")]
	public AOLDBECPPJF JNHNEAMJPBM(DANBPCGMIPF KINLJMKNJJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x27ACA60", Offset = "0x27AB860", VA = "0x1827ACA60")]
	[AsyncStateMachine(typeof(MNLCHPECHMD))]
	public Task<EKFLBFBLJAN<JAMKBHIIBJJ>> JPGAHJPOIJM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class EMGCMJPEFJI : HBDCLDOGDAK.PBNOGBMLKJF
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public delegate int OFNDBMEJKKP();

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void IOOOJIABCGB();

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void OMEONLMPCHO();

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate HLIFGONAOOA FHENJAJIMIN(DIFGANNFPID.OEKIHGBCEEC JCFBNAHPHAO);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void EFPPKOJGNJJ(HBDCLDOGDAK PINKMLPHMFP);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void OBCDEGNMCDB(HBDCLDOGDAK PINKMLPHMFP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly OFNDBMEJKKP MFAIFLPDFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly IOOOJIABCGB MPGNHACLKNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly OMEONLMPCHO GNECDBLLJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly FHENJAJIMIN FHCMGHOJJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly EFPPKOJGNJJ DPHGPPEHKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly OBCDEGNMCDB DOCEKPFNDFM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KDGFICIOAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x10EF120", Offset = "0x10EDF20", VA = "0x1810EF120", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x27AE5E0", Offset = "0x27AD3E0", VA = "0x1827AE5E0", Slot = "6")]
	public void HHLBIDHHEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x27AE610", Offset = "0x27AD410", VA = "0x1827AE610", Slot = "7")]
	public void LEMPAEGCONJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x27AE5B0", Offset = "0x27AD3B0", VA = "0x1827AE5B0", Slot = "5")]
	public HLIFGONAOOA BEEBNIKJJBG(DIFGANNFPID.OEKIHGBCEEC JCFBNAHPHAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xDA6AD0", Offset = "0xDA58D0", VA = "0x180DA6AD0", Slot = "8")]
	public void AFCGINBNKJC(HBDCLDOGDAK PINKMLPHMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xDA6A70", Offset = "0xDA5870", VA = "0x180DA6A70", Slot = "9")]
	public void BBNJCFLNKHE(HBDCLDOGDAK PINKMLPHMFP, CMGFJHDBEGO CFDGGKIIHOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x27AE640", Offset = "0x27AD440", VA = "0x1827AE640")]
	public EMGCMJPEFJI([Optional] OFNDBMEJKKP? DOINAJDAIDD, [Optional] IOOOJIABCGB? FOOIKNOJHCJ, [Optional] OMEONLMPCHO? IAGEEHPPPLE, [Optional] FHENJAJIMIN? AMEEOEGIFKG, [Optional] EFPPKOJGNJJ? CMJMDNPGAAI, [Optional] OBCDEGNMCDB? LFCMODPADDJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[IICOIOJKHLE("CircuitsCreationResult")]
public readonly struct JAMKBHIIBJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public readonly LCLGPAIHKMN<EHDNNCCPOFO, EHDNNCCPOFO.ODBHPFFEENP> DLGCBODAHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public readonly GAJAPGMPNCH<EHDNNCCPOFO, EHDNNCCPOFO.LDKLGLPDMEL> APAGIAJNHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public readonly HBDCLDOGDAK JKGCKOIPIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly BIHBDMOHDCK<FMJOCPEIHPL> KGPPMDENAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly EHDNNCCPOFO FKJDGICJJMH;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x27B2360", Offset = "0x27B1160", VA = "0x1827B2360")]
	public JAMKBHIIBJJ(LCLGPAIHKMN<EHDNNCCPOFO, EHDNNCCPOFO.ODBHPFFEENP> GOMEADMMGKL, GAJAPGMPNCH<EHDNNCCPOFO, EHDNNCCPOFO.LDKLGLPDMEL> MPDLBNEFAOP, HBDCLDOGDAK PINKMLPHMFP, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, EHDNNCCPOFO OEPNGJCDPGI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public readonly struct OEDPLFAIDAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly HBDCLDOGDAK BPKGJHGJDKJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public LCBOCOCABKH MLPAPKKKMGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x27B9430", Offset = "0x27B8230", VA = "0x1827B9430")]
		get
		{
			return default(LCBOCOCABKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public OALFCEOMBCC GLABPHHLEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x27B9460", Offset = "0x27B8260", VA = "0x1827B9460")]
		get
		{
			return default(OALFCEOMBCC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NNLJIKPEIHP? BJEDEKIAONG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x27B9330", Offset = "0x27B8130", VA = "0x1827B9330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CNOGAFAGIEK? JKKPMIOOIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x27B92D0", Offset = "0x27B80D0", VA = "0x1827B92D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0xD5BCB0", Offset = "0xD5AAB0", VA = "0x180D5BCB0")]
	internal OEDPLFAIDAD(HBDCLDOGDAK PINKMLPHMFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class CIBHIGAEIKH : IKMAMAHLHMO
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class LAEMGIGGKAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public OIOBLJKDDDM cv2Dependencies;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public LAEMGIGGKAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680")]
		internal OIOBLJKDDDM HMOKLEIBIKG()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NIBMFBMFLGC.AKJNGJKLMAC FCELHOAPNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DIFGANNFPID.OEKIHGBCEEC CAAKLLMPPGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HBDCLDOGDAK.PBNOGBMLKJF PLLANNGBADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HNLPMDFGNGL.LECFMDNGEBF MEGEGLFOGNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK> PLJNKBNICJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public OALFCEOMBCC.PHHLMNPFINA MAJALBDIOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JEAFHHJHNHG GMMJNAHCMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EOMAFEHEGOI GHPKLPMKACO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9A0", Offset = "0xA0C7A0", VA = "0x180A0D9A0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public CPNBFAFEOAK BLDEGIPKNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA0D020", Offset = "0xA0BE20", VA = "0x180A0D020", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ECGAGLEJEGA JFEMFFELPIO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA0D000", Offset = "0xA0BE00", VA = "0x180A0D000", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public LILPBIECJKB NLIPKEJHANA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA0CFF0", Offset = "0xA0BDF0", VA = "0x180A0CFF0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x27AD370", Offset = "0x27AC170", VA = "0x1827AD370")]
	private CIBHIGAEIKH(NIBMFBMFLGC.AKJNGJKLMAC IGMDDOOAPCK, DIFGANNFPID.OEKIHGBCEEC MMAOPFKOBFI, HBDCLDOGDAK.PBNOGBMLKJF MNKPAJIHFIL, HNLPMDFGNGL.LECFMDNGEBF LMBPMNOJHKB, GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK> NIEOIFDJEHE, OALFCEOMBCC.PHHLMNPFINA PNIPFAKDMJA, JEAFHHJHNHG OOGMKLGABJD, EOMAFEHEGOI EIABALAKKIF, CPNBFAFEOAK FJKEGPKADIO, ECGAGLEJEGA MPCHGKNKMNO, LILPBIECJKB OLMEFEPNKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x27ACB50", Offset = "0x27AB950", VA = "0x1827ACB50")]
	public static CIBHIGAEIKH? BFADLADFBJA(HNLPMDFGNGL.LECFMDNGEBF LMBPMNOJHKB, [Optional] NIBMFBMFLGC.AKJNGJKLMAC? IGMDDOOAPCK, [Optional] DIFGANNFPID.OEKIHGBCEEC? MMAOPFKOBFI, [Optional] HBDCLDOGDAK.PBNOGBMLKJF? MNKPAJIHFIL, [Optional] GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK>? NIEOIFDJEHE, [Optional] OALFCEOMBCC.PHHLMNPFINA? PNIPFAKDMJA, [Optional] JEAFHHJHNHG? OOGMKLGABJD, [Optional] EOMAFEHEGOI? EIABALAKKIF, [Optional] CPNBFAFEOAK? FJKEGPKADIO, [Optional] ECGAGLEJEGA? MPCHGKNKMNO, [Optional] LILPBIECJKB? OLMEFEPNKAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x27AD200", Offset = "0x27AC000", VA = "0x1827AD200")]
	public static CIBHIGAEIKH? PCFOFGELFAL(OIOBLJKDDDM PMIOPICPCII, [Optional] NIBMFBMFLGC.AKJNGJKLMAC? IGMDDOOAPCK, [Optional] DIFGANNFPID.OEKIHGBCEEC? MMAOPFKOBFI, [Optional] HBDCLDOGDAK.PBNOGBMLKJF? MNKPAJIHFIL, [Optional] GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK>? NIEOIFDJEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x27ACF60", Offset = "0x27ABD60", VA = "0x1827ACF60")]
	public static CIBHIGAEIKH? MHCNICKGGEL(GKMMMOPALMB GAOCFOAKLEJ, [Optional] NIBMFBMFLGC.AKJNGJKLMAC? IGMDDOOAPCK, [Optional] DIFGANNFPID.OEKIHGBCEEC? MMAOPFKOBFI, [Optional] HBDCLDOGDAK.PBNOGBMLKJF? MNKPAJIHFIL, [Optional] GGBCFBLMLAI.HLFJKDAONLJ<MHHBOGMHBCP, CMGFJHDBEGO, HBDCLDOGDAK>? NIEOIFDJEHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JGCNDAOEILB
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class EFAJPMGJJME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int maxCloudVariables;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public GKMMMOPALMB getNetworkObjectDelegate;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EFAJPMGJJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0")]
		internal int DNMKLEFJMCJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x27ADBC0", Offset = "0x27AC9C0", VA = "0x1827ADBC0")]
		internal LAELNBABHGN HJCDMKCMKMA(Guid graphId, GKJKNKIFDEP environmentId, bool isPlayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x27ADC20", Offset = "0x27ACA20", VA = "0x1827ADC20")]
		internal LAELNBABHGN[] MHMIBKJHIAL(GKJKNKIFDEP environmentId, Guid[] graphIds, bool isPlayer)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class DPPEGKOKPJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public GKJKNKIFDEP environmentId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public EFAJPMGJJME CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public DPPEGKOKPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x27ADB20", Offset = "0x27AC920", VA = "0x1827ADB20")]
		internal LAELNBABHGN KIKJOCMIHKM(Guid graphId)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static readonly EHDOPHDIBFE OFMMODIHFAA;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x27B2B00", Offset = "0x27B1900", VA = "0x1827B2B00")]
	public static LAELNBABHGN? EHFBFADGJCP(BIHBDMOHDCK<KBIOCKDGHCK>? AGEOBHEILHE, [Optional] LGBECFCOAIK.FOLNEFPFEGK? JEFAEEAIIBP, [Optional] LGBECFCOAIK.EKOOACKJDKA? DEHDLFANLLF, [Optional] LGBECFCOAIK.NBMKLCMHCNJ? FMEKBMBHEGI, bool DNBNGNNFCON = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x27B2B20", Offset = "0x27B1920", VA = "0x1827B2B20")]
	public static OIOBLJKDDDM? FHNBCJKBMHG(GKMMMOPALMB GAOCFOAKLEJ, bool IAHJIOICOOL = true, [Optional] PKJBGIACFMC? KNPAMEGFCLC, [Optional] AKGHGAGDGNL? PBFKMFHDKOA, [Optional] LJPINNDLKGL? PMOMFABMFPL, [Optional] OIAFHNGDCKD? DLJKOBENPEG, int NJMPBENCJIN = 300000, bool BLFBHLEJBPI = false, [Optional] PJJNEOGFGLC? EEMLNICHODP, [Optional] EKOHEHAMKEP? FKAADAKKMFO, [Optional] LHGBFCHHOFF? LDJEICEJGAA, [Optional] MLNOAEHIFBG? AMFPLHHDOGH, [Optional] JDLEDCNCBNJ? GBNCJAOAMLG, [Optional] BEENFEHKPGK? ALCPIPNLPIN, [Optional] NGEOAJOMCEN? MIFBNJCGBLO, [Optional] ENBCEDMPGEP.BNBHBKEMMFA? AKJOHDNDONH, [Optional] CNNFCMGMBCB.GPMGDKJEDOD? IECOOKHOMGL, [Optional] HDADOMGFMBE? JGHICPBIBNK, [Optional] OIOBLJKDDDM.DIHAJOBBDCE? LJHNHLDOADI, [Optional] OIOBLJKDDDM.CJCOMDEGPHB? GKPIBNDLFIE, [Optional] OIOBLJKDDDM.LOPAEHLKNOO? GFFHPKFNDMM, [Optional] OIOBLJKDDDM.CDLMLKCNLFE? KOBPJIHLLOO, [Optional] OIOBLJKDDDM.PAHJEHLLKPG? IOPNPKFJIKG, [Optional] OIOBLJKDDDM.FMDBKPGOGEP? LLNKGPLLABP, [Optional] OIOBLJKDDDM.ANLPOLCKICO? FMDKEEGGFMG, int OEDLNENDGDN = 100, [Optional] OIOBLJKDDDM.HDPJGEHLNHC? PKPJOCNCGEB, [Optional] OIOBLJKDDDM.EDFBBAOELKB? PBDINMFIPJM, [Optional] OIOBLJKDDDM.KIHHFCBBKEP? PJOPOBILFJF, [Optional] OIOBLJKDDDM.HBLACKFDPKE? EKNBAEHNIGP, [Optional] OIOBLJKDDDM.PAPPOFKPMEA? KDOMEKKACLH, [Optional] OIOBLJKDDDM.EJIOPAOKKIH? OADHGPBAJOA, [Optional] OIOBLJKDDDM.DNAKFDOMHFL? IDIHBKHKEPF, [Optional] OIOBLJKDDDM.GMKGMKLAMFP? BPDOOHGNKOG, [Optional] OIOBLJKDDDM.PDMDFPIFCBI? INDEFJGKGMB, [Optional] OIOBLJKDDDM.FHGDGMBLKFH? IMELLNCALBA, [Optional] OIOBLJKDDDM.MPDKGHHJOFJ? ACPKHDLCEFN, [Optional] OIOBLJKDDDM.CMAPJLPPKGE? EJBLCOGGENN, [Optional] OIOBLJKDDDM.BPGBNFEBMOK? FPDKBBBJPNP, [Optional] OIOBLJKDDDM.FAECEGFLBHN? FEMCMPIDACL, [Optional] OIOBLJKDDDM.JCBHHDLAGHB? NINGCIBKFCM, [Optional] OIOBLJKDDDM.FIBCMNNGEAP? IAIALINDGFJ, [Optional] OIOBLJKDDDM.AJBPMCLDJDN? ICLBHGFGKJB, [Optional] OIOBLJKDDDM.ELALDAFCLKL? CHJGGDFBMPM, [Optional] OIOBLJKDDDM.IINEPHGNOMP? NFJLJNPGDJO, [Optional] OIOBLJKDDDM.MOMAHFAGKGB? NAOMACGMIBL, [Optional] OIOBLJKDDDM.NEBHPPGFNBM? JOEOIBNNIFO, [Optional] OIOBLJKDDDM.NBANCGMJKGI? CIMNAGPMLIJ, [Optional] OIOBLJKDDDM.JEGNMFPNEIC? CLKDPLEAJFF, [Optional] OIOBLJKDDDM.HMGFAPNJLBC? CHMNDLMIELP, [Optional] OIOBLJKDDDM.FDANKDDPMME? FIAKFNKCMFE, [Optional] OIOBLJKDDDM.OIJACLHJPFB? JNJEIEAFJBJ, [Optional] OIOBLJKDDDM.OJMGKIFLMAO? JMAOAAJCKPK, [Optional] OIOBLJKDDDM.EBHDLOJCALJ? KONLHFFBNCJ, [Optional] OIOBLJKDDDM.AAPBNCEKKFA? LGNMPLOBNAP, [Optional] OIOBLJKDDDM.EPNJLAJCKOM? CGHDIAOBIFB, [Optional] OIOBLJKDDDM.KBJMONLGMEG? FGHKOEFACFM, [Optional] OIOBLJKDDDM.OECPHANGCAN? ACCKLJPOHGJ, [Optional] OIOBLJKDDDM.AMNKPPLKFGK? EMCJMNBFBBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public delegate BIHBDMOHDCK<KBIOCKDGHCK>? GKMMMOPALMB([In] Guid AEHJOFBOANC, GKJKNKIFDEP LEBLPDLNOOO);
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class KPGBCHAEHKC : MLNOAEHIFBG
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public delegate object PKFLAOALBPM();

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly KPGBCHAEHKC ICOFMPPJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly PKFLAOALBPM? CEEDEFMJOMJ;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x27B73F0", Offset = "0x27B61F0", VA = "0x1827B73F0", Slot = "4")]
	public (DKNKLDOICBN, DKNKLDOICBN, DKNKLDOICBN, DKNKLDOICBN, DKNKLDOICBN) CKKOJOJPFMF(object ENPELEHFGFF)
	{
		return default((DKNKLDOICBN, DKNKLDOICBN, DKNKLDOICBN, DKNKLDOICBN, DKNKLDOICBN));
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x27B7460", Offset = "0x27B6260", VA = "0x1827B7460", Slot = "5")]
	public object EHCGIBKHCHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "6")]
	public bool JOCIPIGBAHE(object ENPELEHFGFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x18D58A0", Offset = "0x18D46A0", VA = "0x1818D58A0", Slot = "7")]
	public string MACNHBNBJBJ(object ENPELEHFGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public KPGBCHAEHKC([Optional] PKFLAOALBPM? AFFMGAIGAOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public sealed class LGBECFCOAIK : LAELNBABHGN
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate bool FOLNEFPFEGK(LGBECFCOAIK FPFHIDBMBMI);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public delegate bool EKOOACKJDKA(LGBECFCOAIK FPFHIDBMBMI);

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate bool NBMKLCMHCNJ(LGBECFCOAIK FPFHIDBMBMI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly FOLNEFPFEGK PDPNJCFOPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private readonly EKOOACKJDKA LPDJBNPGIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly NBMKLCMHCNJ PAPMELDFCKK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public string? KHKODDKNOBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private JONOCBBAFCP? KAAPHNLKDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public GKJKNKIFDEP NPPGJOALEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(GKJKNKIFDEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool GJPJDEBLEJP
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x27B7D90", Offset = "0x27B6B90", VA = "0x1827B7D90", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EMIFEBMJNIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x27B7D60", Offset = "0x27B6B60", VA = "0x1827B7D60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool PKGLCJPKDPP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x27B7D30", Offset = "0x27B6B30", VA = "0x1827B7D30", Slot = "7")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public CEBHFJOBJGG? FNDNLHBLACA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public BIHBDMOHDCK<KBIOCKDGHCK>? OIGBNHFMGFA
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECA0", Offset = "0xA0DAA0", VA = "0x180A0ECA0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x27B7C00", Offset = "0x27B6A00", VA = "0x1827B7C00", Slot = "11")]
	public JIAPBKEBGKJ<GEDHHGFCHLC> Self()
	{
		return default(JIAPBKEBGKJ<GEDHHGFCHLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x27B75A0", Offset = "0x27B63A0", VA = "0x1827B75A0", Slot = "12")]
	public JIAPBKEBGKJ<GEDHHGFCHLC> GetRootObject(EHDOPHDIBFE ANMGGEBBMLP, HIDGDEMJMAO EHGKKBNDPEC)
	{
		return default(JIAPBKEBGKJ<GEDHHGFCHLC>);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA0CC30", Offset = "0xA0BA30", VA = "0x180A0CC30", Slot = "13")]
	public void Bind(JONOCBBAFCP NHEDBPCDPCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "14")]
	public void Unbind()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x27B7CA0", Offset = "0x27B6AA0", VA = "0x1827B7CA0")]
	private LGBECFCOAIK(BIHBDMOHDCK<KBIOCKDGHCK>? AGEOBHEILHE, FOLNEFPFEGK JEFAEEAIIBP, EKOOACKJDKA DEHDLFANLLF, NBMKLCMHCNJ FMEKBMBHEGI, string? IHGFMOMOADA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "15")]
	public void ConfigureAttachedObject()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "16")]
	public void RemoveAITracking()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x27B7640", Offset = "0x27B6440", VA = "0x1827B7640")]
	public static LGBECFCOAIK? NBEICDCLFEE(BIHBDMOHDCK<KBIOCKDGHCK>? AGEOBHEILHE, [Optional] FOLNEFPFEGK? JEFAEEAIIBP, [Optional] EKOOACKJDKA? DEHDLFANLLF, [Optional] NBMKLCMHCNJ? FMEKBMBHEGI, bool DNBNGNNFCON = false)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public sealed class GEMJPEINBDJ : PJJNEOGFGLC
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public delegate float KPJNHKIFEMH([In] float OAIIHELJHLG, [In] int IKPGBPADJDF);

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public delegate float OADCCLNAHKD([In] float OAIIHELJHLG, [In] int IKPGBPADJDF);

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public delegate FJNIAMGOABG FLDODFFENNH([In] FJNIAMGOABG CHIPBNNCPBF, [In] FJNIAMGOABG MDEAIGKHMKE, float JIJABGNNHPJ);

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public delegate float EGGDCCHBLLJ([In] FJNIAMGOABG CHIPBNNCPBF, [In] FJNIAMGOABG MDEAIGKHMKE, [In] FJNIAMGOABG KMBJNMDOLGN);

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public delegate NPKPAEPCCIF GNBKCNDIBEG([In] KNNDIEJAHNG FPFHIDBMBMI);

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public delegate OFJEKJFLDPF KJMDAPDCKHE([In] KNNDIEJAHNG FPFHIDBMBMI);

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public delegate KNNDIEJAHNG LKGHOLJIMCD([In] KNNDIEJAHNG FPFHIDBMBMI);

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public delegate KNNDIEJAHNG EGBGPLFPHLA([In] KNNDIEJAHNG ALCLKCHJGII, [In] KNNDIEJAHNG GFJPONDOIDH);

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public delegate KNNDIEJAHNG IEIOINJJDGD([In] BHMLNBEKKIC FPFHIDBMBMI);

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public delegate float IFEAGKKAMHA([In] OFJEKJFLDPF ALCLKCHJGII, [In] OFJEKJFLDPF GFJPONDOIDH);

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate OFJEKJFLDPF CJONBIEFLDB(float HIFOHDMLFOA, [In] NPKPAEPCCIF AFBNIALGAIO);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public delegate OFJEKJFLDPF KEEOMLLMEGL([In] NPKPAEPCCIF GPOMFMOKBNB);

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate OFJEKJFLDPF AFKEPKOPBKN([In] NPKPAEPCCIF OMIJNNNJAEH, [In] NPKPAEPCCIF MOLDHLHGKKJ);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public delegate OFJEKJFLDPF PKHCLHGKIJN([In] NPKPAEPCCIF MDBOPEGLJFG, [In] NPKPAEPCCIF DAMJNECINFM);

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate float OKKPIKHEGAI([In] OFJEKJFLDPF ALCLKCHJGII, [In] OFJEKJFLDPF GFJPONDOIDH);

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate OFJEKJFLDPF PCCPPMJDOLD([In] OFJEKJFLDPF FPFHIDBMBMI);

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate OFJEKJFLDPF MCKDMLKLLHN([In] OFJEKJFLDPF CHIPBNNCPBF, [In] OFJEKJFLDPF MDEAIGKHMKE, float JIJABGNNHPJ);

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate OFJEKJFLDPF NPBMFAOFGMG([In] OFJEKJFLDPF CHIPBNNCPBF, [In] OFJEKJFLDPF MDEAIGKHMKE, float JIJABGNNHPJ);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate float FCBCLENLPPM([In] OFJEKJFLDPF CHIPBNNCPBF, [In] OFJEKJFLDPF MDEAIGKHMKE, [In] OFJEKJFLDPF KMBJNMDOLGN);

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public delegate OFJEKJFLDPF ELNLCACFOEB([In] OFJEKJFLDPF ALCLKCHJGII, [In] OFJEKJFLDPF GFJPONDOIDH);

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate OFJEKJFLDPF KAKHCEGAGBN([In] OFJEKJFLDPF FPFHIDBMBMI);

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public delegate OFJEKJFLDPF EHABLMFGDGH([In] OFJEKJFLDPF HLHNGKLKCFJ, [In] OFJEKJFLDPF GJCHJCHAFHC, float PJBCAOPCECH);

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate NPKPAEPCCIF MDLIBLJOGME([In] OFJEKJFLDPF FPFHIDBMBMI, [In] NPKPAEPCCIF AJIEOIDDJAD);

	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public delegate OFJEKJFLDPF HGPDPGFJDJP([In] OFJEKJFLDPF CHIPBNNCPBF, [In] OFJEKJFLDPF MDEAIGKHMKE, float JIJABGNNHPJ);

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public delegate void HBMEGFBJJNP([In] OFJEKJFLDPF FPFHIDBMBMI, [Out] float HIFOHDMLFOA, [Out] NPKPAEPCCIF AFBNIALGAIO);

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public delegate NPKPAEPCCIF AKKGLKCDODJ([In] OFJEKJFLDPF FPFHIDBMBMI);

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public delegate NPKPAEPCCIF DCILDHPBHDG([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH);

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate NPKPAEPCCIF PJKFGEHLGFH([In] NPKPAEPCCIF FPFHIDBMBMI, [In] float JLMEKGPDJJB);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public delegate NPKPAEPCCIF FOBCHLNKKJM([In] NPKPAEPCCIF FPFHIDBMBMI, [In] NPKPAEPCCIF PCHCALKOBOF, [In] NPKPAEPCCIF LFFEBJIOAJJ);

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public delegate NPKPAEPCCIF IOLEOPMNLLG([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH);

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public delegate float KFBCKPLDMEM([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH);

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public delegate float GGKDMFGMFKI([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH);

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public delegate float PFEECANEOJL([In] NPKPAEPCCIF FPFHIDBMBMI);

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public delegate NPKPAEPCCIF FBIGIMFKEDG([In] NPKPAEPCCIF CHIPBNNCPBF, [In] NPKPAEPCCIF MDEAIGKHMKE, float JIJABGNNHPJ);

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public delegate NPKPAEPCCIF DBGDFKJNAFK([In] NPKPAEPCCIF CHIPBNNCPBF, [In] NPKPAEPCCIF MDEAIGKHMKE, float JIJABGNNHPJ);

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public delegate float POJLKCNJMDD([In] NPKPAEPCCIF CHIPBNNCPBF, [In] NPKPAEPCCIF MDEAIGKHMKE, [In] NPKPAEPCCIF KMBJNMDOLGN);

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public delegate NPKPAEPCCIF PLFJCDCBCMN([In] NPKPAEPCCIF DDEBNKFKCJA, [In] NPKPAEPCCIF GDCDKMJLKDH, float KKAJLCHPCBA);

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public delegate NPKPAEPCCIF KMMKBKFFHEJ([In] NPKPAEPCCIF FPFHIDBMBMI);

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public delegate NPKPAEPCCIF IAGDPEIDJBJ([In] NPKPAEPCCIF FPFHIDBMBMI);

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public delegate NPKPAEPCCIF ICJCPKFDNII([In] NPKPAEPCCIF FPFHIDBMBMI, [In] NPKPAEPCCIF POIANHHCBDH);

	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public delegate NPKPAEPCCIF GCANLHMHENN([In] NPKPAEPCCIF FPFHIDBMBMI, [In] NPKPAEPCCIF LFFEBJIOAJJ);

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public delegate NPKPAEPCCIF MOPIGHNBLLE([In] NPKPAEPCCIF FPFHIDBMBMI, float GMJFIEDPAMM);

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public delegate NPKPAEPCCIF MEIGOBEBFNE([In] NPKPAEPCCIF DDEBNKFKCJA, [In] NPKPAEPCCIF GDCDKMJLKDH, [In] NPKPAEPCCIF OPOFGKBJGEF, float ONFHNKKNHMD, float KGIMKDKAEAH, float GNNOPFAGLOD, [Out] NPKPAEPCCIF GPBPHJJLKFP);

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public delegate NPKPAEPCCIF JEGGJHPFKEA([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH);

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public delegate NPKPAEPCCIF NAIIDDOOENK([In] NPKPAEPCCIF CHIPBNNCPBF, [In] NPKPAEPCCIF MDEAIGKHMKE, float JIJABGNNHPJ);

	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public delegate NPKPAEPCCIF COFCEIMNDPD([In] NPKPAEPCCIF HAEJIMJGLDC, [In] NPKPAEPCCIF GILMMEPBGCD, [In] OFJEKJFLDPF JIGNOCOKKEP);

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public delegate NPKPAEPCCIF IOALFNKLJMO([In] NPKPAEPCCIF JIEGOKAJLGF, [In] NPKPAEPCCIF GILMMEPBGCD, [In] OFJEKJFLDPF JIGNOCOKKEP);

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public delegate float EMLMKIDBOMN();

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly GEMJPEINBDJ ICOFMPPJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly KPJNHKIFEMH? EGJEIBKBHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly OADCCLNAHKD? ABKDMICKKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private readonly FLDODFFENNH? ILEDFFHKOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly EGGDCCHBLLJ? OOJCONMINIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly GNBKCNDIBEG? CPLHEALHIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly KJMDAPDCKHE? DGGFGKJPLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly LKGHOLJIMCD? DNIPPPLFOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly EGBGPLFPHLA? JCFMIPIIFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly IEIOINJJDGD? FMNBBGLBCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly IFEAGKKAMHA? DJKLCFDBHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly CJONBIEFLDB? OGKMJEMBJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly KEEOMLLMEGL? NNEMPOOEMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly AFKEPKOPBKN? GANAJKFHJEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly PKHCLHGKIJN? CCKALGEOPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly OKKPIKHEGAI? CEOPFPMHMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly PCCPPMJDOLD? DHKCGDAFHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly MCKDMLKLLHN? GAACBNEKMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NPBMFAOFGMG? DFHPKKLPOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly FCBCLENLPPM? NPOHOFPCMNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly ELNLCACFOEB? AOCCBCGJEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly KAKHCEGAGBN? MFKIMLJACAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly EHABLMFGDGH? PGPHHOBHHCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly MDLIBLJOGME? NKHOLPLJAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly HGPDPGFJDJP? NAIOJDJBCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly HBMEGFBJJNP? DLKCAACODNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly AKKGLKCDODJ? BKLBDNLMCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly DCILDHPBHDG? HNICPNMLDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly PJKFGEHLGFH? DILHEGHAKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly FOBCHLNKKJM? BLEFHKNJCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly IOLEOPMNLLG? IAEFCDLAGEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly KFBCKPLDMEM? ABKOGBENBAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly GGKDMFGMFKI? OPNONHKNBPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private readonly PFEECANEOJL? BIGMEJJJBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly FBIGIMFKEDG? LALGDKOHIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly DBGDFKJNAFK? AJPFFNEJKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly POJLKCNJMDD? OGGOPFJFCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private readonly PLFJCDCBCMN? FFIKHPEHJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly KMMKBKFFHEJ? FGGHAIMJPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly IAGDPEIDJBJ? NLOCKEJPKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly ICJCPKFDNII? DDHGIBLNBKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly GCANLHMHENN? DFHPJFLDEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly MOPIGHNBLLE? DOOPIDNOMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly MEIGOBEBFNE? BPCLGEPICOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly JEGGJHPFKEA? HPIHCNAPAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly NAIIDDOOENK? FFDPBPCJHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly COFCEIMNDPD? OJLIBLJJGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly IOALFNKLJMO? GKKAHNAJIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly EMLMKIDBOMN? FBKLOLBFHLI;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x27B1230", Offset = "0x27B0030", VA = "0x1827B1230")]
	public GEMJPEINBDJ([Optional] FLDODFFENNH? FOHIDGGIGDA, [Optional] EGGDCCHBLLJ? KJLNDKGJHMJ, [Optional] GNBKCNDIBEG? NJDKIFBFPNI, [Optional] KJMDAPDCKHE? MGDLPHFFGFE, [Optional] LKGHOLJIMCD? AFNOADBGNLK, [Optional] EGBGPLFPHLA? GGKEMAJDBIE, [Optional] IEIOINJJDGD? GIAGEKEPCGD, [Optional] IFEAGKKAMHA? EEEKAEODHIM, [Optional] CJONBIEFLDB? ODMGCGLEHDE, [Optional] KEEOMLLMEGL? BPNCBCLBAOO, [Optional] AFKEPKOPBKN? JCFJNFLAPLJ, [Optional] PKHCLHGKIJN? OLAFEFFIKIL, [Optional] OKKPIKHEGAI? FIBMALHBHNP, [Optional] PCCPPMJDOLD? DCLKBGOMAGA, [Optional] MCKDMLKLLHN? GLMEFMGGBEP, [Optional] NPBMFAOFGMG? NGIJBKPLHPF, [Optional] FCBCLENLPPM? PGPAAMOFOMN, [Optional] ELNLCACFOEB? DDNJEILJJHH, [Optional] KAKHCEGAGBN? DFIMHBPCCKP, [Optional] EHABLMFGDGH? ABCDNJHEBOM, [Optional] MDLIBLJOGME? NBBDPIEKDID, [Optional] HGPDPGFJDJP? OBILOPDEICA, [Optional] HBMEGFBJJNP? JKMCELPKOJC, [Optional] AKKGLKCDODJ? JHBGKEKIMBN, [Optional] DCILDHPBHDG? NONDALEGDCO, [Optional] PJKFGEHLGFH? ANDOIGDCBAO, [Optional] FOBCHLNKKJM? LFMLFNCKHEK, [Optional] IOLEOPMNLLG? NGMFCEGBABG, [Optional] KFBCKPLDMEM? FFLOCMPLPEI, [Optional] GGKDMFGMFKI? EHAAJCEMDLG, [Optional] PFEECANEOJL? BECMPBKOLLP, [Optional] FBIGIMFKEDG? DOPEIMBBHOB, [Optional] DBGDFKJNAFK? IEAKDHJIMBA, [Optional] POJLKCNJMDD? OKFMLEIBPLB, [Optional] PLFJCDCBCMN? AGPKFJEMGPO, [Optional] KMMKBKFFHEJ? HMENPEOINBG, [Optional] IAGDPEIDJBJ? AAOJJEMIHLG, [Optional] ICJCPKFDNII? JGLEGIDPOFI, [Optional] GCANLHMHENN? KDGKLFJPJCB, [Optional] MOPIGHNBLLE? HJEOKILIKCK, [Optional] MEIGOBEBFNE? HJEEHANNEJN, [Optional] JEGGJHPFKEA? JHIKKGBMLEL, [Optional] NAIIDDOOENK? ODDPDHBINHA, [Optional] COFCEIMNDPD? FBEFEPBOJAJ, [Optional] IOALFNKLJMO? LCAAAFBPBLB, [Optional] EMLMKIDBOMN? EJOPPLMIGDO, [Optional] KPJNHKIFEMH? FJKPLFCOMDM, [Optional] OADCCLNAHKD? JEKCCPNIKFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x27AF0E0", Offset = "0x27ADEE0", VA = "0x1827AF0E0")]
	public float GIDCEPACCHL([In] float OAIIHELJHLG, [In] int IKPGBPADJDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x27AF3B0", Offset = "0x27AE1B0", VA = "0x1827AF3B0")]
	public float PGKIHJHNKKF([In] float OAIIHELJHLG, [In] int IKPGBPADJDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x27AFF70", Offset = "0x27AED70", VA = "0x1827AFF70")]
	public FJNIAMGOABG FGEHNAJCDNL([In] FJNIAMGOABG CHIPBNNCPBF, [In] FJNIAMGOABG MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(FJNIAMGOABG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x27B04B0", Offset = "0x27AF2B0", VA = "0x1827B04B0")]
	public float MIICLEDIALO([In] FJNIAMGOABG CHIPBNNCPBF, [In] FJNIAMGOABG MDEAIGKHMKE, [In] FJNIAMGOABG KMBJNMDOLGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x27B0D10", Offset = "0x27AFB10", VA = "0x1827B0D10")]
	public NPKPAEPCCIF MKALFADAGJF([In] KNNDIEJAHNG FPFHIDBMBMI)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x27B0340", Offset = "0x27AF140", VA = "0x1827B0340")]
	public OFJEKJFLDPF GMELKBFECPP([In] KNNDIEJAHNG FPFHIDBMBMI)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x27B0550", Offset = "0x27AF350", VA = "0x1827B0550")]
	public KNNDIEJAHNG ICNAIOLJBDM([In] KNNDIEJAHNG FPFHIDBMBMI)
	{
		return default(KNNDIEJAHNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x27AF3F0", Offset = "0x27AE1F0", VA = "0x1827AF3F0")]
	public KNNDIEJAHNG BFBKGBIPEPA([In] KNNDIEJAHNG ALCLKCHJGII, [In] KNNDIEJAHNG GFJPONDOIDH)
	{
		return default(KNNDIEJAHNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x27B0F80", Offset = "0x27AFD80", VA = "0x1827B0F80")]
	public KNNDIEJAHNG PEKMFKLECHK([In] BHMLNBEKKIC FPFHIDBMBMI)
	{
		return default(KNNDIEJAHNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x27AF1B0", Offset = "0x27ADFB0", VA = "0x1827AF1B0")]
	public float PEFGOJLDBMF([In] OFJEKJFLDPF ALCLKCHJGII, [In] OFJEKJFLDPF GFJPONDOIDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x27B0390", Offset = "0x27AF190", VA = "0x1827B0390")]
	public OFJEKJFLDPF GPOFCCJMKED(float HIFOHDMLFOA, [In] NPKPAEPCCIF AFBNIALGAIO)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x27B0A70", Offset = "0x27AF870", VA = "0x1827B0A70")]
	public OFJEKJFLDPF MIBGHNIKLHB([In] NPKPAEPCCIF GPOMFMOKBNB)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x27AF300", Offset = "0x27AE100", VA = "0x1827AF300")]
	public OFJEKJFLDPF AONHJBKFGME([In] NPKPAEPCCIF OMIJNNNJAEH, [In] NPKPAEPCCIF MOLDHLHGKKJ)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x27B0B10", Offset = "0x27AF910", VA = "0x1827B0B10")]
	public OFJEKJFLDPF LIEOEDOKAFL([In] NPKPAEPCCIF MDBOPEGLJFG, [In] NPKPAEPCCIF DAMJNECINFM)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x27AF510", Offset = "0x27AE310", VA = "0x1827AF510")]
	public OFJEKJFLDPF OKPOMNAPCNB([In] OFJEKJFLDPF FPFHIDBMBMI)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x27AF620", Offset = "0x27AE420", VA = "0x1827AF620")]
	public OFJEKJFLDPF CBOLFFJIANF([In] OFJEKJFLDPF CHIPBNNCPBF, [In] OFJEKJFLDPF MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x27B0280", Offset = "0x27AF080", VA = "0x1827B0280")]
	public OFJEKJFLDPF MLPFGOELNHJ([In] OFJEKJFLDPF CHIPBNNCPBF, [In] OFJEKJFLDPF MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x27AF180", Offset = "0x27ADF80", VA = "0x1827AF180")]
	public float ALNDDIBCOIE([In] OFJEKJFLDPF CHIPBNNCPBF, [In] OFJEKJFLDPF MDEAIGKHMKE, [In] OFJEKJFLDPF KMBJNMDOLGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x27AFD70", Offset = "0x27AEB70", VA = "0x1827AFD70")]
	public OFJEKJFLDPF IHEENDBBDNB([In] OFJEKJFLDPF ALCLKCHJGII, [In] OFJEKJFLDPF GFJPONDOIDH)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x27AF8B0", Offset = "0x27AE6B0", VA = "0x1827AF8B0")]
	public OFJEKJFLDPF FLAMJNHDGGB([In] OFJEKJFLDPF FPFHIDBMBMI)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x27B09B0", Offset = "0x27AF7B0", VA = "0x1827B09B0")]
	public OFJEKJFLDPF NBCDDJHDFCA([In] OFJEKJFLDPF HLHNGKLKCFJ, [In] OFJEKJFLDPF GJCHJCHAFHC, float PJBCAOPCECH)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x27AF4A0", Offset = "0x27AE2A0", VA = "0x1827AF4A0")]
	public NPKPAEPCCIF BLIFOKMEHCF([In] OFJEKJFLDPF FPFHIDBMBMI, [In] NPKPAEPCCIF AJIEOIDDJAD)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x27AF1D0", Offset = "0x27ADFD0", VA = "0x1827AF1D0")]
	public OFJEKJFLDPF ANFEHEMEDMI([In] OFJEKJFLDPF CHIPBNNCPBF, [In] OFJEKJFLDPF MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x27AF460", Offset = "0x27AE260", VA = "0x1827AF460")]
	public void MBGCCKAAJOM([In] OFJEKJFLDPF FPFHIDBMBMI, [Out] float HIFOHDMLFOA, [Out] NPKPAEPCCIF AFBNIALGAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x27AFB20", Offset = "0x27AE920", VA = "0x1827AFB20")]
	public NPKPAEPCCIF DMIFPKFIPGJ([In] OFJEKJFLDPF FPFHIDBMBMI)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x27AF770", Offset = "0x27AE570", VA = "0x1827AF770")]
	public NPKPAEPCCIF CGINPMDICHC([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x27AF700", Offset = "0x27AE500", VA = "0x1827AF700")]
	public NPKPAEPCCIF CDKGMPDCBIB([In] NPKPAEPCCIF FPFHIDBMBMI, float JLMEKGPDJJB)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x27B0DD0", Offset = "0x27AFBD0", VA = "0x1827B0DD0")]
	public NPKPAEPCCIF NLAPKDIBAPB([In] NPKPAEPCCIF FPFHIDBMBMI, [In] NPKPAEPCCIF PCHCALKOBOF, [In] NPKPAEPCCIF LFFEBJIOAJJ)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x27AF840", Offset = "0x27AE640", VA = "0x1827AF840")]
	public NPKPAEPCCIF CIKEEKBKMJE([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x27AF100", Offset = "0x27ADF00", VA = "0x1827AF100")]
	public float AHLHJMONHEF([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x27AF6E0", Offset = "0x27AE4E0", VA = "0x1827AF6E0")]
	public float CDDBDCCCEDJ([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x27AF3D0", Offset = "0x27AE1D0", VA = "0x1827AF3D0")]
	public float BEHDFKHNBFB([In] NPKPAEPCCIF FPFHIDBMBMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x27AFA20", Offset = "0x27AE820", VA = "0x1827AFA20")]
	public NPKPAEPCCIF DFBNJCKDKOE([In] NPKPAEPCCIF CHIPBNNCPBF, [In] NPKPAEPCCIF MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x27B0CA0", Offset = "0x27AFAA0", VA = "0x1827B0CA0")]
	public NPKPAEPCCIF MIJNEKPDLME([In] NPKPAEPCCIF CHIPBNNCPBF, [In] NPKPAEPCCIF MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x27AFAF0", Offset = "0x27AE8F0", VA = "0x1827AFAF0")]
	public float HPNMFCDHLCN([In] NPKPAEPCCIF CHIPBNNCPBF, [In] NPKPAEPCCIF MDEAIGKHMKE, [In] NPKPAEPCCIF KMBJNMDOLGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x27B0FF0", Offset = "0x27AFDF0", VA = "0x1827B0FF0")]
	public NPKPAEPCCIF PMOFGIHCILH([In] NPKPAEPCCIF DDEBNKFKCJA, [In] NPKPAEPCCIF GDCDKMJLKDH, float KKAJLCHPCBA)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x27B0F20", Offset = "0x27AFD20", VA = "0x1827B0F20")]
	public NPKPAEPCCIF OPMKNKJIPPA([In] NPKPAEPCCIF FPFHIDBMBMI)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x27AFD10", Offset = "0x27AEB10", VA = "0x1827AFD10")]
	public NPKPAEPCCIF EJJAEAEKLOA([In] NPKPAEPCCIF FPFHIDBMBMI)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x27B0030", Offset = "0x27AEE30", VA = "0x1827B0030")]
	public NPKPAEPCCIF FJDADCCNINM([In] NPKPAEPCCIF FPFHIDBMBMI, [In] NPKPAEPCCIF POIANHHCBDH)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x27AF5B0", Offset = "0x27AE3B0", VA = "0x1827AF5B0")]
	public NPKPAEPCCIF BOOJHJIGGFM([In] NPKPAEPCCIF FPFHIDBMBMI, [In] NPKPAEPCCIF LFFEBJIOAJJ)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x27AF290", Offset = "0x27AE090", VA = "0x1827AF290")]
	public NPKPAEPCCIF ANHEILMCHFG([In] NPKPAEPCCIF FPFHIDBMBMI, float GMJFIEDPAMM)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x27AFB80", Offset = "0x27AE980", VA = "0x1827AFB80")]
	public NPKPAEPCCIF EBEDHHLDJPK([In] NPKPAEPCCIF DDEBNKFKCJA, [In] NPKPAEPCCIF GDCDKMJLKDH, [In] NPKPAEPCCIF OPOFGKBJGEF, float ONFHNKKNHMD, float KGIMKDKAEAH, float GNNOPFAGLOD, [Out] NPKPAEPCCIF GPBPHJJLKFP)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x27B0630", Offset = "0x27AF430", VA = "0x1827B0630")]
	public NPKPAEPCCIF ILCKPNGBGGC([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x27B0C30", Offset = "0x27AFA30", VA = "0x1827B0C30")]
	public NPKPAEPCCIF MFOGKCINMFH([In] NPKPAEPCCIF CHIPBNNCPBF, [In] NPKPAEPCCIF MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x27AF950", Offset = "0x27AE750", VA = "0x1827AF950")]
	public NPKPAEPCCIF CPPDLADHHKI([In] NPKPAEPCCIF HAEJIMJGLDC, [In] NPKPAEPCCIF GILMMEPBGCD, [In] OFJEKJFLDPF JIGNOCOKKEP)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x27B0210", Offset = "0x27AF010", VA = "0x1827B0210")]
	public NPKPAEPCCIF GHNFNCLLFNP([In] NPKPAEPCCIF JIEGOKAJLGF, [In] NPKPAEPCCIF GILMMEPBGCD, [In] OFJEKJFLDPF JIGNOCOKKEP)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x27B0890", Offset = "0x27AF690", VA = "0x1827B0890", Slot = "50")]
	public Task JMFBKNEOCMO(Func<Task> HPCIBKDHMEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "51")]
	public void IIHHFPIGHEI([Optional] string? NJJDPBHNDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x27B06A0", Offset = "0x27AF4A0", VA = "0x1827B06A0", Slot = "52")]
	public BAOOKPBABPO IOCEBCGMIPG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x27B00A0", Offset = "0x27AEEA0", VA = "0x1827B00A0", Slot = "53")]
	public BAOOKPBABPO FJKHOJOECMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x27B08C0", Offset = "0x27AF6C0", VA = "0x1827B08C0", Slot = "54")]
	public float KAFLEPPNKIO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x27AF0E0", Offset = "0x27ADEE0", VA = "0x1827AF0E0", Slot = "4")]
	private float ADEFBACLIHJ([In] float OAIIHELJHLG, [In] int IKPGBPADJDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x27AF3B0", Offset = "0x27AE1B0", VA = "0x1827AF3B0", Slot = "5")]
	private float BCJGBHDFAIH([In] float OAIIHELJHLG, [In] int IKPGBPADJDF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x27AF120", Offset = "0x27ADF20", VA = "0x1827AF120", Slot = "6")]
	private FJNIAMGOABG AIPKPBJMNAG([In] FJNIAMGOABG CHIPBNNCPBF, [In] FJNIAMGOABG MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(FJNIAMGOABG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x27B04B0", Offset = "0x27AF2B0", VA = "0x1827B04B0", Slot = "7")]
	private float IACHAOPKFJM([In] FJNIAMGOABG CHIPBNNCPBF, [In] FJNIAMGOABG MDEAIGKHMKE, [In] FJNIAMGOABG KMBJNMDOLGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x27AFFD0", Offset = "0x27AEDD0", VA = "0x1827AFFD0", Slot = "8")]
	private NPKPAEPCCIF FHKCEJKEEHI([In] KNNDIEJAHNG FPFHIDBMBMI)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x27B0150", Offset = "0x27AEF50", VA = "0x1827B0150", Slot = "9")]
	private OFJEKJFLDPF FPJNKABJNGH([In] KNNDIEJAHNG FPFHIDBMBMI)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x27AF9C0", Offset = "0x27AE7C0", VA = "0x1827AF9C0", Slot = "10")]
	private KNNDIEJAHNG DCIIEECLFDK([In] KNNDIEJAHNG FPFHIDBMBMI)
	{
		return default(KNNDIEJAHNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x27B00F0", Offset = "0x27AEEF0", VA = "0x1827B00F0", Slot = "11")]
	private KNNDIEJAHNG FKOJJPJFLMA([In] KNNDIEJAHNG ALCLKCHJGII, [In] KNNDIEJAHNG GFJPONDOIDH)
	{
		return default(KNNDIEJAHNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x27AFA90", Offset = "0x27AE890", VA = "0x1827AFA90", Slot = "12")]
	private KNNDIEJAHNG DJFKELADABB([In] BHMLNBEKKIC FPFHIDBMBMI)
	{
		return default(KNNDIEJAHNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x27AF1B0", Offset = "0x27ADFB0", VA = "0x1827AF1B0", Slot = "13")]
	private float ANDGLDMHOKO([In] OFJEKJFLDPF ALCLKCHJGII, [In] OFJEKJFLDPF GFJPONDOIDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x27B0390", Offset = "0x27AF190", VA = "0x1827B0390", Slot = "14")]
	private OFJEKJFLDPF PKGFIOCHDGP(float HIFOHDMLFOA, [In] NPKPAEPCCIF AFBNIALGAIO)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x27B0A70", Offset = "0x27AF870", VA = "0x1827B0A70", Slot = "15")]
	private OFJEKJFLDPF KDNFEEIBBIJ([In] NPKPAEPCCIF GPOMFMOKBNB)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x27AF300", Offset = "0x27AE100", VA = "0x1827AF300", Slot = "16")]
	private OFJEKJFLDPF EKIHGLICKBP([In] NPKPAEPCCIF OMIJNNNJAEH, [In] NPKPAEPCCIF MOLDHLHGKKJ)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x27B0B10", Offset = "0x27AF910", VA = "0x1827B0B10", Slot = "17")]
	private OFJEKJFLDPF KGPHOAFFAHA([In] NPKPAEPCCIF MDBOPEGLJFG, [In] NPKPAEPCCIF DAMJNECINFM)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x27AF510", Offset = "0x27AE310", VA = "0x1827AF510", Slot = "18")]
	private OFJEKJFLDPF BNNNOGONODC([In] OFJEKJFLDPF FPFHIDBMBMI)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x27AF620", Offset = "0x27AE420", VA = "0x1827AF620", Slot = "19")]
	private OFJEKJFLDPF NEJHNGIFMCE([In] OFJEKJFLDPF CHIPBNNCPBF, [In] OFJEKJFLDPF MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x27B0280", Offset = "0x27AF080", VA = "0x1827B0280", Slot = "20")]
	private OFJEKJFLDPF GLMODHNDCDG([In] OFJEKJFLDPF CHIPBNNCPBF, [In] OFJEKJFLDPF MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x27AF180", Offset = "0x27ADF80", VA = "0x1827AF180", Slot = "21")]
	private float JDBCBANPNGO([In] OFJEKJFLDPF CHIPBNNCPBF, [In] OFJEKJFLDPF MDEAIGKHMKE, [In] OFJEKJFLDPF KMBJNMDOLGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x27AFD70", Offset = "0x27AEB70", VA = "0x1827AFD70", Slot = "22")]
	private OFJEKJFLDPF EMFGLMKFDNL([In] OFJEKJFLDPF ALCLKCHJGII, [In] OFJEKJFLDPF GFJPONDOIDH)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x27AF8B0", Offset = "0x27AE6B0", VA = "0x1827AF8B0", Slot = "23")]
	private OFJEKJFLDPF CJJEILMIPAP([In] OFJEKJFLDPF FPFHIDBMBMI)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x27B09B0", Offset = "0x27AF7B0", VA = "0x1827B09B0", Slot = "24")]
	private OFJEKJFLDPF KCKOOIKHGGL([In] OFJEKJFLDPF HLHNGKLKCFJ, [In] OFJEKJFLDPF GJCHJCHAFHC, float PJBCAOPCECH)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x27B01A0", Offset = "0x27AEFA0", VA = "0x1827B01A0", Slot = "25")]
	private NPKPAEPCCIF GBHOBJNKHFB([In] OFJEKJFLDPF FPFHIDBMBMI, [In] NPKPAEPCCIF AJIEOIDDJAD)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x27AF1D0", Offset = "0x27ADFD0", VA = "0x1827AF1D0", Slot = "26")]
	private OFJEKJFLDPF PCLDMOBFNKH([In] OFJEKJFLDPF CHIPBNNCPBF, [In] OFJEKJFLDPF MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(OFJEKJFLDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x27AF460", Offset = "0x27AE260", VA = "0x1827AF460", Slot = "27")]
	private void BJFEEAANDKF([In] OFJEKJFLDPF FPFHIDBMBMI, [Out] float HIFOHDMLFOA, [Out] NPKPAEPCCIF AFBNIALGAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x27B08E0", Offset = "0x27AF6E0", VA = "0x1827B08E0", Slot = "28")]
	private NPKPAEPCCIF KANKBBEBEHP([In] OFJEKJFLDPF FPFHIDBMBMI)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x27AFC30", Offset = "0x27AEA30", VA = "0x1827AFC30", Slot = "29")]
	private NPKPAEPCCIF EFHJGCMMOFI([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x27AFE20", Offset = "0x27AEC20", VA = "0x1827AFE20", Slot = "30")]
	private NPKPAEPCCIF EPCMJMPECEO([In] NPKPAEPCCIF FPFHIDBMBMI, float JLMEKGPDJJB)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x27AFE90", Offset = "0x27AEC90", VA = "0x1827AFE90", Slot = "31")]
	private NPKPAEPCCIF FEOPEHPEJML([In] NPKPAEPCCIF NPJPCFKLMHD, [In] NPKPAEPCCIF DBHGDDJEAGI, [In] NPKPAEPCCIF LFFEBJIOAJJ)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x27AFF00", Offset = "0x27AED00", VA = "0x1827AFF00", Slot = "32")]
	private NPKPAEPCCIF FGBOEOJOKCK([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x27B06F0", Offset = "0x27AF4F0", VA = "0x1827B06F0", Slot = "33")]
	private NPKPAEPCCIF IOLFKHADJDM([In] NPKPAEPCCIF HAEJIMJGLDC, [In] NPKPAEPCCIF GILMMEPBGCD, [In] OFJEKJFLDPF JIGNOCOKKEP)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x27B0EB0", Offset = "0x27AFCB0", VA = "0x1827B0EB0", Slot = "34")]
	private NPKPAEPCCIF OHJBOFELAHA([In] NPKPAEPCCIF JIEGOKAJLGF, [In] NPKPAEPCCIF GILMMEPBGCD, [In] OFJEKJFLDPF JIGNOCOKKEP)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x27AF100", Offset = "0x27ADF00", VA = "0x1827AF100", Slot = "35")]
	private float DIECLEKCPEF([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x27AF6E0", Offset = "0x27AE4E0", VA = "0x1827AF6E0", Slot = "36")]
	private float FAJKKOMDKGH([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x27AF3D0", Offset = "0x27AE1D0", VA = "0x1827AF3D0", Slot = "37")]
	private float DEJFLKEDBFE([In] NPKPAEPCCIF FPFHIDBMBMI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x27B04E0", Offset = "0x27AF2E0", VA = "0x1827B04E0", Slot = "38")]
	private NPKPAEPCCIF IAKCHCHMJFF([In] NPKPAEPCCIF CHIPBNNCPBF, [In] NPKPAEPCCIF MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x27B0820", Offset = "0x27AF620", VA = "0x1827B0820", Slot = "39")]
	private NPKPAEPCCIF JHELFGCEIDK([In] NPKPAEPCCIF CHIPBNNCPBF, [In] NPKPAEPCCIF MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x27AFAF0", Offset = "0x27AE8F0", VA = "0x1827AFAF0", Slot = "40")]
	private float DMFBKPCLAGG([In] NPKPAEPCCIF CHIPBNNCPBF, [In] NPKPAEPCCIF MDEAIGKHMKE, [In] NPKPAEPCCIF KMBJNMDOLGN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x27B0BC0", Offset = "0x27AF9C0", VA = "0x1827B0BC0", Slot = "41")]
	private NPKPAEPCCIF MADPNNGNHJG([In] NPKPAEPCCIF DDEBNKFKCJA, [In] NPKPAEPCCIF GDCDKMJLKDH, float KKAJLCHPCBA)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x27B0D70", Offset = "0x27AFB70", VA = "0x1827B0D70", Slot = "42")]
	private NPKPAEPCCIF MKEOCGANHGN([In] NPKPAEPCCIF FPFHIDBMBMI)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x27AF7E0", Offset = "0x27AE5E0", VA = "0x1827AF7E0", Slot = "43")]
	private NPKPAEPCCIF CHKBIJAFPEE([In] NPKPAEPCCIF FPFHIDBMBMI)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x27B05C0", Offset = "0x27AF3C0", VA = "0x1827B05C0", Slot = "44")]
	private NPKPAEPCCIF IDJFDIBNCKF([In] NPKPAEPCCIF FPFHIDBMBMI, [In] NPKPAEPCCIF POIANHHCBDH)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x27B0E40", Offset = "0x27AFC40", VA = "0x1827B0E40", Slot = "45")]
	private NPKPAEPCCIF OFBMHEAGLKG([In] NPKPAEPCCIF FPFHIDBMBMI, [In] NPKPAEPCCIF LFFEBJIOAJJ)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x27B0940", Offset = "0x27AF740", VA = "0x1827B0940", Slot = "46")]
	private NPKPAEPCCIF KBFBIBKFLFE([In] NPKPAEPCCIF FPFHIDBMBMI, float GMJFIEDPAMM)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x27B0760", Offset = "0x27AF560", VA = "0x1827B0760", Slot = "47")]
	private NPKPAEPCCIF IPMLGCIBAOJ([In] NPKPAEPCCIF DDEBNKFKCJA, [In] NPKPAEPCCIF GDCDKMJLKDH, [In] NPKPAEPCCIF OPOFGKBJGEF, float ONFHNKKNHMD, float KGIMKDKAEAH, float GNNOPFAGLOD, [Out] NPKPAEPCCIF GPBPHJJLKFP)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x27AFCA0", Offset = "0x27AEAA0", VA = "0x1827AFCA0", Slot = "48")]
	private NPKPAEPCCIF EIHMJNPNFOF([In] NPKPAEPCCIF ALCLKCHJGII, [In] NPKPAEPCCIF GFJPONDOIDH)
	{
		return default(NPKPAEPCCIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x27B0440", Offset = "0x27AF240", VA = "0x1827B0440", Slot = "49")]
	private NPKPAEPCCIF HIPDMLBGILM([In] NPKPAEPCCIF CHIPBNNCPBF, [In] NPKPAEPCCIF MDEAIGKHMKE, float JIJABGNNHPJ)
	{
		return default(NPKPAEPCCIF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public sealed class KFDKDCFMPHH : DLCGGIIKBJG
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool NODCMHIFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x1173110", Offset = "0x1171F10", VA = "0x181173110", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x27B6120", Offset = "0x27B4F20", VA = "0x1827B6120")]
	public KFDKDCFMPHH(int NJMPBENCJIN, bool BLFBHLEJBPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class HOOCMHBEHKF : LHGBFCHHOFF
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public delegate FJNIAMGOABG PHILINOGHPD(int KAALNAHEKBC);

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate int JDBBIIFLNEN([In] FJNIAMGOABG ADDBKELKPKE);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public delegate JIAPBKEBGKJ<NICNPLCGCEF> DLENNBDPJBB(GIFMCFFBPII ANMGGEBBMLP, GNMAJDMPKHN BMMGOECPJCE, bool DHKAKFJGCKH);

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public static readonly HOOCMHBEHKF ICOFMPPJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly PHILINOGHPD? ADCHHJKOIOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly JDBBIIFLNEN? BFAHKOHEJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly DLENNBDPJBB? EBCPIKHHLKF;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0xC59BA0", Offset = "0xC589A0", VA = "0x180C59BA0")]
	public HOOCMHBEHKF([Optional] PHILINOGHPD? NMKFBHBPFAK, [Optional] JDBBIIFLNEN? AICJHAMHJAG, [Optional] DLENNBDPJBB? BCHDOLMELBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x27B1A30", Offset = "0x27B0830", VA = "0x1827B1A30", Slot = "4")]
	public FJNIAMGOABG AKOJKGFCPEC(int KAALNAHEKBC)
	{
		return default(FJNIAMGOABG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x27B1A10", Offset = "0x27B0810", VA = "0x1827B1A10")]
	public int PMMKKNHMNEA([In] FJNIAMGOABG ADDBKELKPKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x27B1A10", Offset = "0x27B0810", VA = "0x1827B1A10", Slot = "5")]
	private int AGMLIOBBAND([In] FJNIAMGOABG ADDBKELKPKE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class KGCNEKGOALL : IDDGGHHBIAE
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private class LCDBIKGMKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Guid HAAJOLCHMMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public long PJPDKAKKBPN
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int HKGEPGJNNFP
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xA11300", Offset = "0xA10100", VA = "0x180A11300")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool FHOBHJMIDOB
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x15EEC20", Offset = "0x15EDA20", VA = "0x1815EEC20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool LNNDIIIIAGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x15EEC30", Offset = "0x15EDA30", VA = "0x1815EEC30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool HFPDGKJKFCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x27B7520", Offset = "0x27B6320", VA = "0x1827B7520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x27B7540", Offset = "0x27B6340", VA = "0x1827B7540")]
		public LCDBIKGMKFJ(Guid ADFEGBCJFEK, long COECJEJOOKF, int PLIONFPCPEM, bool AAJNKGCAKJN, bool DIPDMPOMKIE = false)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Dictionary<KOIDEEJEAKA<KCAEAGPDLDO>, LCDBIKGMKFJ> JCLFLBDHILN;

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x27B6240", Offset = "0x27B5040", VA = "0x1827B6240")]
	public bool BINAPIOHBPN([In] KOIDEEJEAKA<KCAEAGPDLDO> MAKJJJECHHB, [Out] Guid ADFEGBCJFEK, [Out] long COECJEJOOKF, [Out] int PLIONFPCPEM, [Out] bool AJFGKNNBHHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x27B6160", Offset = "0x27B4F60", VA = "0x1827B6160")]
	public void HHBEDOAHDHC([In] KOIDEEJEAKA<KCAEAGPDLDO> MAKJJJECHHB, Guid ADFEGBCJFEK, long COECJEJOOKF, int PLIONFPCPEM, bool AJFGKNNBHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x27B6440", Offset = "0x27B5240", VA = "0x1827B6440")]
	public void HHBEDOAHDHC([In] KOIDEEJEAKA<KCAEAGPDLDO> MAKJJJECHHB, Guid ADFEGBCJFEK, long COECJEJOOKF, int PLIONFPCPEM, bool AJFGKNNBHHN, bool DIPDMPOMKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x27B6520", Offset = "0x27B5320", VA = "0x1827B6520")]
	public void LEOCNFAIKHE([In] KOIDEEJEAKA<KCAEAGPDLDO> MAKJJJECHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x27B6350", Offset = "0x27B5150", VA = "0x1827B6350")]
	public void GDIKMBEGFDM([In] KOIDEEJEAKA<KCAEAGPDLDO> MAKJJJECHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x27B63B0", Offset = "0x27B51B0", VA = "0x1827B63B0")]
	public bool FHOBHJMIDOB([In] KOIDEEJEAKA<KCAEAGPDLDO> MAKJJJECHHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x27B6640", Offset = "0x27B5440", VA = "0x1827B6640")]
	public KGCNEKGOALL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x27B6240", Offset = "0x27B5040", VA = "0x1827B6240", Slot = "4")]
	private bool FIDKNAILBON([In] KOIDEEJEAKA<KCAEAGPDLDO> MAKJJJECHHB, [Out] Guid ADFEGBCJFEK, [Out] long COECJEJOOKF, [Out] int PLIONFPCPEM, [Out] bool AJFGKNNBHHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x27B6160", Offset = "0x27B4F60", VA = "0x1827B6160", Slot = "5")]
	private void BHIJCPNODFA([In] KOIDEEJEAKA<KCAEAGPDLDO> MAKJJJECHHB, Guid ADFEGBCJFEK, long COECJEJOOKF, int PLIONFPCPEM, bool AJFGKNNBHHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x27B6520", Offset = "0x27B5320", VA = "0x1827B6520", Slot = "6")]
	private void OMBEOPOALEM([In] KOIDEEJEAKA<KCAEAGPDLDO> MAKJJJECHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x27B6350", Offset = "0x27B5150", VA = "0x1827B6350", Slot = "7")]
	private void CELOCFLGLLD([In] KOIDEEJEAKA<KCAEAGPDLDO> MAKJJJECHHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x27B63B0", Offset = "0x27B51B0", VA = "0x1827B63B0", Slot = "8")]
	private bool JJIOIIGHBHA([In] KOIDEEJEAKA<KCAEAGPDLDO> MAKJJJECHHB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public sealed class EGPOFFHNAND
{
	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x27ADFD0", Offset = "0x27ACDD0", VA = "0x1827ADFD0")]
	public static BFFJAMKDLAJ GJBHPENFANG()
	{
		return default(BFFJAMKDLAJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public sealed class PJIHEBCLKLM : PKJBGIACFMC
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate bool EPAMMAKHLKG();

	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public delegate void BCBOALCBEJA();

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public delegate IReadOnlyList<KeyValuePair<string, FIBJHCAOCDK>> PHBLKJKDFLK(PPGGIKABFII MGLOMHPNFEI);

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public delegate IReadOnlyDictionary<Guid, int> KJJPJGIPJKD(PPGGIKABFII MGLOMHPNFEI);

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public delegate IReadOnlyDictionary<int, Guid> AMJCMOAPDFB(PPGGIKABFII MGLOMHPNFEI);

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public delegate void PBCFMFDBAJA(PPGGIKABFII MGLOMHPNFEI, Guid FHJPHHKOPAH);

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate void CIFECEDPCIG();

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public delegate bool POFABGCILHB();

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public delegate bool EMBDFCBFGDO();

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate void JEJNFBJDPCJ(Guid BKKDHMFDBGM);

	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public delegate void ACIHMOCNOLF(IOFPHBLLHJB LIMJMJOHDDD, IMKHFLEBFGP KLEPCKMLLDB);

	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public delegate void FAFCNJLBBOK(string PEIFKAPFPCB);

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public delegate Task<bool> ACGJKKOKMEA(string GGNIPFCNHJP, string JAPGNGDBBIF);

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public delegate bool LMMAAFPNHPC(Guid CJNPGHKBKPF, [Out] OAMCAOJIGOB MMDGGJNBPHB);

	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public delegate void NDEBLJAAFHB(BIHBDMOHDCK<LMDGPOLMACN> PBFCKGCJADL);

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public delegate Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> MJEBEHNOANL(Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> JDEJDGHOHNF);

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public delegate Task<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> GENGOJCOLHD(Task<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> JDEJDGHOHNF);

	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public delegate Task<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> IGIJNKINGEB(Task<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> JDEJDGHOHNF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private struct KHMIKBFIFLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private TaskAwaiter<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x27B66D0", Offset = "0x27B54D0", VA = "0x1827B66D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x27B6990", Offset = "0x27B5790", VA = "0x1827B6990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[CompilerGenerated]
	private struct KLIGJNKKILG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Task<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x27B6A00", Offset = "0x27B5800", VA = "0x1827B6A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x27B6CC0", Offset = "0x27B5AC0", VA = "0x1827B6CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private struct AAOCCMGDPDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Task<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TaskAwaiter<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x27AC050", Offset = "0x27AAE50", VA = "0x1827AC050", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x27AC310", Offset = "0x27AB110", VA = "0x1827AC310", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly Dictionary<string, FIBJHCAOCDK> FMMMCFENLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<int, string> NLHBPJMHLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly List<object> PAEGCGAHJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly List<Guid> BMEFLGPNCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly EPAMMAKHLKG DPNHLFFFOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly BCBOALCBEJA BNELGNMNJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly PHBLKJKDFLK CKGKCKKGIEP;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly IReadOnlyDictionary<Guid, int> JBAPAMDGKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly KJJPJGIPJKD ACMIPPIKDJI;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly IReadOnlyDictionary<int, Guid> EGBNIFJFKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly AMJCMOAPDFB OHBGKKAEEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private readonly PBCFMFDBAJA BIALINFONLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly CIFECEDPCIG LPFMLNPAGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly POFABGCILHB FFFPPLHDGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly EMBDFCBFGDO IMBOAOGBCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Dictionary<string, FIBJHCAOCDK> APHFICJCGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly JEJNFBJDPCJ DEJKGFLIEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly ACIHMOCNOLF CJCPCPABHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly FAFCNJLBBOK LGFEAMOKKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly ACGJKKOKMEA NNPHJPJJDBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly LMMAAFPNHPC CBDDBMHMBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly NDEBLJAAFHB FGLBEACDENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly MJEBEHNOANL FFHGICKIBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private readonly GENGOJCOLHD NMGCDCOCMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private readonly IGIJNKINGEB AKCFIJNCNHG;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public JHBAGMAGINN HBOOEBDPGJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "4")]
		get
		{
			return default(JHBAGMAGINN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string JIKCFODMHDF
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x27BA210", Offset = "0x27B9010", VA = "0x1827BA210", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public string KFCOAGNAPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x27BA110", Offset = "0x27B8F10", VA = "0x1827BA110", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public string BLEDFADGEEL
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x27B9D50", Offset = "0x27B8B50", VA = "0x1827B9D50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Regex OGLNHLHBINO
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x27BA240", Offset = "0x27B9040", VA = "0x1827BA240", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Regex PDDFKJHOBNI
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x27BA170", Offset = "0x27B8F70", VA = "0x1827BA170", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Regex FFPONCOCFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x27B9A10", Offset = "0x27B8810", VA = "0x1827B9A10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Regex DCMLDMLKMOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x27BA1C0", Offset = "0x27B8FC0", VA = "0x1827BA1C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int GKOGFFIPDII
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x1191C70", Offset = "0x1190A70", VA = "0x181191C70", Slot = "13")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool IOEOOOFDDLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xCA8320", Offset = "0xCA7120", VA = "0x180CA8320", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int JLMCBENLIOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x11916F0", Offset = "0x11904F0", VA = "0x1811916F0", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyDictionary<int, string> IELFCNMJDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA11370", Offset = "0xA10170", VA = "0x180A11370", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public IReadOnlyList<object> IFKPPDALDHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public IReadOnlyList<Guid> NOGNAEDGDPO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public IReadOnlyDictionary<string, FIBJHCAOCDK> ONIBNPEOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA0D9C0", Offset = "0xA0C7C0", VA = "0x180A0D9C0", Slot = "28")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public FFGKNPMOFPG FHJJJIIDAKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xA397E0", Offset = "0xA385E0", VA = "0x180A397E0", Slot = "33")]
		[CompilerGenerated]
		get
		{
			return default(FFGKNPMOFPG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool FELJDEDABHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x1F55340", Offset = "0x1F54140", VA = "0x181F55340", Slot = "34")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public bool DBCNEFGMPIA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x15D9DE0", Offset = "0x15D8BE0", VA = "0x1815D9DE0", Slot = "36")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool ODHBIAPBHGK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x15D9DF0", Offset = "0x15D8BF0", VA = "0x1815D9DF0", Slot = "35")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x27BA390", Offset = "0x27B9190", VA = "0x1827BA390")]
	public PJIHEBCLKLM([Optional] Dictionary<string, FIBJHCAOCDK>? HNKNFEHEAHM, [Optional] Dictionary<int, string>? MHILJJFGELO, [Optional] List<object>? AMJKFHICPEH, [Optional] List<Guid>? EIHHHOBJCDN, [Optional] EPAMMAKHLKG? MPECACBANAK, [Optional] BCBOALCBEJA? PCNLMHNLGBI, [Optional] PHBLKJKDFLK? GIFJGNKJFPB, [Optional] KJJPJGIPJKD? MKGHDCGHKGC, [Optional] AMJCMOAPDFB? JPEKLNILBPH, [Optional] PBCFMFDBAJA? ONJFHIAJMEM, [Optional] CIFECEDPCIG? LDNGEIJALNO, [Optional] POFABGCILHB? MBNMHGMFNLO, [Optional] EMBDFCBFGDO? PEBBDMGHCLH, [Optional] Dictionary<string, FIBJHCAOCDK>? MNLDBPHOECE, [Optional] JEJNFBJDPCJ? KHHBPKEGGLN, [Optional] ACIHMOCNOLF? ACFCOKMGOBH, [Optional] FAFCNJLBBOK? DFJJDHGBKJH, [Optional] ACGJKKOKMEA? BCHNIPMAMOK, [Optional] LMMAAFPNHPC? KKFKFHIDLEI, [Optional] NDEBLJAAFHB? EEOPPIABPJP, [Optional] MJEBEHNOANL? DCKOEHLOLGK, [Optional] GENGOJCOLHD? MMLFIEJPJOH, [Optional] IGIJNKINGEB? OEFIAHPEIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x27B9B50", Offset = "0x27B8950", VA = "0x1827B9B50", Slot = "18")]
	public bool HGMGMAFLLJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
	public static bool NGMBEFBMFIL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x27BA140", Offset = "0x27B8F40", VA = "0x1827BA140", Slot = "19")]
	public bool MBFEEHOOJAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	public static void FDHPAAIKHEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0xD9A0A0", Offset = "0xD98EA0", VA = "0x180D9A0A0", Slot = "20")]
	public void EMJEALIJFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x27B9AC0", Offset = "0x27B88C0", VA = "0x1827B9AC0")]
	private static IReadOnlyList<KeyValuePair<string, FIBJHCAOCDK>> FHNHECJMAKB(PPGGIKABFII MGLOMHPNFEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x27B9B20", Offset = "0x27B8920", VA = "0x1827B9B20", Slot = "21")]
	public IReadOnlyList<KeyValuePair<string, FIBJHCAOCDK>> HGBLOCFBCJL(PPGGIKABFII MGLOMHPNFEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x27B9C10", Offset = "0x27B8A10", VA = "0x1827B9C10")]
	private static IReadOnlyDictionary<Guid, int> HJJPFCBHEGH(PPGGIKABFII MGLOMHPNFEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x27B99B0", Offset = "0x27B87B0", VA = "0x1827B99B0", Slot = "22")]
	public IReadOnlyDictionary<Guid, int> EILOOAHMMDF(PPGGIKABFII MGLOMHPNFEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x27B9960", Offset = "0x27B8760", VA = "0x1827B9960")]
	private static IReadOnlyDictionary<int, Guid> EBBMAPMMCMA(PPGGIKABFII MGLOMHPNFEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x27B9A90", Offset = "0x27B8890", VA = "0x1827B9A90", Slot = "23")]
	public IReadOnlyDictionary<int, Guid> FAOEDCFDLCB(PPGGIKABFII MGLOMHPNFEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void LMPKKGPCAHJ(PPGGIKABFII MGLOMHPNFEI, Guid FHJPHHKOPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x27BA0A0", Offset = "0x27B8EA0", VA = "0x1827BA0A0", Slot = "24")]
	public void LEHDNNOGNIH(PPGGIKABFII MGLOMHPNFEI, Guid FHJPHHKOPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void OPLKAFCOICA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x27BA070", Offset = "0x27B8E70", VA = "0x1827BA070", Slot = "25")]
	public void KGKFDMDDBFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
	private static bool EDPOPJFEALP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x27B9AF0", Offset = "0x27B88F0", VA = "0x1827B9AF0", Slot = "26")]
	public bool HECFAFBGAJF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0")]
	public static bool FJBGKOHGDOP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x27B99E0", Offset = "0x27B87E0", VA = "0x1827B99E0", Slot = "27")]
	public bool EMCNAIGKMAJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x27BA0E0", Offset = "0x27B8EE0", VA = "0x1827BA0E0", Slot = "29")]
	public IReadOnlyList<KeyValuePair<string, FIBJHCAOCDK>> LGIDCNOHHCC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "30")]
	public IReadOnlyDictionary<Guid, int> GDIGDBLKMEN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "31")]
	public IReadOnlyDictionary<int, Guid> FJCNOHIPGCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	public static void LJMLDEHICOD(Guid BKKDHMFDBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x27B9DC0", Offset = "0x27B8BC0", VA = "0x1827B9DC0", Slot = "32")]
	public void IFBFGHKCHGI(Guid BKKDHMFDBGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void OJKFNFJPODB(IOFPHBLLHJB LIMJMJOHDDD, IMKHFLEBFGP KLEPCKMLLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x27B98F0", Offset = "0x27B86F0", VA = "0x1827B98F0", Slot = "37")]
	public void BCMEFEOCHBN(IOFPHBLLHJB LIMJMJOHDDD, IMKHFLEBFGP KLEPCKMLLDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void DCGBNMDJBIA(string PEIFKAPFPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x27BA040", Offset = "0x27B8E40", VA = "0x1827BA040", Slot = "38")]
	public void JHCCPEFHJLP(string PEIFKAPFPCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x27B9EF0", Offset = "0x27B8CF0", VA = "0x1827B9EF0")]
	private static Task<bool> JEDIPDMODHF(string GGNIPFCNHJP, string JAPGNGDBBIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x27B9A60", Offset = "0x27B8860", VA = "0x1827B9A60", Slot = "39")]
	public Task<bool> FANHBBFFAHP(string GGNIPFCNHJP, string JAPGNGDBBIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x27B9920", Offset = "0x27B8720", VA = "0x1827B9920")]
	private static bool BPAMGAHDLAO(Guid CJNPGHKBKPF, [Out] OAMCAOJIGOB MMDGGJNBPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x27B9D80", Offset = "0x27B8B80", VA = "0x1827B9D80", Slot = "40")]
	public bool IBBMAAEPLMD(Guid CJNPGHKBKPF, [Out] OAMCAOJIGOB MMDGGJNBPHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0")]
	private static void FCDPNOCFDFC(BIHBDMOHDCK<LMDGPOLMACN> PBFCKGCJADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x27B9930", Offset = "0x27B8730", VA = "0x1827B9930", Slot = "41")]
	public void DHKFKHJFNCH(BIHBDMOHDCK<LMDGPOLMACN> PBFCKGCJADL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x27B9E00", Offset = "0x27B8C00", VA = "0x1827B9E00")]
	[AsyncStateMachine(typeof(KHMIKBFIFLH))]
	private static Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> JCIPKGDIFJJ(Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> JDEJDGHOHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x27B9890", Offset = "0x27B8690", VA = "0x1827B9890", Slot = "42")]
	public Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> AGMNKDMJGML(Task<JKEBLLKKBOM<NICNPLCGCEF, CHEIGOJMDOJ>> JDEJDGHOHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x27B9F50", Offset = "0x27B8D50", VA = "0x1827B9F50")]
	[AsyncStateMachine(typeof(KLIGJNKKILG))]
	private static Task<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> JHBHKNEINFC(Task<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> JDEJDGHOHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x27B98C0", Offset = "0x27B86C0", VA = "0x1827B98C0", Slot = "43")]
	public Task<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> AGMNKDMJGML(Task<JKEBLLKKBOM<GLAHDBEPHAO, CHEIGOJMDOJ>> JDEJDGHOHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x27B9C60", Offset = "0x27B8A60", VA = "0x1827B9C60")]
	[AsyncStateMachine(typeof(AAOCCMGDPDG))]
	private static Task<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> HMNOOJLMLCM(Task<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> JDEJDGHOHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x27B9860", Offset = "0x27B8660", VA = "0x1827B9860", Slot = "44")]
	public Task<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> AGMNKDMJGML(Task<JKEBLLKKBOM<BIHBDMOHDCK<NGIHDDPPPGJ>, CHEIGOJMDOJ>> JDEJDGHOHNF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class LJPINNDLKGL : FBBHACIMIBD
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public delegate JIAPBKEBGKJ<NICNPLCGCEF> EKDGAEGBLHE(EHDOPHDIBFE ANMGGEBBMLP, object ICLOEPBNHKL, FBHIIMBEIHO EOJIGBFGLBJ, IReadOnlyList<GEDHHGFCHLC> EPAKLNGEFJA, IList<GEDHHGFCHLC> BHJGGDGPLOC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private HEALPDOJDBM? HKCOBAPKNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly HEALPDOJDBM AFFMGAIGAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly HEALPDOJDBM EHPNAGDIFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private HEALPDOJDBM? BIDOHBIPBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private EKDGAEGBLHE? GKPHMDJBLOE;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "4")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FHBINLMAMOB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "5")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IBICOAMBMPB(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10")]
	private static JIAPBKEBGKJ<NICNPLCGCEF> OOIHKAJEMOK(EHDOPHDIBFE AOJFFKDCAKJ, JOEGNIKLMHH NIPBFDKOBCA)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "6")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OHGLAJHNOEO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "7")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MMJAHCEJOFA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "8")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JPJNLGJDJCM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "9")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FDBONAGDKMD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "10")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LPEFBGIAKIF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "11")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NOHHOEGILLG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "12")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NFEKJHAIHIM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "13")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GBHPNDHMIPB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "14")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FBADMPBFMLN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "15")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HLLBFCIHFND(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "16")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GHKHDKBNNPA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "17")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MMLIGMHFHBG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "18")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CFLMICNCFJC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "19")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LOPGIICMBFD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "20")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JNMLECMGGOM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "21")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DNNLMGMPKJP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "22")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KDFIBALFOPI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "23")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KKFIBMEINGL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "24")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EPCHGJJEMNC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "25")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PKOBEFKEACP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "26")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GKDCCAHFDBE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "27")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FPGGFOLPAMP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "28")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PHIKIMGKDLC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "29")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AKEGCGONNOA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "30")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MAIKNDDKDNC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "31")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FKHJDMFJKLO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "32")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JGALFJAOICA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "33")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NKDONFHGCEI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "34")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HGNDAJNBLLO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "35")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IBEBHFEGMFH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "36")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AOMJGBHKODI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "37")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OBONMBJHPHP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "38")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OEFGPMLBHDC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "39")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IKGBIDKACFJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "40")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CCOEBCHIFMF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "41")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KPNFJEAHAED(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "42")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HFLGFDGPCAM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "43")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HNCPJBDHLIG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "44")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CBAHEJBFHLK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "45")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AFIJDCOMMGC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "46")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AHHJKEHOKHN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "47")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PKOBHCPCABA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "48")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IPAMAHKPBEB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "49")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BKPDLBADNHH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "50")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HIMDKJMLKII(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "51")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NOFDAKOJFKN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "52")]
	public JIAPBKEBGKJ<NICNPLCGCEF> POIJFHKBGHB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "53")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KIJLCKDDFAD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "54")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GPKPFHACIDC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "55")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KIFBDHMPPIG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "56")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LMMGHHCKANN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "57")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CDOJHFKODMO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "58")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EEEGFFPMJON(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "59")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KIEBFOCONEA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "60")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PIBKJJCHCIA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "61")]
	public JIAPBKEBGKJ<NICNPLCGCEF> POPNBFCEFOK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "62")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FBPEKLKJFFB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "63")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KFGBKNLJDFK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "64")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GMMOKHPNOOJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "65")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FAAGCFKLAJL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "66")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JOEOKLELCMK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "67")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> EHKKKMOKONH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "68")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FGKGHICJLGB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "69")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FKHEPACAANH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "70")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IFBKMKCBGDP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "71")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PBCCOIICCPI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "72")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IOHHENFCHCO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "73")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DOEJBCNJJBI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "74")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BBEIBMOJFGE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "75")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CLILLKHPJEH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "76")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CLNHBEFADDI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "77")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DDEHEJHFHFC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "78")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FJHDPPPPEDM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "79")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LPMHAHKMHDN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "80")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EFCBGKLBNAN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "81")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DGIHKODBKBM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "82")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JIMPGNFKJPF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "83")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OEFDCEHIIAD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "84")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CIPJPOJCMBL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "85")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FDHLCAMNPDG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "86")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EMFAKCEIOFH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "87")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HMCINGGPJKC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "88")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PIMJHGHLEOE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "89")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ILFFKMGMFDH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "90")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FPOPFAHPABG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "91")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IAHIIINNICH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, Guid MENEGNEOGDO)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "92")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GGIPCGHPHNM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "93")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OKPNFBNCOKN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "94")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FKHBOJHHGDA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "95")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BNOFLHHNDOO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "96")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HLOLOKMNNJH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "97")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JNDHEPOPADH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "98")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CKCKHMDIBJF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "99")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KHIPFHAELLB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "100")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ACJKIGGDCLL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "101")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CFCJDBNNKJA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "102")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PFAEBOFJABO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "103")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EHOENFLICDK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "104")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BNLBCLLOCPK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "105")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NAEPGPDECOJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "106")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BGKOIMPFLLH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "107")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FKIEBEAONCL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "108")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BEHPMFEPEAO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "109")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NPPOILJOIOK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "110")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ODEJHGOCMOL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "111")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KFIGCCEDPFL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "112")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FEAPDMGBAAA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "113")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JJGAFHFABEK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "114")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NOIDPLLJLIN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "115")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GCEJDPOIABE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "116")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PGACGJBEIFF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "125")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CMCGEOEAAMH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "126")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DBJECOIHNCC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "127")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ALPMBMCENON(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "128")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OADJHALOOMJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "129")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EFFGOALFFPA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "130")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ENDDMFNJGEB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "131")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HGFAEJNODGP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "132")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FEGACHGKDDL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "133")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NPBECACECOI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "134")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JIFMAPCNJGO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "135")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NIJENMELOMG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "136")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CMAPNDFENNC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "137")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CGOEFNHHJKM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "138")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JGCLJPPMCAD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "139")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JPFIABEKGMP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "140")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EAPMFDLKBFB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "141")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BPKDNABBBGK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "142")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HLKCOCKAOOH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "143")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NICOJNKHDBL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "144")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EEGCMIFEGHH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "145")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OBPJHHKIDPC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "146")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OODKLOGDJNO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "147")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FCBJABEMBEF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "148")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IMIMBECLHHA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "149")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FKMPEMKNJDD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "150")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KJOEACALGBJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "151")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ILLFLBEGBAN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "152")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OPABGPDIOPI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "153")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ONICNADFLHJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "154")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DNIBGPADMPP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "155")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OMFFOHGLGDJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "156")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HPFDDHCCOOC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "157")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AJNKFLJBMLJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "158")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LDHKCDNINMO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "159")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MKLLABBGBJG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "160")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LPBGFODPGHG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "161")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OAKAHNBOLOB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "162")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OKGKLPNJKMP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "163")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CJHKJOGIKFN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "164")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IEKAJHNINCL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "165")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GMEBILGBKPI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "166")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ECPOFLNCMBO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "167")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DMLEHHGKIMA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "168")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JEKDMLDDELM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "169")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KNKPOJDBCAH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "170")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BFJKPCOLPCP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "171")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LKBEOBFHHAA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "172")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IJPFPJJFKFA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "173")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JAOOACFDOJO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "174")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HOKKIMDLCKP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "175")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IEENMCHHMAN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "176")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OFJIJBJIAHF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "177")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CGCNGLEMHMI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "178")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BCABJPAHDGB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "179")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KDFCPACGEFH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "180")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CDCMEHGODCM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "181")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OMBOALOMFCP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "207")]
	public JIAPBKEBGKJ<NICNPLCGCEF> INOBJMDHHDB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "208")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FIOPMABJFOC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "209")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JLNDIFJCDMG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "210")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IMEIJGOLMFD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "211")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FKCICOFMOGI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "212")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KNHOEGMGPHP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "213")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NDAKILHJMAE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "214")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GLMHOLPBACA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "215")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MADODJELNLJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "216")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AJDBDLNKEEG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "217")]
	public JIAPBKEBGKJ<NICNPLCGCEF> INLAEINOEGG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "220")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FCLNBFMPHDO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "218")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EDEKKFHPLNM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "219")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EFBJLAFKGAA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "221")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KHMHMBLEAJJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "222")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JDCLPPMONEG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "223")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GJEGJJBHCFP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "224")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CJOAEHGFCKM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "240")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GKEBOPKHODF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "262")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MKPJPINEPCK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "264")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LDKEAEGIGIN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "249")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AMBLLPBNBPK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "250")]
	public JIAPBKEBGKJ<NICNPLCGCEF> INKJLLLFAOE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "241")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NKIFFEMEAIO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "266")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KJMPIPDDAJN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "255")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JFIMKHLAMOK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "256")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EOGPDANDGAE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "232")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IAJPEOGAIOD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "233")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CEBHHODPAKO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "235")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MNPAHOJJNPG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "242")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PKHNFJAKLBD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "243")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LDPIDDAOOKO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "230")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IJCHDLFLOOO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "236")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JOPLMLEFLNL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "251")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GLKEBBKCBNE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "252")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FHFINFCLKEP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "227")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PGCBCILNFBP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "226")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FNPLIAHMOPP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "229")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KIHDGPNFGDB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "237")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LOMJOFHNBKN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "238")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OAJHNIECIAF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "239")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OCHGIMANLKF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "253")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LLEHFNJFIFM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "257")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EHDMJAHKCKP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "258")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LFAGAOJOCJL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "259")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FEGNKEDODAD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "260")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PCKPLKHFHAF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "261")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PPALPNFGNFC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "263")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FHINLBPJJIO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "265")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FJBPPAABDII(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "225")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MMOBKLMEBHA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "244")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IANENOIEEML(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "245")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CCIIHFCBIKO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "246")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EDHDMMKNJEM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "247")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MGLMLNGLJFE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "234")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FOPHIKAFLFA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "248")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DEJFBJOCCDC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "231")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OOEMPDGMJAJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "228")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LJHIOFEJEBO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "254")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CDEEKKBGDAC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "267")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OEPKMALJDAI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "268")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LNMGFKKMNEL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "269")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MKJGLJCPHLJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "270")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AOGJCGKGLOM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "271")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OFCHDGEHIJF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "272")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CCPLFPIHCMI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "273")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FOHKJNDINKM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "274")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MMLNPJOIMFD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "276")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NDECEFMAIHM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "277")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ICLIDPEPLHM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "278")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ENEPEDNJKDH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "280")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HPEBEJFPHIP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "279")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PIINIJCDJBD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "288")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JGELLFNLLGA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "289")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PPBIOPLELJM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "290")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NCCHKNJOEIB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "291")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PDJIJHAKIPG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "292")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LMCCPGBOOIO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "294")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KECNBPFJGAD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "300")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HJFJFCHPPHH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "301")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PMJIFGDCPHB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "304")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IEFMOGAEILC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "308")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MCPENPKAOIE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "309")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OEOAMKHNJKF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "310")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EJLHMGAPKEG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "311")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KJLOMMLNEBA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "312")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LNBPFEFNELC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "313")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CLPGACLDFIC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "314")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NOOOPNNGOHK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "315")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FMILJMJBFFL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "316")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MDBELIFEFOH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "317")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FEKOEAOJJLE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "306")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JKOLCFLOLHB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "307")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DPDDBOKHKJB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "283")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OKNFCFAFHKB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "284")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FNOLMEOPICA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "286")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LLKJLKGOFEH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "293")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KKAHELPMDLM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "281")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IAHECAGOMHH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "287")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GKNLHIKIFJG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "302")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GPNLHBOIOJJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "303")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ILPIDBNNNJA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "275")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CAAOEPKBIDM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "295")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OCADMPICJHN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "296")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JLNGLIIFMDA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "297")]
	public JIAPBKEBGKJ<NICNPLCGCEF> APCPOEFJMDN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "298")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MNNOLPACCHH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "285")]
	public JIAPBKEBGKJ<NICNPLCGCEF> COHNCCAKLPN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "299")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EPPBMIGPPGH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "282")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CLNBCFOMNAI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "318")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GDOMHLMOBAM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "305")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IBPJFKPPCKP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "319")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PGGFHEANGDH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "320")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CMMBAEFHOMA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "321")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> IFAJPIOBGPB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "322")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IGGKIOGMLMH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "323")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BKMNABEPLFF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "324")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FCPNEELIADN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "325")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> LNLAGMDFBOG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "326")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> DFPGJIADBEM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "327")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> ODOLBPLEOOB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "328")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> ALBCBENJBOM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "329")]
	public JIAPBKEBGKJ<JAGEFKKBKOI.MDCMCEMAGOL> CAOFHPMEAMD(EHDOPHDIBFE ANMGGEBBMLP, GEDHHGFCHLC INFMKNJIICF)
	{
		return default(JIAPBKEBGKJ<JAGEFKKBKOI.MDCMCEMAGOL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "330")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PPKBMKFHCNC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "331")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PEKPBCFHNDK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "332")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BGILJBNMNOC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "333")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CGMLMPBEJKF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "334")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DNHDAPEIKLO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "335")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IKKNOKKCKIC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "336")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GCOOOBBKNEM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "337")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BFJMGFINGBF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "338")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PACKLGLAKKI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "339")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PGHLAPNHLFB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "340")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GFCFCNEGHMN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "341")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KDBDNMOKMNG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "342")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ECCEINMHNEM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, int AKEJNJDPKAL)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "343")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> KNHCCPAOMKO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "344")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> KDKAIEFHFKO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "345")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> JCDABCHCEAC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "346")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HJNAECJNBNN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "347")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DFPJABEMGEO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "348")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> GAOJFMBFBLP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "349")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LELIGJPPNMC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "118")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FGMLIKNCPJK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "353")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JPLIGKCADBK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "350")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FKIOALCPGMO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "351")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LOIDAHDLLAI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "352")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BNLMNCKJLGE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "354")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KMCLNOIBFCG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "355")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DHOKIKBDMJE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "356")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GMNPMEPCBAG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "357")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EKAOONDNNPM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "358")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BJBBLMPJNJE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "359")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BCOGIANKJPN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "360")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KHBDENCAEPF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "361")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FBKJPEHABHF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "362")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GLECDHFOIIB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "363")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GNDHOBNBMFB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "364")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KFJODCPAIPE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "365")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OFLLPKMNPHE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "366")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DHMKFLMOGPM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "367")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LJLALKCMIBD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "368")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OELDPBLHJHJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "369")]
	public JIAPBKEBGKJ<NICNPLCGCEF> POLLMHFEHON(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "370")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FPGDIJEJHOK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "371")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PLOPHDICMFF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "372")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BFPHKLOJAIK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "373")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NFJBJLEIPAL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "374")]
	public JIAPBKEBGKJ<NICNPLCGCEF> INKALOGKILC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "375")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IKDCLCMGBIB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "376")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LHENOCMIKFP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "381")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HMLGKKCEJIC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "382")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FNMLDDIJBKA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "383")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LCHIAIDIJJB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "384")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DAHOHLCAKEP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "385")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HPEHFOHHCAO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "386")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HJNDMANEAMP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "377")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KDONOJNKMCH(EHDOPHDIBFE FEDPKDBAMIL, JOEGNIKLMHH MAHMNKIGHHC, int DDEEKFHKHJF)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "378")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> FPLIPBGJAKM(EHDOPHDIBFE FEDPKDBAMIL, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "379")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LFIPFIIGAAL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "380")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OPEAFPPCIDF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "387")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EKOFEKMAMBG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "388")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AHMJAGIEDMP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "389")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JIFFLHBPBLE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "390")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KCNCJHBJHDJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "391")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FJFAJLEADPP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "392")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MEGCKKAFBLJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "393")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EMECCMIPHOD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "394")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GPBADAFCGPM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "395")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MCFNJBCMPCL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "396")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PHDBIPNAPOP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "397")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CPLKCLCAMBM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "398")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PPFPBIJDCMF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "399")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GEBOLPAKCHJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "400")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GNHFGCLEMNF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "401")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DMMGBIBKJIA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "402")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JCGCKCEOIND(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "403")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HFGAIFFOKGN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "404")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EBBEJKALGHG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "405")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PIBBLHFNIDD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "406")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CHJGKOCFNFI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x27B84E0", Offset = "0x27B72E0", VA = "0x1827B84E0", Slot = "407")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OGMEKHCDOMI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "408")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EALILLADHFO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "409")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KNEIPLMCKCL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "410")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HEMJNMDEAEL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "411")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NGFDFPOOKIK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "412")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NDJDCAODHGL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "413")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CPGCPOGDEAJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "414")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MLEGHCPHJJH(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "415")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IANOOGBBBJN(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "416")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DEALOIBNDHK(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "417")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LKHLLACKOJO(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "418")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CMMLDLGLHMM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "419")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NHGCAMKNBPJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "420")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BOKDBAEBONK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, int DEJLIDMJHPI, float IJNFOOIKDNM, float FDNLOJBBCKH)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "421")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> LLLEHMKJJGF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "422")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> OBDDLFMJBIH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "423")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NEOBPBEDOLL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, int NEDPCGGDHKP, float ICMNODJPIEO, float HEHKCCMPILI, float BAMHABFBGKO, float MACPFNENAED, int MLCJDBJBAEP, float CGKJJCGCNLP, float MNAOGHONLEG, float DPABHMAJFBC, bool NNNFFDLCNEB)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "424")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> KIAHBLDKPME(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "425")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> CAEPINNMJKI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "426")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NENHHGLEPLA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, IReadOnlyList<HGHACPEMFNA.JKOJNGNPEKB> DJFJAIAPCNA)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "427")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> ELHBIMFKJIL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "428")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> NFNNALPAHCN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "429")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EDABHDMJNPN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, int BBEJBKCEBPA, int ILIFMKPKAFH, int EEGCPJKIPGM, int ECFOBJICKOI, int HKEMKHOODNF, float NMBLIHFPGFE, float BGHBHHMKMBC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "430")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> IBFHAHOOPFO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "431")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> LIKCEBFABNO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "432")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MOJFKEPGMGE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "433")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EMLBMEIGFBC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "434")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PEFEMPOMKAE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "435")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BMDOGFNMNLD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "436")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GGNIOAGEOPJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "437")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KLOMIAJFFBD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x27B8410", Offset = "0x27B7210", VA = "0x1827B8410", Slot = "438")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EHCGIBKHCHI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "439")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JJPNKBLJHCL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x27B8390", Offset = "0x27B7190", VA = "0x1827B8390", Slot = "441")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CKEGAPCHAMC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "440")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NBLDOJCNDON(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "442")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PBEIMILMOCE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "443")]
	public JIAPBKEBGKJ<NICNPLCGCEF> INFFPICJCGC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "444")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MPDCAPBFKCF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "445")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OEEFONKIGBC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "446")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OOOEADPBHOH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "447")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BGOFJEOHFIF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "448")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OHPNNKIJLMO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "449")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EPHGBEAFCJP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "450")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KDFPKFKKDLJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "451")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HGGOPJOENIE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "452")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FCLPMCINHON(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "453")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DGCGHIHCFNN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "454")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EFFLOHFLANF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "455")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CJAPKJDNONM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "456")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JLGDPCECHBJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "457")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IBCHCKCBLGL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "458")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HPLIOHCIIMJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "459")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BCKLFKEGAPK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "460")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AMJPIMMDAGM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "461")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CPMJAKBJDHK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "462")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IHDFMKCKGNE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "463")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ODECKIJJKOB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "464")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LENBMGOECIB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "465")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HBCBPBJBOKE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "466")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LEALHEJEOCB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "467")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FEGBDCNGBDO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "468")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DIELIAPNJPG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "469")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AIGGJAOOEPN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "470")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CNLJKPPIECJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "471")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CKLDLFBFNLI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "472")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LBJGDNCNDDB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "473")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FCDKAOCLGFP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "474")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AFKGLKGDJAB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "475")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PFMCBBOBDIP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "476")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DAOOGDDKJGN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "477")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NGNKGDCBINF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "478")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LKOMNAKOHAC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "479")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PFHIKDIGKMP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "480")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KINHKGOMJME(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "481")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CHBBMHFOOAF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "482")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CAJOILMDNHO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "483")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KAFEMOHHGPL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "484")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GLEMJOMINGH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "485")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ONLKACENELK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "486")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PJNFGIOEJNM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "487")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NHONNHPNIAO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "488")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GDNMBFBNDHB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "489")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DGCMEEJJHDM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "490")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IPDNCHDPOEO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "491")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JAGBPDOAKMH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "492")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EGKLHOCMFCJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "493")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KNHELCCNFKI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "494")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KBODOGENLLE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "495")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CBINHAAAIMN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "496")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LCJNGGHIFPN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "497")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DLLMIDFGAOF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "498")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DHPIKGCJGEL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "499")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GMOKJPFLKKB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "500")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OPOGFPJNEEE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "501")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GONNKCKBAEE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "502")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KEBLBMCGPBP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "503")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KILFIHOGJCG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "504")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FCEBEJICFOF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "505")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PKENBMBHPFI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "506")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JPKEEGFEKOA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "507")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LOBKAKHEFAA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "508")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GPOAIDIDHAB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "509")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CBGDLIAPBJJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "510")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ENMFAOIMELN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "511")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MKEFBODJAMA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "512")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HODEECCOAHB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "513")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ANIJKCEIEDK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "514")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HOPCAFFIFLB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "515")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EJINLCNOGPB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "516")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HLAJKJJIBKK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "517")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NPOFPGAENMH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "518")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GJPLHLAKEPO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "519")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BKAFIIDGFKL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "520")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PBJDOFDNIAA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "521")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CBHMJKCEHIL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "522")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PIAKJJBNOEN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "523")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HNEJLFMPPNO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "524")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OANFCAFEAGE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "525")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DMMMOGLGKNN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "526")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NHFNAGENCHA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "527")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KAHOHKFOPLF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "528")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DJKIGKCFCLO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "529")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LDFDIBHLMCD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "530")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HCFFOCKLDFC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "531")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NCLDMENFOLM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "532")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MJIFHNPMNBJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "533")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NDCIPDNFDHE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "534")]
	public JIAPBKEBGKJ<NICNPLCGCEF> APJMDNEEOLG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "535")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IAOHLJHKOCO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "536")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MONIGHIDODE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "537")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AIDOHJIFGMO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "538")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CIBBBBOHCJE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "539")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DOCOCAJJINJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "540")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MGHEOKDCMIG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "541")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NIAMBOBBMLL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "542")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PKOOOGKNKIC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "543")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CAKAOENMJCI(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "544")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KLPOKMEJEEE(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "545")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KJFCMPBJJMN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "546")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HJPFGIJPHPL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "547")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KMEFNGAHGCH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "548")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GIDLLDIDKHA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "549")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LGGPKMEAPOM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "550")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NECFLFKLHKN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "551")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NLDABDIGMNL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "552")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GEAPEAEBJFB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "553")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DLEBICLMCMP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "554")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NOOFGKBBEKD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "555")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PFIIGIEBALG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "556")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MFFAMFEGMOL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "557")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PBBDDJALINF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "558")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AKMOHCHAIGL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "559")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IJNEKCHFEMC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "561")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FPGDNNFCABL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "560")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HIIMJLMCDFP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "562")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KHHGLDMMDNF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "563")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LPHINMMONPP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "564")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JGALPFDGBFM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "565")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BMENGPJCDPC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "566")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LAPNJFDDFND(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "567")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LDENDKHCBDL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "568")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DKADMACLNMI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "569")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EIBFHGNIJGB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "570")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FENIIJFDPEK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "571")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DNCAMPGCIFE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "572")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DMHMFFLJAEP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "573")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JGHCHJPMBGM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "574")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NBCJPDPFACN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "575")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EKJNGLHLOLF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "600")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MMNIDJGGHAK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "605")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NFOLFGAGLAE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, int MIHCAHKBOGP)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "591")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HCBNHPCGBOL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "592")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KDDCEDGNHOE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "593")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LIHLIJJAOPP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "594")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GHNELGHDJDP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "595")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DMCEEFBNJCL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "596")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JNDHFAJBOAM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "597")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EIFDFPOFKML(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "598")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HOIAODGMMDE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "599")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KLMCFFBLOGJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "576")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OGMAFJGBMHK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "577")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MDGDBMOMKPC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "578")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LJIJMPGAMKP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "579")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GNKCFLHGBAL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "580")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DOAMDKDEHHI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "581")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CEOOFMBFCOP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "582")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KPHPPEAIBGO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "583")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CDBKAIICHDD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "584")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PMCGHIAKLAD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "585")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PANIDGNKONI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "586")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DCAIDIGPNCP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "587")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JLCOJFMPOLN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "588")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GEFIDDHOGAF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "589")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DJHJMBPFCPE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "590")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AONOOEECICF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "601")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NMFDAMMJOGP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "602")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JCGNMJNGDDA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "662")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JJLJMOKBHAB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "663")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> BGHOINFPIPL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "664")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> IPOPMKOMDHH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "606")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JKJBIPNBIIH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "607")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PHJHENMJEKO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "608")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PLHMCEOEAPA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "609")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BAEMOCPICKB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "610")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BAKFJMIIHHF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "611")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HLNLPBDPHIJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "612")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CDBIJLHJBKG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "613")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EIAEJPFIMNN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "614")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ABODDEGHFIP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "615")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CLGCMCLBPOP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "616")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MLMLJHOGDJM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "617")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NPNDFLFBDKI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "618")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ALIFHINDECH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "619")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IDMEAFDIHBG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "620")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BBFIDGPEOFJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "621")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DADAFLDMCME(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "622")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FKJBCHOIJIC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "623")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JFCOBLBEGPA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "624")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AJOOHJNGBPK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "625")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DLPNGFJJDCO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "626")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JJINPMIJCDC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "627")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IBCBDDNFHPF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "628")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AMACPJKKBJA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "629")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JEGFDODOHKC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "630")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GFODLABMABB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "631")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ACBBEAGAIGB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "632")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OCAGJDDIHHE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "633")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ANJDMLOBNLA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "634")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DPNBJFFANFG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "635")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PKIEAAEJEEM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "637")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FLOLMAAMMOO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "636")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OKJBPJELHBP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "638")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OHGMMDEKGNJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "639")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MGLMPMDFFOK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "640")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LEFILIGJNMI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "641")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ADLCAAHAGOD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "642")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NIMPECBLODJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "643")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KKGMIKOCNPF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "644")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BPFOGBOPIHI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "645")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HENFMIDMEDG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "646")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OLALFODEKLH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "647")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HGPMDCDIEDM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "648")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JKPDEEGCCFK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "649")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IMCOFJJCDIM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "650")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FJINPNNFBAB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "651")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HEODDFKKEAK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "652")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LAMEKLEIOAD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "653")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FJMABEODMCG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "654")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IKGAFCIFJED(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "655")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IPGMKFDKPOG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "656")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KNGAFCOENEJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "657")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LLOMFNPDIED(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "658")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GEGKOFNHFDJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "659")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EJDNMKJPCLP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "660")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MKJPLEEJPDC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "661")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CPBNJPEPDIA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "665")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GIAJFDGDCFK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "666")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HAOGOPHDLHC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000476")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "667")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MMKOGONPLLB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "668")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KJDGENGCCME(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "669")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HMMBMFDHIJC(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "670")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PFMCACELFFF(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "671")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CHPFFNNKOCF(EHDOPHDIBFE LFLIDAIGIHL, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "672")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HBCBHDCPMNA(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "673")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DPDFNGMEMFM(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "674")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CHJJKHKGFEJ(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "675")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BLKHEBOKDFL(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "603")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AKAILFFNFLK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "604")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HDCHNIDCDLN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "676")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JKMHCNLNKOL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "677")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IHNLDJEJBKD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "678")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GNNJPGPNHBD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000484")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "679")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LLHMFNDFHLA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "680")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JLLPDPCDALJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "681")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OJEBOCCDHHB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "682")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IENKFNADCMI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "683")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KDGCCMHHJEP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000489")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "684")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DOOIBHAPHIO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "685")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GNCABALGEGJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "686")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CHADOBMFLCH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "687")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ALFIOJKDCKP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "688")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FBPCNHIHLHO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "689")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BEGOEODBNFA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "690")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CELFCGFOHGE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "691")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HDOMOCAFDKF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "692")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OJOJEMHGDAJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "693")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ICNKKDPMCCF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "694")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PAHGNLHMEKM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "695")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KJCJOILHIAM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "696")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JADNDLEDKFP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "697")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HMKCIJDBLKG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "698")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EJGGALMEHJM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "699")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EIDIDNFDKHI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "700")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MIOHMMJKNGB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "701")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DCCNGMNGNJA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600049B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "702")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ADCAPIABIFH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600049C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "703")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LCOFKPFLOCB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600049D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "704")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BFEOLILOBPI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600049E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "705")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NPAEHPKJOEO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600049F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "706")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LCBAAKMFFHD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "707")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DPGCHPEHPJC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "708")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PKADCCJJMLK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "709")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GPPHEMGHOEC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "710")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AGIOFGKLMHC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "711")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LOOMPAIGJHK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "712")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HCDJKAJLHPC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "713")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PFJDEBIAFHC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "714")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> NLJJIJHMJHJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "715")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OLAACPMHLMN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "716")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PJNKMEDDEOK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "717")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ADPMKGODHPL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "718")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OKFJKNLEFIC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "719")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CMNJFLGACMI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "720")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IICBKIAIPKP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "721")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HCBIECKPFPC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "722")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DBELLLAFJJN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "723")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EKEODAHDMKP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, Guid BEJIAANNGBF)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "724")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> ECIHDLJIOPJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, bool DCAFAIEILEH)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "725")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GNCNNMPNNKI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "726")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ABAFMBKHDME(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "727")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NMKPDIHDBOM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, Guid OPABNANJDJH)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "728")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> LJLDNLIANMG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, bool DCAFAIEILEH)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "729")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PMDLHGADJPC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "730")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CBLPHLMAHLE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, Guid NFAJHOGJGCO)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "731")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> OJELCMJDOBC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004B9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "732")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> JLKGNIGNFCE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, bool DCAFAIEILEH)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "733")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AEEDIEHKLCB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "734")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HMMKADHLDGB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, Guid MFGPOEKJEBE)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "735")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> LLFACLNGOAB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, bool DCAFAIEILEH)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "736")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> EPHKILOPCFA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, bool DCAFAIEILEH)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "737")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EDAGFCHIIOM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004BF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "738")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> HCNACIGIDCI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "739")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> GBCGFNJJAKM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "740")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EOIHMCIBPJF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "741")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CBBHDGCKNNE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "742")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PPAAHDKDEGN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "743")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HIEOBABOKPM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "744")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LOIKIFAJBLL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "745")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HHNOLMDOMNP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, Guid JOPDHEGNJPF)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "746")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JKFPMDIAODJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "747")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> KCPMIJHFLOC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004C9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "748")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BPPFMCBGLKH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "749")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CMEEJNBIHKJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "750")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GBHCFGAPHKK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, Guid CGOKDMJGIOE)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "751")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> FOLLCFPPJDD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, Guid CGOKDMJGIOE, bool DCAFAIEILEH)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "752")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> FOLLCFPPJDD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, bool DCAFAIEILEH)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "753")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> EBPIEPIOCJP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, Guid CGOKDMJGIOE, bool DCAFAIEILEH)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004CF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "754")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> EBPIEPIOCJP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, bool DCAFAIEILEH)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "755")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BICNHBDNPAE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "756")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NKILIDLAFBE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "757")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OEEFCJOOHPN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "758")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DAGACBEDACG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "759")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CBMLBAIILCF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "760")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DLGNMHHAADJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "761")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> CKFBMOHLJNE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "762")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> ANDIMMMPOPJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "763")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> OAACOJOEJNF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004D9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "764")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DHMFGDNECMI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "765")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HMPCIMHIMJM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "766")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PHPNFPODDEG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "768")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NLBEGBBIAPA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "767")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AHELADGGCNF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "769")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DBGNGLOBEKI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004DF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "771")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NMGLENCIPBM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "770")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HGLDBGJJOPA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "772")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ECBCAJCNNBO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "773")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IPHODCIAMNH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "774")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LJHFPMPFPIF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "775")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HBGLBOFMFLC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "776")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HOBPHOFHLCJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "777")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LLFLPNJOPID(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "778")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BDKAMDGMEMD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "779")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JONMIOCFLPK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "780")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EKFJNFFCHBO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "781")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BPCHLCNHELP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "782")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JMPAFEEJDNI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "783")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IKAIPIPCCPE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "784")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OLECHDIONDG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "785")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PIEMEFIHHNL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "786")]
	public JIAPBKEBGKJ<NICNPLCGCEF> POLNLFLODCE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "787")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PFIJJIKCNHP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "788")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MMCFOLHPFMM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "789")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OIDCAGILGAA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, GBMEGLPFFLK NIDFNACFIPF)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "790")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ENCEANKGJPI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, GBMEGLPFFLK NIDFNACFIPF)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "791")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BJIJLAECEJA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, GBMEGLPFFLK NIDFNACFIPF)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "792")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IJCFMKDOCIM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, GBMEGLPFFLK NIDFNACFIPF)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "793")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PMDBCNOGOII(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, GBMEGLPFFLK NIDFNACFIPF)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "794")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EECJHFNMAJG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, GBMEGLPFFLK NIDFNACFIPF)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "795")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FIAECPGKOGJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, GBMEGLPFFLK NIDFNACFIPF)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "796")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GJABGOBOIPL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, GBMEGLPFFLK NIDFNACFIPF)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "797")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AKNMNOBLHPB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, GBMEGLPFFLK NIDFNACFIPF)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "798")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NHKPCDCFPMC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "799")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BNLLOKEPAOD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "800")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NNOCHHDBBIL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "801")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JBNBODJIACH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "802")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JINJKDECBDM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "803")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NCBMLKHPAMN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "804")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FNCPPBOCABJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000502")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "805")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IPGOPEDEDCF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000503")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "806")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ICCLKCNFKIN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000504")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "807")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IBJIHLOBAPO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "808")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KFKFIJPICLA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "809")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FIMEHMNDOEH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "810")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KEIJBMPHGEL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "811")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MPLKNLAHJAB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "812")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IPPGDKIBMPK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "813")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LMNAEGGNAMI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "814")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BILHDEEJIKB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "815")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FKFDEHBKCIP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "816")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BBEMMOGMBDP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "817")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BPBIKOLEJNG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "825")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AGCAFFIEDAG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "824")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ENHNBELLPCB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "826")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FAAFIEHPPHB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "827")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IOEFDMFIBMI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "828")]
	public JIAPBKEBGKJ<NICNPLCGCEF> APPCEDPDFDP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "829")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LKPLHLIODCA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "830")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JMBDMOMGJHA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "818")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BMKMIEBICMO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "819")]
	public JIAPBKEBGKJ<NICNPLCGCEF> INHOFFGPPHN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "820")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IPKJKMJEPNK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "821")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PEPCJIKBHEJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "822")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HIDENHHLOGH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "823")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ECCECMHLOCM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "831")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NLBCMCIOPLI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "832")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AMAEFEAHKOA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "838")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FKPHLCIBJGI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600051F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "839")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ONKBNFDCGHM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000520")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "840")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KKKMAAFOONL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000521")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "841")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AIGKJFHBGFE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000522")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "842")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KPABOHEJLIJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000523")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "843")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NBEDIDPEEJN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000524")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "844")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DHDDPLCIGML(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000525")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "845")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AONLGJIADCH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000526")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "833")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NJDLKMMJJCB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000527")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "834")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MKPOMIIAIMH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000528")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "835")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NNHCHAFEIBM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000529")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "836")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DHMCNKKEEDE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "837")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BEPFJHIHPON(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "846")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MDLLJKCDEOC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "847")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GBHBIKNKFPF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "848")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OOMNPECPFFG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "849")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DICDKHDBEKO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "850")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MBLMJEAIFJD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "851")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BFGHMHJIAPK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "852")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IONEPECFHHJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000532")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "853")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JKHADJNLCBJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000533")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "854")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OFCANHFIPKK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000534")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "855")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GBBONNMJLCM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000535")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "856")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EEGFNGNPMMC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "860")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BPBNOEPHAOM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "861")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DHJJGLKBBNA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "857")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> EOJBMILOBIO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000539")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "858")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IFAJIKIMGNI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "859")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AIOIGEKFEHO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "862")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PEHMONECBNA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "863")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HIHLIECCIDM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "864")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JMDANMPEGNI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "865")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AOBNGLBLHDB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "866")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LDPJOINDMMN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "867")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IBCEAFEOBIM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "868")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JGEFDLNPDEE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "869")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HDNMOOBHDOM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "870")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OPBEMBGPCLP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "871")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CDDPEMOHLAO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "872")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ACFFLCOLCJC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000546")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "873")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JEDAMKLKBIA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000547")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "874")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GNOBJBLAMAD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000548")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "875")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BCHJPGFEJEP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000549")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "876")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MIJCDKKMELE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "877")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GBMMLKKPHHA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "878")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NMNKFCJLMKC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "879")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DHDIFHCOOEC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "880")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FBALNIPLFFL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "881")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KDMFOGBPMKB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600054F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "882")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FEPFOCIACCI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000550")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "883")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MPHMGNDHCFF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000551")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "884")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HJJJMFMBJLL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000552")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "885")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GLLBNJDPOKK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000553")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "886")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GMMNAPNNBJH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000554")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "887")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ACBNFEBKOHA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000555")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "888")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DPLDPKOKLOI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000556")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "889")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NCKLLDEGMGH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000557")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "901")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PBBNCKOLEGA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000558")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "902")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MOJEMGPDANB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000559")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "903")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LOABEDNFEFE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600055A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "904")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CCNLJMODPLF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600055B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "905")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DJCHNGBFIFM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600055C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "906")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LFOGJDMJCFN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600055D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "907")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HCNIDEEGDGD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600055E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "908")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HEJCEKLNKAJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600055F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "909")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GJFKDNKPPOG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000560")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "910")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NGPPGABLJPA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000561")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "911")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ALLCMFGNHPB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000562")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "912")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NBFOGAMNGLJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000563")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "913")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LHKFINCFKMH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000564")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "914")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NKELIJONHMP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000565")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "915")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JOCANALCNEK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000566")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "916")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DNLBPIOEJBM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000567")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "917")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LINCBCPABNG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000568")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "918")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AEGDKGDFPJL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000569")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "919")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KICJNCONPHG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "920")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CELGDLHFBID(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "921")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GEDLGFOPEDC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "922")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OJJEMHMPOHA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "923")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HKFMJODNPDH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "924")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PGMDKKNMKEB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600056F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "925")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MMHJIEIMNIK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000570")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "926")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CKBCJHHCLIG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000571")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "927")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FOOOIJALFLK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000572")]
	[Cpp2IlInjected.Address(RVA = "0x27B83D0", Offset = "0x27B71D0", VA = "0x1827B83D0", Slot = "928")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CNIIOLLHBGD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000573")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "929")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LJACNJCAFNN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000574")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "930")]
	public JIAPBKEBGKJ<NICNPLCGCEF> APELIKAJNAD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH JGEIGFJENKG)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000575")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "931")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KMOOBMJDNHN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000576")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "932")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LHDPIIOLGHA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000577")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "933")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CLAJKOPIPMN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000578")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "934")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GCPPLHBDJAO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000579")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "935")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NGDHONJMHBO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "936")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OLFIJFMOMNE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "937")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FFLCNMAKCDG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "938")]
	public JIAPBKEBGKJ<NICNPLCGCEF> COHHOCOBPOM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "939")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EKPDPGKOEAO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "940")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KJEDOIANBNC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600057F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "941")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HKFMFLHKEAJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000580")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "942")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MBHFJLOOHEO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000581")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "943")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PNOPBPGCNFD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000582")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "944")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LHIFALPNOHI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000583")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "945")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IDADHBJOLII(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000584")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "946")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CKIICJLPBOL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000585")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "947")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HBBFKHMCPDC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000586")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "948")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NGNPKGHKGHK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000587")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "949")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HOKDMADNIHF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000588")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "950")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LKGJEAGMAFK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000589")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "951")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ELFPEGGCMAH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "952")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GJPJDIBLPAI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "953")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FEMCJMALLBN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "954")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OCOFAOOIKPA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "955")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AHHEBCPBEGJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "956")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GPKLPHMGIAO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "957")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JGNIPBAMPEB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "958")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JMIIDOJJKKI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "959")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EBABJKCJPGF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "960")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IMCHIEIPJPO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "961")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CJOKHGHOAHL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "962")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EPCJKJPOCGI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "963")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CPHMINBBMGA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "964")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CMIPKMCAGAB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000597")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "965")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MGABFLNMKBA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000598")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "966")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HGCJBFOKCHA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "967")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NALNCAPPOPK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "968")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DAFFLHJBNKM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "969")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OEFEKBBEGFK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "970")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NIFMNMCIDIE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "971")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BGACJALJJDH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "972")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LLHBEHHILHK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "973")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FJCPMLDJCKL(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "974")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EHDOBMJIANI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "975")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EFIGLLPEKJD(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "976")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GGLEDKHKDKK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "977")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EFJFOOGHIIE(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "978")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JFLBBBDICHM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "979")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LEPEMAHHOAC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "980")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KBOAICFBIJI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "981")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LOGCCFPANGI(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "982")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CAFOEPAIDJA(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "983")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JOFLNAPKEJF(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "984")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EHIMKOLALNE(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "985")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NFMBCNNHODM(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "986")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EEPENBKLGCO(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "987")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LHJBJECKPIA(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "988")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GILJHNAAPAJ(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "989")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FLCFBODDJIG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "990")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BEPKNHKMJBK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "991")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NFFGAFNBEGG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "992")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KLKAOKBDGJG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "993")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NDFDOGFCNPN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "994")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FJMABEDCLPO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "995")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EJNGDCBOPDO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "996")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BFLKAKBPOEL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "997")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CLEFIGKBEDH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "998")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FCJAJCIEAJJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "999")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KHIPONNPAAE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1000")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CMKMLNGNBNM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1001")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KKHEKCIHDBN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1002")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FHNPJDHNMOD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1003")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GAKNFMNIIFL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1004")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BHAMALOCEJK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005BF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1005")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EJGAGEJKFFH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1006")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IPELEEOEDAC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1007")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ALPBEPDBLHJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1008")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MLPIGHEIEAN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1009")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ABLBONJOLLJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1010")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BNAJFMBNAJM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1011")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EBCJJPBMCGH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1012")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JINGPJEPFDC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1013")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ACKOFJFDCLI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1014")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LKEMIGJFNFO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005C9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1015")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GFEMLAPHKKO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1016")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GLFEDCKAEBD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1017")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HKOHEOHJCKG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1018")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IGFNBMEFPAD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1019")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PILGFGNKNGN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1020")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IONGKIAGACG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005CF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1021")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AMBPJGHJCGE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1022")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DDILMMPOPGD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1023")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BAGKLPAGICG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1024")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BLEIMKPKFPK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1025")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NEBIHEEIBDO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1026")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MGOGLLIDLCP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1027")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AHMFALODAOG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1028")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FIFGHFHIJPN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1029")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IAGJLGFFOCH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1030")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KFOFAACBPKC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005D9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1031")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CICCCMFMEJD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1032")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HOOEFPMPAPI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1033")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AKEFAPIIAKP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1034")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AJBCGGDOBJI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1035")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DEGCEIBDOPM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1036")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OKAACLJBPLH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005DF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1037")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CBNDCDDAINF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1038")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PDEKOJCDDCJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1039")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CHKJEHGIDGK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1040")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EIBDJFFPPMG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1041")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NDLPCFLIGNM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1042")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MEAGLCKEKPG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1043")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DDGMLLNKKLP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1044")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MEKMEDGBPMM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1045")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AJPNNFOBNMH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "117")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LPBBEMNADJD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005E9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "119")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CLEPPAPMFFF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "120")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BLEJABAGNCH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "121")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HCNDFFOMCHA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "122")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HLEDKHDAGJI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005ED")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "123")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IOFGHHJCLAN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EE")]
	[Cpp2IlInjected.Address(RVA = "0x27B8380", Offset = "0x27B7180", VA = "0x1827B8380", Slot = "124")]
	public bool AAMNEPBIKNH(string DOABHODDFNN, [Out] int DEJLIDMJHPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005EF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1046")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HCFCBIHIMBK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F0")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1047")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CNIHCKOGOJI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F1")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1048")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BNHPHEPLPMD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F2")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OKCIPHBPPLI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, [In] string GCNGCMBAGEC, [In] int GFAGIKBHNOP)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F3")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1060")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JJGNONJIBAF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F4")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1049")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CKHPENDPMHK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F5")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1050")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DCIJKAHCCEB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F6")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1051")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BDKIMHJAIMG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F7")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1052")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ENBPIGGPEHB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F8")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1053")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DNPCEFCPEEH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005F9")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1054")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ABOOCLANCAO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FA")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1055")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LJEOLBBDILF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FB")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1056")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IJBLFOOCDHB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FC")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1057")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DELAJJMAOKB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FD")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1058")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CPDNMFBJPDC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FE")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "182")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KCCPCNBBGAJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, LFKIDMLBDKG IPFOIBLMBEA)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005FF")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "183")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IJDFEEIOIAN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000600")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "184")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CBEACFHBNFB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000601")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "185")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AOBPFHDLFMI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000602")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "186")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IIGLFKAPDKN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000603")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "187")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DBINNIAMGAB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000604")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "188")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NEOHNOJPBFI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000605")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "189")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NPCDOKKPEFF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000606")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "190")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IFIICJDKKBN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "191")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BBFIEMMNCHK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "192")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IIIFLPKCKMM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "193")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PFBDMBDKHME(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "194")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MGELGOIGIJE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "195")]
	public JIAPBKEBGKJ<NICNPLCGCEF> FCLPOLHPCGD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "196")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DJMPCGKPPAJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "197")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MMMDMOGPMMC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "198")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ANLAKPPJBKH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600060F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "199")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EMMCBAKIPKF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000610")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "200")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OJFJPGDAFMN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000611")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "201")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IJBKCOLKNDG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000612")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "202")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BFGIGMIDAEE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000613")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "203")]
	public JIAPBKEBGKJ<NICNPLCGCEF> APFPPABKCJL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000614")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "204")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KDDGKJGGIIF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000615")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "205")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IBDHPOBCPMF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000616")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "206")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EBIIFPKJCHM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000617")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10")]
	private static JIAPBKEBGKJ<NICNPLCGCEF> OOIHKAJEMOK(EHDOPHDIBFE ANMGGEBBMLP, object ICLOEPBNHKL, FBHIIMBEIHO EOJIGBFGLBJ, IReadOnlyList<GEDHHGFCHLC> EPAKLNGEFJA, IList<GEDHHGFCHLC> BHJGGDGPLOC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000618")]
	[Cpp2IlInjected.Address(RVA = "0x27B8450", Offset = "0x27B7250", VA = "0x1827B8450", Slot = "1061")]
	public JIAPBKEBGKJ<NICNPLCGCEF> ELOFBNIPDJK(EHDOPHDIBFE ANMGGEBBMLP, object ICLOEPBNHKL, FBHIIMBEIHO EOJIGBFGLBJ, IReadOnlyList<GEDHHGFCHLC> EPAKLNGEFJA, IList<GEDHHGFCHLC> BHJGGDGPLOC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1064")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BIENLKJMKLN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1065")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GDPPPNFJHFI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1066")]
	public JIAPBKEBGKJ<NICNPLCGCEF> LPCFNPDOLII(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1067")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PNJNHMOMCJP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1062")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IKIMJAABMAB(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, LNEJAJGHEGI CDCPKOGMNND)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600061E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1063")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DPBJBIDEKBJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "890")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PGEAGEPBGEN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "891")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OECBGMNPODL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "892")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NLCOBNMKFPD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "893")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CGNBJAPJFBN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "894")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IJPJPAGCMND(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "895")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JAAFPIDDCFP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "896")]
	public JIAPBKEBGKJ<NICNPLCGCEF> OLCADBOIMPD(EHDOPHDIBFE ANMGGEBBMLP, IReadOnlyList<GEDHHGFCHLC> EPAKLNGEFJA)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "897")]
	public JIAPBKEBGKJ<NICNPLCGCEF> NMAADFGLEKN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "898")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DBLAGIDDIGP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "899")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KMFFDLMKDEN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "900")]
	public JIAPBKEBGKJ<NICNPLCGCEF> EOLGLAGAJEL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1071")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JLEFMGOFNAG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1072")]
	public JIAPBKEBGKJ<NICNPLCGCEF> KNGIDJDGOJE(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1073")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MMNFHOAHMKD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1074")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DJJADKHPABN(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1075")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HJGFNBHCMDL(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1076")]
	public JIAPBKEBGKJ<NICNPLCGCEF> JANHKAAFBMH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1077")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HKCNHDEAMEM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x27B8520", Offset = "0x27B7320", VA = "0x1827B8520")]
	public LJPINNDLKGL([Optional] HEALPDOJDBM? AFFMGAIGAOB, [Optional] HEALPDOJDBM? EHPNAGDIFFG, [Optional] HEALPDOJDBM? BIDOHBIPBLC, [Optional] HEALPDOJDBM? HKCOBAPKNJB, [Optional] EKDGAEGBLHE? GKPHMDJBLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1078")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> HHPFAEFJAAG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1079")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> KCNANEJFNNP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1080")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> NHHAIKGPOIC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1081")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> GDGAJMDFKLP(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1082")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> FNFAHIKLENK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1083")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> FMBNCOMCBIF(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1084")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> DMPOHGAFPEM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1085")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> CJAAHDABICI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1086")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> IMNKJLIOCFJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1087")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> GGEDBLCBGNK(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1088")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> NMMFMBLBIJJ(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1089")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> BBHGIDNOHIG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1090")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> EKNPGFFDGGD(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x600063F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1091")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> LKGLFPLBAML(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000640")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1092")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> DJMHAHIKOPC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000641")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1093")]
	public JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>> ECPHFHMJCHM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<Task<JIAPBKEBGKJ<KOIPNOBMDGM>>>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000642")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1094")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IEAMMDEKLBO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000643")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1095")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CBIANLBNPBI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000644")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1096")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CGNNNGAHOIM(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000645")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1097")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BAICPJCDONA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000646")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1098")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CNICJEFIHJC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000647")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1099")]
	public JIAPBKEBGKJ<NICNPLCGCEF> PDCJJJNFCCC(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000648")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1100")]
	public JIAPBKEBGKJ<NICNPLCGCEF> DEAEEPDLLJO(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000649")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1101")]
	public JIAPBKEBGKJ<NICNPLCGCEF> CFLIHJPKPCP(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, EFDOKIELPIH JGPFPKIFIGD)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600064A")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1102")]
	public JIAPBKEBGKJ<NICNPLCGCEF> BFGNPDFODJA(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, EFDOKIELPIH JGPFPKIFIGD)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600064B")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1103")]
	public JIAPBKEBGKJ<NICNPLCGCEF> AHHHPIHGHLB(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, EFDOKIELPIH JGPFPKIFIGD)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600064C")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1104")]
	public JIAPBKEBGKJ<NICNPLCGCEF> GCLHCELACBO(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, EFDOKIELPIH JGPFPKIFIGD)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600064D")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1105")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HBNMGLKFFFL(GIFMCFFBPII ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, EFDOKIELPIH JGPFPKIFIGD)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600064E")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10")]
	public JIAPBKEBGKJ<NICNPLCGCEF> IEHHPHKDKAA(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, [In] HNENLJOIFOG IKICABIMEHH)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x600064F")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1069")]
	public JIAPBKEBGKJ<NICNPLCGCEF> MPCKBJGJHAI(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000650")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1070")]
	public JIAPBKEBGKJ<NICNPLCGCEF> HLJDDHHNCAG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000651")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1059")]
	private JIAPBKEBGKJ<NICNPLCGCEF> JPLBMDCOIBH(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, [In] string GCNGCMBAGEC, [In] int GFAGIKBHNOP)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000652")]
	[Cpp2IlInjected.Address(RVA = "0xFC5D10", Offset = "0xFC4B10", VA = "0x180FC5D10", Slot = "1068")]
	private JIAPBKEBGKJ<NICNPLCGCEF> HKBAFIHCCIG(EHDOPHDIBFE ANMGGEBBMLP, JOEGNIKLMHH MAHMNKIGHHC, [In] HNENLJOIFOG IKICABIMEHH)
	{
		return default(JIAPBKEBGKJ<NICNPLCGCEF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public sealed class JJJDPJIOKLP : AKGHGAGDGNL
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public delegate Task<bool> IMALBPKAMHC(KOEKCBHEICH BINEDJHADMC);

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static readonly JJJDPJIOKLP LJAJAMKHAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly IMALBPKAMHC IDHGHOJNPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly IMALBPKAMHC LMOADIHGKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool IGJBNKGGEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private bool GEFDACKGKFF;

	[Cpp2IlInjected.Token(Token = "0x6000655")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC80", Offset = "0x27BBA80", VA = "0x1827BCC80", Slot = "4")]
	public Task<bool> JINMELPJPGE(KOEKCBHEICH BINEDJHADMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000656")]
	[Cpp2IlInjected.Address(RVA = "0x27C18D0", Offset = "0x27C06D0", VA = "0x1827C18D0", Slot = "5")]
	public Task<bool> BMMJILDNPPB(KOEKCBHEICH BINEDJHADMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000657")]
	[Cpp2IlInjected.Address(RVA = "0x27C19B0", Offset = "0x27C07B0", VA = "0x1827C19B0")]
	public JJJDPJIOKLP([Optional] IMALBPKAMHC? NPPLJEFCDML, [Optional] IMALBPKAMHC? NHJJBFBKAMK, bool IGJBNKGGEKN = false, bool GEFDACKGKFF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x27C1900", Offset = "0x27C0700", VA = "0x1827C1900", Slot = "6")]
	public (PKMOOKCLFLL, Guid, Guid)? HPJFIMCMEEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10", Slot = "7")]
	public bool EALDCOJBMHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0xF9B930", Offset = "0xF9A730", VA = "0x180F9B930", Slot = "8")]
	public bool IBKMLHENOAP()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[Obsolete]
public sealed class PMCAKFHGEHA : AEOLPMHEEIO
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Guid MACFCNDPNBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xD60120", Offset = "0xD5EF20", VA = "0x180D60120", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000663")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
	public void Bind(HOAPFJKDIFG BOLHCOHKPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000664")]
	[Cpp2IlInjected.Address(RVA = "0xFE3E80", Offset = "0xFE2C80", VA = "0x180FE3E80")]
	public PMCAKFHGEHA(Guid PDFBNFKDLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000665")]
	[Cpp2IlInjected.Address(RVA = "0x27C4D60", Offset = "0x27C3B60", VA = "0x1827C4D60")]
	public static PMCAKFHGEHA NBEICDCLFEE(Guid PDFBNFKDLAH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class BDKGAEJDACK : OIAFHNGDCKD
{
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public delegate bool CNOPCIGCODA(KOIDEEJEAKA<JLGBKHFBOKK> JONFANGPPNH, KOIDEEJEAKA<HJIDLNADIFB>? GHMFFOACHJG, IReadOnlyDictionary<KOIDEEJEAKA<HJIDLNADIFB>, Guid>? BEGLDHJFHLM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private CNOPCIGCODA? AFDJHLINAME;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool FELJDEDABHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xCA8320", Offset = "0xCA7120", VA = "0x180CA8320", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool IDJDHAMNPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x27BC850", Offset = "0x27BB650", VA = "0x1827BC850", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool GBAIENGMHPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x1173110", Offset = "0x1171F10", VA = "0x181173110", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000669")]
	[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "6")]
	public bool BBIJNHMIPJJ(Guid OEFNJCAEKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "7")]
	public NFBNLJJMNLE FHCCLJMAGGG(Guid FELNIPICJHL)
	{
		return default(NFBNLJJMNLE);
	}

	[Cpp2IlInjected.Token(Token = "0x600066B")]
	[Cpp2IlInjected.Address(RVA = "0x27BC800", Offset = "0x27BB600", VA = "0x1827BC800", Slot = "8")]
	public bool FOIIEABHOFM(KOIDEEJEAKA<JLGBKHFBOKK> JONFANGPPNH, KOIDEEJEAKA<HJIDLNADIFB>? GHMFFOACHJG, IReadOnlyDictionary<KOIDEEJEAKA<HJIDLNADIFB>, Guid>? BEGLDHJFHLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066C")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "9")]
	public bool JBHHLJBCKMH(Guid OEFNJCAEKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066D")]
	[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "10")]
	public bool EHPNBILEEAD(Guid OEFNJCAEKAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600066E")]
	[Cpp2IlInjected.Address(RVA = "0x27BC860", Offset = "0x27BB660", VA = "0x1827BC860")]
	public BDKGAEJDACK(bool CDEHIIHANPM = false, bool FECAGDKMEDH = false, bool BILPHNIOCMF = false, bool HEMFKJKAMEL = false, bool EDPBHLGPAJA = false, [Optional] CNOPCIGCODA? FJHDAAFLLKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public sealed class MIANDGHPDFG : HDADOMGFMBE
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public delegate bool IPCNDAINJOC();

	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public delegate bool MCFEFEOMNPG();

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly MIANDGHPDFG LJAJAMKHAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly IPCNDAINJOC EHOHKFAANGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly MCFEFEOMNPG JHGBKGBHLHF;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool OIEENEHANEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x10EF120", Offset = "0x10EDF20", VA = "0x1810EF120", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool HHCAHPFFEFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x27C2E00", Offset = "0x27C1C00", VA = "0x1827C2E00", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000673")]
	[Cpp2IlInjected.Address(RVA = "0x27C2EB0", Offset = "0x27C1CB0", VA = "0x1827C2EB0")]
	public MIANDGHPDFG([Optional] IPCNDAINJOC? ANIADNKGPOI, [Optional] MCFEFEOMNPG? EPJLMBIGBND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public sealed class DPDOHAHICCI : EKOHEHAMKEP
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public static readonly DPDOHAHICCI ICOFMPPJNFC;

	[Cpp2IlInjected.Token(Token = "0x600067D")]
	[Cpp2IlInjected.Address(RVA = "0xABF9B0", Offset = "0xABE7B0", VA = "0x180ABF9B0", Slot = "4")]
	public object LGDBIGPAFJK(object OAIIHELJHLG, Type AAFMBEEMJAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600067E")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public DPDOHAHICCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public sealed class FDEFBOGBMKJ : BAOOKPBABPO
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public sealed class BAMCJCKBLMF : HLJNELPDBKH, INotifyCompletion
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static readonly BAMCJCKBLMF ICOFMPPJNFC;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool IGGJDLMDHKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0xA24630", Offset = "0xA23430", VA = "0x180A24630", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x27BC580", Offset = "0x27BB380", VA = "0x1827BC580", Slot = "6")]
		public void OnCompleted(Action KMLADDINOBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "5")]
		public void HHMPPDCCHNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public BAMCJCKBLMF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public static readonly FDEFBOGBMKJ ICOFMPPJNFC;

	[Cpp2IlInjected.Token(Token = "0x6000680")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	private FDEFBOGBMKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000681")]
	[Cpp2IlInjected.Address(RVA = "0x27C0D00", Offset = "0x27BFB00", VA = "0x1827C0D00", Slot = "4")]
	public HLJNELPDBKH BCGDNIKCDKC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public sealed class GAJAPGMPNCH<TRoot, TDeps> : IDisposable, KNAAHAGIAHE where TRoot : notnull where TDeps : notnull, HHCAACLJFDN.JBGOOOEKMEL<TRoot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly TDeps JLPOGPHFPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly TRoot PNPPCEOCLJN;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public BIHBDMOHDCK<FMJOCPEIHPL> IHHOBAGEDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(BIHBDMOHDCK<FMJOCPEIHPL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000689")]
	[Cpp2IlInjected.Address(RVA = "0x2D13A90", Offset = "0x2D12890", VA = "0x182D13A90")]
	public GAJAPGMPNCH(TDeps JCFBNAHPHAO, TRoot IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> AMOPEOJDIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068A")]
	[Cpp2IlInjected.Address(RVA = "0x4B7BDE0", Offset = "0x4B7ABE0", VA = "0x184B7BDE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068B")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C280", Offset = "0x4B7B080", VA = "0x184B7C280")]
	public BIHBDMOHDCK<KBIOCKDGHCK> JELMHKHOHMF([In] Guid? AEHJOFBOANC, GKJKNKIFDEP LEBLPDLNOOO)
	{
		return default(BIHBDMOHDCK<KBIOCKDGHCK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600068C")]
	[Cpp2IlInjected.Address(RVA = "0x4B7BF70", Offset = "0x4B7AD70", VA = "0x184B7BF70", Slot = "6")]
	public void ELNFNCPIINL(BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C0C0", Offset = "0x4B7AEC0", VA = "0x184B7C0C0", Slot = "7")]
	public void FOFBPBDNIOO(BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C4C0", Offset = "0x4B7B2C0", VA = "0x184B7C4C0", Slot = "8")]
	public void LENCJBCLBFP(BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C6A0", Offset = "0x4B7B4A0", VA = "0x184B7C6A0", Slot = "10")]
	public void MJPHMLECAKN(BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, EHCDJHCNGGB KHJDGOHGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x4B7BB60", Offset = "0x4B7A960", VA = "0x184B7BB60", Slot = "9")]
	public void DCIDMMFOKJL(BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C780", Offset = "0x4B7B580", VA = "0x184B7C780", Slot = "11")]
	public void NKJCHFEBLFI(BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, CDHLEMKKJAJ? HEDGKGMEDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x4B7CAD0", Offset = "0x4B7B8D0", VA = "0x184B7CAD0", Slot = "12")]
	public BIHBDMOHDCK<FMJOCPEIHPL> OLLLJAPHAHC(BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID)
	{
		return default(BIHBDMOHDCK<FMJOCPEIHPL>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000693")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B990", Offset = "0x4B7A790", VA = "0x184B7B990", Slot = "13")]
	public BIHBDMOHDCK<PKHGGFFHAFE> BIFGPIFKMFF(BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, string MAKJJJECHHB, object OAIIHELJHLG, DIHIEGCJAKF NHPABLGEENB, JIGKDJKGFGE IMKLGAJMJEH)
	{
		return default(BIHBDMOHDCK<PKHGGFFHAFE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x4B7C9C0", Offset = "0x4B7B7C0", VA = "0x184B7C9C0", Slot = "14")]
	public void NOELLLLJFAF(BIHBDMOHDCK<PKHGGFFHAFE> MOJMKMNDDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x4B7BCB0", Offset = "0x4B7AAB0", VA = "0x184B7BCB0", Slot = "15")]
	public void DJGOKFBAFGH(BIHBDMOHDCK<PKHGGFFHAFE> MOJMKMNDDDD, object OAIIHELJHLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class HHCAACLJFDN
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public interface JBGOOOEKMEL<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000696")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KGOFBPFMHOM(TRoot IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH);

		[Cpp2IlInjected.Token(Token = "0x6000697")]
		[Cpp2IlInjected.Address(Slot = "1")]
		BIHBDMOHDCK<FMJOCPEIHPL>? ALPBINKOMOE(TRoot IPCOMOHMNHK);

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(Slot = "2")]
		BIHBDMOHDCK<KBIOCKDGHCK> JELMHKHOHMF(TRoot IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> DLJDIONABKD, [In] Guid? AEHJOFBOANC, GKJKNKIFDEP LEBLPDLNOOO);

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ELNFNCPIINL(TRoot IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA);

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FOFBPBDNIOO(TRoot IPCOMOHMNHK, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA);

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void MJPHMLECAKN(TRoot IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA);

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DCIDMMFOKJL(TRoot IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA);

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void NKJCHFEBLFI(TRoot IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, CDHLEMKKJAJ? HEDGKGMEDOE);

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		BIHBDMOHDCK<FMJOCPEIHPL>? OLLLJAPHAHC(TRoot IPCOMOHMNHK, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID);

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		BIHBDMOHDCK<PKHGGFFHAFE> BIFGPIFKMFF(TRoot IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, string MAKJJJECHHB, object LDGCNLHOBMI, DIHIEGCJAKF NHPABLGEENB, JIGKDJKGFGE IMKLGAJMJEH);

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void NOELLLLJFAF(TRoot IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<PKHGGFFHAFE> MOJMKMNDDDD);

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void DJGOKFBAFGH(TRoot IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<PKHGGFFHAFE> MOJMKMNDDDD, object OAIIHELJHLG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
internal sealed class ECEDPBEKLBA
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	internal struct JOMPJMEIMPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public readonly HashSet<BIHBDMOHDCK<KBIOCKDGHCK>> NNNIADAHANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public HAIPMHAADMB<PKHGGFFHAFE, FIEDIOJGJGN> LNFAONLIIOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly Dictionary<BIHBDMOHDCK<PKHGGFFHAFE>, BIHBDMOHDCK<MPEKJFEIBFI.APNHMEBCBCD>> KPDINFEFEPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Dictionary<BIHBDMOHDCK<MPEKJFEIBFI.APNHMEBCBCD>, BIHBDMOHDCK<PKHGGFFHAFE>> PJDDLOJPHKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public PKGDJDPCMOK<KBIOCKDGHCK, CDHLEMKKJAJ?> JOENPEJAKFK;

		[Cpp2IlInjected.Token(Token = "0x60006B3")]
		[Cpp2IlInjected.Address(RVA = "0x27C1DB0", Offset = "0x27C0BB0", VA = "0x1827C1DB0")]
		private JOMPJMEIMPC(HashSet<BIHBDMOHDCK<KBIOCKDGHCK>> EHBOPGCKOBG, [In] HAIPMHAADMB<PKHGGFFHAFE, FIEDIOJGJGN> DOMIJLNPKHF, Dictionary<BIHBDMOHDCK<PKHGGFFHAFE>, BIHBDMOHDCK<MPEKJFEIBFI.APNHMEBCBCD>> MLLIICLIMGE, Dictionary<BIHBDMOHDCK<MPEKJFEIBFI.APNHMEBCBCD>, BIHBDMOHDCK<PKHGGFFHAFE>> GEPKJIIPPDM, [In] PKGDJDPCMOK<KBIOCKDGHCK, CDHLEMKKJAJ?> GOCHICPMFCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B4")]
		[Cpp2IlInjected.Address(RVA = "0x27C1BD0", Offset = "0x27C09D0", VA = "0x1827C1BD0")]
		public static JOMPJMEIMPC NBEICDCLFEE()
		{
			return default(JOMPJMEIMPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	private struct HGDEDMCHBHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public BIHBDMOHDCK<FMJOCPEIHPL>? AHJJPKDILHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public readonly Guid? IIFNBDFMHFC;

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x27C12B0", Offset = "0x27C00B0", VA = "0x1827C12B0")]
		public HGDEDMCHBHJ(BIHBDMOHDCK<FMJOCPEIHPL> BKPPJKFJHPL, [In] Guid? AEHJOFBOANC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	internal struct FIEDIOJGJGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public JIGKDJKGFGE KFEBPMJCFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public DIHIEGCJAKF AJCPANDDFOD;

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0xAE6A40", Offset = "0xAE5840", VA = "0x180AE6A40")]
		internal FIEDIOJGJGN(JIGKDJKGFGE IMKLGAJMJEH, DIHIEGCJAKF NHPABLGEENB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x27C0DD0", Offset = "0x27BFBD0", VA = "0x1827C0DD0")]
		public static FIEDIOJGJGN NBEICDCLFEE(JIGKDJKGFGE IMKLGAJMJEH, DIHIEGCJAKF NHPABLGEENB)
		{
			return default(FIEDIOJGJGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	internal struct MPEKJFEIBFI
	{
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		public sealed class APNHMEBCBCD
		{
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public string KHKODDKNOBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public object COJGBJGNJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int PLNNNGNNOIK;

		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(RVA = "0x27C33D0", Offset = "0x27C21D0", VA = "0x1827C33D0")]
		internal MPEKJFEIBFI(string IHGFMOMOADA, object OAIIHELJHLG, int COGACKGGKED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x27C3380", Offset = "0x27C2180", VA = "0x1827C3380")]
		public static MPEKJFEIBFI NBEICDCLFEE(string IHGFMOMOADA, object OAIIHELJHLG)
		{
			return default(MPEKJFEIBFI);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private HAIPMHAADMB<KBIOCKDGHCK, HGDEDMCHBHJ> IMOHAMDDIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private Dictionary<(Guid, GKJKNKIFDEP), BIHBDMOHDCK<KBIOCKDGHCK>> CDPAMDFDINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private HAIPMHAADMB<MPEKJFEIBFI.APNHMEBCBCD, MPEKJFEIBFI> IMDFCOKELPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private Dictionary<string, BIHBDMOHDCK<MPEKJFEIBFI.APNHMEBCBCD>> KMMOPBINHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private PKGDJDPCMOK<FMJOCPEIHPL, JOMPJMEIMPC> AELIPHPHKMM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public BIHBDMOHDCK<KBIOCKDGHCK>? HIAHLBIBLNP
	{
		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0xCFC430", Offset = "0xCFB230", VA = "0x180CFC430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x27BE5A0", Offset = "0x27BD3A0", VA = "0x1827BE5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x27BE9A0", Offset = "0x27BD7A0", VA = "0x1827BE9A0")]
	public void KCGBACPBOON([In] GFAEBDOOJCH<FMJOCPEIHPL> EMMMFPJLKFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x27BEEE0", Offset = "0x27BDCE0", VA = "0x1827BEEE0")]
	public void KKOHIOADNDL(BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, bool IGDECPIGGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x27BEBA0", Offset = "0x27BD9A0", VA = "0x1827BEBA0")]
	public void KGOFBPFMHOM(BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<FMJOCPEIHPL>? MALBEIBOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006A7")]
	[Cpp2IlInjected.Address(RVA = "0x27BE5B0", Offset = "0x27BD3B0", VA = "0x1827BE5B0")]
	public BIHBDMOHDCK<KBIOCKDGHCK> JELMHKHOHMF(BIHBDMOHDCK<FMJOCPEIHPL> DLJDIONABKD, [In] Guid? AEHJOFBOANC, GKJKNKIFDEP LEBLPDLNOOO, [In] GFAEBDOOJCH<FMJOCPEIHPL> EMMMFPJLKFF)
	{
		return default(BIHBDMOHDCK<KBIOCKDGHCK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x27BDB50", Offset = "0x27BC950", VA = "0x1827BDB50")]
	public BIHBDMOHDCK<PKHGGFFHAFE> BIFGPIFKMFF(BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, string IHGFMOMOADA, object LDGCNLHOBMI, DIHIEGCJAKF NHPABLGEENB, JIGKDJKGFGE IMKLGAJMJEH)
	{
		return default(BIHBDMOHDCK<PKHGGFFHAFE>);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A9")]
	[Cpp2IlInjected.Address(RVA = "0x27BF660", Offset = "0x27BE460", VA = "0x1827BF660")]
	public void NOELLLLJFAF(BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<PKHGGFFHAFE> MOJMKMNDDDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AA")]
	[Cpp2IlInjected.Address(RVA = "0x27BF3A0", Offset = "0x27BE1A0", VA = "0x1827BF3A0")]
	public BIHBDMOHDCK<KBIOCKDGHCK>? LECEMKMPGJM([In] Guid AEHJOFBOANC, GKJKNKIFDEP LEBLPDLNOOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x27BE3B0", Offset = "0x27BD1B0", VA = "0x1827BE3B0")]
	public void ELNFNCPIINL([In] GFAEBDOOJCH<FMJOCPEIHPL> EMMMFPJLKFF, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x27BE430", Offset = "0x27BD230", VA = "0x1827BE430")]
	public void FOFBPBDNIOO(BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x27BF450", Offset = "0x27BE250", VA = "0x1827BF450")]
	public void MJPHMLECAKN(BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x27BDE00", Offset = "0x27BCC00", VA = "0x1827BDE00")]
	public void DCIDMMFOKJL([In] GFAEBDOOJCH<FMJOCPEIHPL> EMMMFPJLKFF, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x27BF590", Offset = "0x27BE390", VA = "0x1827BF590")]
	public void NKJCHFEBLFI(BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, CDHLEMKKJAJ? HEDGKGMEDOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B0")]
	[Cpp2IlInjected.Address(RVA = "0x27BF850", Offset = "0x27BE650", VA = "0x1827BF850")]
	public BIHBDMOHDCK<FMJOCPEIHPL>? OLLLJAPHAHC(BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(RVA = "0x27BDF80", Offset = "0x27BCD80", VA = "0x1827BDF80")]
	public void DJGOKFBAFGH([In] GFAEBDOOJCH<FMJOCPEIHPL> EMMMFPJLKFF, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<PKHGGFFHAFE> MOJMKMNDDDD, object OAIIHELJHLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(RVA = "0x27BF8C0", Offset = "0x27BE6C0", VA = "0x1827BF8C0")]
	public ECEDPBEKLBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
internal static class DFBFPHDIAEA
{
	[Cpp2IlInjected.Token(Token = "0x60006BA")]
	[Cpp2IlInjected.Address(RVA = "0x27BD060", Offset = "0x27BBE60", VA = "0x1827BD060")]
	public static void KCGBACPBOON(this ECEDPBEKLBA.JOMPJMEIMPC FPFHIDBMBMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public class MKIPIILIBMO : ENBCEDMPGEP.BNBHBKEMMFA
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static MKIPIILIBMO JBLOFIECBAB;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BCJLBKIBIHI NKGNHBBCGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0xA0B680", Offset = "0xA0A480", VA = "0x180A0B680", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public BCJLBKIBIHI KJEAHOOPGAC
	{
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(RVA = "0xA17110", Offset = "0xA15F10", VA = "0x180A17110")]
	public MKIPIILIBMO(BCJLBKIBIHI PGEKCICOMKM, BCJLBKIBIHI AHDLPMOFHFJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[IICOIOJKHLE("MockCircuitsNetwork")]
public sealed class EHDNNCCPOFO : IDisposable
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private readonly struct FKGIDMFMECG : PPAIEIINDHH.JPHGIHLIEKF<BEPCLDNEIBO, CMGFJHDBEGO, EHDNNCCPOFO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000093")]
		[CompilerGenerated]
		private struct LGCCIMKNNMK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public EHDNNCCPOFO root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public BIHBDMOHDCK<FMJOCPEIHPL> actorId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			public BIHBDMOHDCK<BEPCLDNEIBO> requestId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			public CMGFJHDBEGO action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			public FKGIDMFMECG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private (Task SendLocalTask, Task[] SendOthersTasks) <tasks>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0x27C25D0", Offset = "0x27C13D0", VA = "0x1827C25D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006CD")]
			[Cpp2IlInjected.Address(RVA = "0x27C28E0", Offset = "0x27C16E0", VA = "0x1827C28E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA097D0", VA = "0x180A0A9D0", Slot = "4")]
		public int JDLHACMIFPE(EHDNNCCPOFO IPCOMOHMNHK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C6")]
		[Cpp2IlInjected.Address(RVA = "0x27C0E30", Offset = "0x27BFC30", VA = "0x1827C0E30", Slot = "5")]
		public int ALMIPOKMHLH(EHDNNCCPOFO IPCOMOHMNHK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C7")]
		[Cpp2IlInjected.Address(RVA = "0x27C0E10", Offset = "0x27BFC10", VA = "0x1827C0E10", Slot = "6")]
		public int AEJJDLEAPED(EHDNNCCPOFO IPCOMOHMNHK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xDFF780", Offset = "0xDFE580", VA = "0x180DFF780", Slot = "7")]
		public int PNJMDGEIDAL(EHDNNCCPOFO IPCOMOHMNHK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x27C0F90", Offset = "0x27BFD90", VA = "0x1827C0F90", Slot = "8")]
		public void MEBHIEALMGA(EHDNNCCPOFO IPCOMOHMNHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "9")]
		public bool DLNEEPEKLBG(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> FAPLIEIFOHC, CMGFJHDBEGO[] GONMDJMHKJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0x27C0E50", Offset = "0x27BFC50", VA = "0x1827C0E50", Slot = "10")]
		[AsyncStateMachine(typeof(LGCCIMKNNMK))]
		public Task KNHLBDALFEK(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> FAPLIEIFOHC, BIHBDMOHDCK<BEPCLDNEIBO> AEHODJLJACF, CMGFJHDBEGO CFDGGKIIHOI, bool GIEHBHBKKAM = true)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	private readonly struct BFGEDJCCHAN : PPAIEIINDHH.JMNOCPOJNGK<IPDKADPDBAD, HBDCLDOGDAK.MDCBNLABDFL, FKGIDMFMECG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public IPDKADPDBAD EFDFJHLJCNL
		{
			[Cpp2IlInjected.Token(Token = "0x60006CE")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "4")]
			get
			{
				return default(IPDKADPDBAD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public HBDCLDOGDAK.MDCBNLABDFL BNIOCAJEEHJ
		{
			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "5")]
			get
			{
				return default(HBDCLDOGDAK.MDCBNLABDFL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public FKGIDMFMECG HAIPLDJPOBE
		{
			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0xA53DA0", Offset = "0xA52BA0", VA = "0x180A53DA0", Slot = "6")]
			get
			{
				return default(FKGIDMFMECG);
			}
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	public readonly struct ODBHPFFEENP : JKIMPDANFCO.IMGACFDGOJE<EHDNNCCPOFO>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private struct FBJIGKBBJBM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000132")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000133")]
			public AsyncTaskMethodBuilder<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000134")]
			public EHDNNCCPOFO root;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000135")]
			public BIHBDMOHDCK<FMJOCPEIHPL> clientId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000136")]
			public CMGFJHDBEGO action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000137")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000138")]
			public ODBHPFFEENP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000139")]
			private TaskAwaiter<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x27C0A10", Offset = "0x27BF810", VA = "0x1827C0A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x27C0C90", Offset = "0x27BFA90", VA = "0x1827C0C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0x27C3980", Offset = "0x27C2780", VA = "0x1827C3980", Slot = "4")]
		[AsyncStateMachine(typeof(FBJIGKBBJBM))]
		public Task<JKEBLLKKBOM<object, CHEIGOJMDOJ>> KNHLBDALFEK(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, CMGFJHDBEGO CFDGGKIIHOI, bool DPAGNCPIBHD)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public readonly struct LDKLGLPDMEL : HHCAACLJFDN.JBGOOOEKMEL<EHDNNCCPOFO>
	{
		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0x27C23D0", Offset = "0x27C11D0", VA = "0x1827C23D0", Slot = "4")]
		public void KGOFBPFMHOM(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xDE9740", Offset = "0xDE8540", VA = "0x180DE9740", Slot = "5")]
		public BIHBDMOHDCK<FMJOCPEIHPL>? ALPBINKOMOE(EHDNNCCPOFO IPCOMOHMNHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x27C2380", Offset = "0x27C1180", VA = "0x1827C2380")]
		public BIHBDMOHDCK<KBIOCKDGHCK> JELMHKHOHMF(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> DLJDIONABKD, [In] Guid? AEHJOFBOANC, GKJKNKIFDEP LEBLPDLNOOO)
		{
			return default(BIHBDMOHDCK<KBIOCKDGHCK>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x27C2170", Offset = "0x27C0F70", VA = "0x1827C2170", Slot = "7")]
		public void ELNFNCPIINL(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x27C2200", Offset = "0x27C1000", VA = "0x1827C2200", Slot = "8")]
		public void FOFBPBDNIOO(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x27C2400", Offset = "0x27C1200", VA = "0x1827C2400", Slot = "9")]
		public void MJPHMLECAKN(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x27C2110", Offset = "0x27C0F10", VA = "0x1827C2110", Slot = "10")]
		public void DCIDMMFOKJL(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, EHCDJHCNGGB KHJDGOHGJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x27C2440", Offset = "0x27C1240", VA = "0x1827C2440", Slot = "11")]
		public void NKJCHFEBLFI(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID, CDHLEMKKJAJ? HEDGKGMEDOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x27C2550", Offset = "0x27C1350", VA = "0x1827C2550", Slot = "12")]
		public BIHBDMOHDCK<FMJOCPEIHPL>? OLLLJAPHAHC(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<KBIOCKDGHCK> NIFNCNHCJID)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x27C20B0", Offset = "0x27C0EB0", VA = "0x1827C20B0", Slot = "13")]
		public BIHBDMOHDCK<PKHGGFFHAFE> BIFGPIFKMFF(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, string MAKJJJECHHB, object LDGCNLHOBMI, DIHIEGCJAKF NHPABLGEENB, JIGKDJKGFGE IMKLGAJMJEH)
		{
			return default(BIHBDMOHDCK<PKHGGFFHAFE>);
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x27C2520", Offset = "0x27C1320", VA = "0x1827C2520", Slot = "14")]
		public void NOELLLLJFAF(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<PKHGGFFHAFE> MOJMKMNDDDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x27C2140", Offset = "0x27C0F40", VA = "0x1827C2140", Slot = "15")]
		public void DJGOKFBAFGH(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, BIHBDMOHDCK<PKHGGFFHAFE> MOJMKMNDDDD, object OAIIHELJHLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E0")]
		[Cpp2IlInjected.Address(RVA = "0x27C2380", Offset = "0x27C1180", VA = "0x1827C2380", Slot = "6")]
		private BIHBDMOHDCK<KBIOCKDGHCK> PBCBMMAMDNB(EHDNNCCPOFO IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> DLJDIONABKD, [In] Guid? AEHJOFBOANC, GKJKNKIFDEP LEBLPDLNOOO)
		{
			return default(BIHBDMOHDCK<KBIOCKDGHCK>);
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[CompilerGenerated]
	private struct DPHIIOKIGLD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public AsyncTaskMethodBuilder<JAMKBHIIBJJ> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public EHDNNCCPOFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public BIHBDMOHDCK<KBIOCKDGHCK>? rootCV2Object;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public IKMAMAHLHMO deps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public FJFOJKNNALJ registry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public LCBOCOCABKH registryV2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BB8")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private BIHBDMOHDCK<FMJOCPEIHPL> <clientId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC0")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private LCLGPAIHKMN<EHDNNCCPOFO, ODBHPFFEENP> <staticNetSys>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC8")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private GAJAPGMPNCH<EHDNNCCPOFO, LDKLGLPDMEL> <dynamicNetSys>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BD0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private HBDCLDOGDAK <circuitsManager>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BD8")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x27BD4A0", Offset = "0x27BC2A0", VA = "0x1827BD4A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x27BDAE0", Offset = "0x27BC8E0", VA = "0x1827BDAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly HHMFGDOPAGH<CMGFJHDBEGO, NICNPLCGCEF, HBDCLDOGDAK, IPDKADPDBAD, HBDCLDOGDAK.MDCBNLABDFL, FKGIDMFMECG, EHDNNCCPOFO, BFGEDJCCHAN> FEHFNLHDCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly ECEDPBEKLBA LNEHKBOILLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private GFAEBDOOJCH<FMJOCPEIHPL> EINHIEJFNIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private PKGDJDPCMOK<FMJOCPEIHPL, NICNPLCGCEF> AELIPHPHKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private PKGDJDPCMOK<FMJOCPEIHPL, HBDCLDOGDAK> LEDGDDOCKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private BIHBDMOHDCK<FMJOCPEIHPL>? NEHPNCLKHOA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public GKMMMOPALMB LJNKNLEKNCA
	{
		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0xA0ECC0", Offset = "0xA0DAC0", VA = "0x180A0ECC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(RVA = "0x27C0500", Offset = "0x27BF300", VA = "0x1827C0500")]
	public EHDNNCCPOFO(int INAJLBMHABM, int LILJFCLKDHC, int CHIFDKPKEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C1")]
	[Cpp2IlInjected.Address(RVA = "0x27BFDC0", Offset = "0x27BEBC0", VA = "0x1827BFDC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C2")]
	[Cpp2IlInjected.Address(RVA = "0x27C0280", Offset = "0x27BF080", VA = "0x1827C0280")]
	[AsyncStateMachine(typeof(DPHIIOKIGLD))]
	public Task<JAMKBHIIBJJ> KKOHIOADNDL(IKMAMAHLHMO JCFBNAHPHAO, FJFOJKNNALJ ENALCCBHCIF, LCBOCOCABKH GPFGJHBJKPA, BIHBDMOHDCK<KBIOCKDGHCK>? ELOLDAOBHKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006C3")]
	[Cpp2IlInjected.Address(RVA = "0x27BFF90", Offset = "0x27BED90", VA = "0x1827BFF90")]
	private void KGOFBPFMHOM(BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006C4")]
	[Cpp2IlInjected.Address(RVA = "0x27C0440", Offset = "0x27BF240", VA = "0x1827C0440")]
	[CompilerGenerated]
	private BIHBDMOHDCK<KBIOCKDGHCK>? PJPFLEBMLIJ([In] Guid AEHJOFBOANC, GKJKNKIFDEP LEBLPDLNOOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public sealed class BGHDGIGJFBH : DIFGANNFPID.OEKIHGBCEEC
{
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public delegate Task<CKGJLKOHNOP> DNMCICELECF(HBDCLDOGDAK PINKMLPHMFP, BINGFOABLIG BGPKDMDEGME, HHNNLOLDABE? KJJLJHGIIKB, MMIHAIKLLOA? NIAGKFELLGP, CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public delegate void AAEOKGOHABC();

	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public delegate void OOIHBNGBBAM();

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CompilerGenerated]
	private struct GBHOMOBCAIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public AsyncTaskMethodBuilder<CKGJLKOHNOP> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public BGHDGIGJFBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public HBDCLDOGDAK circuitsManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public BINGFOABLIG evRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public HHNNLOLDABE cv2RoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public MMIHAIKLLOA cv2SuperRoomData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private TaskAwaiter<CKGJLKOHNOP> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x27C0FE0", Offset = "0x27BFDE0", VA = "0x1827C0FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x27C11F0", Offset = "0x27BFFF0", VA = "0x1827C11F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly DNMCICELECF MOKHBFOFAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly AAEOKGOHABC? DDFMJIBIONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly OOIHBNGBBAM? DJIIEIBIJDE;

	[Cpp2IlInjected.Token(Token = "0x60006E3")]
	[Cpp2IlInjected.Address(RVA = "0x27BC8D0", Offset = "0x27BB6D0", VA = "0x1827BC8D0", Slot = "4")]
	[AsyncStateMachine(typeof(GBHOMOBCAIK))]
	public Task<CKGJLKOHNOP> JJGBLHMLIGM(HBDCLDOGDAK PINKMLPHMFP, BINGFOABLIG BGPKDMDEGME, HHNNLOLDABE? KJJLJHGIIKB, MMIHAIKLLOA? NIAGKFELLGP, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006E4")]
	[Cpp2IlInjected.Address(RVA = "0xE80B60", Offset = "0xE7F960", VA = "0x180E80B60", Slot = "5")]
	public void MBOMEGGJCAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E5")]
	[Cpp2IlInjected.Address(RVA = "0xF38670", Offset = "0xF37470", VA = "0x180F38670", Slot = "6")]
	public void OFAJLBGEKJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006E6")]
	[Cpp2IlInjected.Address(RVA = "0x27BCA50", Offset = "0x27BB850", VA = "0x1827BCA50")]
	public BGHDGIGJFBH([Optional] DNMCICELECF? LKAPEAEMBGD, [Optional] AAEOKGOHABC? DIIIDKCCNKE, [Optional] OOIHBNGBBAM? HAMFFJFMCHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public sealed class PKPCPBHCDCI : HNLPMDFGNGL.LECFMDNGEBF
{
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public delegate OIOBLJKDDDM GGNFPFDBKFB();

	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public delegate Task<HHNNLOLDABE> JELECPJGBOE(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public delegate Task<MMIHAIKLLOA> ELEJPDNFNEK(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	public delegate Task<MKHACDHEGGK> APLLECLFNDG(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public delegate Task<PPPBEPLDMBL> GFNEGBECMCP(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	public delegate Task<HNLPMDFGNGL.LECFMDNGEBF.JMKLHDAGPGG> JECPGPBKGBJ(CancellationToken GHKBKDKNIOM);

	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public delegate Task<GABCMIEAAIL> IDLBHEDBODI(CancellationToken GHKBKDKNIOM);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[CompilerGenerated]
	private struct MBECIGFKMGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public AsyncTaskMethodBuilder<HHNNLOLDABE> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public PKPCPBHCDCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private TaskAwaiter<HHNNLOLDABE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600070A")]
		[Cpp2IlInjected.Address(RVA = "0x27C2BA0", Offset = "0x27C19A0", VA = "0x1827C2BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0x27C2D90", Offset = "0x27C1B90", VA = "0x1827C2D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[CompilerGenerated]
	private struct LKMGHMGGGJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public AsyncTaskMethodBuilder<MMIHAIKLLOA> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public PKPCPBHCDCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private TaskAwaiter<MMIHAIKLLOA> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0x27C2940", Offset = "0x27C1740", VA = "0x1827C2940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x27C2B30", Offset = "0x27C1930", VA = "0x1827C2B30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[CompilerGenerated]
	private struct IKMDOBFEDMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public AsyncTaskMethodBuilder<MKHACDHEGGK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public PKPCPBHCDCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private TaskAwaiter<MKHACDHEGGK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0x27C1330", Offset = "0x27C0130", VA = "0x1827C1330", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0x27C1520", Offset = "0x27C0320", VA = "0x1827C1520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct DOFPFIADJDP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public AsyncTaskMethodBuilder<PPPBEPLDMBL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public PKPCPBHCDCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private TaskAwaiter<PPPBEPLDMBL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x27BD1C0", Offset = "0x27BBFC0", VA = "0x1827BD1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x27BD3B0", Offset = "0x27BC1B0", VA = "0x1827BD3B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[CompilerGenerated]
	private struct ADMOIMAPHJJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public AsyncTaskMethodBuilder<HNLPMDFGNGL.LECFMDNGEBF.JMKLHDAGPGG> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public PKPCPBHCDCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private TaskAwaiter<HNLPMDFGNGL.LECFMDNGEBF.JMKLHDAGPGG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x27BC230", Offset = "0x27BB030", VA = "0x1827BC230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x27BC420", Offset = "0x27BB220", VA = "0x1827BC420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[CompilerGenerated]
	private struct KDFFJGBNCND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		public AsyncTaskMethodBuilder<GABCMIEAAIL> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public PKPCPBHCDCI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private TaskAwaiter<GABCMIEAAIL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x27C1E50", Offset = "0x27C0C50", VA = "0x1827C1E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x27C2040", Offset = "0x27C0E40", VA = "0x1827C2040", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private readonly GGNFPFDBKFB BFHHPLLFFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly JELECPJGBOE ANJJIHAMEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly ELEJPDNFNEK GKBFHCLHFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly APLLECLFNDG JDHLAPJKMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private readonly GFNEGBECMCP HLHAMDKBEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly JECPGPBKGBJ PMMGLMGGJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly IDLBHEDBODI NBMCIKBHALJ;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public OIOBLJKDDDM BHJKLLEIMLP
	{
		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x10EF120", Offset = "0x10EDF20", VA = "0x1810EF120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x27C3DF0", Offset = "0x27C2BF0", VA = "0x1827C3DF0", Slot = "5")]
	[AsyncStateMachine(typeof(MBECIGFKMGM))]
	public Task<HHNNLOLDABE> BOAHDKMEPPF(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x27C4120", Offset = "0x27C2F20", VA = "0x1827C4120", Slot = "6")]
	[AsyncStateMachine(typeof(LKMGHMGGGJK))]
	public Task<MMIHAIKLLOA> MOELEBNEGMB(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x27C4230", Offset = "0x27C3030", VA = "0x1827C4230", Slot = "7")]
	[AsyncStateMachine(typeof(IKMDOBFEDMF))]
	public Task<MKHACDHEGGK> NGJHMHEGOFA(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x27C3CE0", Offset = "0x27C2AE0", VA = "0x1827C3CE0", Slot = "8")]
	[AsyncStateMachine(typeof(DOFPFIADJDP))]
	public Task<PPPBEPLDMBL> AKCMDEDDGNL(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x27C3F00", Offset = "0x27C2D00", VA = "0x1827C3F00", Slot = "9")]
	[AsyncStateMachine(typeof(ADMOIMAPHJJ))]
	public Task<HNLPMDFGNGL.LECFMDNGEBF.JMKLHDAGPGG> ECFOCJABPIG(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x27C4010", Offset = "0x27C2E10", VA = "0x1827C4010", Slot = "10")]
	[AsyncStateMachine(typeof(KDFFJGBNCND))]
	public Task<GABCMIEAAIL> JICHOLDGFOE(CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006FB")]
	[Cpp2IlInjected.Address(RVA = "0x27C4340", Offset = "0x27C3140", VA = "0x1827C4340")]
	public PKPCPBHCDCI(GGNFPFDBKFB MNCMLMNPOIP, [Optional] JELECPJGBOE? LBJCCOBNPJH, [Optional] ELEJPDNFNEK? HELHOMGIALM, [Optional] APLLECLFNDG? DCBFOMEEGIE, [Optional] GFNEGBECMCP? MHHMPIENFML, [Optional] JECPGPBKGBJ? JDOBKCMGGLI, [Optional] IDLBHEDBODI? NDGMNNIFFHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public sealed class BCFFEPKBFKJ : OALFCEOMBCC.PHHLMNPFINA
{
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	public delegate bool IONIIKMCGNF();

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public static readonly OALFCEOMBCC.PHHLMNPFINA ICOFMPPJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private readonly IONIIKMCGNF FAOGDKHIFIB;

	[Cpp2IlInjected.Token(Token = "0x600071E")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public BCFFEPKBFKJ(IONIIKMCGNF HPLCJLOJFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600071F")]
	[Cpp2IlInjected.Address(RVA = "0x10EF120", Offset = "0x10EDF20", VA = "0x1810EF120", Slot = "4")]
	public bool HGDLCFDPOAN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public sealed class OGJDHOFCEGN : JEAFHHJHNHG
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	public delegate bool OGLBALBNFKL([In] JKEBLLKKBOM<NICNPLCGCEF, LPPJEHMJDEA> BPINCJLADGC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly OGLBALBNFKL ENMABDKAPKO;

	[Cpp2IlInjected.Token(Token = "0x6000726")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC80", Offset = "0x27BBA80", VA = "0x1827BCC80")]
	public bool NDIEIKCIHPO([In] JKEBLLKKBOM<NICNPLCGCEF, LPPJEHMJDEA> BPINCJLADGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000727")]
	[Cpp2IlInjected.Address(RVA = "0x27C3AE0", Offset = "0x27C28E0", VA = "0x1827C3AE0")]
	public OGJDHOFCEGN([Optional] OGLBALBNFKL? FAOADLOLHMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000728")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC80", Offset = "0x27BBA80", VA = "0x1827BCC80", Slot = "4")]
	private bool ILHHFKPBKLJ([In] JKEBLLKKBOM<NICNPLCGCEF, LPPJEHMJDEA> BPINCJLADGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public sealed class NELIINKLFGK : EOMAFEHEGOI
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public delegate EHDOPHDIBFE JMOIFFHPAEB();

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public static readonly NELIINKLFGK ICOFMPPJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private readonly JMOIFFHPAEB? LCBBOPLLBEK;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EHDOPHDIBFE OHPKMNNNOCK
	{
		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x10EF120", Offset = "0x10EDF20", VA = "0x1810EF120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public NELIINKLFGK([Optional] JMOIFFHPAEB? MMBDKMPKBIE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class NCJOAMEBOIF : CPNBFAFEOAK
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public delegate FJNIAMGOABG BMGMNCBEEFI(int CKEOIJBAIFI);

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public static readonly CPNBFAFEOAK ICOFMPPJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private readonly BMGMNCBEEFI AJKGFDBEMAF;

	[Cpp2IlInjected.Token(Token = "0x6000733")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC80", Offset = "0x27BBA80", VA = "0x1827BCC80", Slot = "4")]
	public FJNIAMGOABG GGOHHEDPFPD(int CKEOIJBAIFI)
	{
		return default(FJNIAMGOABG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000734")]
	[Cpp2IlInjected.Address(RVA = "0x27C34A0", Offset = "0x27C22A0", VA = "0x1827C34A0")]
	public NCJOAMEBOIF([Optional] BMGMNCBEEFI? KEJCIMLNMLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BA")]
public sealed class JDEBNFHEIPI : ECGAGLEJEGA
{
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public delegate Task<bool> OEDDEKOPFNO(string OAIIHELJHLG, string JAPGNGDBBIF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[CompilerGenerated]
	private struct NIHDDNNOPAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public JDEBNFHEIPI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public string value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public string context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x27C3720", Offset = "0x27C2520", VA = "0x1827C3720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x27C3910", Offset = "0x27C2710", VA = "0x1827C3910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private readonly OEDDEKOPFNO ABEBDANBFOF;

	[Cpp2IlInjected.Token(Token = "0x600073B")]
	[Cpp2IlInjected.Address(RVA = "0x27C1590", Offset = "0x27C0390", VA = "0x1827C1590", Slot = "4")]
	[AsyncStateMachine(typeof(NIHDDNNOPAG))]
	public Task<bool> OBAAGIICIEN(string OAIIHELJHLG, string JAPGNGDBBIF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600073C")]
	[Cpp2IlInjected.Address(RVA = "0x27C16D0", Offset = "0x27C04D0", VA = "0x1827C16D0")]
	public JDEBNFHEIPI([Optional] OEDDEKOPFNO? CKPNDEJDBFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BE")]
public sealed class BPNMHDHMOJE : LILPBIECJKB
{
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	public delegate NBNDKMMHANJ? EPMEIPHIEKG([In] KOIDEEJEAKA<JLGBKHFBOKK> JONFANGPPNH);

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public static readonly LILPBIECJKB ICOFMPPJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private readonly EPMEIPHIEKG IEBAPPOLMNC;

	[Cpp2IlInjected.Token(Token = "0x6000744")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC80", Offset = "0x27BBA80", VA = "0x1827BCC80")]
	public NBNDKMMHANJ? JEGGAJFDPAB([In] KOIDEEJEAKA<JLGBKHFBOKK> JONFANGPPNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000745")]
	[Cpp2IlInjected.Address(RVA = "0x27BCD30", Offset = "0x27BBB30", VA = "0x1827BCD30")]
	public BPNMHDHMOJE([Optional] EPMEIPHIEKG? LHOPIEDJLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000747")]
	[Cpp2IlInjected.Address(RVA = "0x27BCC80", Offset = "0x27BBA80", VA = "0x1827BCC80", Slot = "4")]
	private NBNDKMMHANJ GAKCCAHCOKB([In] KOIDEEJEAKA<JLGBKHFBOKK> JONFANGPPNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C1")]
public sealed class GOMOKPJLIII : MHCDCFBPCHG
{
	[Cpp2IlInjected.Token(Token = "0x600074D")]
	[Cpp2IlInjected.Address(RVA = "0x27C1260", Offset = "0x27C0060", VA = "0x1827C1260", Slot = "4")]
	public FACHCHBHOJO CGFDOHCMBJC(string IHGFMOMOADA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
	public GOMOKPJLIII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C2")]
public sealed class EEGGCFGMFIN : MFKBGMJPIHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private readonly Dictionary<string, bool> BJHAFOMKHPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private readonly Dictionary<string, float> CDNPGDOJAIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private readonly Dictionary<string, double> DHNPGLNKDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private readonly Dictionary<string, int> CJMDMHOILLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private readonly Dictionary<string, long> KPODODDMAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private readonly Dictionary<string, string> GELIKGCPOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private readonly Dictionary<string, uint> CKADGCLMDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private readonly Dictionary<string, ulong> PLEEIAFIBID;

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x27BFA70", Offset = "0x27BE870", VA = "0x1827BFA70", Slot = "4")]
	public bool? IPHPOPJMGCA(string MAKJJJECHHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0x27BFB10", Offset = "0x27BE910", VA = "0x1827BFB10")]
	public EEGGCFGMFIN()
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
