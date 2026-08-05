using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Mono.Math;
using Newtonsoft.Json;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal sealed class ODINFDAPMKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Action FAAEOGDIAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IECEHJHNOCE PEDEEKPLDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LGNIOJMMPJC OLPFLKCCPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private IECEHJHNOCE MBNCOKCGBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool CMEKACJAPJB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public IECEHJHNOCE MHMGMMKDDIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3015210", Offset = "0x3014610", VA = "0x183015210")]
		get
		{
			return default(IECEHJHNOCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public IECEHJHNOCE KCPGKKAJNMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5406510", Offset = "0x5405910", VA = "0x185406510")]
		get
		{
			return default(IECEHJHNOCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public IECEHJHNOCE LDECLJDGBAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FC520", Offset = "0x6FB920", VA = "0x1806FC520")]
		get
		{
			return default(IECEHJHNOCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KAJPBCDPOFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x678030", Offset = "0x677430", VA = "0x180678030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x54066F0", Offset = "0x5405AF0", VA = "0x1854066F0")]
	public ODINFDAPMKD(Action EKAENMGCNKL, in IECEHJHNOCE KOMJPICBGNJ, in IECEHJHNOCE HBPGLKBLIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5406530", Offset = "0x5405930", VA = "0x185406530")]
	public void MJLCDAAKEBA(in IECEHJHNOCE IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5406540", Offset = "0x5405940", VA = "0x185406540")]
	public void PPKJCNHCKGF(in IECEHJHNOCE? JPOOBOCKIFB, in IECEHJHNOCE? DOILICGBFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5406460", Offset = "0x5405860", VA = "0x185406460")]
	public void DGJPKMHPHMD(bool IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5406470", Offset = "0x5405870", VA = "0x185406470")]
	private void DOEEJIJOJHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MEODHCGMDDL
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate object BEFOJADPLHK();

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate object MJKAHBKMBLB<T>(T MMLIFJCNOMF);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate object GLGHDCOMDGJ<T>(in T MMLIFJCNOMF);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface NCLHOOPKADJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		IECEHJHNOCE GHFOMCLCLFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MFIHEHOKFNE(object KAKCNEMJMJL);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void MFIHEHOKFNE(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct AEMOKBJMMCG : NCLHOOPKADJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public IECEHJHNOCE GHFOMCLCLFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x53F5BC0", Offset = "0x53F4FC0", VA = "0x1853F5BC0", Slot = "4")]
			get
			{
				return default(IECEHJHNOCE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x53F5C90", Offset = "0x53F5090", VA = "0x1853F5C90", Slot = "5")]
		public void MFIHEHOKFNE(object KAKCNEMJMJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x53F5C20", Offset = "0x53F5020", VA = "0x1853F5C20", Slot = "6")]
		public void MFIHEHOKFNE(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private readonly struct ELMFJMBPAHF : NCLHOOPKADJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public IECEHJHNOCE GHFOMCLCLFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x53F93C0", Offset = "0x53F87C0", VA = "0x1853F93C0", Slot = "4")]
			get
			{
				return default(IECEHJHNOCE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x53F9490", Offset = "0x53F8890", VA = "0x1853F9490", Slot = "5")]
		public void MFIHEHOKFNE(object KAKCNEMJMJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x53F9420", Offset = "0x53F8820", VA = "0x1853F9420", Slot = "6")]
		public void MFIHEHOKFNE(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private readonly struct HEJKNMFIBLM : NCLHOOPKADJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public IECEHJHNOCE GHFOMCLCLFA
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x53F96B0", Offset = "0x53F8AB0", VA = "0x1853F96B0", Slot = "4")]
			get
			{
				return default(IECEHJHNOCE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x53F9780", Offset = "0x53F8B80", VA = "0x1853F9780", Slot = "5")]
		public void MFIHEHOKFNE(object KAKCNEMJMJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x53F9710", Offset = "0x53F8B10", VA = "0x1853F9710", Slot = "6")]
		public void MFIHEHOKFNE(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private static class NEFDFEGMBLM
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x2754B30", Offset = "0x2753F30", VA = "0x182754B30")]
		public static void MFIHEHOKFNE<T>(in T LKINCHDLDIG, object KAKCNEMJMJL, in IECEHJHNOCE AOFGAGALOCP) where T : NCLHOOPKADJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x2754A70", Offset = "0x2753E70", VA = "0x182754A70")]
		public static void MFIHEHOKFNE<T>(in T LKINCHDLDIG, object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, in IECEHJHNOCE AOFGAGALOCP) where T : NCLHOOPKADJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x2754BD0", Offset = "0x2753FD0", VA = "0x182754BD0")]
		public static void MFIHEHOKFNE<T>(in T LKINCHDLDIG, BEFOJADPLHK KAKCNEMJMJL, in IECEHJHNOCE AOFGAGALOCP) where T : NCLHOOPKADJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x2754C90", Offset = "0x2754090", VA = "0x182754C90")]
		public static void MFIHEHOKFNE<T>(in T LKINCHDLDIG, BEFOJADPLHK KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, in IECEHJHNOCE AOFGAGALOCP) where T : NCLHOOPKADJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x27548D0", Offset = "0x2753CD0", VA = "0x1827548D0")]
		public static void MFIHEHOKFNE<T, U>(in T LKINCHDLDIG, MJKAHBKMBLB<U> KAKCNEMJMJL, in U MMLIFJCNOMF, in IECEHJHNOCE AOFGAGALOCP) where T : NCLHOOPKADJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x2754710", Offset = "0x2753B10", VA = "0x182754710")]
		public static void MFIHEHOKFNE<T, U>(in T LKINCHDLDIG, MJKAHBKMBLB<U> KAKCNEMJMJL, in U MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, in IECEHJHNOCE AOFGAGALOCP) where T : NCLHOOPKADJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x27549A0", Offset = "0x2753DA0", VA = "0x1827549A0")]
		public static void MFIHEHOKFNE<T, U>(in T LKINCHDLDIG, GLGHDCOMDGJ<U> KAKCNEMJMJL, in U MMLIFJCNOMF, in IECEHJHNOCE AOFGAGALOCP) where T : NCLHOOPKADJ
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x27547F0", Offset = "0x2753BF0", VA = "0x1827547F0")]
		public static void MFIHEHOKFNE<T, U>(in T LKINCHDLDIG, GLGHDCOMDGJ<U> KAKCNEMJMJL, in U MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, in IECEHJHNOCE AOFGAGALOCP) where T : NCLHOOPKADJ
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface DONOOOFHGND<TConditionArg>
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BNMOGLEIOOC();

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GPMFLIOEDNK(in TConditionArg MMLIFJCNOMF);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool OEDKEPNLCGN(in TConditionArg MMLIFJCNOMF, bool CLCLPFEGNIE);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private readonly struct ECEACENJCDI : DONOOOFHGND<((string, int), object)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Dictionary<(string File, int Line), object> DDEDAGFGAAB;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x88DB80", Offset = "0x88CF80", VA = "0x18088DB80")]
		private ECEACENJCDI(Dictionary<(string File, int Line), object> FIDHAFHJADM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x53F90F0", Offset = "0x53F84F0", VA = "0x1853F90F0")]
		public static ECEACENJCDI IKMCJIAOBME()
		{
			return default(ECEACENJCDI);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x53F8FB0", Offset = "0x53F83B0", VA = "0x1853F8FB0", Slot = "4")]
		public void BNMOGLEIOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x53F9010", Offset = "0x53F8410", VA = "0x1853F9010")]
		public bool GPMFLIOEDNK(in ((string File, int Line) Location, object Value) MMLIFJCNOMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3C75C30", Offset = "0x3C75030", VA = "0x183C75C30")]
		public bool OEDKEPNLCGN(in ((string File, int Line) Location, object Value) FAHGJOEFBKN, bool CLCLPFEGNIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x53F9000", Offset = "0x53F8400", VA = "0x1853F9000", Slot = "5")]
		private bool GBFIFJLKAGC(in ((string File, int Line) Location, object Value) MMLIFJCNOMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3C75C30", Offset = "0x3C75030", VA = "0x183C75C30", Slot = "6")]
		private bool HIDAOENPKBA(in ((string File, int Line) Location, object Value) MMLIFJCNOMF, bool CLCLPFEGNIE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private readonly struct CAPLDKJJCJD : DONOOOFHGND<(string, int)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly HashSet<(string File, int Line)> GEPAJMMFABI;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x88DB80", Offset = "0x88CF80", VA = "0x18088DB80")]
		private CAPLDKJJCJD(HashSet<(string File, int Line)> OICBACPBGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x53F7510", Offset = "0x53F6910", VA = "0x1853F7510")]
		public static CAPLDKJJCJD IKMCJIAOBME()
		{
			return default(CAPLDKJJCJD);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x53F7410", Offset = "0x53F6810", VA = "0x1853F7410", Slot = "4")]
		public void BNMOGLEIOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x53F7470", Offset = "0x53F6870", VA = "0x1853F7470")]
		public bool GPMFLIOEDNK(in (string File, int Line) MMLIFJCNOMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C75C30", Offset = "0x3C75030", VA = "0x183C75C30")]
		public bool OEDKEPNLCGN(in (string File, int Line) FAHGJOEFBKN, bool CLCLPFEGNIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x53F7460", Offset = "0x53F6860", VA = "0x1853F7460", Slot = "5")]
		private bool FIOOHPDGFNP(in (string File, int Line) MMLIFJCNOMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C75C30", Offset = "0x3C75030", VA = "0x183C75C30", Slot = "6")]
		private bool BPIANLKIACL(in (string File, int Line) MMLIFJCNOMF, bool CLCLPFEGNIE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private readonly struct MCPENANLFGF : DONOOOFHGND<((string, int), long)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<(string File, int Line), long> NFHFOMEEIKJ;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x53FFDC0", Offset = "0x53FF1C0", VA = "0x1853FFDC0", Slot = "4")]
		public void BNMOGLEIOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x88DB80", Offset = "0x88CF80", VA = "0x18088DB80")]
		private MCPENANLFGF(Dictionary<(string File, int Line), long> JMDFJIGPLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x53FFFA0", Offset = "0x53FF3A0", VA = "0x1853FFFA0")]
		public static MCPENANLFGF IKMCJIAOBME()
		{
			return default(MCPENANLFGF);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x53FFE10", Offset = "0x53FF210", VA = "0x1853FFE10")]
		public bool GPMFLIOEDNK(in ((string File, int Line) Location, long ThrottleMs) MMLIFJCNOMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3C75C30", Offset = "0x3C75030", VA = "0x183C75C30")]
		public bool OEDKEPNLCGN(in ((string File, int Line) Location, long ThrottleMs) MMLIFJCNOMF, bool CLCLPFEGNIE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5400010", Offset = "0x53FF410", VA = "0x185400010", Slot = "5")]
		private bool PDJCMPEGDPM(in ((string File, int Line) Location, long ThrottleMs) MMLIFJCNOMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3C75C30", Offset = "0x3C75030", VA = "0x183C75C30", Slot = "6")]
		private bool EAMGPNAJLOF(in ((string File, int Line) Location, long ThrottleMs) MMLIFJCNOMF, bool CLCLPFEGNIE)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private readonly struct ENBCALEJGJI : DONOOOFHGND<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
		public void BNMOGLEIOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x53F94F0", Offset = "0x53F88F0", VA = "0x1853F94F0")]
		public bool GPMFLIOEDNK(in bool MMLIFJCNOMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x53F9500", Offset = "0x53F8900", VA = "0x1853F9500")]
		public bool OEDKEPNLCGN(in bool MMLIFJCNOMF, bool FAHGJOEFBKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x53F94F0", Offset = "0x53F88F0", VA = "0x1853F94F0", Slot = "5")]
		private bool DOBBFOOFDNH(in bool MMLIFJCNOMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x53F9500", Offset = "0x53F8900", VA = "0x1853F9500", Slot = "6")]
		private bool LANGBECJDIH(in bool MMLIFJCNOMF, bool CLCLPFEGNIE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private readonly struct GKDFPPAHGFK : DONOOOFHGND<((string, int), bool)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly ENBCALEJGJI BCMBDLFIDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly CAPLDKJJCJD CFBCEDKOKBB;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x31D18C0", Offset = "0x31D0CC0", VA = "0x1831D18C0")]
		private GKDFPPAHGFK(in CAPLDKJJCJD GNNAHKMDAJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x53F9650", Offset = "0x53F8A50", VA = "0x1853F9650")]
		public static GKDFPPAHGFK IKMCJIAOBME()
		{
			return default(GKDFPPAHGFK);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x53F95E0", Offset = "0x53F89E0", VA = "0x1853F95E0", Slot = "4")]
		public void BNMOGLEIOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x53F9630", Offset = "0x53F8A30", VA = "0x1853F9630")]
		public bool GPMFLIOEDNK(in ((string File, int Line) Location, bool Condition) MMLIFJCNOMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC640", Offset = "0x1FABA40", VA = "0x181FAC640")]
		public bool OEDKEPNLCGN(in ((string File, int Line) Location, bool Condition) MMLIFJCNOMF, bool FAHGJOEFBKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x53F9630", Offset = "0x53F8A30", VA = "0x1853F9630", Slot = "5")]
		private bool HFBODNBIJPO(in ((string File, int Line) Location, bool Condition) MMLIFJCNOMF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1FAC640", Offset = "0x1FABA40", VA = "0x181FAC640", Slot = "6")]
		private bool CBDBOGMIDDB(in ((string File, int Line) Location, bool Condition) MMLIFJCNOMF, bool CLCLPFEGNIE)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private readonly struct KOLPCBEOJAC<TDeps> where TDeps : NCLHOOPKADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly TDeps PLDEBFMNDPG;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x296BD70", Offset = "0x296B170", VA = "0x18296BD70")]
		private bool EDCKPBPIOJH(in IECEHJHNOCE? AOFGAGALOCP, out IECEHJHNOCE LEIEPHBEPEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x296CC80", Offset = "0x296C080", VA = "0x18296CC80")]
		public void MFIHEHOKFNE(object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x296B990", Offset = "0x296AD90", VA = "0x18296B990")]
		[Conditional("LOGGING_ENABLED")]
		[Conditional("UNITY_EDITOR")]
		public void DFNDFEBIINI(object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x296C470", Offset = "0x296B870", VA = "0x18296C470")]
		public void MFIHEHOKFNE(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x296BC70", Offset = "0x296B070", VA = "0x18296BC70")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void DFNDFEBIINI(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x296C550", Offset = "0x296B950", VA = "0x18296C550")]
		public void MFIHEHOKFNE(BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x296B8B0", Offset = "0x296ACB0", VA = "0x18296B8B0")]
		[Conditional("LOGGING_ENABLED")]
		[Conditional("UNITY_EDITOR")]
		public void DFNDFEBIINI(BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x296C610", Offset = "0x296BA10", VA = "0x18296C610")]
		public void MFIHEHOKFNE(BEFOJADPLHK KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x296BCF0", Offset = "0x296B0F0", VA = "0x18296BCF0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void DFNDFEBIINI(BEFOJADPLHK KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x23E79C0", Offset = "0x23E6DC0", VA = "0x1823E79C0")]
		public void MFIHEHOKFNE<TMessageArg>(MJKAHBKMBLB<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x23E7790", Offset = "0x23E6B90", VA = "0x1823E7790")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void DFNDFEBIINI<TMessageArg>(MJKAHBKMBLB<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x23E7C60", Offset = "0x23E7060", VA = "0x1823E7C60")]
		public void MFIHEHOKFNE<TMessageArg>(MJKAHBKMBLB<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x23E77B0", Offset = "0x23E6BB0", VA = "0x1823E77B0")]
		[Conditional("LOGGING_ENABLED")]
		[Conditional("UNITY_EDITOR")]
		public void DFNDFEBIINI<TMessageArg>(MJKAHBKMBLB<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x23E79C0", Offset = "0x23E6DC0", VA = "0x1823E79C0")]
		public void MFIHEHOKFNE<TMessageArg>(GLGHDCOMDGJ<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x23E7790", Offset = "0x23E6B90", VA = "0x1823E7790")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void DFNDFEBIINI<TMessageArg>(GLGHDCOMDGJ<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x23E7C60", Offset = "0x23E7060", VA = "0x1823E7C60")]
		public void MFIHEHOKFNE<TMessageArg>(GLGHDCOMDGJ<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x23E77B0", Offset = "0x23E6BB0", VA = "0x1823E77B0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void DFNDFEBIINI<TMessageArg>(GLGHDCOMDGJ<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private readonly struct JPPNNBPIGNE<TDeps, TConditionDeps, TConditionArg> where TDeps : NCLHOOPKADJ where TConditionDeps : DONOOOFHGND<TConditionArg>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly TDeps PLDEBFMNDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly TConditionDeps BGLHHINLMKA;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x31D1910", Offset = "0x31D0D10", VA = "0x1831D1910")]
		public JPPNNBPIGNE(in TConditionDeps JCAJBEDNEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x31CF3E0", Offset = "0x31CE7E0", VA = "0x1831CF3E0")]
		public void BNMOGLEIOOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x31CF8C0", Offset = "0x31CECC0", VA = "0x1831CF8C0")]
		private bool JOAFOAPGFIK(in IECEHJHNOCE? AOFGAGALOCP, in TConditionArg FJOJFHIJGLJ, out IECEHJHNOCE LEIEPHBEPEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x31D08C0", Offset = "0x31CFCC0", VA = "0x1831D08C0")]
		public bool MFIHEHOKFNE(object KAKCNEMJMJL, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x31CF5B0", Offset = "0x31CE9B0", VA = "0x1831CF5B0")]
		public bool DFNDFEBIINI(object KAKCNEMJMJL, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x31D0120", Offset = "0x31CF520", VA = "0x1831D0120")]
		public bool MFIHEHOKFNE(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x23E7040", Offset = "0x23E6440", VA = "0x1823E7040")]
		public bool DFNDFEBIINI(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x31CFD20", Offset = "0x31CF120", VA = "0x1831CFD20")]
		public bool MFIHEHOKFNE(BEFOJADPLHK KAKCNEMJMJL, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x31CF5B0", Offset = "0x31CE9B0", VA = "0x1831CF5B0")]
		public bool DFNDFEBIINI(BEFOJADPLHK KAKCNEMJMJL, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x31D04F0", Offset = "0x31CF8F0", VA = "0x1831D04F0")]
		public bool MFIHEHOKFNE(BEFOJADPLHK KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x23E7040", Offset = "0x23E6440", VA = "0x1823E7040")]
		public bool DFNDFEBIINI(BEFOJADPLHK KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x23E71C0", Offset = "0x23E65C0", VA = "0x1823E71C0")]
		public bool MFIHEHOKFNE<TMessageArg>(MJKAHBKMBLB<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x23E7040", Offset = "0x23E6440", VA = "0x1823E7040")]
		public bool DFNDFEBIINI<TMessageArg>(MJKAHBKMBLB<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x23E73E0", Offset = "0x23E67E0", VA = "0x1823E73E0")]
		public bool MFIHEHOKFNE<TMessageArg>(MJKAHBKMBLB<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x23E6FC0", Offset = "0x23E63C0", VA = "0x1823E6FC0")]
		public bool DFNDFEBIINI<TMessageArg>(MJKAHBKMBLB<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x23E71C0", Offset = "0x23E65C0", VA = "0x1823E71C0")]
		public bool MFIHEHOKFNE<TMessageArg>(GLGHDCOMDGJ<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x23E7040", Offset = "0x23E6440", VA = "0x1823E7040")]
		public bool DFNDFEBIINI<TMessageArg>(GLGHDCOMDGJ<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x23E73E0", Offset = "0x23E67E0", VA = "0x1823E73E0")]
		public bool MFIHEHOKFNE<TMessageArg>(GLGHDCOMDGJ<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x23E6FC0", Offset = "0x23E63C0", VA = "0x1823E6FC0")]
		public bool DFNDFEBIINI<TMessageArg>(GLGHDCOMDGJ<TMessageArg> KAKCNEMJMJL, in TMessageArg MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, in TConditionArg FJOJFHIJGLJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct LBPIDDBMDIC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly object KAKCNEMJMJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly IECEHJHNOCE? AGHIOHHDKJB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private bool GPMFLIOEDNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x53FF300", Offset = "0x53FE700", VA = "0x1853FF300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x53FF3C0", Offset = "0x53FE7C0", VA = "0x1853FF3C0")]
		public LBPIDDBMDIC(object KAKCNEMJMJL, in IECEHJHNOCE? AGHIOHHDKJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x53FF250", Offset = "0x53FE650", VA = "0x1853FF250", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JOCALGIMGJP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
		public JOCALGIMGJP(object KAKCNEMJMJL, in IECEHJHNOCE? AGHIOHHDKJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum FFDBFDMHBEB
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Method = 1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Params = 2,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Link = 4,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		MiniLink = 8,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Default = 7
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class CCOHDLNLEGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public BEFOJADPLHK message;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public CCOHDLNLEGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x53F7580", Offset = "0x53F6980", VA = "0x1853F7580")]
		internal object <LogExceptionErrorString>b__0(Exception e)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly KOLPCBEOJAC<AEMOKBJMMCG> ELAIGEBCLBP;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly JPPNNBPIGNE<AEMOKBJMMCG, ECEACENJCDI, ((string File, int Line) Location, object Value)> CCGNBIAMNFI;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly KOLPCBEOJAC<HEJKNMFIBLM> BDNAHKFNMLD;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly JPPNNBPIGNE<HEJKNMFIBLM, CAPLDKJJCJD, (string File, int Line)> BCFOJNEDEJL;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public const string ADGHALBEBNE = "START: ";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public const string INBBGLLECHP = "END: ";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static readonly JPPNNBPIGNE<AEMOKBJMMCG, MCPENANLFGF, ((string File, int Line) Location, long ThrottleMs)> DFBCKOMLGPP;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static readonly KOLPCBEOJAC<ELMFJMBPAHF> IJBBAAKECGM;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly JPPNNBPIGNE<HEJKNMFIBLM, ENBCALEJGJI, bool> GPOKEFOCAJN;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly JPPNNBPIGNE<HEJKNMFIBLM, GKDFPPAHGFK, ((string File, int Line) Location, bool Condition)> HKJEMLGJNAP;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly Regex GMGBEAKAGND;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly Regex LPOGLDPLNMO;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x54028C0", Offset = "0x5401CC0", VA = "0x1854028C0")]
	public static void MFIHEHOKFNE(object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5402840", Offset = "0x5401C40", VA = "0x185402840")]
	public static void MFIHEHOKFNE(BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x32243C0", Offset = "0x32237C0", VA = "0x1832243C0")]
	public static void MFIHEHOKFNE<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3224700", Offset = "0x3223B00", VA = "0x183224700")]
	public static void MFIHEHOKFNE<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5402700", Offset = "0x5401B00", VA = "0x185402700")]
	public static void MFIHEHOKFNE(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x54027A0", Offset = "0x5401BA0", VA = "0x1854027A0")]
	public static void MFIHEHOKFNE(BEFOJADPLHK KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3224AC0", Offset = "0x3223EC0", VA = "0x183224AC0")]
	public static void MFIHEHOKFNE<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x32245B0", Offset = "0x32239B0", VA = "0x1832245B0")]
	public static void MFIHEHOKFNE<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void DFNDFEBIINI(object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void DFNDFEBIINI(BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void DFNDFEBIINI<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void DFNDFEBIINI<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void DFNDFEBIINI(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void DFNDFEBIINI(BEFOJADPLHK KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void DFNDFEBIINI<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void DFNDFEBIINI<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3223220", Offset = "0x3222620", VA = "0x183223220")]
	public static void DEPFECDINDD<T>(object KAKCNEMJMJL, in T JLBINKLPHKJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3223360", Offset = "0x3222760", VA = "0x183223360")]
	public static void DEPFECDINDD<T>(BEFOJADPLHK KAKCNEMJMJL, in T JLBINKLPHKJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x32230E0", Offset = "0x32224E0", VA = "0x1832230E0")]
	public static void DEPFECDINDD<U, T>(MJKAHBKMBLB<U> KAKCNEMJMJL, in U MMLIFJCNOMF, in T JLBINKLPHKJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3222FA0", Offset = "0x32223A0", VA = "0x183222FA0")]
	public static void DEPFECDINDD<U, T>(GLGHDCOMDGJ<U> KAKCNEMJMJL, in U MMLIFJCNOMF, in T JLBINKLPHKJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3223AE0", Offset = "0x3222EE0", VA = "0x183223AE0")]
	public static void EMCGAHDODFD<T>(object KAKCNEMJMJL, in T JLBINKLPHKJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x32239A0", Offset = "0x3222DA0", VA = "0x1832239A0")]
	public static void EMCGAHDODFD<T>(BEFOJADPLHK KAKCNEMJMJL, in T JLBINKLPHKJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3223720", Offset = "0x3222B20", VA = "0x183223720")]
	public static void EMCGAHDODFD<U, T>(MJKAHBKMBLB<U> KAKCNEMJMJL, in U MMLIFJCNOMF, in T JLBINKLPHKJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3223860", Offset = "0x3222C60", VA = "0x183223860")]
	public static void EMCGAHDODFD<U, T>(GLGHDCOMDGJ<U> KAKCNEMJMJL, in U MMLIFJCNOMF, in T JLBINKLPHKJ, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5401670", Offset = "0x5400A70", VA = "0x185401670")]
	public static void HPDOPNHAGJK(object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5401700", Offset = "0x5400B00", VA = "0x185401700")]
	public static void HPDOPNHAGJK(BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3224000", Offset = "0x3223400", VA = "0x183224000")]
	public static void HPDOPNHAGJK<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x32240A0", Offset = "0x32234A0", VA = "0x1832240A0")]
	public static void HPDOPNHAGJK<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5401830", Offset = "0x5400C30", VA = "0x185401830")]
	public static void HPDOPNHAGJK(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5401790", Offset = "0x5400B90", VA = "0x185401790")]
	public static void HPDOPNHAGJK(BEFOJADPLHK KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3223EA0", Offset = "0x32232A0", VA = "0x183223EA0")]
	public static void HPDOPNHAGJK<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x3223F50", Offset = "0x3223350", VA = "0x183223F50")]
	public static void HPDOPNHAGJK<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void BILEACJFIBF(object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void BILEACJFIBF(BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void BILEACJFIBF<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void BILEACJFIBF<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void BILEACJFIBF(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void BILEACJFIBF(BEFOJADPLHK KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void BILEACJFIBF<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void BILEACJFIBF<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5400F20", Offset = "0x5400320", VA = "0x185400F20")]
	public static void GLNNLNDFECH(Exception DLEJGHMKMEP, [Optional] BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5401090", Offset = "0x5400490", VA = "0x185401090")]
	public static void GLNNLNDFECH(Exception DLEJGHMKMEP, [Optional] BEFOJADPLHK KAKCNEMJMJL, [Optional] UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5402330", Offset = "0x5401730", VA = "0x185402330")]
	private static void MEOOEJEMAFI(Exception DLEJGHMKMEP, StringBuilder BIOJHMCHAFL, int FGINFGKNAGK = 0, int EAMEHFAIJLE = 5)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5403270", Offset = "0x5402670", VA = "0x185403270")]
	public static void PPKEMIOEJHK(object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5400800", Offset = "0x53FFC00", VA = "0x185400800")]
	public static void ECFLOILKOID(object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x54006D0", Offset = "0x53FFAD0", VA = "0x1854006D0")]
	public static LBPIDDBMDIC EBOEKGPABAG(object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(LBPIDDBMDIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5400590", Offset = "0x53FF990", VA = "0x185400590")]
	public static LBPIDDBMDIC EBOEKGPABAG(BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(LBPIDDBMDIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x32234A0", Offset = "0x32228A0", VA = "0x1832234A0")]
	public static LBPIDDBMDIC EBOEKGPABAG<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(LBPIDDBMDIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x32235E0", Offset = "0x32229E0", VA = "0x1832235E0")]
	public static LBPIDDBMDIC EBOEKGPABAG<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(LBPIDDBMDIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5400270", Offset = "0x53FF670", VA = "0x185400270")]
	public static JOCALGIMGJP AJPKAOECLNH(object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(JOCALGIMGJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5400190", Offset = "0x53FF590", VA = "0x185400190")]
	public static JOCALGIMGJP AJPKAOECLNH(BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(JOCALGIMGJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3222E80", Offset = "0x3222280", VA = "0x183222E80")]
	public static JOCALGIMGJP AJPKAOECLNH<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(JOCALGIMGJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3222D60", Offset = "0x3222160", VA = "0x183222D60")]
	public static JOCALGIMGJP AJPKAOECLNH<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(JOCALGIMGJP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5400CC0", Offset = "0x54000C0", VA = "0x185400CC0")]
	public static void FHCENLEPBDA(object KAKCNEMJMJL, long HKFJIMLNGDM, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5400B80", Offset = "0x53FFF80", VA = "0x185400B80")]
	public static void FHCENLEPBDA(BEFOJADPLHK KAKCNEMJMJL, long HKFJIMLNGDM, [Optional] IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3223C20", Offset = "0x3223020", VA = "0x183223C20")]
	public static void FHCENLEPBDA<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, long HKFJIMLNGDM, [Optional] IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3223D60", Offset = "0x3223160", VA = "0x183223D60")]
	public static void FHCENLEPBDA<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, long HKFJIMLNGDM, [Optional] IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5402940", Offset = "0x5401D40", VA = "0x185402940")]
	public static void MFJDOKFKMOC(object KAKCNEMJMJL, long HKFJIMLNGDM, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5402A80", Offset = "0x5401E80", VA = "0x185402A80")]
	public static void MFJDOKFKMOC(BEFOJADPLHK KAKCNEMJMJL, long HKFJIMLNGDM, [Optional] IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3225070", Offset = "0x3224470", VA = "0x183225070")]
	public static void MFJDOKFKMOC<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, long HKFJIMLNGDM, [Optional] IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3224F30", Offset = "0x3224330", VA = "0x183224F30")]
	public static void MFJDOKFKMOC<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, long HKFJIMLNGDM, [Optional] IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5402D80", Offset = "0x5402180", VA = "0x185402D80")]
	public static void OCONKDLKCCJ(object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5402CF0", Offset = "0x54020F0", VA = "0x185402CF0")]
	public static void OCONKDLKCCJ(BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3225310", Offset = "0x3224710", VA = "0x183225310")]
	public static void OCONKDLKCCJ<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x32253B0", Offset = "0x32247B0", VA = "0x1832253B0")]
	public static void OCONKDLKCCJ<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5402C50", Offset = "0x5402050", VA = "0x185402C50")]
	public static void OCONKDLKCCJ(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5402E10", Offset = "0x5402210", VA = "0x185402E10")]
	public static void OCONKDLKCCJ(BEFOJADPLHK KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3225260", Offset = "0x3224660", VA = "0x183225260")]
	public static void OCONKDLKCCJ<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x32251B0", Offset = "0x32245B0", VA = "0x1832251B0")]
	public static void OCONKDLKCCJ<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void CFBMCCCKNIM(object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void CFBMCCCKNIM(BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void CFBMCCCKNIM<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void CFBMCCCKNIM<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void CFBMCCCKNIM(object KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void CFBMCCCKNIM(BEFOJADPLHK KAKCNEMJMJL, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void CFBMCCCKNIM<T>(MJKAHBKMBLB<T> KAKCNEMJMJL, in T MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void CFBMCCCKNIM<T>(GLGHDCOMDGJ<T> KAKCNEMJMJL, in T MMLIFJCNOMF, UnityEngine.Object GKMHGIGLKCO, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5400440", Offset = "0x53FF840", VA = "0x185400440")]
	[Obsolete]
	public static OPLAPIGKHFI BOMGNANDGDA()
	{
		return default(OPLAPIGKHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5402C20", Offset = "0x5402020", VA = "0x185402C20")]
	[Obsolete]
	public static OPLAPIGKHFI NCGOKNADPEM(in IECEHJHNOCE IGDJJEECDAF)
	{
		return default(OPLAPIGKHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5401AA0", Offset = "0x5400EA0", VA = "0x185401AA0")]
	public static OPLAPIGKHFI JPDIKFONBMC(in IECEHJHNOCE IGDJJEECDAF)
	{
		return default(OPLAPIGKHFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5400EA0", Offset = "0x54002A0", VA = "0x185400EA0")]
	[Obsolete]
	public static LONCFDFLFFP GLECMIOKJMP()
	{
		return default(LONCFDFLFFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x54018D0", Offset = "0x5400CD0", VA = "0x1854018D0")]
	public static global::DIONNCNIINH<bool> JEMFOJJPFNO(bool IGDJJEECDAF)
	{
		return default(global::DIONNCNIINH<bool>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5400020", Offset = "0x53FF420", VA = "0x185400020")]
	[Obsolete]
	public static LONCFDFLFFP ABODOJJGMMB(in IECEHJHNOCE IGDJJEECDAF)
	{
		return default(LONCFDFLFFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5400320", Offset = "0x53FF720", VA = "0x185400320")]
	public static LONCFDFLFFP BKDFBIDPKEO(in IECEHJHNOCE IGDJJEECDAF)
	{
		return default(LONCFDFLFFP);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x54004C0", Offset = "0x53FF8C0", VA = "0x1854004C0")]
	[Obsolete]
	public static CDFOHMPFGPO CBNCHKBGLFI()
	{
		return default(CDFOHMPFGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5402300", Offset = "0x5401700", VA = "0x185402300")]
	[Obsolete]
	public static CDFOHMPFGPO LDFMFKKHAEN(in IECEHJHNOCE? IGDJJEECDAF, [Optional] int? NHOBPJLHECA)
	{
		return default(CDFOHMPFGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5400E00", Offset = "0x5400200", VA = "0x185400E00")]
	public static CDFOHMPFGPO FKCCPAHHMFB(in IECEHJHNOCE IGDJJEECDAF, [Optional] int? NHOBPJLHECA)
	{
		return default(CDFOHMPFGPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x54000F0", Offset = "0x53FF4F0", VA = "0x1854000F0")]
	public static bool AHNBAJDMOHM(bool FJOJFHIJGLJ, object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5400050", Offset = "0x53FF450", VA = "0x185400050")]
	public static bool AHNBAJDMOHM(bool FJOJFHIJGLJ, BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3222C00", Offset = "0x3222000", VA = "0x183222C00")]
	public static bool AHNBAJDMOHM<TMessageArgs>(bool FJOJFHIJGLJ, MJKAHBKMBLB<TMessageArgs> KAKCNEMJMJL, in TMessageArgs MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3222CB0", Offset = "0x32220B0", VA = "0x183222CB0")]
	public static bool AHNBAJDMOHM<TMessageArgs>(bool FJOJFHIJGLJ, GLGHDCOMDGJ<TMessageArgs> KAKCNEMJMJL, in TMessageArgs MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x54031D0", Offset = "0x54025D0", VA = "0x1854031D0")]
	public static bool OJLLOCAHHFD(bool FJOJFHIJGLJ, object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5403130", Offset = "0x5402530", VA = "0x185403130")]
	public static bool OJLLOCAHHFD(bool FJOJFHIJGLJ, BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3225450", Offset = "0x3224850", VA = "0x183225450")]
	public static bool OJLLOCAHHFD<TMessageArgs>(bool FJOJFHIJGLJ, MJKAHBKMBLB<TMessageArgs> KAKCNEMJMJL, in TMessageArgs MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3225500", Offset = "0x3224900", VA = "0x183225500")]
	public static bool OJLLOCAHHFD<TMessageArgs>(bool FJOJFHIJGLJ, GLGHDCOMDGJ<TMessageArgs> KAKCNEMJMJL, in TMessageArgs MMLIFJCNOMF, [Optional] in IECEHJHNOCE? AOFGAGALOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5401470", Offset = "0x5400870", VA = "0x185401470")]
	public static bool HEMOGGHNKFL(bool FJOJFHIJGLJ, object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5401330", Offset = "0x5400730", VA = "0x185401330")]
	public static bool HEMOGGHNKFL(bool FJOJFHIJGLJ, BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5402FF0", Offset = "0x54023F0", VA = "0x185402FF0")]
	public static bool OIELHFMPFBP(bool FJOJFHIJGLJ, object KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5402EB0", Offset = "0x54022B0", VA = "0x185402EB0")]
	public static bool OIELHFMPFBP(bool FJOJFHIJGLJ, BEFOJADPLHK KAKCNEMJMJL, [Optional] in IECEHJHNOCE? AOFGAGALOCP, [CallerFilePath] string DNJACPJDGNO = "", [CallerLineNumber] int JOMFBPFHOJK = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x54015B0", Offset = "0x54009B0", VA = "0x1854015B0")]
	public static bool HJKJIIEPBDE(in IECEHJHNOCE AOFGAGALOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x54008E0", Offset = "0x53FFCE0", VA = "0x1854008E0")]
	private static bool EDCKPBPIOJH(in IECEHJHNOCE? AOFGAGALOCP, in IECEHJHNOCE KEKHPFKGFLI, out IECEHJHNOCE LEIEPHBEPEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x54011D0", Offset = "0x54005D0", VA = "0x1854011D0")]
	private static object GPOBGFKHBGD(object KAKCNEMJMJL, in IECEHJHNOCE AOFGAGALOCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5400350", Offset = "0x53FF750", VA = "0x185400350")]
	public static void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5402BC0", Offset = "0x5401FC0", VA = "0x185402BC0")]
	public static void MLINMNLHNFK(Exception DLEJGHMKMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5401AD0", Offset = "0x5400ED0", VA = "0x185401AD0")]
	public static string KPJCBIFKBHA(string AIOIJCLKGCN, FFDBFDMHBEB AOFGAGALOCP = FFDBFDMHBEB.All)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x775500", Offset = "0x774900", VA = "0x180775500")]
	public static string EIEMPAJDPMI(string KCBCONDOCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5400AE0", Offset = "0x53FFEE0", VA = "0x185400AE0")]
	public static string EIEMPAJDPMI(string KCBCONDOCPA, [Optional] int? DFHCEKBBLKC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class AECDBFCBCHI
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal static readonly ODINFDAPMKD GJICELHGILH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal static readonly ODINFDAPMKD GFNDCGIBHLK;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal static readonly ODINFDAPMKD PDJOHEIDOOG;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static IECEHJHNOCE NJJIHBJEPHC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly KKOBNOKBGDO CLIKPINENCO;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal static bool GFMLECALAOG;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal static bool HFLFBCNOHDO;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static int HEPGLNNEIJO;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static AJIGPCDNBGG KAHEJEOHKME;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static CMGAENMIIKI AGCBCOJCCNO;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static bool IEAAGAIMBOE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static JsonConverter[] BCEBHBHKMJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x53F5310", Offset = "0x53F4710", VA = "0x1853F5310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x53F4260", Offset = "0x53F3660", VA = "0x1853F4260")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static IECEHJHNOCE KOGKCBJOPCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x53F4190", Offset = "0x53F3590", VA = "0x1853F4190")]
		get
		{
			return default(IECEHJHNOCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static IECEHJHNOCE BFKAEAELGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x53F52A0", Offset = "0x53F46A0", VA = "0x1853F52A0")]
		get
		{
			return default(IECEHJHNOCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal static IECEHJHNOCE BFNKDLOIBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x53F3BF0", Offset = "0x53F2FF0", VA = "0x1853F3BF0")]
		get
		{
			return default(IECEHJHNOCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static IECEHJHNOCE.FKIGFJNJGGO JMIJCOIIPGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x53F4DA0", Offset = "0x53F41A0", VA = "0x1853F4DA0")]
		[CompilerGenerated]
		get
		{
			return default(IECEHJHNOCE.FKIGFJNJGGO);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x53F4200", Offset = "0x53F3600", VA = "0x1853F4200")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static NDGJNFBOPEE JIKNBKLDEPE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x53F3E80", Offset = "0x53F3280", VA = "0x1853F3E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x53F45E0", Offset = "0x53F39E0", VA = "0x1853F45E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool CAAOJHKONOD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x53F46B0", Offset = "0x53F3AB0", VA = "0x1853F46B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x53F4650", Offset = "0x53F3A50", VA = "0x1853F4650")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static bool LEAFMCEFFCF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x53F4B50", Offset = "0x53F3F50", VA = "0x1853F4B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool OOGLELLGNEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x53F4870", Offset = "0x53F3C70", VA = "0x1853F4870")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x53F42D0", Offset = "0x53F36D0", VA = "0x1853F42D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static int FAGMIBCKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x53F4450", Offset = "0x53F3850", VA = "0x1853F4450")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x53F40E0", Offset = "0x53F34E0", VA = "0x1853F40E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static double BBMCHFGAFGP
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x53F4520", Offset = "0x53F3920", VA = "0x1853F4520")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x53F44B0", Offset = "0x53F38B0", VA = "0x1853F44B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double MHGFIDBJHFG
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x53F4790", Offset = "0x53F3B90", VA = "0x1853F4790")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static NGBAJKFMIJG LFEOLEBPIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x53F48D0", Offset = "0x53F3CD0", VA = "0x1853F48D0")]
		[CompilerGenerated]
		get
		{
			return default(NGBAJKFMIJG);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x53F3A70", Offset = "0x53F2E70", VA = "0x1853F3A70")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static bool IDHNKABJKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x53F4CE0", Offset = "0x53F40E0", VA = "0x1853F4CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x53F4580", Offset = "0x53F3980", VA = "0x1853F4580")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x53F4E80", Offset = "0x53F4280", VA = "0x1853F4E80")]
	public static void OEJBAIAEPOD(in IECEHJHNOCE IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x53F4C60", Offset = "0x53F4060", VA = "0x1853F4C60")]
	public static void LOFOAGMBEDF(bool IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x53F4140", Offset = "0x53F3540", VA = "0x1853F4140")]
	private static void EGNLCGENKAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x53F3AD0", Offset = "0x53F2ED0", VA = "0x1853F3AD0")]
	public static void ADKDLGNMBIB(in IECEHJHNOCE IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x53F43D0", Offset = "0x53F37D0", VA = "0x1853F43D0")]
	public static void GOPJLAAFPCM(bool IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x53F5250", Offset = "0x53F4650", VA = "0x1853F5250")]
	private static void PDJPCBJGMBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x53F4930", Offset = "0x53F3D30", VA = "0x1853F4930")]
	private static void LHJHOPOEGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x53F3B50", Offset = "0x53F2F50", VA = "0x1853F3B50")]
	[Conditional("UNITY_EDITOR")]
	public static void BLJIHEEBJBE(IECEHJHNOCE.FKIGFJNJGGO GBMKHELIDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x53F3A00", Offset = "0x53F2E00", VA = "0x1853F3A00")]
	public static void AAAMIPJCHJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x53F3EE0", Offset = "0x53F32E0", VA = "0x1853F3EE0")]
	private static void EEJIKEOJHGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x53F4D40", Offset = "0x53F4140", VA = "0x1853F4D40")]
	internal static int MCHHIMEONJF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x53F4BF0", Offset = "0x53F3FF0", VA = "0x1853F4BF0")]
	public static void LLOGCODEGLI(int DEBAMGFBJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x53F3C50", Offset = "0x53F3050", VA = "0x1853F3C50")]
	public static void BOLFDBEPFNI(int? AMPJBEEOLPN, int? OOJCGOEDBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x53F4F00", Offset = "0x53F4300", VA = "0x1853F4F00")]
	public static void PAAIADCFDIA(CMGAENMIIKI HCDIHNPPHMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x53F4340", Offset = "0x53F3740", VA = "0x1853F4340")]
	internal static void GKEMOPNAMHG(string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x53F4E00", Offset = "0x53F4200", VA = "0x1853F4E00")]
	public static void NLFAMINGBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x53F4710", Offset = "0x53F3B10", VA = "0x1853F4710")]
	public static string JKINKKMCKFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x53F5370", Offset = "0x53F4770", VA = "0x1853F5370")]
	public static byte[] PPCIBJEBHEE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class EIFFFLKLLCE : NDGJNFBOPEE
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private sealed class KEOBPJBNAGC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public KEOBPJBNAGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public PHGCAIBNIDF.NMBEEGBCKAA DPDABGHJPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
	public void ACOCNMJPHMM(float DDDKCJEIFCA, int AGCIOOLHOPB, int ECOBPGOIEOA, int MEBBPPKGHNJ, string JLABEFCNBHE, string HNGFICBIBFI, int KCKDDEDDANN, int FJIAMGKKHIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x53F92F0", Offset = "0x53F86F0", VA = "0x1853F92F0", Slot = "5")]
	public IDisposable IAJNMIBHLJF(float CBENHIMNKJF, Action<float> BLADCNLMNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x53F9340", Offset = "0x53F8740", VA = "0x1853F9340")]
	public EIFFFLKLLCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class OOKHJLIEBHF
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly KMCJODOMGFP.EDKEBGGMIMD ENGHMPBCJDM;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly KMCJODOMGFP.EDKEBGGMIMD DKIOCGFEEEF;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly KMCJODOMGFP.EDKEBGGMIMD CFKMBAFEGLB;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly KMCJODOMGFP.FFJMDIBKDPN FHEFEHBAMCG;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly KMCJODOMGFP.AIJLODFJBEN NNBIDHJLCBB;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly KMCJODOMGFP.NNHBAOHKEEM PONLDCFBOME;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly EEADHKPFFPD DIAFEBDFBMK;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly CDPPNBFGDEA DNPPOHBJOFD;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5406A30", Offset = "0x5405E30", VA = "0x185406A30")]
	public static void JDAMGPIICKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5406D20", Offset = "0x5406120", VA = "0x185406D20")]
	public static void MFIHEHOKFNE(string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5406E90", Offset = "0x5406290", VA = "0x185406E90")]
	public static void OCONKDLKCCJ(string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x54069D0", Offset = "0x5405DD0", VA = "0x1854069D0")]
	public static void HPDOPNHAGJK(string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x5406D80", Offset = "0x5406180", VA = "0x185406D80")]
	public static void MLINMNLHNFK(Exception DLEJGHMKMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void HBFGNIELCME(string DHKKANIEGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0")]
	public static void LFADNACGBNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5406DE0", Offset = "0x54061E0", VA = "0x185406DE0")]
	public static string MMPHMAGKPJO(object JLBINKLPHKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5406BF0", Offset = "0x5405FF0", VA = "0x185406BF0")]
	public static long LDCAPHLLDLI()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface NDGJNFBOPEE
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	PHGCAIBNIDF.NMBEEGBCKAA DPDABGHJPPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ACOCNMJPHMM(float DDDKCJEIFCA, int AGCIOOLHOPB, int ECOBPGOIEOA, int MEBBPPKGHNJ, string JLABEFCNBHE, string HNGFICBIBFI, int KCKDDEDDANN, int FJIAMGKKHIP);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable IAJNMIBHLJF(float CBENHIMNKJF, Action<float> BLADCNLMNHE);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class AJIGPCDNBGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly Dictionary<int, int> KDGGGOGDDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int KGKEEFFMGEK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int FOEAJNEMIOI
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x679BD0", Offset = "0x678FD0", VA = "0x180679BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x53F6040", Offset = "0x53F5440", VA = "0x1853F6040")]
	public AJIGPCDNBGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x53F60C0", Offset = "0x53F54C0", VA = "0x1853F60C0")]
	public AJIGPCDNBGG(int CBMGECOGCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x53F5E50", Offset = "0x53F5250", VA = "0x1853F5E50")]
	public void CIHFLFFDHOL(int CBMGECOGCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x53F5F30", Offset = "0x53F5330", VA = "0x1853F5F30")]
	public void FJNFBIOAIOM(int CBMGECOGCDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x53F5CF0", Offset = "0x53F50F0", VA = "0x1853F5CF0")]
	private int BMOLCOFANIM()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class MJMABKNPMFD
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static JsonConverter HHIGEFNAPGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x5404310", Offset = "0x5403710", VA = "0x185404310")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static JsonConverter CKENEPLCPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5404250", Offset = "0x5403650", VA = "0x185404250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static JsonConverter NEHPOMFBIKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x5404370", Offset = "0x5403770", VA = "0x185404370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static JsonConverter IJONCICHGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x54042B0", Offset = "0x54036B0", VA = "0x1854042B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class DBNMLJDIPKB
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct KIFMAKGLPEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public WeakReference NDBFMADKMHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int FEDKMJICEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int PMGCDJPLMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public string GAELEJJHLDP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct NMMFDCKNEPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int EJJNEBECADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int KKLCAGCDGIJ;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool KDCIOACLOJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x5406170", Offset = "0x5405570", VA = "0x185406170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string GANCNKNFIML
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x5406180", Offset = "0x5405580", VA = "0x185406180")]
			get
			{
				return null;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal const int KJEKPAOEKIB = 1000000;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal const int KIAKCINNGBH = 200;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static readonly List<KIFMAKGLPEB> INEFKOIFIDF;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly List<KIFMAKGLPEB> EFHBHLKABOO;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static readonly List<KIFMAKGLPEB> PMMJEBFKCMH;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static readonly List<KIFMAKGLPEB> FEEMNCAPFLK;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly List<KIFMAKGLPEB> IJFEOBFBOAO;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static string AGMFODFFAGP;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static bool JDLOIICGJEC;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x53F8230", Offset = "0x53F7630", VA = "0x1853F8230")]
	public static void DKMEPNBBIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x53F7C30", Offset = "0x53F7030", VA = "0x1853F7C30")]
	[Conditional("LEAKDETECTOR_ENABLED")]
	public static void AKBMAMDKLNI(object JLBINKLPHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x53F7A00", Offset = "0x53F6E00", VA = "0x1853F7A00")]
	public static void ACOIOAIIPBK([Optional] string DHKKANIEGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x53F8310", Offset = "0x53F7710", VA = "0x1853F8310")]
	public static NMMFDCKNEPL EDMAHHLMNGC()
	{
		return default(NMMFDCKNEPL);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x53F8870", Offset = "0x53F7C70", VA = "0x1853F8870")]
	private static bool ONFLNGGOKKO(this object JLBINKLPHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x53F8590", Offset = "0x53F7990", VA = "0x1853F8590")]
	private static void IPBHKKGLFFI(List<KIFMAKGLPEB> CKINMDHJCPD, List<KIFMAKGLPEB> GEEIKPIKCJH, string AGEOBIJKNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x53F7ED0", Offset = "0x53F72D0", VA = "0x1853F7ED0")]
	private static string CCFPBLNDKKK(KIFMAKGLPEB BKADPMHNDEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct IECEHJHNOCE : IEquatable<IECEHJHNOCE>
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Flags]
	public enum FKIGFJNJGGO
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		FormatUnityEngineDebugLogCalls = 2,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		ShowPstTimeNow = 4,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		ShowFrame = 8,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		ShowTimeSinceStartup = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		ShowLogType = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		ShowLogFlags = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		All = -1
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly JCKHBEJPNIO AOFGAGALOCP;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly IECEHJHNOCE HEDEHEAFHML;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly IECEHJHNOCE LKFNHGANOJB;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly IECEHJHNOCE ABILKLOODNE;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly IECEHJHNOCE GCNJHDOJIAF;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly IECEHJHNOCE PNCGLENNLGC;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly IECEHJHNOCE GILCFJGBAMM;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly IECEHJHNOCE LDFDBHEIDJF;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IECEHJHNOCE GBNPANDPNCK;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly IECEHJHNOCE ABMONGJOPAF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly IECEHJHNOCE DFNIOPPADLH;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly IECEHJHNOCE GDLJNBGHDNC;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly IECEHJHNOCE OBLACEJJKHN;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly IECEHJHNOCE BCOENIFILMH;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly IECEHJHNOCE CJEOEGFPMCM;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly IECEHJHNOCE HHMFMONBLHB;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly IECEHJHNOCE ANGBFHGNCAE;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly IECEHJHNOCE ACKLEIPAEKD;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static readonly IECEHJHNOCE JHDFCBPNGLH;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static readonly IECEHJHNOCE IEJJAIDMAHI;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static readonly IECEHJHNOCE DMOKBFGJKFC;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly IECEHJHNOCE OMDPLBGHJBC;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly IECEHJHNOCE NOONDGEBNLJ;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly IECEHJHNOCE NBKBBHBPPMB;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly IECEHJHNOCE JMJCNJBOOCG;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly IECEHJHNOCE HFGDLFJGFCC;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public static readonly IECEHJHNOCE ENAHOHACHMM;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly IECEHJHNOCE IOILJFBFAIF;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly IECEHJHNOCE GMCLJBLNPNI;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly IECEHJHNOCE IPIEDJFFMFB;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly IECEHJHNOCE KCAAGFBILCB;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly IECEHJHNOCE PKEJHKHGNCG;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly IECEHJHNOCE BFEGKNLEIGA;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly IECEHJHNOCE JLAGAJPDAAI;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly IECEHJHNOCE KIBMKMBBEKD;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly IECEHJHNOCE FIMEOGBDMHE;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static readonly IECEHJHNOCE BLCLMCFGGDK;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly IECEHJHNOCE JHONHDNBPNK;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly IECEHJHNOCE LLBMNOMLGBP;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly IECEHJHNOCE OKNCNIOJLFK;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly IECEHJHNOCE OIDKMBLBCJM;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly IECEHJHNOCE POJHGCLPOLF;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static readonly IECEHJHNOCE DDHGJPOOIIB;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly IECEHJHNOCE MEFIMPHGFFM;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly IECEHJHNOCE BLHBADPLJPP;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly IECEHJHNOCE HIKCAAANLIA;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly IECEHJHNOCE CAIHAHOGACN;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly IECEHJHNOCE IJLNDHFDGIC;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static readonly IECEHJHNOCE DBGAHKFLCEG;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly IECEHJHNOCE CDPCDPMJNFK;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly IECEHJHNOCE DHKDBPODCEC;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly IECEHJHNOCE NBGNEJJELCK;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly IECEHJHNOCE NMNIOAALNNE;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly IECEHJHNOCE EJPLNHEIMGJ;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly IECEHJHNOCE EOFIHPIEDPD;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static readonly IECEHJHNOCE CHBLIIABFLC;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly IECEHJHNOCE LCPEMMFNIGI;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly IECEHJHNOCE MKMJEPKCNPB;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly IECEHJHNOCE BKIMHMJINMC;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public static readonly IECEHJHNOCE JHOBLKIPODG;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal static readonly IECEHJHNOCE OFJLLDFCGJC;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	internal static readonly IECEHJHNOCE EGNBCGINMEN;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	[Obsolete]
	public static readonly IECEHJHNOCE LEAJLIAOJHP;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	internal static readonly IECEHJHNOCE HNPKMBCPGNF;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	[Obsolete]
	public static readonly IECEHJHNOCE GDNNCPKEBIP;

	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public static readonly IECEHJHNOCE IHPNALICNOB;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x53FB7F0", Offset = "0x53FABF0", VA = "0x1853FB7F0")]
	internal IECEHJHNOCE(KHJIGBJHMOB AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6DD4E0", Offset = "0x6DC8E0", VA = "0x1806DD4E0")]
	internal IECEHJHNOCE(JCKHBEJPNIO AOFGAGALOCP)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x53F9F90", Offset = "0x53F9390", VA = "0x1853F9F90")]
	public static IECEHJHNOCE GFKKOGBEPBN(KHJIGBJHMOB AOFGAGALOCP)
	{
		return default(IECEHJHNOCE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x53F9C70", Offset = "0x53F9070", VA = "0x1853F9C70")]
	public static IECEHJHNOCE BLNFEIIGDLO(in IECEHJHNOCE LKINCHDLDIG, in IECEHJHNOCE EPJIAIAEMFF)
	{
		return default(IECEHJHNOCE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x53FA540", Offset = "0x53F9940", VA = "0x1853FA540")]
	public static IECEHJHNOCE OMEJHGADKMM(in IECEHJHNOCE LKINCHDLDIG, in IECEHJHNOCE EPJIAIAEMFF)
	{
		return default(IECEHJHNOCE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x53FA5C0", Offset = "0x53F99C0", VA = "0x1853FA5C0")]
	public static IECEHJHNOCE PDEHHEFIEEI(in IECEHJHNOCE LKINCHDLDIG, in IECEHJHNOCE EPJIAIAEMFF)
	{
		return default(IECEHJHNOCE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x53FA4D0", Offset = "0x53F98D0", VA = "0x1853FA4D0")]
	public static IECEHJHNOCE OAICNEFEEMI(in IECEHJHNOCE LKINCHDLDIG)
	{
		return default(IECEHJHNOCE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x53FA230", Offset = "0x53F9630", VA = "0x1853FA230")]
	public static bool LPAHFDMKICD(in IECEHJHNOCE LBABLKMFGKM, in IECEHJHNOCE MGCAIGBBIIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x53F9B80", Offset = "0x53F8F80", VA = "0x1853F9B80")]
	public static bool AFMDFHOMNJI(in IECEHJHNOCE LBABLKMFGKM, in IECEHJHNOCE MGCAIGBBIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x53F9E40", Offset = "0x53F9240", VA = "0x1853F9E40", Slot = "4")]
	public bool Equals(IECEHJHNOCE MGCAIGBBIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x53F9EB0", Offset = "0x53F92B0", VA = "0x1853F9EB0", Slot = "0")]
	public override bool Equals(object MGCAIGBBIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x53FA050", Offset = "0x53F9450", VA = "0x1853FA050", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x53FA070", Offset = "0x53F9470", VA = "0x1853FA070")]
	public bool HJKJIIEPBDE(in IECEHJHNOCE AOFGAGALOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x53FA640", Offset = "0x53F9A40", VA = "0x1853FA640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x53F9C30", Offset = "0x53F9030", VA = "0x1853F9C30")]
	public FMGCJPKPBOD AJENBKAFJPB()
	{
		return default(FMGCJPKPBOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x53F9FC0", Offset = "0x53F93C0", VA = "0x1853F9FC0")]
	internal static string GPOBGFKHBGD(string KAKCNEMJMJL, LogType AJJOGHKEFIO, IECEHJHNOCE AGHIOHHDKJB, FKIGFJNJGGO JMKAIGOOOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x53F9CF0", Offset = "0x53F90F0", VA = "0x1853F9CF0")]
	public static IECEHJHNOCE DGCIGPCEOGA(string PGFKHDANIMB)
	{
		return default(IECEHJHNOCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x53FA180", Offset = "0x53F9580", VA = "0x1853FA180")]
	public string KBMLIHPOAIM(string KAKCNEMJMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x53FA2A0", Offset = "0x53F96A0", VA = "0x1853FA2A0")]
	public (IECEHJHNOCE, string) NHGFPAKNEAP(LogType? AJJOGHKEFIO, string IGDJJEECDAF, FKIGFJNJGGO JMKAIGOOOKA)
	{
		return default((IECEHJHNOCE, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x53F9D50", Offset = "0x53F9150", VA = "0x1853F9D50")]
	private static JCKHBEJPNIO DKOALHGANJG(KHJIGBJHMOB AOFGAGALOCP)
	{
		return default(JCKHBEJPNIO);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DebuggerTypeProxy(typeof(JIEPMOOHEAP))]
internal struct JCKHBEJPNIO
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public static readonly JCKHBEJPNIO MKMJEPKCNPB;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private const int LOHAFJIFFFL = 32;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	internal const int FELJDPMCKHE = 2;

	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	internal const int EFHIAFDMJOO = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal unsafe fixed uint JOOAPFLIEDN[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	internal unsafe fixed byte EEMDNKKFCBK[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private uint EJGKDCIFNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private uint JCBCGDJABJM;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x53FC4A0", Offset = "0x53FB8A0", VA = "0x1853FC4A0")]
	public JCKHBEJPNIO(KHJIGBJHMOB AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x53FC2C0", Offset = "0x53FB6C0", VA = "0x1853FC2C0")]
	public JCKHBEJPNIO(ReadOnlySpan<char> DGPEPJNHDPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x53FC240", Offset = "0x53FB640", VA = "0x1853FC240")]
	public MFCHGFFLPPI PEKBJENCCON()
	{
		return default(MFCHGFFLPPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x53FBAE0", Offset = "0x53FAEE0", VA = "0x1853FBAE0")]
	public FMGCJPKPBOD AJENBKAFJPB()
	{
		return default(FMGCJPKPBOD);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x53FC260", Offset = "0x53FB660", VA = "0x1853FC260", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x53FBC80", Offset = "0x53FB080", VA = "0x1853FBC80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x53FBDF0", Offset = "0x53FB1F0", VA = "0x1853FBDF0")]
	public bool HJKJIIEPBDE(in JCKHBEJPNIO AOFGAGALOCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x53FBEC0", Offset = "0x53FB2C0", VA = "0x1853FBEC0")]
	public void KNBGLHDOKIA(KHJIGBJHMOB DLKKHAHFEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x27663C0", Offset = "0x27657C0", VA = "0x1827663C0")]
	public int ECNEGPPDMND(int OGPIPIDCIKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x53FBB50", Offset = "0x53FAF50", VA = "0x1853FBB50")]
	public void CMHOMKBMHDJ(int OGPIPIDCIKL, int IGDJJEECDAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x53FBBA0", Offset = "0x53FAFA0", VA = "0x1853FBBA0", Slot = "0")]
	public override bool Equals(object JLBINKLPHKJ)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x53FBA70", Offset = "0x53FAE70", VA = "0x1853FBA70")]
	public static bool AFMDFHOMNJI(in JCKHBEJPNIO LBABLKMFGKM, in JCKHBEJPNIO MGCAIGBBIIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x53FBEF0", Offset = "0x53FB2F0", VA = "0x1853FBEF0")]
	public static bool LPAHFDMKICD(JCKHBEJPNIO LBABLKMFGKM, JCKHBEJPNIO MGCAIGBBIIM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x53FBB20", Offset = "0x53FAF20", VA = "0x1853FBB20")]
	public static JCKHBEJPNIO BLNFEIIGDLO(JCKHBEJPNIO LBABLKMFGKM, JCKHBEJPNIO MGCAIGBBIIM)
	{
		return default(JCKHBEJPNIO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x53FC1E0", Offset = "0x53FB5E0", VA = "0x1853FC1E0")]
	public static JCKHBEJPNIO OMEJHGADKMM(JCKHBEJPNIO LBABLKMFGKM, JCKHBEJPNIO MGCAIGBBIIM)
	{
		return default(JCKHBEJPNIO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x53FC210", Offset = "0x53FB610", VA = "0x1853FC210")]
	public static JCKHBEJPNIO PDEHHEFIEEI(JCKHBEJPNIO LBABLKMFGKM, JCKHBEJPNIO MGCAIGBBIIM)
	{
		return default(JCKHBEJPNIO);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x53FC1C0", Offset = "0x53FB5C0", VA = "0x1853FC1C0")]
	public static JCKHBEJPNIO OAICNEFEEMI(JCKHBEJPNIO LKINCHDLDIG)
	{
		return default(JCKHBEJPNIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x53FBA30", Offset = "0x53FAE30", VA = "0x1853FBA30")]
	private int AFLJKIDGNME(int OGPIPIDCIKL, int IGDJJEECDAF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x53FBC50", Offset = "0x53FB050", VA = "0x1853FBC50")]
	private int FMBFJMPLFNO(int OGPIPIDCIKL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class JIEPMOOHEAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly JCKHBEJPNIO DNKDLGKCHNJ;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string[] POMBOBCBFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x53FC560", Offset = "0x53FB960", VA = "0x1853FC560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int[] HHKMPMPNAOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x53FC6B0", Offset = "0x53FBAB0", VA = "0x1853FC6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte[] CMPNBJDJNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x53FC6C0", Offset = "0x53FBAC0", VA = "0x1853FC6C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public uint[] IFDBMNLMICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x53FC4D0", Offset = "0x53FB8D0", VA = "0x1853FC4D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0xFF51C0", Offset = "0xFF45C0", VA = "0x180FF51C0")]
	public JIEPMOOHEAP(JCKHBEJPNIO DNKDLGKCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x53FC750", Offset = "0x53FBB50", VA = "0x1853FC750")]
	private int[] KLLLEDDHKMO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x53FC560", Offset = "0x53FB960", VA = "0x1853FC560")]
	private string[] CLALDGMBNHK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x53FC6C0", Offset = "0x53FBAC0", VA = "0x1853FC6C0")]
	private byte[] ONGENMBNOAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x53FC4D0", Offset = "0x53FB8D0", VA = "0x1853FC4D0")]
	private uint[] BEBLDMGADOC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct MFCHGFFLPPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly JCKHBEJPNIO DNKDLGKCHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private byte BLPENECLMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int HJOOMNOCNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int HMJKJGLHFKE;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int BHDIBOCECJI
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677440", VA = "0x180678040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x5403750", Offset = "0x5402B50", VA = "0x185403750")]
	public MFCHGFFLPPI(in JCKHBEJPNIO DNKDLGKCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x54036E0", Offset = "0x5402AE0", VA = "0x1854036E0")]
	public bool NGAIBNDHFMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x54036B0", Offset = "0x5402AB0", VA = "0x1854036B0")]
	private bool FFAOPHBOBDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5403660", Offset = "0x5402A60", VA = "0x185403660")]
	private bool EIBBEMMGBIE()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal static class MJELJKHKIEC
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private const string NHJHBPKJOMM = "None";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private const string CFCAABKPAFO = "All";

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly StringBuilder BIOJHMCHAFL;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly string[] CIMKGILNFLJ;

	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly Dictionary<string, int> FAKPDKAJFCF;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5403B90", Offset = "0x5402F90", VA = "0x185403B90")]
	public static JCKHBEJPNIO DGCIGPCEOGA(string ECACCEGKEMA)
	{
		return default(JCKHBEJPNIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5403770", Offset = "0x5402B70", VA = "0x185403770")]
	internal static string ALGJFNADCFK(in JCKHBEJPNIO CEKMLOEJDBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5403E40", Offset = "0x5403240", VA = "0x185403E40")]
	private static Dictionary<string, int> DIPAGDILMCA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class NIHLDBECNJA
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly StringBuilder BIOJHMCHAFL;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private const string OGJJHGKDDKP = "|>";

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private const int FGBDPLICIGI = 4;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int DCFEBGLMNGI;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly IECEHJHNOCE JBJAOHOPJPK;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly IECEHJHNOCE EKPCHGPMMPH;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x54047F0", Offset = "0x5403BF0", VA = "0x1854047F0")]
	public static string BOEEOEFFBHD(in IECEHJHNOCE IGDJJEECDAF, string KAKCNEMJMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x54052C0", Offset = "0x54046C0", VA = "0x1854052C0")]
	public static string HLPKNKAGKIE(in IECEHJHNOCE IGDJJEECDAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5405410", Offset = "0x5404810", VA = "0x185405410")]
	public static IECEHJHNOCE JIDLMBGJPGN(string IGDJJEECDAF)
	{
		return default(IECEHJHNOCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x5405760", Offset = "0x5404B60", VA = "0x185405760")]
	public static string LFDDPFKHICM(in IECEHJHNOCE IGDJJEECDAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x5405010", Offset = "0x5404410", VA = "0x185405010")]
	public static IECEHJHNOCE GHDCCMEPGNK(string NANEOMELJBA)
	{
		return default(IECEHJHNOCE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x5405820", Offset = "0x5404C20", VA = "0x185405820")]
	public static (IECEHJHNOCE, string) NBGEINOEKCJ(in IECEHJHNOCE AGHIOHHDKJB, LogType? AJJOGHKEFIO, string IGDJJEECDAF, IECEHJHNOCE.FKIGFJNJGGO JMKAIGOOOKA)
	{
		return default((IECEHJHNOCE, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x5404C50", Offset = "0x5404050", VA = "0x185404C50")]
	private static bool DJKKJBGEHGA(string IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5404860", Offset = "0x5403C60", VA = "0x185404860")]
	private static (IECEHJHNOCE, string) CIBPJFNBCBB(in IECEHJHNOCE ONLEALMJJCL, LogType AJJOGHKEFIO, string IGDJJEECDAF, IECEHJHNOCE.FKIGFJNJGGO JMKAIGOOOKA)
	{
		return default((IECEHJHNOCE, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x5404CF0", Offset = "0x54040F0", VA = "0x185404CF0")]
	private static JCKHBEJPNIO FDEDLAHOIOO(ReadOnlySpan<char> LBIEEEOCGHA)
	{
		return default(JCKHBEJPNIO);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5405680", Offset = "0x5404A80", VA = "0x185405680")]
	private static IECEHJHNOCE KPDPBFBNMFH(LogType AJJOGHKEFIO)
	{
		return default(IECEHJHNOCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x5404D30", Offset = "0x5404130", VA = "0x185404D30")]
	private static (IECEHJHNOCE, string) FPHFDMFMIEJ(in IECEHJHNOCE ONLEALMJJCL, LogType AJJOGHKEFIO, string IGDJJEECDAF, IECEHJHNOCE.FKIGFJNJGGO JMKAIGOOOKA)
	{
		return default((IECEHJHNOCE, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x5404630", Offset = "0x5403A30", VA = "0x185404630")]
	private static string BOEEOEFFBHD(in JCKHBEJPNIO IGDJJEECDAF, string KAKCNEMJMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5405600", Offset = "0x5404A00", VA = "0x185405600")]
	private static void JLBLODDPJJC(in JCKHBEJPNIO IGDJJEECDAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class BFGHKIBEGKI
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly TimeZoneInfo IMKIBNHDOFB;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x53F6580", Offset = "0x53F5980", VA = "0x1853F6580")]
	public static string GPOBGFKHBGD(string KAKCNEMJMJL, LogType AJJOGHKEFIO, in IECEHJHNOCE AGHIOHHDKJB, IECEHJHNOCE.FKIGFJNJGGO JMKAIGOOOKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x53F63D0", Offset = "0x53F57D0", VA = "0x1853F63D0")]
	private static bool CEEFCHBIGDF(in IECEHJHNOCE AGHIOHHDKJB, IECEHJHNOCE.FKIGFJNJGGO JMKAIGOOOKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x53F7200", Offset = "0x53F6600", VA = "0x1853F7200")]
	private static void NLMFJCEBJIB(StringBuilder BIOJHMCHAFL, IECEHJHNOCE.FKIGFJNJGGO JMKAIGOOOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x53F6180", Offset = "0x53F5580", VA = "0x1853F6180")]
	private static void AKLHHNMOMCE(IECEHJHNOCE.FKIGFJNJGGO JMKAIGOOOKA, StringBuilder BIOJHMCHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x53F6BC0", Offset = "0x53F5FC0", VA = "0x1853F6BC0")]
	private static void HABNBABMNHN(IECEHJHNOCE.FKIGFJNJGGO JMKAIGOOOKA, StringBuilder BIOJHMCHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x53F62C0", Offset = "0x53F56C0", VA = "0x1853F62C0")]
	private static void ANPDPBCKBAD(LogType AJJOGHKEFIO, IECEHJHNOCE.FKIGFJNJGGO JMKAIGOOOKA, StringBuilder BIOJHMCHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x53F64A0", Offset = "0x53F58A0", VA = "0x1853F64A0")]
	private static void CJMKANLBPCF(IECEHJHNOCE AGHIOHHDKJB, IECEHJHNOCE.FKIGFJNJGGO JMKAIGOOOKA, StringBuilder BIOJHMCHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x53F6150", Offset = "0x53F5550", VA = "0x1853F6150")]
	private static void ADPPDBPOICD(string KAKCNEMJMJL, StringBuilder BIOJHMCHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x53F6DB0", Offset = "0x53F61B0", VA = "0x1853F6DB0")]
	private static TimeZoneInfo JFGBCNMDMDM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x726530", Offset = "0x725930", VA = "0x180726530")]
	private static bool HOICILMDNKL(IECEHJHNOCE.FKIGFJNJGGO LBABLKMFGKM, IECEHJHNOCE.FKIGFJNJGGO MGCAIGBBIIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct FMGCJPKPBOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private MFCHGFFLPPI PBKPLMFOCCI;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string BHDIBOCECJI
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x53F9510", Offset = "0x53F8910", VA = "0x1853F9510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x53F95A0", Offset = "0x53F89A0", VA = "0x1853F95A0")]
	internal FMGCJPKPBOD(in JCKHBEJPNIO DNKDLGKCHNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x53F9590", Offset = "0x53F8990", VA = "0x1853F9590")]
	public bool NGAIBNDHFMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1D58BD0", Offset = "0x1D57FD0", VA = "0x181D58BD0")]
	public FMGCJPKPBOD PEKBJENCCON()
	{
		return default(FMGCJPKPBOD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct GNJOGHCEPEP
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Obsolete]
	public ref struct DCFMMHIMAAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private ReadOnlySpan<char> CBAFCEIOCEG;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string BHDIBOCECJI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x697540", VA = "0x180698140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x53F8E10", Offset = "0x53F8210", VA = "0x1853F8E10")]
		public DCFMMHIMAAH(string KAKCNEMJMJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x53F8D00", Offset = "0x53F8100", VA = "0x1853F8D00")]
		public bool NGAIBNDHFMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x53F8BE0", Offset = "0x53F7FE0", VA = "0x1853F8BE0")]
		private ReadOnlySpan<char> KDNFHNIAFBG(ReadOnlySpan<char> LBIEEEOCGHA)
		{
			return default(ReadOnlySpan<char>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x53F8A70", Offset = "0x53F7E70", VA = "0x1853F8A70")]
		private ReadOnlySpan<char> CHBAEBDNHOP(ReadOnlySpan<char> LBIEEEOCGHA, out ReadOnlySpan<char> CBAFCEIOCEG)
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly string KAKCNEMJMJL;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x88DB80", Offset = "0x88CF80", VA = "0x18088DB80")]
	public GNJOGHCEPEP(string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x53F9680", Offset = "0x53F8A80", VA = "0x1853F9680")]
	public DCFMMHIMAAH PEKBJENCCON()
	{
		return default(DCFMMHIMAAH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class LGNIOJMMPJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly Dictionary<IECEHJHNOCE, int> IEBAIGAIDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private IECEHJHNOCE LPCODIOKJJI;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public IECEHJHNOCE NINBPOMIIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x3015210", Offset = "0x3014610", VA = "0x183015210")]
		get
		{
			return default(IECEHJHNOCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x53FF870", Offset = "0x53FEC70", VA = "0x1853FF870")]
	public LGNIOJMMPJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x53FF930", Offset = "0x53FED30", VA = "0x1853FF930")]
	public LGNIOJMMPJC(in IECEHJHNOCE AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x53FF480", Offset = "0x53FE880", VA = "0x1853FF480")]
	public void GCPLOCJIPFO(in IECEHJHNOCE AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x53FF760", Offset = "0x53FEB60", VA = "0x1853FF760")]
	public void PFAEANNIHFA(in IECEHJHNOCE AOFGAGALOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x53FF560", Offset = "0x53FE960", VA = "0x1853FF560")]
	private IECEHJHNOCE KCINIOIDPIB()
	{
		return default(IECEHJHNOCE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct OPLAPIGKHFI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly global::GFKENNHKGGN<IMOBLFIBELG> PBBLLEMFPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly global::GFKENNHKGGN<IMOBLFIBELG>.NFHIKKHOFJN GEOFHHLFPDO;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5407440", Offset = "0x5406840", VA = "0x185407440")]
	internal OPLAPIGKHFI(in IECEHJHNOCE AGHIOHHDKJB, bool POKKNFLDEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x54071C0", Offset = "0x54065C0", VA = "0x1854071C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class GFKENNHKGGN<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate T BEANOOKHKEF();

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void BFMKMAENAMC(in T PNMIIEJFOON);

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void JMKAHGOCJFB(in T? MGCMKIDFBAL, in T? FFHJDMNBFPN);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct NFHIKKHOFJN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly global::GFKENNHKGGN<T> MPOECACHGAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly bool EHIJIGGOPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly IECEHJHNOCE? MNEKFPJNBOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly T? FLMJFIEJCNP;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x3433330", Offset = "0x3432730", VA = "0x183433330")]
		public NFHIKKHOFJN(global::GFKENNHKGGN<T> KOEICPMBJFP, in IECEHJHNOCE? AOFGAGALOCP, T? PNMIIEJFOON, bool POKKNFLDEOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3433100", Offset = "0x3432500", VA = "0x183433100", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly ODINFDAPMKD IEBAIGAIDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly BEANOOKHKEF BKIKCJEOGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly BFMKMAENAMC ICHOIDGGNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly JMKAHGOCJFB IPDOHKDHGNP;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x278FC70", Offset = "0x278F070", VA = "0x18278FC70")]
	public GFKENNHKGGN(ODINFDAPMKD AOFGAGALOCP, BEANOOKHKEF GOLBPPACOIC, BFMKMAENAMC NNOIEJOPPIK, JMKAHGOCJFB NDOOOEDJDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x278FC20", Offset = "0x278F020", VA = "0x18278FC20")]
	public NFHIKKHOFJN IIEKPBCMLDL(in IECEHJHNOCE? AOFGAGALOCP, in T? PNMIIEJFOON, bool POKKNFLDEOM)
	{
		return default(NFHIKKHOFJN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface CMGAENMIIKI
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDHKDCKBDDF(string KAKCNEMJMJL);

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LCNMODMNCBM(int DEBAMGFBJEH);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNMOGLEIOOC();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string BMENDPFFAPK();

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	byte[] GKFGBFKBHAI();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class LBJELLKGLAI : CMGAENMIIKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly object NHJGDCHMPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Queue<string> NPGNGHMCGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private int KONFIAEJEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int JOMLOOEKIPB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int HEHPNMDAHOP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x698D90", Offset = "0x698190", VA = "0x180698D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x53FEE90", Offset = "0x53FE290", VA = "0x1853FEE90", Slot = "4")]
	public void DDHKDCKBDDF(string KAKCNEMJMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x53FF070", Offset = "0x53FE470", VA = "0x1853FF070", Slot = "5")]
	public void LCNMODMNCBM(int DEBAMGFBJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x53FF100", Offset = "0x53FE500", VA = "0x1853FF100")]
	private void PBDDNKJDBFC(int EJFIBLHICKO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x53FEDF0", Offset = "0x53FE1F0", VA = "0x1853FEDF0", Slot = "6")]
	public void BNMOGLEIOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x53FEBE0", Offset = "0x53FDFE0", VA = "0x1853FEBE0", Slot = "7")]
	public string BMENDPFFAPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x53FF020", Offset = "0x53FE420", VA = "0x1853FF020", Slot = "8")]
	public byte[] GKFGBFKBHAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x53FF1A0", Offset = "0x53FE5A0", VA = "0x1853FF1A0")]
	public LBJELLKGLAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct CDFOHMPFGPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly global::GFKENNHKGGN<int> PBBLLEMFPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly global::GFKENNHKGGN<int>.NFHIKKHOFJN GEOFHHLFPDO;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x53F7920", Offset = "0x53F6D20", VA = "0x1853F7920")]
	internal CDFOHMPFGPO(in IECEHJHNOCE? CIBLONIJGCG, int? DEBAMGFBJEH, bool POKKNFLDEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x53F76A0", Offset = "0x53F6AA0", VA = "0x1853F76A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Flags]
public enum NGBAJKFMIJG
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Error = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Assert = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Warning = 4,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Log = 8,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	Exception = 0x10
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class OCIHILLEKBH
{
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x5406360", Offset = "0x5405760", VA = "0x185406360")]
	public static bool DPCIJIGKNIO(this NGBAJKFMIJG AOFGAGALOCP, LogType AJJOGHKEFIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class PHGCAIBNIDF
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[OBCGLNMHEMP]
	public interface NMBEEGBCKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JCMJMLAJPBP(IECEHJHNOCE FDNOKENEOPG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class DIMBCBGGAPL : NMBEEGBCKAA
	{
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public static readonly DIMBCBGGAPL KGKEDLDKCKD;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		private DIMBCBGGAPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
		public void JCMJMLAJPBP(IECEHJHNOCE FDNOKENEOPG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class HOKKKJPLCHF
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[OBCGLNMHEMP]
	public interface EOMABOAELPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MGBICODKPBK(AGMGIMOIAEN CAKABFDHMJN, string MPKBKIOONCO);

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable KGAEJGHONPP(AGMGIMOIAEN CAKABFDHMJN, string HKIOOIAAIPL);
	}

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static EOMABOAELPG PLDEBFMNDPG;

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x53F9A40", Offset = "0x53F8E40", VA = "0x1853F9A40")]
	[Conditional("ENABLE_PLATFORM_NATIVE_PROFILER")]
	public static void MCHKJMFLFEN(EOMABOAELPG MHCCDFMDJCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x53F9860", Offset = "0x53F8C60", VA = "0x1853F9860")]
	[Conditional("ENABLE_PLATFORM_NATIVE_PROFILER")]
	public static void HHCHHGIDHHK(string MPKBKIOONCO, AGMGIMOIAEN CAKABFDHMJN = AGMGIMOIAEN.General)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x53F9940", Offset = "0x53F8D40", VA = "0x1853F9940")]
	[Conditional("ENABLE_PLATFORM_NATIVE_PROFILER")]
	public static void JDLICCKBJOE(string HKIOOIAAIPL, ref IDisposable AABPMFLKFCF, AGMGIMOIAEN CAKABFDHMJN = AGMGIMOIAEN.General)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum AGMGIMOIAEN
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	General,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Frame,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	RecNet,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	BestHTTP,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	JSON,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	BootSequence,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Async,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	Fade,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	PhotonRegion,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	PhotonRoomJoin,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	TitleScreen
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class KKOBNOKBGDO : ILogHandler
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private readonly struct KGADKAIBGJN : IEquatable<KGADKAIBGJN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public readonly LogType FLLPEJFJBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly UnityEngine.Object PFGJKMKBHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public readonly string GDJFNMEAMHI;

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x729D00", Offset = "0x729100", VA = "0x180729D00")]
		public KGADKAIBGJN(LogType AJJOGHKEFIO, UnityEngine.Object GKMHGIGLKCO, string KAKCNEMJMJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x53FC890", Offset = "0x53FBC90", VA = "0x1853FC890", Slot = "4")]
		public bool Equals(KGADKAIBGJN JLBINKLPHKJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private readonly struct EDKFBHNPPLL : IEquatable<EDKFBHNPPLL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public readonly Exception LBKKPHDAGFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public readonly UnityEngine.Object PFGJKMKBHDE;

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x728A10", Offset = "0x727E10", VA = "0x180728A10")]
		public EDKFBHNPPLL(Exception GHBHEEBHPAJ, UnityEngine.Object GKMHGIGLKCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x53F9160", Offset = "0x53F8560", VA = "0x1853F9160", Slot = "4")]
		public bool Equals(EDKFBHNPPLL JLBINKLPHKJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class HKFJLFEFDBN : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x53F97E0", Offset = "0x53F8BE0", VA = "0x1853F97E0")]
		public HKFJLFEFDBN(string KAKCNEMJMJL, Exception GKFIKAGHEFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class EGMFNDBFFNC : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x53F9270", Offset = "0x53F8670", VA = "0x1853F9270")]
		public EGMFNDBFFNC(string KAKCNEMJMJL, Exception GKFIKAGHEFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class ILKDDCEIJJD : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x53FB9C0", Offset = "0x53FADC0", VA = "0x1853FB9C0")]
		public ILKDDCEIJJD(string KAKCNEMJMJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x53FB940", Offset = "0x53FAD40", VA = "0x1853FB940")]
		public ILKDDCEIJJD(string KAKCNEMJMJL, Exception GKFIKAGHEFN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly object NHJGDCHMPBG;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private const float KBBGPMHBJCB = 6f;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private const int PLNDPIONFOF = 180;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private const int GANKHLLHIMI = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly ILogHandler KNLKCBLPING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private IDisposable FFPNBFDFGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private int JBMLFCLKIID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int IKAHKAPCPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private KGADKAIBGJN? JLABEFCNBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private int NCLHJBLEIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private EDKFBHNPPLL? HNGFICBIBFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private int AOOAMMHHLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private bool NCFLAPIBDMB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool OFCIHJFJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x960680", Offset = "0x95FA80", VA = "0x180960680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x9606B0", Offset = "0x95FAB0", VA = "0x1809606B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x53FEB50", Offset = "0x53FDF50", VA = "0x1853FEB50")]
	public KKOBNOKBGDO(ILogHandler KNLKCBLPING)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x53FCBD0", Offset = "0x53FBFD0", VA = "0x1853FCBD0")]
	public void BNBDPGMNFMF(bool KBDPFLOCJFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x53FD1A0", Offset = "0x53FC5A0", VA = "0x1853FD1A0")]
	private void FNJAICIKNMH(float FAHGJOEFBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x53FD9B0", Offset = "0x53FCDB0", VA = "0x1853FD9B0", Slot = "5")]
	public void LogException(Exception GHBHEEBHPAJ, UnityEngine.Object GKMHGIGLKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x53FCF50", Offset = "0x53FC350", VA = "0x1853FCF50")]
	private void DBOAHLMBLJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x53FDF50", Offset = "0x53FD350", VA = "0x1853FDF50", Slot = "4")]
	public void LogFormat(LogType AJJOGHKEFIO, UnityEngine.Object GKMHGIGLKCO, string AAKPIPNIBLA, params object[] MMLIFJCNOMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x53FE690", Offset = "0x53FDA90", VA = "0x1853FE690")]
	private void OKFFEJGHJMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x53FD5C0", Offset = "0x53FC9C0", VA = "0x1853FD5C0")]
	public static Exception JGCLEMMHLKB(Exception GHBHEEBHPAJ, string KAKCNEMJMJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x53FCAA0", Offset = "0x53FBEA0", VA = "0x1853FCAA0")]
	private static string BDICEEBMLAA(Exception GHBHEEBHPAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x53FC9B0", Offset = "0x53FBDB0", VA = "0x1853FC9B0")]
	private static bool AGELIGAAKEA(Exception GHBHEEBHPAJ, StringBuilder BIOJHMCHAFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x53FD4B0", Offset = "0x53FC8B0", VA = "0x1853FD4B0")]
	[Conditional("UNITY_EDITOR")]
	private static void HDAHOECCOLD(LogType FPPBLNEEHBP, object KAKCNEMJMJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct DIONNCNIINH<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly Action<T> GKDAJBJDGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly T EMCJDFHKAFD;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x2801C40", Offset = "0x2801040", VA = "0x182801C40")]
	public DIONNCNIINH(Action<T> GKDAJBJDGBP, T EMCJDFHKAFD, T ADNCLAHHBEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x2801AE0", Offset = "0x2800EE0", VA = "0x182801AE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct LONCFDFLFFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly global::GFKENNHKGGN<IMOBLFIBELG> PBBLLEMFPAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly global::GFKENNHKGGN<IMOBLFIBELG>.NFHIKKHOFJN GEOFHHLFPDO;

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x53FFC90", Offset = "0x53FF090", VA = "0x1853FFC90")]
	internal LONCFDFLFFP(in IECEHJHNOCE AGHIOHHDKJB, bool POKKNFLDEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x53FFA10", Offset = "0x53FEE10", VA = "0x1853FFA10", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class ThreadSafeTimeUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5407570", Offset = "0x5406970", VA = "0x185407570")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x54076E0", Offset = "0x5406AE0", VA = "0x1854076E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xEE3F40", Offset = "0xEE3340", VA = "0x180EE3F40")]
		public ThreadSafeTimeUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[Flags]
public enum KHJIGBJHMOB
{
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Unity = 1,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Error = 2,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Warning = 3,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	Debug = 4,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	PUNNetworkManager = 5,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	PhotonRpcs = 6,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	PhotonCustomProperties = 7,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	PhotonOwnership = 8,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	PhotonNetworkInstantiate = 9,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	PhotonCreateAndDestroy = 0xA,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	PhotonNetwork = 0xB,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	SynchronizedFields = 0xC,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	UJect = 0xD,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RoomLoad = 0xE,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	RecNet = 0xF,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	ObjectModel = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	CircuitsV2DebugLogNode = 0x11,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	CircuitsV2Reduce = 0x12,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	CircuitsV2RecRoomIntegration = 0x13,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	CircuitsV2Lifecycle = 0x14,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	CircuitsV2Visualization = 0x15,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	CircuitsV2Heat = 0x16,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	CircuitsV2Memory = 0x17,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	CircuitsV2CloudData = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	CircuitsV2Environments = 0x19,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	CircuitsV2EventBus = 0x1A,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	CircuitsV2Graph = 0x1B,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	CircuitsV2Root = 0x1C,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	CircuitsV2State = 0x1D,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	RoomReset = 0x1E,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	UgcWatchdog = 0x1F,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	AvatarLod = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	HashCheck = 0x21,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	ConvexHullGeneration = 0x22,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	SpawnableToolInstantiate = 0x23,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	BufferedEventHelper = 0x24,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	BufferedEventHelperSendRecv = 0x25,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	PhotonClient = 0x26,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	RoomManager = 0x27,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	QuestManager = 0x28,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	RoomOperation = 0x29,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	BigDataTrackedObject = 0x2A,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	LoadingScreen = 0x2B,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	PersistenceView = 0x2C,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	MakerPen = 0x2D,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Autosave = 0x2E,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Connectables = 0x2F,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	PlayerLoopInjector = 0x30,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	Tags = 0x31,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	Patching = 0x32,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LogGameObjectAddComponentPatch = 0x33,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LogTransformSetPositionPatch = 0x34,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LogTransformSetRotationPatch = 0x35,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LogTransformSetLocalPositionPatch = 0x36,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	LogTransformSetLocalRotationPatch = 0x37,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	LogTransformSetLocalScalePatch = 0x38,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	LogTransformSetParentPatch = 0x39,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	LogGameObjectDestroyPatch = 0x3A,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	LogTaskCancelPatch = 0x3B,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	LogCancellationTokenSourceDisposePatch = 0x3C,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	ImageCompression = 0x3D,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	COUNT = 0x3E,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	All = -2
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class NLJAGALCJKH
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static byte[] JCLCDCCNAPM;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static int BKAHGFCDIKL;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static int GJMNCFGIJLO;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static BigInteger MOEAOMJCPNL;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NLJAGALCJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x5405B40", Offset = "0x5404F40", VA = "0x185405B40")]
	private static string EMKPABEMONO(byte[] IKDBBHHKFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x5405C50", Offset = "0x5405050", VA = "0x185405C50")]
	public static string NJEIEMNKMPN(byte[] EEMDNKKFCBK, bool DIMJIPPBEJB)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
