using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Logging;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_NoEngine_Logging_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8674EE0", Offset = "0x86734E0", VA = "0x188674EE0", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public readonly struct Log
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly Log Invalid;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD991D0", Offset = "0xD977D0", VA = "0x180D991D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool YPHBRAPPLRV
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8676480", Offset = "0x8674A80", VA = "0x188676480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KDTGETGRUAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x86777E0", Offset = "0x8675DE0", VA = "0x1886777E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string XJWRXVLQQQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x86772D0", Offset = "0x86758D0", VA = "0x1886772D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool HFYUEIOIRYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x549BD10", Offset = "0x549A310", VA = "0x18549BD10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel KDPNPQISWZF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8676410", Offset = "0x8674A10", VA = "0x188676410")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8677AE0", Offset = "0x86760E0", VA = "0x188677AE0")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x15F4A80", Offset = "0x15F3080", VA = "0x1815F4A80")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8677B40", Offset = "0x8676140", VA = "0x188677B40")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x39DF2C0", Offset = "0x39DD8C0", VA = "0x1839DF2C0")]
		public void FZZSIHJTLRU<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8676760", Offset = "0x8674D60", VA = "0x188676760")]
		public void FZZSIHJTLRU(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8676660", Offset = "0x8674C60", VA = "0x188676660")]
		public void FZZSIHJTLRU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8676540", Offset = "0x8674B40", VA = "0x188676540")]
		public void DHNCGRJZIKZ(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x39E0450", Offset = "0x39DEA50", VA = "0x1839E0450")]
		public void KMVJMNBSKBE<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8676DF0", Offset = "0x86753F0", VA = "0x188676DF0")]
		public void KMVJMNBSKBE(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8676CF0", Offset = "0x86752F0", VA = "0x188676CF0")]
		public void KMVJMNBSKBE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x39E4670", Offset = "0x39E2C70", VA = "0x1839E4670")]
		public void ZAQNXNDUXLX<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8677940", Offset = "0x8675F40", VA = "0x188677940")]
		public void ZAQNXNDUXLX(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8677830", Offset = "0x8675E30", VA = "0x188677830")]
		public void ZAQNXNDUXLX(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x39E39A0", Offset = "0x39E1FA0", VA = "0x1839E39A0")]
		public void XPCLCMOKABS<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8677610", Offset = "0x8675C10", VA = "0x188677610")]
		public void XPCLCMOKABS(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8677700", Offset = "0x8675D00", VA = "0x188677700")]
		public void XPCLCMOKABS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x39E0C40", Offset = "0x39DF240", VA = "0x1839E0C40")]
		public void OOLPSUYYUHF<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8676FF0", Offset = "0x86755F0", VA = "0x188676FF0")]
		public void OOLPSUYYUHF(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8676F10", Offset = "0x8675510", VA = "0x188676F10")]
		public void OOLPSUYYUHF(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x39E1410", Offset = "0x39DFA10", VA = "0x1839E1410")]
		public void ORYRHKHQPYQ<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86771D0", Offset = "0x86757D0", VA = "0x1886771D0")]
		public void ORYRHKHQPYQ(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86770F0", Offset = "0x86756F0", VA = "0x1886770F0")]
		public void ORYRHKHQPYQ(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86764D0", Offset = "0x8674AD0", VA = "0x1886764D0")]
		public void BVXGPMPRRRR(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8677A70", Offset = "0x8676070", VA = "0x188677A70")]
		public void ZGVRDXDVFYM(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x39DBC20", Offset = "0x39DA220", VA = "0x1839DBC20")]
		public LogRangeScope AXDDWWMWFFB<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740")]
		public LogRangeScope AKJZPMZFBHA<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86762F0", Offset = "0x86748F0", VA = "0x1886762F0")]
		public LogRangeScope AXDDWWMWFFB(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86761F0", Offset = "0x86747F0", VA = "0x1886761F0")]
		public LogRangeScope AXDDWWMWFFB(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x114B740", Offset = "0x1149D40", VA = "0x18114B740")]
		public LogRangeScope AKJZPMZFBHA(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8677530", Offset = "0x8675B30", VA = "0x188677530")]
		public void RGKDMJVRGSP(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8677320", Offset = "0x8675920", VA = "0x188677320")]
		public void RGKDMJVRGSP(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x39E1B20", Offset = "0x39E0120", VA = "0x1839E1B20")]
		public void RGKDMJVRGSP<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		public void JYGOQTNUAFG([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8676870", Offset = "0x8674E70", VA = "0x188676870")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8676990", Offset = "0x8674F90", VA = "0x188676990")]
		private static void HRVKURXPOSI(Exception a, StringBuilder b, int c = 0, int d = 5)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class Logs
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public static class Teams
		{
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public static readonly Log TXDHZBVBSPA;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log OEHAGTMBKLP;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log IOXDTXJSULT;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log UJGCASDYTAW;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log EPIXYLBKGFW;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log HXAPQILGWDK;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log RAIPYAWGYFZ;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log EWGUUSQHSJK;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log SQLZXLGSGZX;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log AZELNYFNGCA;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log HFUELABDUTE;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log SDWWEPHBEXA;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log HVBCQITNISU;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log DXCCKEOITUJ;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log WZRAVERQQUL;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log OVUKEJZHHSD;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log NJNBTJGVRJD;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log IMQPTANLMLY;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log XMZKIZEXMRT;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log VHBKRRTDFCD;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log XEOLJIONTFD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class AI
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public static class MakerAI
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public static class Command
				{
					[Cpp2IlInjected.Token(Token = "0x4000021")]
					public static readonly Log RVMSQUHBYPN;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log LZCVIPRGCVZ;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log RVMSQUHBYPN;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log ISKYHZDXYXL;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log GXYXDGIAFRC;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log YFAZLZAVMNM;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log YZXEMOVHUBO;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log WUGLDJPECNM;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log JOAWPPPAQSO;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log RVMSQUHBYPN;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log ISKYHZDXYXL;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log YFAZLZAVMNM;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log YZXEMOVHUBO;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log KYHNRSXWEET;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log CMGTIFCPSNY;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log EJCOEPHVVBM;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log RVMSQUHBYPN;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log RCUSVJUGCDS;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log HCIYNLLQHIZ;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log RVMSQUHBYPN;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log TVIVLKYXMAT;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log TVDOOEFACPK;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log TVTJFYMSEXL;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log TVOCIRSUVMC;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log TWDXAMAMXUD;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log TVYQDFGPOIU;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log TWOKUZOHQQV;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log TWJDXSUKHFM;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log TTSSHIVSONZ;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log TTNLKCBVFCQ;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log RVMSQUHBYPN;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log TVIVLKYXMAT;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log TVDOOEFACPK;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log TVTJFYMSEXL;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log TVOCIRSUVMC;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log TWDXAMAMXUD;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log TVYQDFGPOIU;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log TWOKUZOHQQV;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log TWJDXSUKHFM;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log TTSSHIVSONZ;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log TTNLKCBVFCQ;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log RVMSQUHBYPN;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log YGNYQXARVVF;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log JIVXCCICLUR;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log NRPMJKIMDBH;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log QFGWVFLSPFL;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log RVMSQUHBYPN;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log SKSHYJAMOVY;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log XJAKWCWORKE;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log JBYHTSJFMBL;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log VKXVTILIBVE;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log MSRVYCZPFZH;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log VRBWJNCXPWH;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log RVMSQUHBYPN;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log JUIYCNBDJOP;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log FDMMNWSTGJH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log JMMVZBZMLHI;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log ZFVYVWDYXBN;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log QDIQSSKNTSP;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log DNCPISWUAPB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log ZAQWNLJKSRF;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log MXRVJEJOQCM;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log CWPNUGRFVKT;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log EIEFMZKSIFL;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log XLSSPQZATHQ;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log ZCBPCWQXDPC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log HQBCOEEFSZL;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log YXLIGAWACYE;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log LOBWCXIZZSM;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log QQRSZIALNAH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log KQXHVXSELYF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log TMXMQOHXKLV;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log RGYFOGEXPCD;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log EIEFMZKSIFL;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log OMDBFQTMPAV;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log XEOLJIONTFD;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log BNKXABYZUEJ;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log LLIMEFCABIE;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log MSRVYCZPFZH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log RVMSQUHBYPN;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log MVQOYMWCMDL;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log PXNOBKRQALW;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log IVMKQOKZCMR;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log WNIMSIGYMVO;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log EIEFMZKSIFL;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log ZNEGJOOJJIJ;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log OXNIRNUMPSL;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log WOTHACPTZZM;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log EMPVPBWHBGM;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log RDVUTTQUSWM;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log EUJKHIDPOVA;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log WNAJIRWLXPA;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log IOBWTOXMXSU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log RUEITTZULRT;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log EIEFMZKSIFL;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log QJZSGSDWWKV;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log NMVNDGNXREW;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log LZWOTJFLROT;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log JQWWSEJKWVU;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log EKNGNMIJTZT;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log AINXHUMZSEN;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log WRWQZDWGDSZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log GPLFACXAGGK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x4000089")]
				private static readonly Log PBBTIUZEHMH;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008A")]
				public static readonly Log RVMSQUHBYPN;

				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public static readonly Log WQOLOGOHZLZ;

				[Cpp2IlInjected.Token(Token = "0x400008C")]
				public static readonly Log MLMMXYVGPMF;

				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log QNSQZOIRSEX;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log KOFBZOFSLYS;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log YYUUULXZMMH;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log CLZYXZNURRQ;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log ZWLESBFVDGM;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log WADLWQAESWG;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log AZELNYFNGCA;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log KYHNRSXWEET;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log TECICHDQTYZ;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log BSUKQQMCKCK;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log KXNQQKPTVYU;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log UMKZFYAKISJ;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log BLPUYGANOTO;
			}

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly Log RVMSQUHBYPN;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A2")]
				public static readonly Log RVMSQUHBYPN;

				[Cpp2IlInjected.Token(Token = "0x40000A3")]
				public static readonly Log XPTDRUTORDT;

				[Cpp2IlInjected.Token(Token = "0x40000A4")]
				public static readonly Log MWGNQAXVUUV;

				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log BYWISIGZRAP;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log UXMXRKVULSF;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B2")]
					private static readonly Log PBBTIUZEHMH;

					[Cpp2IlInjected.Token(Token = "0x40000B3")]
					public static readonly Log INBJZBHFPPS;

					[Cpp2IlInjected.Token(Token = "0x40000B4")]
					public static readonly Log MMYJVMLYWSB;

					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					public static readonly Log ZVHPKUPTOTY;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log RASZMOJNVRE;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log HXAQCWOARRG;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log BYWISIGZRAP;

					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public static readonly Log YLEZDYLSAPO;
				}

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log RVMSQUHBYPN;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log CXHGTZWHXBM;

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log FUYKCJOFOZX;

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log RBNZIAJPIGA;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log DMBZHFVHQET;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log MWGNQAXVUUV;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log OOUGPDUSRBH;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log BDCXDYVWOFK;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log YONRDBRRPJT;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log WESVGUNILAG;

				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public static readonly Log DLBWUKHSYAN;
			}

			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public static readonly Log RVMSQUHBYPN;

			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public static readonly Log YRNHEPHAWQL;

			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public static readonly Log CALWQRVVGOE;

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log WRCJNMBHEON;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log XEWKTXONTKP;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log KLCYHFGVEOP;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log KOFZNJBGAUY;

			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly Log AMCBZXTEMWQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public static readonly Log RVMSQUHBYPN;

				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public static readonly Log ZMXSIVIJAFG;

				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public static readonly Log HJJAGRUOGFT;

				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log UJTNXJDVQLF;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log OZGNBXZNZFB;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log RPMVHKHNXFE;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log OWICGUNRGXK;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log TVGLOSMGXEJ;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log QPPJNPUZBDR;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log MBVGYCWGBBQ;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log MRGQBIUJNME;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log MRBXMNIAJVH;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log CNUMLIPBXOA;

				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log OQHMIITGIJI;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log RVMSQUHBYPN;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log CTGILCMLSLY;

				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log MMRTNTCLZJM;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class ZQHFWTSXVKB
			{
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log RVMSQUHBYPN;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log KEFDUOUDZBO;

				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log NICRBYRQZPC;

				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public static readonly Log ESMBKFTXJXH;
			}

			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public static readonly Log RVMSQUHBYPN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public static readonly Log GYAFUZJJZOF;

			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public static readonly Log WLGUDDUQXTQ;

			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public static readonly Log FXQJUGMSSBD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public static readonly Log KERQSKZUDLR;

			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly Log VVWCIPCROMT;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log BLPUYGANOTO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log RVMSQUHBYPN;

			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log LFGVMFWTDEZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public static readonly Log RVMSQUHBYPN;

			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public static readonly Log HQVEWWMQJQL;

			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public static readonly Log FNFGNJJNJMW;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public static readonly Log RVMSQUHBYPN;

			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public static readonly Log IAICYNJCVXA;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log ZQLBJPQBYKN;

			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log QWLVCBOEDKL;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log VDQCZZZDVQV;

			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log IYKTMDDYQCL;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log UTYDMUUKBXW;

			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log PGEQWGZLXRP;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log FUFEVNEQNYV;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log EIEFMZKSIFL;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log CCJOXJHXCBI;

			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log TCZAJMILSXE;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log MTXRAKVHSFG;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log AQPLBNGJIAU;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log ZQHCDDQXYBW;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log XVNNBSUKNCE;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log SRCNNFGUBKL;

			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log WEIITPIJOLN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log RVMSQUHBYPN;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log UJGCASDYTAW;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log IFZGFYFVBWZ;

			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log VBFPWVXLAKS;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log ECQANZPTYJL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly Log UXWFOINKKZO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly Log GOWDBLTHTHS;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log YBHMLEGXRNF;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly Log KPRYEOHNPHA;

			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log DNFIPIEVXHZ;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log MYBBJGRORFJ;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log EEFIZGNBBJJ;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log GPVQGMNTNPR;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log OSWRJJFRLZJ;

			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public static readonly Log UWUISCKTQZL;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log XLQLONNBPZM;

			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly Log EIZBFATROEL;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log PULXMTOOZSG;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log GQBYZINGTTX;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log ATTLEFYDVKO;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log XLSRABGDNAE;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log EJCOEPHVVBM;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public static readonly Log RVMSQUHBYPN;

				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public static readonly Log PHSSOMXKCXT;

				[Cpp2IlInjected.Token(Token = "0x4000113")]
				public static readonly Log EUZOALFCQWQ;
			}

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private static readonly Log RVMSQUHBYPN;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log EHFUSPAQIMN;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log IXEWYKBDWWZ;

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly Log WVOWTETYNIA;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log LUTRIBKQFNL;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log KHJIYQKZPHP;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log XFBCTOAIWKB;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log WVLAVUSMWHB;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log YDVVRAJNQKT;

			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly Log HDAVWWNBRJZ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private static readonly Log PBBTIUZEHMH;

			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public static readonly Log TPBHKMBBSXT;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public static readonly Log RVMSQUHBYPN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public static readonly Log RVMSQUHBYPN;

			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log QVYDGBYSRKN;

			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log TRTHBLUNWEB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly Log RVMSQUHBYPN;

			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public static readonly Log BPGBCZKTGOP;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class UXRGCJTXILI
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public class PCQUEUKYBYS : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private readonly (int index, bool enabled)[] FJOIUDFERPR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private List<(int index, bool enabled)> APANAXQECAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private bool VCUGZDPNRYZ;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x86785B0", Offset = "0x8676BB0", VA = "0x1886785B0")]
			internal PCQUEUKYBYS((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8678530", Offset = "0x8676B30", VA = "0x188678530")]
			public IDisposable PETIJSBIODU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8678480", Offset = "0x8676A80", VA = "0x188678480", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class HDCSRCGKRMP
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private static readonly Log PBBTIUZEHMH;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public static readonly Log GITKTHCBKBD;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly Log WLOROVRWZOY;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly Log FIFMVXWDUFN;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly Log XSZAFVVIFCX;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static readonly Log BVGIESSZQGB;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static readonly Log ZAJOIVCZGGE;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static readonly Log YBHMLEGXRNF;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly Log GIEBQBGSVOX;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly Log FXDLBESABMV;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly Log IXIYPFFXAJN;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly Log BKNLTQGINMK;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly Log CMLBPXWYNGF;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log KFDDCOLLBDA;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log ZPBDJSXJHUF;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log GOFXAZPXOER;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log LEFVWSBWPYW;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log MYBBJGRORFJ;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log AABYERRUSBT;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log NNAFRWSLDMU;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log AEFQZYOZFDZ;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log AZELNYFNGCA;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log WWYGREKXUHW;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log MMQZIZMISGN;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log NVPECQVZKQC;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log RDNZNGUBKGY;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log UZACZWBIAFS;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log AIPCDLMXYVK;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log JSZEHKOAGKP;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log SIHZEQOTOQW;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log XDZXJNOLBEF;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log IMBZCCUJAUO;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log FQVQRCDSMYR;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log TEVJNVAFKZE;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log DUKOPENFKXD;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log GXYXDGIAFRC;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log XXDLBDNZGJS;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log OZMFTIHEYRK;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log DGOKCCKYFMM;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log JEPHGUAPVWD;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log RWKMARPRISL;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log AZJJHJHTXNX;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log OWWWGZCYLGC;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log CTCNEFVPBQV;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log QTCPOIPBOAU;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log TPPNJBNGUWQ;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Log AEHGBSBSFTN;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Log EQZBFVZFLTS;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log SQPRCLFLRYA
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8673440", Offset = "0x8671A40", VA = "0x188673440")]
			get
			{
				return default(Log);
			}
		}
	}
}
namespace RecRoom.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal class UJMGTECKRRG
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private UJMGTECKRRG parent;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
			public Scope(UJMGTECKRRG parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private readonly Stopwatch RBVGTTLJPBN;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x153BCA0", Offset = "0x153A2A0", VA = "0x18153BCA0")]
		public Scope MSXNPUWSKNG()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x867C080", Offset = "0x867A680", VA = "0x18867C080")]
		public UJMGTECKRRG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface SYDUYQNDTEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FZZSIHJTLRU(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void KMVJMNBSKBE(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void XPCLCMOKABS(object a, [Optional] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct LogRangeScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly object message;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8674E40", Offset = "0x8673440", VA = "0x188674E40")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8674DD0", Offset = "0x86733D0", VA = "0x188674DD0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[Preserve]
	public abstract class LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void KQPXXDZDTRT();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class VULQTIIOOJY
	{
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private static List<LogRegistrationIndex> HFNFCRVGOOR;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private static bool WRTFZCYHOHA;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private static readonly object ENOKYUPHHLT;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> DXXPMGDNOKB
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x867C530", Offset = "0x867AB30", VA = "0x18867C530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x867C3C0", Offset = "0x867A9C0", VA = "0x18867C3C0")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x867C570", Offset = "0x867AB70", VA = "0x18867C570")]
		private static void ZVFBIRJSSID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x867C180", Offset = "0x867A780", VA = "0x18867C180")]
		private static void FXWHPHJXGQM(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class EKZJJERWPYF
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
			public void IUQUATTXSIX(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
			public ParanoiaLevel NCKEJMSOCZB(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static Action KGMWYKNRLWM;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly object FEGPPPJJWKA;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static readonly Dictionary<(int parentIndex, string token), int> BLHPJTKWVPA;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly List<string> ENOPNXTPMBI;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly List<int> IESXEYDLKXV;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly List<ulong> LZLKKCEFRSD;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly List<ulong> OLYNDQFJAQU;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly List<ulong> VDCAWFYQQMH;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly StringBuilder VAWYODTZVKJ;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly UJMGTECKRRG TYIPCZXJUDT;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static Debug YVGJTYCMUZF;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static int OAWLTCIQUCN;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static SYDUYQNDTEP HYODHPLVJJW
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x866FCD0", Offset = "0x866E2D0", VA = "0x18866FCD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8670160", Offset = "0x866E760", VA = "0x188670160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool NOCHKUFMJHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x866E940", Offset = "0x866CF40", VA = "0x18866E940")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool LAUQEVUVTGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x86709F0", Offset = "0x866EFF0", VA = "0x1886709F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool QZTFXVJHYYC
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x866F760", Offset = "0x866DD60", VA = "0x18866F760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8671880", Offset = "0x866FE80", VA = "0x188671880")]
		static EKZJJERWPYF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x866FAC0", Offset = "0x866E0C0", VA = "0x18866FAC0")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x866FD20", Offset = "0x866E320", VA = "0x18866FD20")]
		public static int KQPXXDZDTRT(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x866FEC0", Offset = "0x866E4C0", VA = "0x18866FEC0")]
		public static int KQPXXDZDTRT(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x86717C0", Offset = "0x866FDC0", VA = "0x1886717C0")]
		public static Log XTYYQLAKLBN(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8670B00", Offset = "0x866F100", VA = "0x188670B00")]
		public static void SPYKLVYKRSA(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x866EEE0", Offset = "0x866D4E0", VA = "0x18866EEE0")]
		public static void GWMQKLIZTCN(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x86700E0", Offset = "0x866E6E0", VA = "0x1886700E0")]
		public static bool LDEIRIBNIUJ(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x866FF90", Offset = "0x866E590", VA = "0x18866FF90")]
		public static int KZZZHVTEZNS(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x86705F0", Offset = "0x866EBF0", VA = "0x1886705F0")]
		public static string QUALMZDCBLB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8670850", Offset = "0x866EE50", VA = "0x188670850")]
		public static (string[], int[]) RCPPJEHNPAA()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x866F9A0", Offset = "0x866DFA0", VA = "0x18866F9A0")]
		private static int IVJEDJQCNNO(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x86704E0", Offset = "0x866EAE0", VA = "0x1886704E0")]
		private static int OHSVNFQLMYC(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8671280", Offset = "0x866F880", VA = "0x188671280")]
		private static int XROFNOIPJRA(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x866EB60", Offset = "0x866D160", VA = "0x18866EB60")]
		private static int DWWSJCJCXNL(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x866E990", Offset = "0x866CF90", VA = "0x18866E990")]
		private static int DWWSJCJCXNL(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x866F7F0", Offset = "0x866DDF0", VA = "0x18866F7F0")]
		private static void IEUUAGTKPSQ(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8670A40", Offset = "0x866F040", VA = "0x188670A40")]
		public static bool RRACMKYWFEY(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x866ECB0", Offset = "0x866D2B0", VA = "0x18866ECB0")]
		public static bool EBEZRQJEXGT(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x866F0F0", Offset = "0x866D6F0", VA = "0x18866F0F0")]
		public static void IAOUYUCGUQZ(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8670ED0", Offset = "0x866F4D0", VA = "0x188670ED0")]
		public static void WJDRSZEJZZU(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8670590", Offset = "0x866EB90", VA = "0x188670590")]
		private static void QGUBMFBVAAX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8670210", Offset = "0x866E810", VA = "0x188670210")]
		private static void NJYHWZMBCXU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x866F620", Offset = "0x866DC20", VA = "0x18866F620")]
		private static bool IBLLXZSXTLN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8670D80", Offset = "0x866F380", VA = "0x188670D80")]
		private static bool UMSHJJGARPA(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x866EC30", Offset = "0x866D230", VA = "0x18866EC30")]
		private static bool DYAODMMLNYU(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8670CC0", Offset = "0x866F2C0", VA = "0x188670CC0")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8671810", Offset = "0x866FE10", VA = "0x188671810")]
		private static void ZEFGOOGWKFK(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x866ED70", Offset = "0x866D370", VA = "0x18866ED70")]
		public static UXRGCJTXILI.PCQUEUKYBYS GLEAYJPKMKK((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x866F960", Offset = "0x866DF60", VA = "0x18866F960")]
		public static void IUQUATTXSIX(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x86701D0", Offset = "0x866E7D0", VA = "0x1886701D0")]
		public static ParanoiaLevel NCKEJMSOCZB(int a)
		{
			return default(ParanoiaLevel);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum ParanoiaLevel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		FastDebug,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		Debug,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Paranoid,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		SuperParanoid,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		MassivelyParanoid
	}
}
namespace RecRoom.Logging.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[Obfuscation(Exclude = true)]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public PreserveAttribute()
		{
		}
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
