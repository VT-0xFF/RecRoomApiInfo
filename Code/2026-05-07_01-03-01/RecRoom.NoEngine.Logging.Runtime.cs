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
		[Cpp2IlInjected.Address(RVA = "0x99A49C0", Offset = "0x99A33C0", VA = "0x1899A49C0", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
			[Cpp2IlInjected.Address(RVA = "0xF535F0", Offset = "0xF51FF0", VA = "0x180F535F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x99A7640", Offset = "0x99A6040", VA = "0x1899A7640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool CMHSJSPGFUV
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x99A7690", Offset = "0x99A6090", VA = "0x1899A7690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string HMETGHEOROT
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x99A5DA0", Offset = "0x99A47A0", VA = "0x1899A5DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool SFWGMFEBQCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6973BD0", Offset = "0x69725D0", VA = "0x186973BD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel TQWMFDCWDPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x99A6130", Offset = "0x99A4B30", VA = "0x1899A6130")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99A76E0", Offset = "0x99A60E0", VA = "0x1899A76E0")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x15AB7E0", Offset = "0x15AA1E0", VA = "0x1815AB7E0")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99A7740", Offset = "0x99A6140", VA = "0x1899A7740")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3C1D5A0", Offset = "0x3C1BFA0", VA = "0x183C1D5A0")]
		public void DPMSSQUUFGW<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99A5EF0", Offset = "0x99A48F0", VA = "0x1899A5EF0")]
		public void DPMSSQUUFGW(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99A5DF0", Offset = "0x99A47F0", VA = "0x1899A5DF0")]
		public void DPMSSQUUFGW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C26E80", Offset = "0x3C25880", VA = "0x183C26E80")]
		public void XQEFUOCZFXP<d>(bool a, Func<d, object> b, [In] d args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99A7520", Offset = "0x99A5F20", VA = "0x1899A7520")]
		public void XQEFUOCZFXP(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C26640", Offset = "0x3C25040", VA = "0x183C26640")]
		public void WYNAKPRZUYS<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99A7300", Offset = "0x99A5D00", VA = "0x1899A7300")]
		public void WYNAKPRZUYS(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99A7420", Offset = "0x99A5E20", VA = "0x1899A7420")]
		public void WYNAKPRZUYS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C22880", Offset = "0x3C21280", VA = "0x183C22880")]
		public void TXWNEVJNALX<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99A6E60", Offset = "0x99A5860", VA = "0x1899A6E60")]
		public void TXWNEVJNALX(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99A6F90", Offset = "0x99A5990", VA = "0x1899A6F90")]
		public void TXWNEVJNALX(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3C20720", Offset = "0x3C1F120", VA = "0x183C20720")]
		public void LIBCEQYQFAM<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99A6650", Offset = "0x99A5050", VA = "0x1899A6650")]
		public void LIBCEQYQFAM(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99A6570", Offset = "0x99A4F70", VA = "0x1899A6570")]
		public void LIBCEQYQFAM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C25E40", Offset = "0x3C24840", VA = "0x183C25E40")]
		public void WXKSJPXXADB<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99A7110", Offset = "0x99A5B10", VA = "0x1899A7110")]
		public void WXKSJPXXADB(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x99A7210", Offset = "0x99A5C10", VA = "0x1899A7210")]
		public void WXKSJPXXADB(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C22440", Offset = "0x3C20E40", VA = "0x183C22440")]
		public void RPATJSAHASM<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99A6C70", Offset = "0x99A5670", VA = "0x1899A6C70")]
		public void RPATJSAHASM(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99A6D70", Offset = "0x99A5770", VA = "0x1899A6D70")]
		public void RPATJSAHASM(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99A6500", Offset = "0x99A4F00", VA = "0x1899A6500")]
		public void LDOBSRRUBQH(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99A70A0", Offset = "0x99A5AA0", VA = "0x1899A70A0")]
		public void UOOHDNSSNYI(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3C21E60", Offset = "0x3C20860", VA = "0x183C21E60")]
		public LogRangeScope QKYUDLHAIAT<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0")]
		public LogRangeScope UECGGSQSVDU<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99A6A50", Offset = "0x99A5450", VA = "0x1899A6A50")]
		public LogRangeScope QKYUDLHAIAT(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99A6B70", Offset = "0x99A5570", VA = "0x1899A6B70")]
		public LogRangeScope QKYUDLHAIAT(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10E45F0", Offset = "0x10E2FF0", VA = "0x1810E45F0")]
		public LogRangeScope UECGGSQSVDU(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x99A6970", Offset = "0x99A5370", VA = "0x1899A6970")]
		public void PKNBDRXBUHB(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x99A6750", Offset = "0x99A5150", VA = "0x1899A6750")]
		public void PKNBDRXBUHB(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3C216C0", Offset = "0x3C200C0", VA = "0x183C216C0")]
		public void PKNBDRXBUHB<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
		public void XHDWQKVSGVK([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99A6010", Offset = "0x99A4A10", VA = "0x1899A6010")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99A61A0", Offset = "0x99A4BA0", VA = "0x1899A61A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x99B1910", Offset = "0x99B0310", VA = "0x1899B1910")]
			internal WORLHXBIZNU((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x99B1890", Offset = "0x99B0290", VA = "0x1899B1890")]
			public IDisposable PCZHYYZRCEO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x99B17E0", Offset = "0x99B01E0", VA = "0x1899B17E0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x99A9390", Offset = "0x99A7D90", VA = "0x1899A9390")]
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
			[Cpp2IlInjected.Address(RVA = "0xEBA9B0", Offset = "0xEB93B0", VA = "0x180EBA9B0")]
			public Scope(SCHLZLHUVCA parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly Stopwatch PINOVHFBIVF;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x10DEEF0", Offset = "0x10DD8F0", VA = "0x1810DEEF0")]
		public Scope VWLUZANINNW()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x99AC8E0", Offset = "0x99AB2E0", VA = "0x1899AC8E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99A4920", Offset = "0x99A3320", VA = "0x1899A4920")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x99A48B0", Offset = "0x99A32B0", VA = "0x1899A48B0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
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
			[Cpp2IlInjected.Address(RVA = "0x99A92D0", Offset = "0x99A7CD0", VA = "0x1899A92D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99A8D00", Offset = "0x99A7700", VA = "0x1899A8D00")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x99A90C0", Offset = "0x99A7AC0", VA = "0x1899A90C0")]
		private static void UCAEUHMZHBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x99A8E80", Offset = "0x99A7880", VA = "0x1899A8E80")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
			public void MKOESJHSGRJ(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850")]
			public ParanoiaLevel ASEGOMSLGZV(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x99AD8B0", Offset = "0x99AC2B0", VA = "0x1899AD8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x99ACF90", Offset = "0x99AB990", VA = "0x1899ACF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool TTUBWNDTOCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x99AD320", Offset = "0x99ABD20", VA = "0x1899AD320")]
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
			[Cpp2IlInjected.Address(RVA = "0x99AF1F0", Offset = "0x99ADBF0", VA = "0x1899AF1F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x99ACA10", Offset = "0x99AB410", VA = "0x1899ACA10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x99AD5F0", Offset = "0x99ABFF0", VA = "0x1899AD5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x99AFBC0", Offset = "0x99AE5C0", VA = "0x1899AFBC0")]
		static TMJTITEZZGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x99AD370", Offset = "0x99ABD70", VA = "0x1899AD370")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99AEF90", Offset = "0x99AD990", VA = "0x1899AEF90")]
		public static int QCIVJGOFOSZ(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x99AEEC0", Offset = "0x99AD8C0", VA = "0x1899AEEC0")]
		public static int QCIVJGOFOSZ(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99ACF40", Offset = "0x99AB940", VA = "0x1899ACF40")]
		public static Log GWKJHKBBVLF(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x99AD940", Offset = "0x99AC340", VA = "0x1899AD940")]
		public static void MQIVTEBPGEE(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99AE5A0", Offset = "0x99ACFA0", VA = "0x1899AE5A0")]
		public static void PAMEDYFHPGR(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99AC990", Offset = "0x99AB390", VA = "0x1899AC990")]
		public static bool BMKMWBHSQWR(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x99AD640", Offset = "0x99AC040", VA = "0x1899AD640")]
		public static int MEIMFGGOCCQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99ACCD0", Offset = "0x99AB6D0", VA = "0x1899ACCD0")]
		public static string GKKABFGOQCD(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99AFA10", Offset = "0x99AE410", VA = "0x1899AFA10")]
		public static (string[], int[]) ZNEAITZRWMA()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99AD790", Offset = "0x99AC190", VA = "0x1899AD790")]
		private static int MGFCAAEMNUM(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x99AF240", Offset = "0x99ADC40", VA = "0x1899AF240")]
		private static int YSDVKWKHFLE(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x99AE040", Offset = "0x99ACA40", VA = "0x1899AE040")]
		private static int OQKIPREARFU(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x99AD080", Offset = "0x99ABA80", VA = "0x1899AD080")]
		private static int IVJGLTISEOJ(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x99AD150", Offset = "0x99ABB50", VA = "0x1899AD150")]
		private static int IVJGLTISEOJ(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x99ADED0", Offset = "0x99AC8D0", VA = "0x1899ADED0")]
		private static void OJOKFMPVIQE(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x99ADB00", Offset = "0x99AC500", VA = "0x1899ADB00")]
		public static bool MVVEBZKMSEA(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x99ACAA0", Offset = "0x99AB4A0", VA = "0x1899ACAA0")]
		public static bool DAYKJGVJDOP(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x99AEB70", Offset = "0x99AD570", VA = "0x1899AEB70")]
		private static void PZDPZWARXKL(int a, bool b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x99AF560", Offset = "0x99ADF60", VA = "0x1899AF560")]
		public static void ZDHULBJDKAN(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x99AE7B0", Offset = "0x99AD1B0", VA = "0x1899AE7B0")]
		public static void PJDSMOFXMGK(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x99ADD20", Offset = "0x99AC720", VA = "0x1899ADD20")]
		private static void NFCDQJDJYLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x99AF2F0", Offset = "0x99ADCF0", VA = "0x1899AF2F0")]
		private static void YSOGNIZDOZU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x99ADD90", Offset = "0x99AC790", VA = "0x1899ADD90")]
		private static bool NJDTILOBGAD(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x99ADBC0", Offset = "0x99AC5C0", VA = "0x1899ADBC0")]
		private static bool NBOVTVVKNRY(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x99AD000", Offset = "0x99ABA00", VA = "0x1899AD000")]
		private static bool IMNZGJHXCEM(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x99AF130", Offset = "0x99ADB30", VA = "0x1899AF130")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x99AD580", Offset = "0x99ABF80", VA = "0x1899AD580")]
		private static void LIKNHIFLQUY(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x99ACB60", Offset = "0x99AB560", VA = "0x1899ACB60")]
		public static EDLLWPRZZVU.WORLHXBIZNU GJRFWFWGFUW((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x99AD900", Offset = "0x99AC300", VA = "0x1899AD900")]
		public static void MKOESJHSGRJ(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x99AC950", Offset = "0x99AB350", VA = "0x1899AC950")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
