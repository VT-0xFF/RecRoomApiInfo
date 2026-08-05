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
		[Cpp2IlInjected.Address(RVA = "0x83F3C90", Offset = "0x83F3090", VA = "0x1883F3C90", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
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
			[Cpp2IlInjected.Address(RVA = "0xC6C430", Offset = "0xC6B830", VA = "0x180C6C430")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IAXDBLMGRUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x83F6120", Offset = "0x83F5520", VA = "0x1883F6120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool VJFWYCIRXNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x83F5D20", Offset = "0x83F5120", VA = "0x1883F5D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string XIQPRXQENAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x83F6540", Offset = "0x83F5940", VA = "0x1883F6540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool TJTYNZBKWRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x531C540", Offset = "0x531B940", VA = "0x18531C540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel DEPJRBOOVQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x83F5880", Offset = "0x83F4C80", VA = "0x1883F5880")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x83F6890", Offset = "0x83F5C90", VA = "0x1883F6890")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x12A3E30", Offset = "0x12A3230", VA = "0x1812A3E30")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83F68F0", Offset = "0x83F5CF0", VA = "0x1883F68F0")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3752EE0", Offset = "0x37522E0", VA = "0x183752EE0")]
		public void IUPSMACTODK<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83F58F0", Offset = "0x83F4CF0", VA = "0x1883F58F0")]
		public void IUPSMACTODK(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83F5A00", Offset = "0x83F4E00", VA = "0x1883F5A00")]
		public void IUPSMACTODK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83F6590", Offset = "0x83F5990", VA = "0x1883F6590")]
		public void ZUDTYARSLSP(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3751AD0", Offset = "0x3750ED0", VA = "0x183751AD0")]
		public void CECHSQCVHDW<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83F5300", Offset = "0x83F4700", VA = "0x1883F5300")]
		public void CECHSQCVHDW(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83F5420", Offset = "0x83F4820", VA = "0x1883F5420")]
		public void CECHSQCVHDW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x37521C0", Offset = "0x37515C0", VA = "0x1837521C0")]
		public void FSJDWXJXHJB<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83F5520", Offset = "0x83F4920", VA = "0x1883F5520")]
		public void FSJDWXJXHJB(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83F5650", Offset = "0x83F4A50", VA = "0x1883F5650")]
		public void FSJDWXJXHJB(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x37546F0", Offset = "0x3753AF0", VA = "0x1837546F0")]
		public void SUMMTIIBVMO<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x83F6030", Offset = "0x83F5430", VA = "0x1883F6030")]
		public void SUMMTIIBVMO(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83F5F50", Offset = "0x83F5350", VA = "0x1883F5F50")]
		public void SUMMTIIBVMO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3754200", Offset = "0x3753600", VA = "0x183754200")]
		public void SNGBXDCKYCR<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83F5D70", Offset = "0x83F5170", VA = "0x1883F5D70")]
		public void SNGBXDCKYCR(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83F5E70", Offset = "0x83F5270", VA = "0x1883F5E70")]
		public void SNGBXDCKYCR(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3755600", Offset = "0x3754A00", VA = "0x183755600")]
		public void ZWLRCDFXRZE<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83F66B0", Offset = "0x83F5AB0", VA = "0x1883F66B0")]
		public void ZWLRCDFXRZE(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83F67B0", Offset = "0x83F5BB0", VA = "0x1883F67B0")]
		public void ZWLRCDFXRZE(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83F4FA0", Offset = "0x83F43A0", VA = "0x1883F4FA0")]
		public void APTZOMLZTPP(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83F6170", Offset = "0x83F5570", VA = "0x1883F6170")]
		public void VMJLMYPZPUS(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3753D70", Offset = "0x3753170", VA = "0x183753D70")]
		public LogRangeScope KZRBCJQQGOV<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0")]
		public LogRangeScope QZFHOFEOCBW<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83F5B00", Offset = "0x83F4F00", VA = "0x1883F5B00")]
		public LogRangeScope KZRBCJQQGOV(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83F5C20", Offset = "0x83F5020", VA = "0x1883F5C20")]
		public LogRangeScope KZRBCJQQGOV(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDE8FC0", Offset = "0xDE83C0", VA = "0x180DE8FC0")]
		public LogRangeScope QZFHOFEOCBW(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83F5220", Offset = "0x83F4620", VA = "0x1883F5220")]
		public void BPAJNOJONTT(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x83F5010", Offset = "0x83F4410", VA = "0x1883F5010")]
		public void BPAJNOJONTT(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3747F90", Offset = "0x3747390", VA = "0x183747F90")]
		public void BPAJNOJONTT<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
		public void GFSUBHOWYQW([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83F5760", Offset = "0x83F4B60", VA = "0x1883F5760")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83F61E0", Offset = "0x83F55E0", VA = "0x1883F61E0")]
		private static void VPELLPKKDYK(Exception a, StringBuilder b, int c = 0, int d = 5)
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
			public static readonly Log SBCPALJHIIU;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log VBSFUIYUNST;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log QDUKOGHQYRF;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log YCRKQIQZLJK;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log VQVHWHVOHGG;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log QZRKKESGWQS;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log NVURNYXNXAF;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log KKGPOGZWBNA;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log LECEZQWKLJF;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log NWTWXUSSHEO;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log DBQDWEFQHRC;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log LTVKDXJHVAQ;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log ANWIRUFCOHU;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log KZIMFFRHATR;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log CZBNIXOJCPX;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log VTSVEDTTUMZ;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log FZAYWZSPZGD;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log KUNNBLDRZYI;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log ISAVFPYGAVN;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log LPZPNKGLZKR;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log WPYROYVOBQP;
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
					public static readonly Log YQUACTRGRPH;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log YEMSPUMVWUV;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log YQUACTRGRPH;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log LVYTMABRKGD;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log DHMJPDMDRJY;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log KEUGLGICFGU;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log BHKBVRHTXYK;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log EAFZMLTBCKM;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log UMVXAMWDTUY;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log YQUACTRGRPH;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log LVYTMABRKGD;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log KEUGLGICFGU;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log BHKBVRHTXYK;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log OXVEIQTADYN;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log YCTGVKVOBKU;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log AZGUOYSJBCY;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log YQUACTRGRPH;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log BXPLQQWEQOO;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log LTBPAEVLTJJ;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log YQUACTRGRPH;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log NHAWRKWEAIB;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log NGVPUECGQWS;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log NGQIWXIJHLJ;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log NGLBZQOLYAA;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log NHVYGLXTMBL;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log NHQRJFDWCQC;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log NHLKLYJYTET;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log NHGDORQBJTK;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log NFKTNISZCVH;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log NFFMQBZBTJY;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log YQUACTRGRPH;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log NHAWRKWEAIB;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log NGVPUECGQWS;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log NGQIWXIJHLJ;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log NGLBZQOLYAA;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log NHVYGLXTMBL;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log NHQRJFDWCQC;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log NHLKLYJYTET;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log NHGDORQBJTK;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log NFKTNISZCVH;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log NFFMQBZBTJY;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log YQUACTRGRPH;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log SLQLWYXZGEN;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log WTCYQQAJFNF;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log YRBIDNQMLOL;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log JRVNIBEGRHJ;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log YQUACTRGRPH;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log GPHHDZCRIVO;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log NYZDNAPJXBA;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log IJEPLYBYABR;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log OSWOUJRQWIQ;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log NHSVHTEMGKH;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log HGGYJVOLZHD;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log YQUACTRGRPH;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log BTDGQNYMWYF;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log RGPLQFAIJFF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log FMFKXMUOCVG;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log CEUJVALJJND;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log EFYTQSZDJGJ;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log SWCBDIJAVGB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log LXARLMDQWLH;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log MXUYNFQMBWO;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log KKOYBQHRBNP;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log OBAVPYYGRFR;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log LKBXVJMCNKY;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log HZHCSSFHBHI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log EHDMIUIKHIT;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log LTXCAKBZTXY;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log TQLWSIMWNLU;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log RKOAURLWOQB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log EOKJXQKEYAL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log OIWAOXUSPXH;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log CAMQDXTJNTL;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log OBAVPYYGRFR;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log XXSRZRJPMOT;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log WPYROYVOBQP;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log PTYLICLJXOP;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log FCNKGQSGZKS;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log NHSVHTEMGKH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log YQUACTRGRPH;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log ZUPHMXKKOZJ;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log VTKUKADNNHI;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log ZKHKYZCWSOP;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log HHTLGLSQJMC;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log OBAVPYYGRFR;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log LUUTQYGGDPZ;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log TLJTFFWOPHT;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log UAJAWRMLTMQ;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log BQXCLWDPRMW;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log IWEHADXMVQS;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log UTEPXOEMVFK;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log QXEDVNCZAAQ;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log RCFCIFUDTGO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log FYDYEJTXFUL;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log OBAVPYYGRFR;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log DNPFDQSIRQL;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log MTIPUPJGBRK;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log GALRDRAXEKR;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log CTFQVVBPFQY;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log ERYCIBKGKTZ;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log AAKGPXVOWPV;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log BCDNLEHNJFF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log CTIUGGAOASE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x4000089")]
				private static readonly Log ISWOYAUQWZP;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008A")]
				public static readonly Log YQUACTRGRPH;

				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public static readonly Log HCQNIETEDIZ;

				[Cpp2IlInjected.Token(Token = "0x400008C")]
				public static readonly Log INPLTRITOTF;

				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log YWJKOHNNZDT;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log DPOARNEYUXC;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log PKXAXMKFYDL;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log KXJYIJVHSHG;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log BHZMTSVPTVQ;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log QCGKZZPFAJG;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log NWTWXUSSHEO;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log OXVEIQTADYN;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log HZVFCJIFCJJ;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log ZBFNJKJSRMY;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log JNBRJWHHBWC;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log HGSVFTBABQP;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log OVQPBETENHA;
			}

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly Log YQUACTRGRPH;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A2")]
				public static readonly Log YQUACTRGRPH;

				[Cpp2IlInjected.Token(Token = "0x40000A3")]
				public static readonly Log HLUPEVCXVCT;

				[Cpp2IlInjected.Token(Token = "0x40000A4")]
				public static readonly Log BSODRGGGVAX;

				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log KHTEEVPSPPL;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log FBDQQRHPLML;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B2")]
					private static readonly Log ISWOYAUQWZP;

					[Cpp2IlInjected.Token(Token = "0x40000B3")]
					public static readonly Log DFHRWZUZQFI;

					[Cpp2IlInjected.Token(Token = "0x40000B4")]
					public static readonly Log PGVRYCPBYFJ;

					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					public static readonly Log EIJGJLIWLPS;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log YPOZFORNBLC;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log NFQIKZOOCYK;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log KHTEEVPSPPL;

					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public static readonly Log EESNZHZYMFM;
				}

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log YQUACTRGRPH;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log EHYLMOOHJQQ;

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log EALDWGXZAQX;

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log CQWOVYOKDVQ;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log NLOEDJEXPTX;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log BSODRGGGVAX;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log IKASHGLDQKL;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log TNWJWTTAQEG;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log KPMRJQDWEFN;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log JLSQMQGJVUU;

				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public static readonly Log FXLEJGBGUMT;
			}

			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public static readonly Log YQUACTRGRPH;

			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public static readonly Log FXYVTNZYFBX;

			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public static readonly Log SEOJWXWDAIS;

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log CVVLMQJEBRJ;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log MDQIOYGCYGN;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log CBLQLOQTYPT;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log CIKEMECPMFQ;

			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly Log WINAIHSZRVM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public static readonly Log YQUACTRGRPH;

				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public static readonly Log NXKEWFRHICG;

				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public static readonly Log EDAYQFFEQQX;

				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log SKDYFXGCJCR;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log JAZCGIDFNIZ;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log SDVOOZODIQA;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log ORNFTYXJOPE;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log OSJVCCKNAKD;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log WCBHMSCVIUN;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log CMSVEFJCBXW;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log XLWTUPFQRPM;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log DAPNETNWMZR;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log WMZNOQRCPFA;

				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log UJFVGUSRGYI;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log YQUACTRGRPH;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log KIPFUPPYCOU;

				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log EXGBFCPJUII;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class MJPKPRJRQUT
			{
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log YQUACTRGRPH;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log KUKHONDCAKG;

				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log NFUNAUEMIWC;

				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public static readonly Log KVYCOXCXAIX;
			}

			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public static readonly Log YQUACTRGRPH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public static readonly Log WULMKRFDIGP;

			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public static readonly Log TVUJMOGBKNC;

			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public static readonly Log JKABDTQXWJZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public static readonly Log FCTCHZCODEN;

			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly Log CDUGEUXXMXH;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log OVQPBETENHA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log YQUACTRGRPH;

			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log DDUDHPNKATF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public static readonly Log YQUACTRGRPH;

			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public static readonly Log VCDIKEHWQKF;

			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public static readonly Log RMMSEANACMI;

			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public static readonly Log ORGUBYBTKHB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public static readonly Log YQUACTRGRPH;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log NTUBKOVMKXG;

			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log RGICTTJTRTR;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log QWTMSCZDFVP;

			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log WGTOKMZHNDN;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log TSXQLMXJAVP;

			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log LIFKTZDNIJM;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log AJKQSNUGPDR;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log KIGRTYSKUAT;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log OBAVPYYGRFR;

			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log ACHDYDPEVBS;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log USCSXKJPLMQ;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log HZHQOKMPNHQ;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log TOKAJEXXAPE;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log TCBDKKSEPFY;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log CEAPSJQUDXE;

			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log CQVXXKIJALL;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log TTDTQNWJFFX;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log YQUACTRGRPH;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log YCRKQIQZLJK;

			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log GNIYQIXYVSD;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log OMYJALJDNRS;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log EDSYDUGPXUL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log DABTQBNYOMC;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log ZRSKVMMBCPM;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly Log HIINVYAVMUF;

			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log BCNEAXEYYEE;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log WODEOXSVRHP;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log PXDWTZFGPBX;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log UTVDFMKPNXT;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log LHPSQOLWOGR;

			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public static readonly Log QYXPSNHBFEZ;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log FHIVTZJVWPZ;

			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly Log NSSDEPPQLTG;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log MVRDLUDZJBP;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log CMLTBXGKPHK;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log CIXJCICIZRZ;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log KXHAHZRVUEA;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log WEZTGBGRNNY;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log AZGUOYSJBCY;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public static readonly Log YQUACTRGRPH;

				[Cpp2IlInjected.Token(Token = "0x4000113")]
				public static readonly Log XRIIXYQLWQX;

				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public static readonly Log NGLUHYZJDCO;
			}

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private static readonly Log YQUACTRGRPH;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log JWRANETULIL;

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly Log NCGPVEKQIFF;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log ZUTTVYXRGOG;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log GVTJXFQADEX;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log YZGNKTOMJFB;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log NTLBAJZDNZJ;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log ZFXDYJVOHXL;

			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly Log IRBVMXHQSVH;

			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public static readonly Log GYBJEWEOQQZ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private static readonly Log ISWOYAUQWZP;

			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public static readonly Log BWFRRHWGLOH;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public static readonly Log YQUACTRGRPH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log YQUACTRGRPH;

			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log XHBCQWQGIMP;

			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly Log QIOEBPVOIJV;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public static readonly Log YQUACTRGRPH;

			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public static readonly Log AQBFKJPDWGZ;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class YZFTJIOIWCE
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public class WYGCVRGPHVO : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private readonly (int index, bool enabled)[] TBLGJRHFNMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private List<(int index, bool enabled)> JGLBBVMNMLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private bool CWUBGNTQSSD;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x83FB060", Offset = "0x83FA460", VA = "0x1883FB060")]
			internal WYGCVRGPHVO((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x83FAFE0", Offset = "0x83FA3E0", VA = "0x1883FAFE0")]
			public IDisposable FESZZGJGLAA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x83FAF30", Offset = "0x83FA330", VA = "0x1883FAF30", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class YBSKZFYCANH
	{
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static readonly Log ISWOYAUQWZP;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly Log AVQUSDUMKSD;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly Log BMHHPXUSFNQ;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly Log ABVQQDHBFCN;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static readonly Log GQAZANOWWYV;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static readonly Log LKKUHZDSDNV;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static readonly Log TFMKVZIWMFI;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly Log HIINVYAVMUF;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly Log IRQYFESAHHD;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly Log CQINOCYTKYT;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly Log TSHIAIKNEOF;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly Log IKABDCRUCBK;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log WBAXDAZKXYP;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log LMCAQENBCJC;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log IBBTTFVLLAL;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log QNDAFVZBHUD;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log FVWUVYLOGCY;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log PXDWTZFGPBX;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log NUTTESZNWWH;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log VYOVZAIOSMG;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log ZLERSBIERUN;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log NWTWXUSSHEO;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log SYYJLNSMWZQ;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log UFUQQKWBJPF;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log EGFOQSVFQXO;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log AATZZAXDLVU;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log EFETNCZEEJY;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log XXTZYERHORM;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log XQUQDSTNWYN;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log BBQHFCFOPXC;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log RMLTWACOSBF;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log QMEXTDNIFZG;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log ZNDAXODIMVV;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log BYXJSWDCIAE;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log JKBZIWJOAST;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log DHMJPDMDRJY;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log EVHFTAVGGAC;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log VCUQPJSZFWC;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log FUAPKEZRLKK;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log XVXXZNHOSQB;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log MVYRHEQQYEN;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log JHKPUZGRVKP;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log YEWVMYPVAOA;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log MJCYJGJOWNB;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log DUCVVSQDJHM;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Log IWTFBIPMLPI;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Log LUVNUCWTXOZ;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly Log IUSSBXGBMFQ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log VOSGMAOKRIO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x83FB1B0", Offset = "0x83FA5B0", VA = "0x1883FB1B0")]
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
	internal class NFATQWMJDWG
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private NFATQWMJDWG parent;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xBB8570", Offset = "0xBB7970", VA = "0x180BB8570")]
			public Scope(NFATQWMJDWG parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly Stopwatch NHTAAMTFLWV;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xDC6330", Offset = "0xDC5730", VA = "0x180DC6330")]
		public Scope GMYRHDUDHAW()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x83F6F10", Offset = "0x83F6310", VA = "0x1883F6F10")]
		public NFATQWMJDWG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface MQAJXTMNVHT
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IUPSMACTODK(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CECHSQCVHDW(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SUMMTIIBVMO(object a, [Optional] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct LogRangeScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private readonly object message;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x83F3BF0", Offset = "0x83F2FF0", VA = "0x1883F3BF0")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x83F3B80", Offset = "0x83F2F80", VA = "0x1883F3B80", Slot = "4")]
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
		public abstract void SHWXSEAJSCT();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class JCDYXGZLHPS
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private static List<LogRegistrationIndex> YMMOJUUTHDB;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private static bool ZFIWQTWPVEQ;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private static readonly object LCVPORGLVTR;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> SNTSIHYPTRF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x83F3160", Offset = "0x83F2560", VA = "0x1883F3160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x83F31A0", Offset = "0x83F25A0", VA = "0x1883F31A0")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83F3310", Offset = "0x83F2710", VA = "0x1883F3310")]
		private static void LYKFPEZDYWJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x83F3520", Offset = "0x83F2920", VA = "0x1883F3520")]
		private static void PKVHTEVNDYG(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class EXWXZJRXOVB
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
			public void MIGCEKWNEFH(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAED770", Offset = "0xAECB70", VA = "0x180AED770")]
			public ParanoiaLevel CDIPCGUANGV(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static Action NQDKLOGUIZA;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static readonly object XEWSBNYMXIS;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly Dictionary<(int parentIndex, string token), int> LLEOLHVPBEM;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly List<string> JJHJBKRDMBG;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly List<int> YYLGHTFHBMJ;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly List<ulong> RYEPELKKGMV;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly List<ulong> UZZZCGYFRJI;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly List<ulong> SSZXFUPDCUR;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly StringBuilder RNYRUSEAZHV;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static readonly NFATQWMJDWG KBRWMMHEUWD;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static Debug GRKJXWPCXHX;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static int XDSCIOCWTDB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static MQAJXTMNVHT KJPPRXDQMSO
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x83F1450", Offset = "0x83F0850", VA = "0x1883F1450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x83F0620", Offset = "0x83EFA20", VA = "0x1883F0620")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool KTDXIJMFSRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x83F0360", Offset = "0x83EF760", VA = "0x1883F0360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool CWSKICZKIRV
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x83EEA10", Offset = "0x83EDE10", VA = "0x1883EEA10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool PDPDQGTEMLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x83EE6E0", Offset = "0x83EDAE0", VA = "0x1883EE6E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x83F14A0", Offset = "0x83F08A0", VA = "0x1883F14A0")]
		static EXWXZJRXOVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x83EEFB0", Offset = "0x83EE3B0", VA = "0x1883EEFB0")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x83F03B0", Offset = "0x83EF7B0", VA = "0x1883F03B0")]
		public static int SHWXSEAJSCT(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83F0550", Offset = "0x83EF950", VA = "0x1883F0550")]
		public static int SHWXSEAJSCT(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x83EEF60", Offset = "0x83EE360", VA = "0x1883EEF60")]
		public static Log ICFBJHCLOJX(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x83EF1C0", Offset = "0x83EE5C0", VA = "0x1883EF1C0")]
		public static void JGVZEYHSCCC(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x83F11C0", Offset = "0x83F05C0", VA = "0x1883F11C0")]
		public static void VXYXPPSAOIH(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83EEDC0", Offset = "0x83EE1C0", VA = "0x1883EEDC0")]
		public static bool GGXRLINRNGD(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83EFD90", Offset = "0x83EF190", VA = "0x1883EFD90")]
		public static int NQAIXPYZHTU(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83F0C90", Offset = "0x83F0090", VA = "0x1883F0C90")]
		public static string UGLFETQWFND(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x83EE540", Offset = "0x83ED940", VA = "0x1883EE540")]
		public static (string[], int[]) AQPWGXUHDHA()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x83EEBE0", Offset = "0x83EDFE0", VA = "0x1883EEBE0")]
		private static int ERXVSMHLLCG(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x83EEE40", Offset = "0x83EE240", VA = "0x1883EEE40")]
		private static int HCDKVPNKFLO(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x83EF850", Offset = "0x83EEC50", VA = "0x1883EF850")]
		private static int MPXIBNNOKYU(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83EE770", Offset = "0x83EDB70", VA = "0x1883EE770")]
		private static int BHZQSLGFCJN(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83EE840", Offset = "0x83EDC40", VA = "0x1883EE840")]
		private static int BHZQSLGFCJN(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83EF380", Offset = "0x83EE780", VA = "0x1883EF380")]
		private static void JYPLXFWHCVU(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83EED00", Offset = "0x83EE100", VA = "0x1883EED00")]
		public static bool ETZJCCGGGRQ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x83F02A0", Offset = "0x83EF6A0", VA = "0x1883F02A0")]
		public static bool RNQOGUCHVAF(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x83F0750", Offset = "0x83EFB50", VA = "0x1883F0750")]
		public static void TYJRYOEPRYH(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x83EFEE0", Offset = "0x83EF2E0", VA = "0x1883EFEE0")]
		public static void QZPEPUTNXUE(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x83EF7B0", Offset = "0x83EEBB0", VA = "0x1883EF7B0")]
		private static void LEOEVXJGHDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x83F0EF0", Offset = "0x83F02F0", VA = "0x1883F0EF0")]
		private static void UIZXCPIRBSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x83EEAA0", Offset = "0x83EDEA0", VA = "0x1883EEAA0")]
		private static bool CLUCMTGFQNX(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x83EF660", Offset = "0x83EEA60", VA = "0x1883EF660")]
		private static bool LDCIUYHPMEI(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x83F13D0", Offset = "0x83F07D0", VA = "0x1883F13D0")]
		private static bool WXKPRRAURNM(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x83F0690", Offset = "0x83EFA90", VA = "0x1883F0690")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x83EEEF0", Offset = "0x83EE2F0", VA = "0x1883EEEF0")]
		private static void HTXAUVBQVDQ(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x83EF4F0", Offset = "0x83EE8F0", VA = "0x1883EF4F0")]
		public static YZFTJIOIWCE.WYGCVRGPHVO KDGTTXQDHDC((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x83EF810", Offset = "0x83EEC10", VA = "0x1883EF810")]
		public static void MIGCEKWNEFH(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x83EEA60", Offset = "0x83EDE60", VA = "0x1883EEA60")]
		public static ParanoiaLevel CDIPCGUANGV(int a)
		{
			return default(ParanoiaLevel);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum ParanoiaLevel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		FastDebug,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Debug,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		Paranoid,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		SuperParanoid,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
