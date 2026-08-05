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
		[Cpp2IlInjected.Address(RVA = "0x836C2C0", Offset = "0x836B6C0", VA = "0x18836C2C0", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
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
			[Cpp2IlInjected.Address(RVA = "0xC9E6F0", Offset = "0xC9DAF0", VA = "0x180C9E6F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool EDZKGSPNION
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x836E500", Offset = "0x836D900", VA = "0x18836E500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool NDJNPJTMOXZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x836D5D0", Offset = "0x836C9D0", VA = "0x18836D5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string YTLUPOXLYLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x836DFF0", Offset = "0x836D3F0", VA = "0x18836DFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool SNUBYQZVLOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5349BC0", Offset = "0x5348FC0", VA = "0x185349BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel FBMHCVDNQGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x836D620", Offset = "0x836CA20", VA = "0x18836D620")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x836EEC0", Offset = "0x836E2C0", VA = "0x18836EEC0")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x12F15C0", Offset = "0x12F09C0", VA = "0x1812F15C0")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x836EF20", Offset = "0x836E320", VA = "0x18836EF20")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x37BA8A0", Offset = "0x37B9CA0", VA = "0x1837BA8A0")]
		public void XCPAHPBRLGE<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x836E650", Offset = "0x836DA50", VA = "0x18836E650")]
		public void XCPAHPBRLGE(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x836E550", Offset = "0x836D950", VA = "0x18836E550")]
		public void XCPAHPBRLGE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x836DC20", Offset = "0x836D020", VA = "0x18836DC20")]
		public void PPMCDNCWWVZ(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x37BC750", Offset = "0x37BBB50", VA = "0x1837BC750")]
		public void ZZNLPVXLPAA<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x836EDA0", Offset = "0x836E1A0", VA = "0x18836EDA0")]
		public void ZZNLPVXLPAA(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x836ECA0", Offset = "0x836E0A0", VA = "0x18836ECA0")]
		public void ZZNLPVXLPAA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x37B86F0", Offset = "0x37B7AF0", VA = "0x1837B86F0")]
		public void UBBHGJGLJBN<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x836DDB0", Offset = "0x836D1B0", VA = "0x18836DDB0")]
		public void UBBHGJGLJBN(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x836DEE0", Offset = "0x836D2E0", VA = "0x18836DEE0")]
		public void UBBHGJGLJBN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x37B95C0", Offset = "0x37B89C0", VA = "0x1837B95C0")]
		public void WALKOWSUKQW<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x836E330", Offset = "0x836D730", VA = "0x18836E330")]
		public void WALKOWSUKQW(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x836E420", Offset = "0x836D820", VA = "0x18836E420")]
		public void WALKOWSUKQW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x37BBF50", Offset = "0x37BB350", VA = "0x1837BBF50")]
		public void XVNCDKUVFOB<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x836E840", Offset = "0x836DC40", VA = "0x18836E840")]
		public void XVNCDKUVFOB(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x836E760", Offset = "0x836DB60", VA = "0x18836E760")]
		public void XVNCDKUVFOB(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37B59A0", Offset = "0x37B4DA0", VA = "0x1837B59A0")]
		public void FSABVAPVDMC<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x836D690", Offset = "0x836CA90", VA = "0x18836D690")]
		public void FSABVAPVDMC(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x836D790", Offset = "0x836CB90", VA = "0x18836D790")]
		public void FSABVAPVDMC(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x836DD40", Offset = "0x836D140", VA = "0x18836DD40")]
		public void RABPPVIDGIV(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x836DBB0", Offset = "0x836CFB0", VA = "0x18836DBB0")]
		public void NIQIUUIYQFY(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x37B73F0", Offset = "0x37B67F0", VA = "0x1837B73F0")]
		public LogRangeScope JFAHIPGFVFP<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350")]
		public LogRangeScope OURQOILEUWI<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x836D990", Offset = "0x836CD90", VA = "0x18836D990")]
		public LogRangeScope JFAHIPGFVFP(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x836DAB0", Offset = "0x836CEB0", VA = "0x18836DAB0")]
		public LogRangeScope JFAHIPGFVFP(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE26350", Offset = "0xE25750", VA = "0x180E26350")]
		public LogRangeScope OURQOILEUWI(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x836E250", Offset = "0x836D650", VA = "0x18836E250")]
		public void VMJHJVXCCYB(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x836E040", Offset = "0x836D440", VA = "0x18836E040")]
		public void VMJHJVXCCYB(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37B8E30", Offset = "0x37B8230", VA = "0x1837B8E30")]
		public void VMJHJVXCCYB<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
		public void VTVZOKZVHDI([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x836D870", Offset = "0x836CC70", VA = "0x18836D870")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x836E940", Offset = "0x836DD40", VA = "0x18836E940")]
		private static void YDSZBVEXCAK(Exception a, StringBuilder b, int c = 0, int d = 5)
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
			public static readonly Log ITNQCOPFLEU;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log FSECWJGNXCX;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log ZSZZTKKBHYP;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log BGKTMVEEAHG;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log OEEWMRVQBKK;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log MIXNUDXQALA;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log IHOMHAUMPRP;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log WLBINRNMHJM;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log WKOGZYPGBZB;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log TGSEOOIHQMG;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log DOMGJXQKJBW;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log TDYAMHVCPRK;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log DBBJNUDHOWS;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log ZDPKZXVZSML;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log KCTOMRLGQFH;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log SCOWOKUXCNT;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log IFDVNUAGKTZ;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log GCGTKIJOVRC;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log TJSVWVITIVZ;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log NUPDIYPNFUJ;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log PRZKJGITDZR;
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
					public static readonly Log IXKFGVVLAKZ;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log HKMHAVXGZIV;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log IXKFGVVLAKZ;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log QJVVMMLFLPR;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log VNLFNPBCVJE;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log RGZOWFDMYQQ;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log FZUSTBNTZJU;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log DBFWWRTICXO;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log VXIQZHTUNYU;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log IXKFGVVLAKZ;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log QJVVMMLFLPR;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log RGZOWFDMYQQ;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log FZUSTBNTZJU;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log IUSEYWHJUEN;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log XLEAHBAXENO;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log USBZZRFKATO;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log IXKFGVVLAKZ;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log UHDSKCDQWIW;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log MCYECWCLFFV;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log IXKFGVVLAKZ;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log OLZPRZYNOWB;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log OLUIUTEQFKS;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log OLPBXMKSVZJ;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log OLJVAFQVMOA;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log OLEOCYWYDCR;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log OKZHFSDATRI;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log OKUAILJDKFZ;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log OKOTLEPGAUQ;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log OKJMNXVIRJH;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log OKEFQRBLHXY;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log IXKFGVVLAKZ;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log OLZPRZYNOWB;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log OLUIUTEQFKS;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log OLPBXMKSVZJ;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log OLJVAFQVMOA;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log OLEOCYWYDCR;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log OKZHFSDATRI;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log OKUAILJDKFZ;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log OKOTLEPGAUQ;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log OKJMNXVIRJH;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log OKEFQRBLHXY;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log IXKFGVVLAKZ;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log TIJPWDYQJDX;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log WJLYKMXAYQH;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log AUZRZOCAKGL;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log FPHQIYJFWMP;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log IXKFGVVLAKZ;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log JJODTTLABKM;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log WPEMKZSWKGG;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log YOTEWRKDORF;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log ZUCLWCWAQWA;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log LUTWPZKADPF;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log ALZXWFHLZUN;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log IXKFGVVLAKZ;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log VPQZQVKCKIR;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log DCHFWQZRRTV;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log YNGPGNHTNGU;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log YWKEEUPCNHT;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log VAPEEUZLLCF;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log YFLPUVAMVUZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log NROLGAGUSIZ;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log FVYBQQDGJSC;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log AYLBXHRERJT;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log IJTTIKUCEQL;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log ZGAENWNKHSU;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log MWSLEANJXSG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log SIUQZJQVWOP;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log MOWYGVTDNLU;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log GTZNUSSBASW;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log GNXPTZBVCLP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log RKNLELPDACD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log SAVQPNNZKFT;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log YKVKFJMKPQF;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log IJTTIKUCEQL;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log BDGTGFPMMSH;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log PRZKJGITDZR;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log WJFRUJNMPYX;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log UALPNTKBIUW;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log LUTWPZKADPF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log IXKFGVVLAKZ;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log YANJXQCEYMP;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log QFGHJZUDAAG;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log HBHEKTKWSXB;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log NVRDEMJKTLA;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log IJTTIKUCEQL;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log JBQZZXBYWVV;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log UFGMCVIYXKB;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log XFHCOWTOPYU;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log QFNPBMZNFYK;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log AJNHBHTFQZA;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log BVVNISVFKKQ;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log APQIIZPHCJC;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log ZCDGVHFLHRE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log BEZXFDFDYZR;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log IJTTIKUCEQL;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log LKVIKMYDHGD;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log WLTKEWDGYAU;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log QKGBGUQPYOF;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log UYMZIAQYILS;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log QONLSBXMHHB;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log CAOHLYTGROP;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log KZARZCITIAX;

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly Log IXHIYLUWRPC;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log OUGRLATVAAN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public static readonly Log EPMREWGWUCQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				private static readonly Log OAFYHDROXFH;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				public static readonly Log IXKFGVVLAKZ;

				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log BGBQQJIINYF;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log KNKDQJLPAIX;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log ASXRTGHXHDX;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log PVDOQHHYMSA;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log YWNAPMHJYAN;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log SNEQHQPEOIY;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log GPQIAJCARFE;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log FQPWFHMNKCI;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log TGSEOOIHQMG;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log IUSEYWHJUEN;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log BERUMSXUIGT;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log BZEAZZBWNWI;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log TMZYFPRTZJQ;

				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly Log ZPNFGQLVWPB;

				[Cpp2IlInjected.Token(Token = "0x400009B")]
				public static readonly Log HLHGEVVITZA;
			}

			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Log IXKFGVVLAKZ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A4")]
				public static readonly Log IXKFGVVLAKZ;

				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log QIAQMMEQVLF;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log GZJEQFYFRJR;

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log NOXIPLYUNFT;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log MUTINJMOBMP;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B4")]
					private static readonly Log OAFYHDROXFH;

					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					public static readonly Log FLGDBIYBDSG;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log FUWTOZUOIXZ;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log HWWLZSXUWVW;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log RPDDLFOHNFC;

					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public static readonly Log HVISFOZBCZE;

					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public static readonly Log NOXIPLYUNFT;

					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					public static readonly Log MIZOWIVVYJI;
				}

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log IXKFGVVLAKZ;

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log GQLMWAOROEY;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log LMZYZCKBHXJ;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log UMVUKVGWXDI;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log OJEXVRNFGWB;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log GZJEQFYFRJR;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log XGABWFOCRRN;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log MKVESOOSKVY;

				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public static readonly Log CMDPWWYEIJJ;

				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public static readonly Log GMFSABYYXYA;

				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public static readonly Log HLVAXMEDLOP;
			}

			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public static readonly Log IXKFGVVLAKZ;

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log LIEGYSNKQEZ;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log QWMSSABTRVQ;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log JEQPKBVUNST;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log AIIQFLPWNBP;

			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly Log YQMJKSEBAOB;

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public static readonly Log EVPGCITIBVY;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public static readonly Log CBHPLCDAVSW;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public static readonly Log IXKFGVVLAKZ;

				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log IXCULJRQAMG;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log HKCLXLRKAZR;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log PFTODOENDTL;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log DOIEBCLOYON;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log OHYZTLASGNK;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log HJIUGDCPDKW;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log CGBIPLVOYWP;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log VQLZNGSNNOR;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log XQWHKOLOBGE;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log QAAABIQNSUC;

				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log WPOAEQXSAOL;

				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log VTWMQLXARJE;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log UVGQOMELLMI;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log IXKFGVVLAKZ;

				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log XCJAVQHEOYM;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log PUDPLHNKAOQ;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class QVYZZIFCUOD
			{
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log IXKFGVVLAKZ;

				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public static readonly Log XXZRGPJEITI;

				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public static readonly Log JYDJJTVMTSK;

				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public static readonly Log WCLQEFLFKXF;
			}

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly Log IXKFGVVLAKZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public static readonly Log NVCSICWHQWD;

			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public static readonly Log ROVRAVOEBEU;

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public static readonly Log HMPAAVHETZR;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log RHGLIYCDHKF;

			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log QIUXRCLFWKF;

			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log HLHGEVVITZA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public static readonly Log IXKFGVVLAKZ;

			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public static readonly Log HQDMCGXJHWX;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public static readonly Log IXKFGVVLAKZ;

			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public static readonly Log BDCORBGZTJX;

			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public static readonly Log WTIQKSNEMFS;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log GFWEKJCRNNN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log IXKFGVVLAKZ;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log WUHWYABQQZG;

			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log YEAQDMPIEJN;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log XXVHIVIWVDX;

			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log VFCOBRYCDRN;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log UYNFCGRWDBX;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log IUNDFBJLZUG;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log GXPUVUXXVOX;

			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log HYHWULCQOST;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log IJTTIKUCEQL;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log WBKRBPSYVSE;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log QZMGQPEXNFC;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log KAZCTREGQMG;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log NXEYDGIDXRQ;

			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log VLIOVPSPZNU;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log VQETRIWGUZA;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log GQMJNWQABKV;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log YCZPOBTNLVT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log IXKFGVVLAKZ;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log BGKTMVEEAHG;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log CDKOSSVTNJB;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly Log NJFJRQDPKHG;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log ESUZWPMJLBV;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log FJCRYDJRJFI;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log JONGYSSMEJM;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log FFSDWTXZFLH;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log MWYPZEOQKPC;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log XFSHYXDNKOZ;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log LWMABILYLPH;

			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public static readonly Log LYJPUAJLFCR;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log JZBQWUAXMAR;

			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly Log ZKOESGVFKRX;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log YIJTUISFCSX;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log RJKGSSRBSQM;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log POZCUBSVJJD;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log DOTULNMOESM;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log GIATILTHRJF;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log NYOGTWADHSM;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log ZNGNNLXNCSW;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log USBZZRFKATO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public static readonly Log IXKFGVVLAKZ;

				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public static readonly Log EALNDDKMANB;

				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public static readonly Log GBAEOIIEYQC;
			}

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private static readonly Log IXKFGVVLAKZ;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log OXJCWBGCEVB;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log XAMXJISYDRV;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log MJRZFCTEITY;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log UYKOEXQGEWT;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log RXAGCJZUORB;

			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly Log ONPTLWAXXBV;

			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public static readonly Log DOPDTIFAAEB;

			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly Log JLMGDYCMGYV;

			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly Log AVDBZCARTPD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private static readonly Log OAFYHDROXFH;

			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log NIJNGKMYKYD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log IXKFGVVLAKZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly Log IXKFGVVLAKZ;

			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public static readonly Log YFSNFIQUYCP;

			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public static readonly Log MWCKURHJXMH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public static readonly Log IXKFGVVLAKZ;

			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly Log WGCVMTMYNXX;

			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly Log GSMNHKITKKM;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class NQFSMKGQMWQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public class SJNZTKPJQUA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private readonly (int index, bool enabled)[] CKPIZNOHMKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private List<(int index, bool enabled)> GMSHSYOPJDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private bool THKILBWSGHF;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8373650", Offset = "0x8372A50", VA = "0x188373650")]
			internal SJNZTKPJQUA((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8373520", Offset = "0x8372920", VA = "0x188373520")]
			public IDisposable AVDUCVDTNLG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x83735A0", Offset = "0x83729A0", VA = "0x1883735A0", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class ONUGWMBKGUF
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly Log OAFYHDROXFH;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static readonly Log CQOUBCVSZCT;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static readonly Log OMCFIUTSAUC;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static readonly Log SMHJANFAIDD;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly Log ELNBUZVTJSR;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly Log DWEOROASPXF;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly Log CHDVSOHCRMK;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly Log FFSDWTXZFLH;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly Log FTIGLKRBHJT;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log YAXWJYTCMKD;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log AESHKABIKUV;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log OWVEEQXEPIU;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log NXTWELHBIDZ;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log BLSRMUROMBW;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log DDVBOMSLGNB;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log TRLHYBSBIID;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log BJXIJFWDHVS;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log LWMABILYLPH;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log ZEHTLRONYBN;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log PGOXREJQJJU;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log XIHAHQAUNTL;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log TGSEOOIHQMG;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log TDRCQWBYFZI;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log UDOIOBUVLTR;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log ZTWCHJPIWPK;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log SFPDHHFBRPM;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log DVOFWWORWXI;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log QQUPJIWBKYC;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log OJEUCNXEHWR;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log SIQHNQNMXKA;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log KSQOJZRPEUT;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log SWWHZAGOXSY;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log ZTSJYYQBBBN;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log WHVNEJOPMXK;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log MNAOWLAUXNN;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log VNLFNPBCVJE;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log GWVIGDVJBRQ;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log XBJBOLSLJFQ;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log YKOGGIONGZU;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log HCMLYDBYJYR;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log TPHZOIKUKUJ;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log JMHYPRJTTYP;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Log JRGWFEQQOEQ;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Log MKPNWXFBSLR;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly Log GASVOILGPJU;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly Log ZGSYKLOEQSS;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly Log MIKHOGREDXT;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly Log LVVMPPNWTZA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log RNQMCOSBXBA
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x836F6C0", Offset = "0x836EAC0", VA = "0x18836F6C0")]
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
	internal class KPPESYECZSK
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private KPPESYECZSK parent;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xBEF470", Offset = "0xBEE870", VA = "0x180BEF470")]
			public Scope(KPPESYECZSK parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private readonly Stopwatch TSUUNRKKXCR;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE07730", Offset = "0xE06B30", VA = "0x180E07730")]
		public Scope EVFRDTHOMPI()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x836BD30", Offset = "0x836B130", VA = "0x18836BD30")]
		public KPPESYECZSK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface NPZSTCTCBSB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void XCPAHPBRLGE(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZZNLPVXLPAA(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WALKOWSUKQW(object a, [Optional] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct LogRangeScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly object message;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x836C220", Offset = "0x836B620", VA = "0x18836C220")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x836C1B0", Offset = "0x836B5B0", VA = "0x18836C1B0", Slot = "4")]
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
		public abstract void MKOAUOREKWX();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class COEBPYQMATK
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static List<LogRegistrationIndex> UIIMOYXVLFR;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static bool LHYXHKNSNQU;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly object XOZUGKRROYP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> QAEFMREUQVV
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x83692D0", Offset = "0x83686D0", VA = "0x1883692D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8368D10", Offset = "0x8368110", VA = "0x188368D10")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83690C0", Offset = "0x83684C0", VA = "0x1883690C0")]
		private static void TCXXVGPKODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8368E80", Offset = "0x8368280", VA = "0x188368E80")]
		private static void RMKBIDEJSMG(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class ZFZQDPRYZJB
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			public void TAPOONAXWRT(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50")]
			public ParanoiaLevel WRMUGLFDBFL(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static Action ZNDFOXAYFTE;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly object WKMCVJBOAGG;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly Dictionary<(int parentIndex, string token), int> TFVESPAQGLW;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly List<string> BJZNMSZHPCM;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly List<int> ACAUBRRICGV;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly List<ulong> POHVZEGCQWF;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static readonly List<ulong> NPGVDSYLJEO;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly List<ulong> NOZMIOOPZHD;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly StringBuilder AXWUAHXCXLJ;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly KPPESYECZSK LPCOKWBHTEX;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static Debug NFPFMLWSSBD;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static int GSYVVWJAXQL;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static NPZSTCTCBSB RMDIZIAYCJM
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x8377410", Offset = "0x8376810", VA = "0x188377410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x83770D0", Offset = "0x83764D0", VA = "0x1883770D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool UUIQTIRAXAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8375DD0", Offset = "0x83751D0", VA = "0x188375DD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool RICYOSSDDWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8374F70", Offset = "0x8374370", VA = "0x188374F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool ZWRTDXOSBKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x83771C0", Offset = "0x83765C0", VA = "0x1883771C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8377BC0", Offset = "0x8376FC0", VA = "0x188377BC0")]
		static ZFZQDPRYZJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8375A30", Offset = "0x8374E30", VA = "0x188375A30")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8376360", Offset = "0x8375760", VA = "0x188376360")]
		public static int MKOAUOREKWX(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8376500", Offset = "0x8375900", VA = "0x188376500")]
		public static int MKOAUOREKWX(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8376E00", Offset = "0x8376200", VA = "0x188376E00")]
		public static Log ORPWUCEHZPT(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8377720", Offset = "0x8376B20", VA = "0x188377720")]
		public static void WLURTSFJEOG(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8376990", Offset = "0x8375D90", VA = "0x188376990")]
		public static void NZHOBXMICFZ(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8376F10", Offset = "0x8376310", VA = "0x188376F10")]
		public static bool PTMWXUMBHDV(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8375070", Offset = "0x8374470", VA = "0x188375070")]
		public static int DATFIJROSLM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8376BA0", Offset = "0x8375FA0", VA = "0x188376BA0")]
		public static string OGYYYECDQEV(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8374C60", Offset = "0x8374060", VA = "0x188374C60")]
		public static (string[], int[]) AESYDOJVNNI()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8375C40", Offset = "0x8375040", VA = "0x188375C40")]
		private static int JNQPHSSLDAW(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8374FC0", Offset = "0x83743C0", VA = "0x188374FC0")]
		private static int BWBBQWCZFCM(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83754F0", Offset = "0x83748F0", VA = "0x1883754F0")]
		private static int HGHEPLVFPFS(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8377AF0", Offset = "0x8376EF0", VA = "0x188377AF0")]
		private static int WTEQHLCGDNN(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8377920", Offset = "0x8376D20", VA = "0x188377920")]
		private static int WTEQHLCGDNN(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8374E00", Offset = "0x8374200", VA = "0x188374E00")]
		private static void AKCEKFGSFRM(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8377250", Offset = "0x8376650", VA = "0x188377250")]
		public static bool STIKBDKRSTY(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8376E50", Offset = "0x8376250", VA = "0x188376E50")]
		public static bool PQQFUIYTUBL(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8375E20", Offset = "0x8375220", VA = "0x188375E20")]
		public static void LIYONASKFWP(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x83765D0", Offset = "0x83759D0", VA = "0x1883765D0")]
		public static void NYGRGHWBLTK(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x83751C0", Offset = "0x83745C0", VA = "0x1883751C0")]
		private static void DZXDLUAKVNX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8375220", Offset = "0x8374620", VA = "0x188375220")]
		private static void FJHHWZJPXLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8376F90", Offset = "0x8376390", VA = "0x188376F90")]
		private static bool QTAURQJFQSR(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83775D0", Offset = "0x83769D0", VA = "0x1883775D0")]
		private static bool WKQNAQQYGNS(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8377140", Offset = "0x8376540", VA = "0x188377140")]
		private static bool SEPBCNEODVQ(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8377310", Offset = "0x8376710", VA = "0x188377310")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8375D60", Offset = "0x8375160", VA = "0x188375D60")]
		private static void KAMCVZMPIYG(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8377460", Offset = "0x8376860", VA = "0x188377460")]
		public static NQFSMKGQMWQ.SJNZTKPJQUA UXSACPIWVEE((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x83773D0", Offset = "0x83767D0", VA = "0x1883773D0")]
		public static void TAPOONAXWRT(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x83778E0", Offset = "0x8376CE0", VA = "0x1883778E0")]
		public static ParanoiaLevel WRMUGLFDBFL(int a)
		{
			return default(ParanoiaLevel);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum ParanoiaLevel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		FastDebug,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Debug,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Paranoid,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		SuperParanoid,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
