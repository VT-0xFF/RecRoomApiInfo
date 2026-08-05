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
		[Cpp2IlInjected.Address(RVA = "0x9B06790", Offset = "0x9B05190", VA = "0x189B06790", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
			[Cpp2IlInjected.Address(RVA = "0xF7A900", Offset = "0xF79300", VA = "0x180F7A900")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool EWYTUNKVBLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9B09370", Offset = "0x9B07D70", VA = "0x189B09370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CMHSJSPGFUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9B093C0", Offset = "0x9B07DC0", VA = "0x189B093C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string HMETGHEOROT
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9B07B20", Offset = "0x9B06520", VA = "0x189B07B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool SFWGMFEBQCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6A4D150", Offset = "0x6A4BB50", VA = "0x186A4D150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel TQWMFDCWDPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9B07EA0", Offset = "0x9B068A0", VA = "0x189B07EA0")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9B09410", Offset = "0x9B07E10", VA = "0x189B09410")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x15FBC00", Offset = "0x15FA600", VA = "0x1815FBC00")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B09470", Offset = "0x9B07E70", VA = "0x189B09470")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3C31180", Offset = "0x3C2FB80", VA = "0x183C31180")]
		public void DPMSSQUUFGW<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9B07C70", Offset = "0x9B06670", VA = "0x189B07C70")]
		public void DPMSSQUUFGW(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9B07B70", Offset = "0x9B06570", VA = "0x189B07B70")]
		public void DPMSSQUUFGW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A9D0", Offset = "0x3C393D0", VA = "0x183C3A9D0")]
		public void XQEFUOCZFXP<d>(bool a, Func<d, object> b, [In] d args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9B09250", Offset = "0x9B07C50", VA = "0x189B09250")]
		public void XQEFUOCZFXP(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A190", Offset = "0x3C38B90", VA = "0x183C3A190")]
		public void WYNAKPRZUYS<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9B09030", Offset = "0x9B07A30", VA = "0x189B09030")]
		public void WYNAKPRZUYS(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9B09150", Offset = "0x9B07B50", VA = "0x189B09150")]
		public void WYNAKPRZUYS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C36400", Offset = "0x3C34E00", VA = "0x183C36400")]
		public void TXWNEVJNALX<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9B08BA0", Offset = "0x9B075A0", VA = "0x189B08BA0")]
		public void TXWNEVJNALX(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9B08CD0", Offset = "0x9B076D0", VA = "0x189B08CD0")]
		public void TXWNEVJNALX(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3C342B0", Offset = "0x3C32CB0", VA = "0x183C342B0")]
		public void LIBCEQYQFAM<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9B083C0", Offset = "0x9B06DC0", VA = "0x189B083C0")]
		public void LIBCEQYQFAM(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9B082E0", Offset = "0x9B06CE0", VA = "0x189B082E0")]
		public void LIBCEQYQFAM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C399B0", Offset = "0x3C383B0", VA = "0x183C399B0")]
		public void WXKSJPXXADB<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9B08E50", Offset = "0x9B07850", VA = "0x189B08E50")]
		public void WXKSJPXXADB(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9B08F50", Offset = "0x9B07950", VA = "0x189B08F50")]
		public void WXKSJPXXADB(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C35FC0", Offset = "0x3C349C0", VA = "0x183C35FC0")]
		public void RPATJSAHASM<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B089C0", Offset = "0x9B073C0", VA = "0x189B089C0")]
		public void RPATJSAHASM(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B08AC0", Offset = "0x9B074C0", VA = "0x189B08AC0")]
		public void RPATJSAHASM(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B08270", Offset = "0x9B06C70", VA = "0x189B08270")]
		public void LDOBSRRUBQH(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B08DE0", Offset = "0x9B077E0", VA = "0x189B08DE0")]
		public void UOOHDNSSNYI(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3C359F0", Offset = "0x3C343F0", VA = "0x183C359F0")]
		public LogRangeScope QKYUDLHAIAT<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1123DA0", Offset = "0x11227A0", VA = "0x181123DA0")]
		public LogRangeScope UECGGSQSVDU<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9B087A0", Offset = "0x9B071A0", VA = "0x189B087A0")]
		public LogRangeScope QKYUDLHAIAT(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9B088C0", Offset = "0x9B072C0", VA = "0x189B088C0")]
		public LogRangeScope QKYUDLHAIAT(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1123DA0", Offset = "0x11227A0", VA = "0x181123DA0")]
		public LogRangeScope UECGGSQSVDU(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9B086C0", Offset = "0x9B070C0", VA = "0x189B086C0")]
		public void PKNBDRXBUHB(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B084B0", Offset = "0x9B06EB0", VA = "0x189B084B0")]
		public void PKNBDRXBUHB(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3C35250", Offset = "0x3C33C50", VA = "0x183C35250")]
		public void PKNBDRXBUHB<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
		public void XHDWQKVSGVK([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B07D80", Offset = "0x9B06780", VA = "0x189B07D80")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B07F10", Offset = "0x9B06910", VA = "0x189B07F10")]
		private static void JNXATKNPUGE(Exception a, StringBuilder b, int c = 0, int d = 5)
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
			public static readonly Log KIYBZTTPTQO;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log BAWLRIIXCDL;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log IDUCMGCXVUZ;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log ABCZAKEYEVM;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log JYJRJZUXYDG;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log QWHFDEFPEYE;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log IGAXORCVSJF;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log TEZDOQADCSE;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log VJXPZPNMKJT;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log LKDZCKBYFRC;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log PZSNLOMISMO;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log OMUFCIHZPHA;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log JZLOZMBNCQE;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log MLWMMFRHRKB;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log PBTBHEHEIPB;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log TWFEWZRHNJJ;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log FJLDWUQHATP;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log AJJCGUNIJJE;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log KURPMKDIBWB;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log KOXCEACTUTB;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log ADCUZHDBVJH;
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
					public static readonly Log YMVJUILALJR;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log XVLQTEPECHZ;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log AEIOPGAGODH;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log NDFBKTYMQPW;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log BJECXYUCMIK;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log EMJQYVGXHRW;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log NGDVCWAFJJU;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log QQDMPSXWXOW;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log AEIOPGAGODH;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log BJECXYUCMIK;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log EMJQYVGXHRW;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log PHHBIWJIKWT;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log XVJMNENZZGG;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log MNCUCQPRCSK;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log FPZMMLIPTQA;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log NXQGEIMHWLL;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log YMVJUILALJR;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log ULVUPYTAIUX;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log ULQNSRZCZJO;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log UMGIKMGVBRP;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log UMBBNFMXSGG;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log ULATAXRKXBN;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log UKVMDQXNNQE;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log ULLGVLFFPYF;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log ULFZYELIGMW;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log UNLXUAWFGHR;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log UNGQWUCHWWI;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log YMVJUILALJR;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log ULVUPYTAIUX;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log ULQNSRZCZJO;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log UMGIKMGVBRP;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log UMBBNFMXSGG;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log ULATAXRKXBN;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log UKVMDQXNNQE;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log ULLGVLFFPYF;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log ULFZYELIGMW;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log UNLXUAWFGHR;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log UNGQWUCHWWI;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log YMVJUILALJR;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log SBUDRDEOSVV;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log NUQOFUABKLT;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log VPANJBKKOWN;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log IYIJHKSTIPX;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log SGDHPPOAFBI;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log HZORPMDJRLW;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log DIERPRIZBOB;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log VKSWMVXLFZQ;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log UJBTVGYCLHX;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log YCLZQJCPJYP;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log YMVJUILALJR;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log HKXWALIJJCL;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log DMNXUQYZPBP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log XTIKOYESXJI;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log SRQJCTVBYCL;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log HMAVJICPGDN;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log FGVSSCUPFDJ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log QZLYDQKJQUT;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log IBUPVFTBKNC;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log CRYUQAEUFXV;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log DLCLDTZXVDP;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log BZCEADCRTWO;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log ZYRBHOORMYQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log MJCZMJGRTUN;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log OVORIIJGGZO;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log WILHGNSYVUU;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log KWCZQLMOTNB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log RZYLUHNJHIJ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log MQKWAIYFEOT;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log OCCKFVOHMXB;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log DLCLDTZXVDP;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log RQGGCZQPYDH;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log ADCUZHDBVJH;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log GLWAIJHCHHD;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log HPJXIVFCVHC;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log UJBTVGYCLHX;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log VQVQNCFYGMN;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log JCAAPNNTXAM;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log OPDWZFSXAQV;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log YZHQMFJNLAA;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log DLCLDTZXVDP;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log KNWVTGXCTUN;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log JXWBPUNYPLV;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log EADPQCDRBDE;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log KEUYGDEIUHS;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log DSZUFRHQVOU;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log JFYMSGDNQJM;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log FROMAHRCVZY;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log IXEBDNBYPIU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log IUGTHYLZOQV;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log DLCLDTZXVDP;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log ZZBNBQBSQKJ;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log XZOSMIIGKFE;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log TQVXMBQMTRZ;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log LLUZBGZUBIO;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log WMCWVKBMGYF;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log KJZXVIMNUTD;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log RTKYOPGHUMN;

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly Log IVDDZVKDNCG;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log FKUNBHYSLUS;

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly Log DWWMNWLKJKP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Log YPWJUKBEBWS;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private static readonly Log IXMVHIEPYSL;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log PNDIYQYTJGX;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log ZVNYEABHVUJ;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log HSGDBLBLVPR;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log IZHBYJPEEPM;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log RJECGSDFGTV;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log IJGYBBPNEIS;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log IOTEDKJDAFO;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log YWYZSKNNKKC;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log LKDZCKBYFRC;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log PHHBIWJIKWT;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log DMWKZNZMLGR;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log PUZSRIYCKOO;

				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly Log LJEDQXPUPWM;

				[Cpp2IlInjected.Token(Token = "0x400009B")]
				public static readonly Log BFIYFRVCQAZ;

				[Cpp2IlInjected.Token(Token = "0x400009C")]
				public static readonly Log QYASLSRAETS;
			}

			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly Log YMVJUILALJR;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log FQJGNINXXCJ;

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log TVPUHIDQZSR;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log GBHIYWZYOMP;

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log IOKUOMRJGEJ;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					private static readonly Log IXMVHIEPYSL;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log TXBTQGQIILS;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log WMJOOBKDUON;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log MOEHSOPNAYC;

					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public static readonly Log NDKSBVBEYNE;

					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public static readonly Log JVXHLPEQLFK;

					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					public static readonly Log GBHIYWZYOMP;

					[Cpp2IlInjected.Token(Token = "0x40000BC")]
					public static readonly Log OMKCOOHANEM;
				}

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log WGBOWOOJHDE;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log LHVQPQITZQR;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log SNEBVEXXZTG;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log AUNPVDGRMNF;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log TVPUHIDQZSR;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log RPOZARPBAJP;

				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public static readonly Log GZJLRIESCXS;

				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public static readonly Log AQTCYOVGLUJ;

				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public static readonly Log BNLEBTCSZFI;

				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public static readonly Log QJLMPUIVVTP;
			}

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log YMVJUILALJR;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log UJPQANIPWHR;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log QZWREUPWVII;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log NKTQZXVFVOV;

			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly Log YOVISCEHKFR;

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public static readonly Log RVWRLTOTDIL;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public static readonly Log MEXDWKCCDHK;

			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public static readonly Log AVEWIORQMSE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log SKJKRYFPAXG;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log TOUNQROHWKF;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log XDFHLZISKBF;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log QDILPFJWHUH;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log MMSZBJOHXJA;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log REKPAUPVAQE;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log ZPEAWLJSSCF;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log JGLGGJHQABV;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log OTSBOCQVLLI;

				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log SFBCNDIQNLS;

				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log IDYVVNGQSXT;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log BYMVVYFYXMI;

				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log FGXTNKENOVE;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log HIQKFVRZWGO;

				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log FFSOXDRLDMK;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class WFBMTJGIFNP
			{
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public static readonly Log VEHJUSBDUMI;

				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public static readonly Log UOKGHJZQMMY;

				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public static readonly Log ETQXEIWWRZP;
			}

			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public static class Renderer
			{
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public static readonly Log JRJFDKACYKR;
			}

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly Log YMVJUILALJR;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public static class Preferences
			{
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public static readonly Log YCUALQQVGCU;

				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public static readonly Log AXIWIYLOXXA;

				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public static readonly Log BOWLKQVKUEN;
			}

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly Log NUYVGIKGMCF;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log FEJUHJEPWLA;

			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log LHDQWRYYSYZ;

			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log SPXRLBCOMTW;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log VVIFMQBAHZZ;

			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log THKYJIXEAPB;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log QYASLSRAETS;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log YMVJUILALJR;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log AZAVOSPMQYB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log YMVJUILALJR;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log YEASLBEFRIH;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log NKJILAWDDZQ;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log LAREOOSEDMV;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log YMVJUILALJR;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log XWRATLFRFWW;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log UNRLJRMKLNP;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log TFOGXYYQTUL;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log OMPLTMRHXHL;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log UUWQIMIEAPF;

			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log KLRVWPWRZNG;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log PJOSQTJAWJX;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log BYVHVQCANHD;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log DLCLDTZXVDP;

			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log YUIYRJTRDOG;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log TGDESTEKOZE;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log BVZNFIMUDBG;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly Log HAQCNGQWVHW;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log AYQSKWQPZWE;

			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly Log CQELDYILUIQ;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log GPIHZXIBQHZ;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly Log CGEIAHHTDDF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log YMVJUILALJR;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log ABCZAKEYEVM;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log TSPQMVBPUDP;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log DUUQMNIRHMO;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log ALPVHXWWNQN;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log PWKOBYOLHAY;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log GFIRGEZHOUA;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log ACRPIKQILZB;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log YSJWZRRRBPE;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log OHERMZBVAMP;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log UBQQRLMBUKX;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log SACEJDAOYRZ;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log ANDOOKQIEZV;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log NYHNXSWRZHR;

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly Log XDWTLKDRXRD;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log GFSXDFWMEGC;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log NESPCHPMRTN;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log ZDZXWHTWDVM;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log ISFCKCOOSCB;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log DBTFFQXDPVU;

			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly Log MBSMJZHQNSE;

			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public static readonly Log MNCUCQPRCSK;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public static readonly Log YMVJUILALJR;

				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public static readonly Log UISDCIGPHRX;

				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public static readonly Log CCUMMNZBPBC;
			}

			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private static readonly Log YMVJUILALJR;

			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly Log GWGAVDGAFOJ;

			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly Log DWNKMOZJEER;

			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public static readonly Log YEQWNYNOUXK;

			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public static readonly Log KPTHYWEXKBT;

			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public static readonly Log KAHVJJBMAUV;

			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log YNBLWHWWBVD;

			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log OAOBFTSHPTB;

			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly Log PCWRRFBVVEP;

			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public static readonly Log DHWYBMYSAMD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private static readonly Log IXMVHIEPYSL;

			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly Log VHDQXREEJCF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public static readonly Log YMVJUILALJR;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public static readonly Log YMVJUILALJR;

			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public static readonly Log YIEPVKEQTZD;

			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly Log TGYMBFRTMIN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly Log YMVJUILALJR;

			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public static readonly Log LVMAGFUTWZV;

			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public static readonly Log XBQFTFNMLAW;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class EDLLWPRZZVU
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public class WORLHXBIZNU : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private readonly (int index, bool enabled)[] EYIVCEASADJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private List<(int index, bool enabled)> KJFVJJUQSSZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			private bool QXXRKWVUXGJ;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9B13120", Offset = "0x9B11B20", VA = "0x189B13120")]
			internal WORLHXBIZNU((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9B130A0", Offset = "0x9B11AA0", VA = "0x189B130A0")]
			public IDisposable PCZHYYZRCEO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9B12FF0", Offset = "0x9B119F0", VA = "0x189B12FF0", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class RHNOLRZOCKD
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly Log IXMVHIEPYSL;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log FKYQAYSCWQZ;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log UBBQVOXSBGU;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log DVLHJPTPGSP;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log LFZZOBLVONZ;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log WWCETNPUBUV;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log WEUIZCSXGLG;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log ACRPIKQILZB;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log ZUSEQBIUGZZ;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log GJDLMYRJFBH;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log JDUSKTTBNCD;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log YWDELARHUIK;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log KFMDAERZIXD;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log QIUXBVEMSDA;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log VKFNWRCGWFT;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log VNFBVKFAZZP;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log OUWBUKEIFFY;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log UBQQRLMBUKX;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log LKYYHQQGRRL;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log XEOJXXAXOYE;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log CRNYGCHHXET;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log LKDZCKBYFRC;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log PWQAFDJWCZO;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log PMRNCQUJCFD;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log CKASUJVJJLM;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log TKUBPHMBRZK;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log XQZUUUVEMTK;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log SRARUILDAAQ;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log QHQOEHOFLXF;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log SCDLZIQBWIK;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log EHPVCQPVVLT;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log MOUKSUDUWOW;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log PSCFBRRFZFH;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log CKXXLYUOQKG;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Log NIIVFPTUOGB;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Log NDFBKTYMQPW;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly Log MMOVINSORQM;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly Log JJJUQLHOMJG;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly Log LYGCBOYGQJS;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly Log EHMTOWRYVRB;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly Log SDSNUIMGKTN;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly Log NNXSUIDCARP;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly Log OUJGNPCBNMK;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly Log ZKZTVNLZHZP;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly Log NRGAEJXTIQQ;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly Log ZHKJYJHEXNS;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly Log SCCPXPRIGCX;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly Log HBEADHYKUCU;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log RJCARECONVK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9B0AFE0", Offset = "0x9B099E0", VA = "0x189B0AFE0")]
			get
			{
				return default(Log);
			}
		}
	}
}
namespace RecRoom.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal class SCHLZLHUVCA
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private SCHLZLHUVCA parent;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xEF0480", Offset = "0xEEEE80", VA = "0x180EF0480")]
			public Scope(SCHLZLHUVCA parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly Stopwatch PINOVHFBIVF;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1105600", Offset = "0x1104000", VA = "0x181105600")]
		public Scope VWLUZANINNW()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9B0E290", Offset = "0x9B0CC90", VA = "0x189B0E290")]
		public SCHLZLHUVCA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface FAATJHKFRIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DPMSSQUUFGW(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WYNAKPRZUYS(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LIBCEQYQFAM(object a, [Optional] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct LogRangeScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly object message;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9B066F0", Offset = "0x9B050F0", VA = "0x189B066F0")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9B06680", Offset = "0x9B05080", VA = "0x189B06680", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[Preserve]
	public abstract class LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void QCIVJGOFOSZ();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class QRVYZYJNJOG
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static List<LogRegistrationIndex> POMWSYSSIKN;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static bool NTFGNJMOEQS;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly object EOQDUKELFIV;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> KUUYPZTODZL
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9B0AF20", Offset = "0x9B09920", VA = "0x189B0AF20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9B0A960", Offset = "0x9B09360", VA = "0x189B0A960")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9B0AD10", Offset = "0x9B09710", VA = "0x189B0AD10")]
		private static void UCAEUHMZHBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9B0AAD0", Offset = "0x9B094D0", VA = "0x189B0AAD0")]
		private static void JZPTBDUHMIQ(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class TMJTITEZZGN
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD54D90", Offset = "0xD53790", VA = "0x180D54D90")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
			public void MKOESJHSGRJ(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD54D90", Offset = "0xD53790", VA = "0x180D54D90")]
			public ParanoiaLevel ASEGOMSLGZV(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static Action CDOPCVYJTKY;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly object OVKSHHTYREE;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly Dictionary<(int parentIndex, string token), int> ZSLZNCGYZAK;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly List<string> MBZXBXWHVIS;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly List<int> JPEDVWLCFHV;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly List<ulong> STEQVOAOMZN;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly List<ulong> ZLLYBTNGARO;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly List<ulong> VDRLSIRAJMX;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly StringBuilder KZSTIETAQNT;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly SCHLZLHUVCA NAXFSMOGRMJ;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private static Debug WERQNFOLUIL;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static int WUPDKMMOUNT;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static FAATJHKFRIL NQUYRTUWWJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9B0F250", Offset = "0x9B0DC50", VA = "0x189B0F250")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9B0E930", Offset = "0x9B0D330", VA = "0x189B0E930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool TTUBWNDTOCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9B0ECC0", Offset = "0x9B0D6C0", VA = "0x189B0ECC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool SAAIHHRKALH
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9B10B50", Offset = "0x9B0F550", VA = "0x189B10B50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool YQHAOLLBBWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9B0E3C0", Offset = "0x9B0CDC0", VA = "0x189B0E3C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9B0EF90", Offset = "0x9B0D990", VA = "0x189B0EF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9B11500", Offset = "0x9B0FF00", VA = "0x189B11500")]
		static TMJTITEZZGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9B0ED10", Offset = "0x9B0D710", VA = "0x189B0ED10")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9B108F0", Offset = "0x9B0F2F0", VA = "0x189B108F0")]
		public static int QCIVJGOFOSZ(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9B10820", Offset = "0x9B0F220", VA = "0x189B10820")]
		public static int QCIVJGOFOSZ(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9B0E8E0", Offset = "0x9B0D2E0", VA = "0x189B0E8E0")]
		public static Log GWKJHKBBVLF(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F2E0", Offset = "0x9B0DCE0", VA = "0x189B0F2E0")]
		public static void MQIVTEBPGEE(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9B0FF10", Offset = "0x9B0E910", VA = "0x189B0FF10")]
		public static void PAMEDYFHPGR(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9B0E340", Offset = "0x9B0CD40", VA = "0x189B0E340")]
		public static bool BMKMWBHSQWR(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9B0EFE0", Offset = "0x9B0D9E0", VA = "0x189B0EFE0")]
		public static int MEIMFGGOCCQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9B0E680", Offset = "0x9B0D080", VA = "0x189B0E680")]
		public static string GKKABFGOQCD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9B11360", Offset = "0x9B0FD60", VA = "0x189B11360")]
		public static (string[], int[]) ZNEAITZRWMA()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F130", Offset = "0x9B0DB30", VA = "0x189B0F130")]
		private static int MGFCAAEMNUM(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9B10BA0", Offset = "0x9B0F5A0", VA = "0x189B10BA0")]
		private static int YSDVKWKHFLE(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F9C0", Offset = "0x9B0E3C0", VA = "0x189B0F9C0")]
		private static int OQKIPREARFU(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9B0EA20", Offset = "0x9B0D420", VA = "0x189B0EA20")]
		private static int IVJGLTISEOJ(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9B0EAF0", Offset = "0x9B0D4F0", VA = "0x189B0EAF0")]
		private static int IVJGLTISEOJ(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F850", Offset = "0x9B0E250", VA = "0x189B0F850")]
		private static void OJOKFMPVIQE(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F4A0", Offset = "0x9B0DEA0", VA = "0x189B0F4A0")]
		public static bool MVVEBZKMSEA(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9B0E450", Offset = "0x9B0CE50", VA = "0x189B0E450")]
		public static bool DAYKJGVJDOP(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9B104E0", Offset = "0x9B0EEE0", VA = "0x189B104E0")]
		private static void PZDPZWARXKL(int a, bool b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9B10EC0", Offset = "0x9B0F8C0", VA = "0x189B10EC0")]
		public static void ZDHULBJDKAN(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9B10120", Offset = "0x9B0EB20", VA = "0x189B10120")]
		public static void PJDSMOFXMGK(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F6B0", Offset = "0x9B0E0B0", VA = "0x189B0F6B0")]
		private static void NFCDQJDJYLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9B10C50", Offset = "0x9B0F650", VA = "0x189B10C50")]
		private static void YSOGNIZDOZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F710", Offset = "0x9B0E110", VA = "0x189B0F710")]
		private static bool NJDTILOBGAD(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F560", Offset = "0x9B0DF60", VA = "0x189B0F560")]
		private static bool NBOVTVVKNRY(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9B0E9A0", Offset = "0x9B0D3A0", VA = "0x189B0E9A0")]
		private static bool IMNZGJHXCEM(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9B10A90", Offset = "0x9B0F490", VA = "0x189B10A90")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9B0EF20", Offset = "0x9B0D920", VA = "0x189B0EF20")]
		private static void LIKNHIFLQUY(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9B0E510", Offset = "0x9B0CF10", VA = "0x189B0E510")]
		public static EDLLWPRZZVU.WORLHXBIZNU GJRFWFWGFUW((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9B0F2A0", Offset = "0x9B0DCA0", VA = "0x189B0F2A0")]
		public static void MKOESJHSGRJ(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9B0E300", Offset = "0x9B0CD00", VA = "0x189B0E300")]
		public static ParanoiaLevel ASEGOMSLGZV(int a)
		{
			return default(ParanoiaLevel);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum ParanoiaLevel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		FastDebug,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Debug,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Paranoid,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		SuperParanoid,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		MassivelyParanoid
	}
}
namespace RecRoom.Logging.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Obfuscation(Exclude = true)]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xD341B0", Offset = "0xD32BB0", VA = "0x180D341B0")]
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
