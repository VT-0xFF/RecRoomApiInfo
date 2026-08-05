using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct HGBECKJBNCD<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : GKIDJGGAJHN.GIFEODJLPKP<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialSnapshot[] HCPBKAGPMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int MBMLLEAGLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps LDMMCHHPBGO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5460", Offset = "0x3FF4660", VA = "0x183FF5460")]
	internal HGBECKJBNCD(TPartialSnapshot[] PPNCPKDDKEM, int JLGJHGJPJKK, TDeps JCHGABJHIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3FF5390", Offset = "0x3FF4590", VA = "0x183FF5390")]
	public static global::HGBECKJBNCD<TPartialSnapshot, TFullSnapshot, TDeps> ELCFDEFNBDD(TDeps JCHGABJHIIM)
	{
		return default(global::HGBECKJBNCD<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GKIDJGGAJHN
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface GIFEODJLPKP<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KEPLACBBJLM(in TPartialSnapshot MFDAGLBPHAI);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot HELFLMLBJOA(TPartialSnapshot[] HENKJBJLEIM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2265CB0", Offset = "0x2264EB0", VA = "0x182265CB0")]
	public static global::FHJHGBHFPAM<TFullSnapshot> MAHMDBAOOJG<TFullSnapshot, TPartialSnapshot, TDeps>(this ref global::HGBECKJBNCD<TPartialSnapshot, TFullSnapshot, TDeps> DIJPFIMLAFB, TPartialSnapshot MFDAGLBPHAI) where TDeps : GIFEODJLPKP<TPartialSnapshot, TFullSnapshot>
	{
		return default(global::FHJHGBHFPAM<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2265BD0", Offset = "0x2264DD0", VA = "0x182265BD0")]
	public static bool EPBEGPHGMPN<TPartialSnapshot, TFullSnapshot, TDeps>(this ref global::HGBECKJBNCD<TPartialSnapshot, TFullSnapshot, TDeps> DIJPFIMLAFB, TPartialSnapshot MFDAGLBPHAI) where TDeps : GIFEODJLPKP<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class ICANBGLOPKH : HODHNINHENI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x681B060", Offset = "0x681A260", VA = "0x18681B060", Slot = "5")]
	public override string HMHKJMAEDDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2B50AF0", Offset = "0x2B4FCF0", VA = "0x182B50AF0")]
	public ICANBGLOPKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GCIOMOGFFIA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface KNDMNBHDCDM<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MBEPJHOEMPM(TNetSys CJIOEHCKACP, TAction IBKGKDECOEG);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction NLOLGNNIEMP(TNetSys CJIOEHCKACP, TAction IBKGKDECOEG);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction NFOFDAMAMOF(TNetSys CJIOEHCKACP, TAction IBKGKDECOEG);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> LJPAJKOLDCA(TNetSys CJIOEHCKACP, TAction IBKGKDECOEG);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool KMKNCHKNIIG(TNetSys CJIOEHCKACP, TAction IBKGKDECOEG);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool BCEJKBOJHLL(TNetSys CJIOEHCKACP, TAction IBKGKDECOEG);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DDEBIICAAMN(TNetSys CJIOEHCKACP, TAction IBKGKDECOEG);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool KCHEOEIHENJ(TNetSys CJIOEHCKACP, TAction IBKGKDECOEG);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool JPJMOGEAGPP(TNetSys CJIOEHCKACP, TAction IBKGKDECOEG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface BKHFGABDEIM<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		TActionDeps EDOJBEIAHNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		TReceiverDeps FKICOLLOJKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		TRootDeps LJIGFNLLAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface FELHJHFLFGJ<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		global::MPNGGJINIEL<TMActor> JFPJNHFBJGO(TReceiver HHOOFBDANAJ);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<global::LAFJBBFBCGA<object, HODHNINHENI>> GJKEHKMHBJP(TReceiver HHOOFBDANAJ, TAction IBKGKDECOEG);

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] BEKIJCMMIAJ(TReceiver HHOOFBDANAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface PHHCBFGCNKI<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EKKLOBANEAG(TRoot KPDGHDGLMHO);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int KGEAGNOEMGD(TRoot KPDGHDGLMHO);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int EBAPCCMNJPC(TRoot KPDGHDGLMHO);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DIEHBHAKCJD(TRoot KPDGHDGLMHO);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task IJELCOMNAEO(TRoot KPDGHDGLMHO, global::MPNGGJINIEL<TMActor> PIHPHEMDPGD, global::MPNGGJINIEL<TMRequest> AMGNCPLIAAC, TAction IBKGKDECOEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public sealed class OMIEGBJFHPC<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : GCIOMOGFFIA.KNDMNBHDCDM<TAction, TNetSys> where TReceiverDeps : GCIOMOGFFIA.FELHJHFLFGJ<TMActor, TAction, TReceiver> where TRootDeps : GCIOMOGFFIA.PHHCBFGCNKI<TMRequest, TMActor, TAction, TRoot> where TDeps : GCIOMOGFFIA.BKHFGABDEIM<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface AIOKIANEKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GBKEOMCGFKI(in global::LAFJBBFBCGA<object, HODHNINHENI> CDNLFEOBNKB);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BOIFGGAHABK();

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::LAFJBBFBCGA<object, HODHNINHENI> GJIMECHGDFJ();

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MDBNAKBEGAH(Exception AHHCFDOHCNE);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class LIAKHLKICHJ : AIOKIANEKHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly TaskCompletionSource<global::LAFJBBFBCGA<object, HODHNINHENI>> IMIBBJHNCGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly List<global::LAFJBBFBCGA<object, BBMENPGBPEA>> IFEELALCCCF;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x21A2AA0", Offset = "0x21A1CA0", VA = "0x1821A2AA0")]
		private LIAKHLKICHJ(TaskCompletionSource<global::LAFJBBFBCGA<object, HODHNINHENI>> EMHINPPMHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2160140", Offset = "0x215F340", VA = "0x182160140")]
		public static LIAKHLKICHJ ELCFDEFNBDD(TaskCompletionSource<global::LAFJBBFBCGA<object, HODHNINHENI>> EMHINPPMHNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x21A2370", Offset = "0x21A1570", VA = "0x1821A2370")]
		public void GBKEOMCGFKI(in global::LAFJBBFBCGA<object, HODHNINHENI> CDNLFEOBNKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x21A1DD0", Offset = "0x21A0FD0", VA = "0x1821A1DD0", Slot = "5")]
		public void BOIFGGAHABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x21A26B0", Offset = "0x21A18B0", VA = "0x1821A26B0", Slot = "6")]
		public global::LAFJBBFBCGA<object, HODHNINHENI> GJIMECHGDFJ()
		{
			return default(global::LAFJBBFBCGA<object, HODHNINHENI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x21A28C0", Offset = "0x21A1AC0", VA = "0x1821A28C0", Slot = "7")]
		public void MDBNAKBEGAH(Exception AHHCFDOHCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1B4D370", Offset = "0x1B4C570", VA = "0x181B4D370", Slot = "4")]
		private void BJIHFJKJLGL(in global::LAFJBBFBCGA<object, HODHNINHENI> CDNLFEOBNKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class KBLCFEPDIMK : AIOKIANEKHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly TaskCompletionSource<global::LAFJBBFBCGA<object, HODHNINHENI>> IMIBBJHNCGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private global::LAFJBBFBCGA<object, HODHNINHENI> AGEDDNKEHIB;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1B3B7F0", Offset = "0x1B3A9F0", VA = "0x181B3B7F0")]
		private KBLCFEPDIMK(TaskCompletionSource<global::LAFJBBFBCGA<object, HODHNINHENI>> EMHINPPMHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2160140", Offset = "0x215F340", VA = "0x182160140")]
		public static KBLCFEPDIMK ELCFDEFNBDD(TaskCompletionSource<global::LAFJBBFBCGA<object, HODHNINHENI>> EMHINPPMHNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2160210", Offset = "0x215F410", VA = "0x182160210")]
		public void GBKEOMCGFKI(in global::LAFJBBFBCGA<object, HODHNINHENI> CDNLFEOBNKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2160020", Offset = "0x215F220", VA = "0x182160020", Slot = "5")]
		public void BOIFGGAHABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAD8450", Offset = "0xAD7650", VA = "0x180AD8450", Slot = "6")]
		public global::LAFJBBFBCGA<object, HODHNINHENI> GJIMECHGDFJ()
		{
			return default(global::LAFJBBFBCGA<object, HODHNINHENI>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x21602F0", Offset = "0x215F4F0", VA = "0x1821602F0", Slot = "7")]
		public void MDBNAKBEGAH(Exception AHHCFDOHCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1B4D370", Offset = "0x1B4C570", VA = "0x181B4D370", Slot = "4")]
		private void BJIHFJKJLGL(in global::LAFJBBFBCGA<object, HODHNINHENI> CDNLFEOBNKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private sealed class PIEHCOBMNFF : AIOKIANEKHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly List<global::LAFJBBFBCGA<object, HODHNINHENI>> IFEELALCCCF;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x2BE7280", Offset = "0x2BE6480", VA = "0x182BE7280")]
		private PIEHCOBMNFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x20C40A0", Offset = "0x20C32A0", VA = "0x1820C40A0")]
		public static PIEHCOBMNFF ELCFDEFNBDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6D80", Offset = "0x2BE5F80", VA = "0x182BE6D80")]
		public void GBKEOMCGFKI(in global::LAFJBBFBCGA<object, HODHNINHENI> CDNLFEOBNKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
		public void BOIFGGAHABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2BE6F60", Offset = "0x2BE6160", VA = "0x182BE6F60", Slot = "6")]
		public global::LAFJBBFBCGA<object, HODHNINHENI> GJIMECHGDFJ()
		{
			return default(global::LAFJBBFBCGA<object, HODHNINHENI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "7")]
		public void MDBNAKBEGAH(Exception AHHCFDOHCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1B4D370", Offset = "0x1B4C570", VA = "0x181B4D370", Slot = "4")]
		private void BJIHFJKJLGL(in global::LAFJBBFBCGA<object, HODHNINHENI> CDNLFEOBNKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class DEMOGJOJGCF : AIOKIANEKHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::LAFJBBFBCGA<object, HODHNINHENI> AGEDDNKEHIB;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		private DEMOGJOJGCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x20C40A0", Offset = "0x20C32A0", VA = "0x1820C40A0")]
		public static DEMOGJOJGCF ELCFDEFNBDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1985D50", Offset = "0x1984F50", VA = "0x181985D50")]
		public void GBKEOMCGFKI(in global::LAFJBBFBCGA<object, HODHNINHENI> CDNLFEOBNKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
		public void BOIFGGAHABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2E0", Offset = "0x7D94E0", VA = "0x1807DA2E0", Slot = "6")]
		public global::LAFJBBFBCGA<object, HODHNINHENI> GJIMECHGDFJ()
		{
			return default(global::LAFJBBFBCGA<object, HODHNINHENI>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "7")]
		public void MDBNAKBEGAH(Exception AHHCFDOHCNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1B4D370", Offset = "0x1B4C570", VA = "0x181B4D370", Slot = "4")]
		private void BJIHFJKJLGL(in global::LAFJBBFBCGA<object, HODHNINHENI> CDNLFEOBNKB)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct EJBEOGCMGFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<object, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public global::OMIEGBJFHPC<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::MPNGGJINIEL<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public global::MPNGGJINIEL<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter<global::LAFJBBFBCGA<object, HODHNINHENI>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x27E4380", Offset = "0x27E3580", VA = "0x1827E4380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x27E4F30", Offset = "0x27E4130", VA = "0x1827E4F30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct IJCHBGCMDHO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<object, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::OMIEGBJFHPC<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public global::MPNGGJINIEL<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public global::MPNGGJINIEL<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private AIOKIANEKHI <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1B2F3C0", Offset = "0x1B2E5C0", VA = "0x181B2F3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1B32FC0", Offset = "0x1B321C0", VA = "0x181B32FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct EHPHJJKLCDA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public global::OMIEGBJFHPC<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AIOKIANEKHI completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private AIOKIANEKHI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private TaskAwaiter<global::LAFJBBFBCGA<object, HODHNINHENI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x27E1620", Offset = "0x27E0820", VA = "0x1827E1620", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x87A5F0", Offset = "0x8797F0", VA = "0x18087A5F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct OMCFGFBHEJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public AsyncTaskMethodBuilder<global::LAFJBBFBCGA<object, HODHNINHENI>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Task sendTask_;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Task<global::LAFJBBFBCGA<object, HODHNINHENI>> tcsTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private TaskAwaiter<global::LAFJBBFBCGA<object, HODHNINHENI>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x203A200", Offset = "0x2039400", VA = "0x18203A200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x203ADE0", Offset = "0x2039FE0", VA = "0x18203ADE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly TDeps LDMMCHHPBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly Dictionary<global::MPNGGJINIEL<TMRequest>, TaskCompletionSource<global::LAFJBBFBCGA<object, HODHNINHENI>>> LHIGCIKAINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private global::DDDNPHHEGPI<TMRequest> CGONGFOIBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private int JCDOOMPHOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private Task IAEIHEIFOCP;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TActionDeps EDOJBEIAHNG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x203B680", Offset = "0x203A880", VA = "0x18203B680")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private TRootDeps LJIGFNLLAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x203DE20", Offset = "0x203D020", VA = "0x18203DE20")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private TReceiverDeps FKICOLLOJKA
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x203DC80", Offset = "0x203CE80", VA = "0x18203DC80")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool GKBONACFAMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9F78A0", Offset = "0x9F6AA0", VA = "0x1809F78A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9F78C0", Offset = "0x9F6AC0", VA = "0x1809F78C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int EKFBEAGJGFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x952290", Offset = "0x951490", VA = "0x180952290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x203F020", Offset = "0x203E220", VA = "0x18203F020")]
	public OMIEGBJFHPC(TDeps JCHGABJHIIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x203CED0", Offset = "0x203C0D0", VA = "0x18203CED0")]
	public Task<global::LAFJBBFBCGA<object, HODHNINHENI>> IJELCOMNAEO(TRoot KPDGHDGLMHO, TNetSys GMCEPPMNFKM, global::MPNGGJINIEL<TMActor> PIHPHEMDPGD, TAction IBKGKDECOEG, bool MBMBCHFDDHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x203BA80", Offset = "0x203AC80", VA = "0x18203BA80")]
	[AsyncStateMachine(typeof(global::OMIEGBJFHPC<, , , , , , , , , >.EJBEOGCMGFA))]
	public Task<global::LAFJBBFBCGA<object, HODHNINHENI>> GJKEHKMHBJP(TRoot KPDGHDGLMHO, TNetSys BNBDIJNPMKA, TReceiver HHOOFBDANAJ, global::MPNGGJINIEL<TMActor> PIHPHEMDPGD, global::MPNGGJINIEL<TMRequest> AMGNCPLIAAC, TAction IBKGKDECOEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x203DF00", Offset = "0x203D100", VA = "0x18203DF00")]
	[AsyncStateMachine(typeof(global::OMIEGBJFHPC<, , , , , , , , , >.IJCHBGCMDHO))]
	private Task<global::LAFJBBFBCGA<object, HODHNINHENI>> LIHIJMBIAGI(TRoot KPDGHDGLMHO, TNetSys BNBDIJNPMKA, TReceiver HHOOFBDANAJ, global::MPNGGJINIEL<TMActor> PIHPHEMDPGD, global::MPNGGJINIEL<TMRequest> AMGNCPLIAAC, TAction IBKGKDECOEG, Task KGGBCNNFKEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x203C0A0", Offset = "0x203B2A0", VA = "0x18203C0A0")]
	[AsyncStateMachine(typeof(global::OMIEGBJFHPC<, , , , , , , , , >.EHPHJJKLCDA))]
	private Task HBGPEOEIBAO(TRoot KPDGHDGLMHO, TNetSys BNBDIJNPMKA, TReceiver HHOOFBDANAJ, TAction IBKGKDECOEG, AIOKIANEKHI CMLDOMEODEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x203B0C0", Offset = "0x203A2C0", VA = "0x18203B0C0")]
	private void EOOLKEPOIKH(TRoot KPDGHDGLMHO, TNetSys BNBDIJNPMKA, TReceiver HHOOFBDANAJ, global::MPNGGJINIEL<TMActor> PIHPHEMDPGD, TAction IBKGKDECOEG, bool INKKBJIKFCI, bool GJKPAEFNFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x203E730", Offset = "0x203D930", VA = "0x18203E730")]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(global::OMIEGBJFHPC<, , , , , , , , , >.OMCFGFBHEJO))]
	internal static Task<global::LAFJBBFBCGA<object, HODHNINHENI>> OJGOOKFFEKK(Task DNBBPLKKDOB, Task<global::LAFJBBFBCGA<object, HODHNINHENI>> DHPEEHEPOFB)
	{
		return null;
	}
}
namespace Cpp2IlInjected;

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
