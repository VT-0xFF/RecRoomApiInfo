using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer;
using RecRoom.Foundation;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.SynchronizedFields;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface UJHHKPUJOKV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool IGCVSUYRXVW
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool HQKPLFSVRCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		PPTCRKDFMWF LDCNDDLIBQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int MGIOJNHADGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool OFDBMCMRSTZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool KDERPQQCQHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action FVFZZYHANOM;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void DDHUYAXEAJT();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void GSJAAQCRMSZ(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RUZBSBDYOZB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface SHIPZXAWMBA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string GDITXKPDJXL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool AWZPAQNAHKX
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface KCSINCSLNDT<a> : SHIPZXAWMBA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a OKPHEENBODB
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NNNYBGONPRQ(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class LBHFSEIACUC<a> : KCSINCSLNDT<a>, SHIPZXAWMBA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly ANYDKCTSBKX<a> YYBTNYLECQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly ANYDKCTSBKX<a> AWPATOHSIZU;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string GDITXKPDJXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xF8EEE0", Offset = "0xF8E2E0", VA = "0x180F8EEE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AVNRZDBPYFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x688EE60", Offset = "0x688E260", VA = "0x18688EE60", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a MBOJBLRLUXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6890340", Offset = "0x688F740", VA = "0x186890340", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x688D070", Offset = "0x688C470", VA = "0x18688D070", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a OKPHEENBODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x688E470", Offset = "0x688D870", VA = "0x18688E470", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x688E5A0", Offset = "0x688D9A0", VA = "0x18688E5A0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a FCAQLXAUMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x688E470", Offset = "0x688D870", VA = "0x18688E470")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x688F6C0", Offset = "0x688EAC0", VA = "0x18688F6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool AWZPAQNAHKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x687F110", Offset = "0x687E510", VA = "0x18687F110", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x687ECF0", Offset = "0x687E0F0", VA = "0x18687ECF0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x688C8F0", Offset = "0x688BCF0", VA = "0x18688C8F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x688E920", Offset = "0x688DD20", VA = "0x18688E920", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6891B10", Offset = "0x6890F10", VA = "0x186891B10")]
		public LBHFSEIACUC([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x688D7B0", Offset = "0x688CBB0", VA = "0x18688D7B0")]
		private void LNQKBZDHKGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x688E000", Offset = "0x688D400", VA = "0x18688E000", Slot = "5")]
		public void NNNYBGONPRQ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x688E3A0", Offset = "0x688D7A0", VA = "0x18688E3A0")]
		public void NNNYBGONPRQ(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x687E650", Offset = "0x687DA50", VA = "0x18687E650", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class LBBYUXOCTIT<a, b> : KCSINCSLNDT<(a, b)>, SHIPZXAWMBA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly AODKHJNPKWG<a, b> YYBTNYLECQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly AODKHJNPKWG<a, b> AWPATOHSIZU;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string GDITXKPDJXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xF8EEE0", Offset = "0xF8E2E0", VA = "0x180F8EEE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool AVNRZDBPYFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6889940", Offset = "0x6888D40", VA = "0x186889940", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool TLGSHGGEVKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x688B270", Offset = "0x688A670", VA = "0x18688B270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool TLWMZANWXSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x688B7E0", Offset = "0x688ABE0", VA = "0x18688B7E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) MBOJBLRLUXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x688ADD0", Offset = "0x688A1D0", VA = "0x18688ADD0", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6887FC0", Offset = "0x68873C0", VA = "0x186887FC0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) OKPHEENBODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x688A010", Offset = "0x6889410", VA = "0x18688A010", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6888D30", Offset = "0x6888130", VA = "0x186888D30", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) FCAQLXAUMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6888C00", Offset = "0x6888000", VA = "0x186888C00")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x688A2B0", Offset = "0x68896B0", VA = "0x18688A2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a JHZOMUOKJLR
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6885AC0", Offset = "0x6884EC0", VA = "0x186885AC0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x68869D0", Offset = "0x6885DD0", VA = "0x1868869D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a LVVNDRBRRMW
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6886380", Offset = "0x6885780", VA = "0x186886380")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x68860F0", Offset = "0x68854F0", VA = "0x1868860F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a EGPPWFQWXWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6886380", Offset = "0x6885780", VA = "0x186886380")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x688A660", Offset = "0x6889A60", VA = "0x18688A660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b JIEVKBIHSXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x68859A0", Offset = "0x6884DA0", VA = "0x1868859A0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6886560", Offset = "0x6885960", VA = "0x186886560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b LVQGGKHUIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6886340", Offset = "0x6885740", VA = "0x186886340")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b EGKIYYWZOLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6886340", Offset = "0x6885740", VA = "0x186886340")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x688AB00", Offset = "0x6889F00", VA = "0x18688AB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool AWZPAQNAHKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x687F110", Offset = "0x687E510", VA = "0x18687F110", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x687ECF0", Offset = "0x687E0F0", VA = "0x18687ECF0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6889270", Offset = "0x6888670", VA = "0x186889270", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x688C160", Offset = "0x688B560", VA = "0x18688C160")]
		public LBBYUXOCTIT([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6888380", Offset = "0x6887780", VA = "0x186888380")]
		private void LNQKBZDHKGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6885CA0", Offset = "0x68850A0", VA = "0x186885CA0")]
		public void BCUOVOJJQPF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x68889F0", Offset = "0x6887DF0", VA = "0x1868889F0")]
		public void NNNYBGONPRQ(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6886F90", Offset = "0x6886390", VA = "0x186886F90", Slot = "5")]
		private void HIGVUDPSPVH((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x687E650", Offset = "0x687DA50", VA = "0x18687E650", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class LAWRXQUFJXK<a, b, c> : KCSINCSLNDT<(a, b, c)>, SHIPZXAWMBA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly AOIREQHMUHP<a, b, c> YYBTNYLECQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly AOIREQHMUHP<a, b, c> AWPATOHSIZU;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string GDITXKPDJXL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xF8EEE0", Offset = "0xF8E2E0", VA = "0x180F8EEE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool AVNRZDBPYFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6883340", Offset = "0x6882740", VA = "0x186883340", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool TLGSHGGEVKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x68848E0", Offset = "0x6883CE0", VA = "0x1868848E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool TLWMZANWXSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6884CC0", Offset = "0x68840C0", VA = "0x186884CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool TLRGBTTZOHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6884F80", Offset = "0x6884380", VA = "0x186884F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) MBOJBLRLUXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6884400", Offset = "0x6883800", VA = "0x186884400", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6882060", Offset = "0x6881460", VA = "0x186882060", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) OKPHEENBODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6883D40", Offset = "0x6883140", VA = "0x186883D40", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6882910", Offset = "0x6881D10", VA = "0x186882910", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a JHZOMUOKJLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6880700", Offset = "0x687FB00", VA = "0x186880700")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6881530", Offset = "0x6880930", VA = "0x186881530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a LVVNDRBRRMW
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6880D20", Offset = "0x6880120", VA = "0x186880D20")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a EGPPWFQWXWK
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6880D20", Offset = "0x6880120", VA = "0x186880D20")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6883F90", Offset = "0x6883390", VA = "0x186883F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b JIEVKBIHSXA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6880620", Offset = "0x687FA20", VA = "0x186880620")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x68810C0", Offset = "0x68804C0", VA = "0x1868810C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b LVQGGKHUIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6880B60", Offset = "0x687FF60", VA = "0x186880B60")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b EGKIYYWZOLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6880B60", Offset = "0x687FF60", VA = "0x186880B60")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6884020", Offset = "0x6883420", VA = "0x186884020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c JIKCHICFCIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6880540", Offset = "0x687F940", VA = "0x186880540")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6881040", Offset = "0x6880440", VA = "0x186881040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c LVKZJDNWYQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6880CF0", Offset = "0x68800F0", VA = "0x186880CF0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c EGFCBSDCEZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6880CF0", Offset = "0x68800F0", VA = "0x186880CF0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6884300", Offset = "0x6883700", VA = "0x186884300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool AWZPAQNAHKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x687F110", Offset = "0x687E510", VA = "0x18687F110", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6882DC0", Offset = "0x68821C0", VA = "0x186882DC0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68857B0", Offset = "0x6884BB0", VA = "0x1868857B0")]
		public LAWRXQUFJXK([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6882550", Offset = "0x6881950", VA = "0x186882550")]
		private void LNQKBZDHKGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x68807E0", Offset = "0x687FBE0", VA = "0x1868807E0")]
		public void BCUOVOJJQPF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6883680", Offset = "0x6882A80", VA = "0x186883680")]
		public void UPLRVXHJHRS(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6882F10", Offset = "0x6882310", VA = "0x186882F10")]
		public void SGBAYPOOBZT(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6882630", Offset = "0x6881A30", VA = "0x186882630")]
		public void NNNYBGONPRQ(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6881680", Offset = "0x6880A80", VA = "0x186881680", Slot = "5")]
		private void GMLRJUXRGMO((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x687E650", Offset = "0x687DA50", VA = "0x18687E650", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class LARLAKAIAMB<a, b, c, d> : KCSINCSLNDT<(a, b, c, d)>, SHIPZXAWMBA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly AMXUXUYFGGE<a, b, c, d> YYBTNYLECQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly AMXUXUYFGGE<a, b, c, d> AWPATOHSIZU;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string GDITXKPDJXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xF8EEE0", Offset = "0xF8E2E0", VA = "0x180F8EEE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) OKPHEENBODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x687F4E0", Offset = "0x687E8E0", VA = "0x18687F4E0", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x687F0C0", Offset = "0x687E4C0", VA = "0x18687F0C0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b LVQGGKHUIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x687E490", Offset = "0x687D890", VA = "0x18687E490")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c LVKZJDNWYQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x687E570", Offset = "0x687D970", VA = "0x18687E570")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d LVFSLWTZPEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x687E3B0", Offset = "0x687D7B0", VA = "0x18687E3B0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool AWZPAQNAHKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x687F110", Offset = "0x687E510", VA = "0x18687F110", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x687ECF0", Offset = "0x687E0F0", VA = "0x18687ECF0", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x687F9B0", Offset = "0x687EDB0", VA = "0x18687F9B0")]
		public LARLAKAIAMB([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x687E8F0", Offset = "0x687DCF0", VA = "0x18687E8F0")]
		private void LNQKBZDHKGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x687E2C0", Offset = "0x687D6C0", VA = "0x18687E2C0")]
		public void BCUOVOJJQPF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x687E9F0", Offset = "0x687DDF0", VA = "0x18687E9F0")]
		public void NNNYBGONPRQ(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x687F480", Offset = "0x687E880", VA = "0x18687F480", Slot = "5")]
		private void UJPBWBMSKPC((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x687E650", Offset = "0x687DA50", VA = "0x18687E650", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class ZDYZHFBEKLR
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x98D8B50", Offset = "0x98D7F50", VA = "0x1898D8B50")]
		public static string PSGRWNXQKWS(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD5FA70", Offset = "0xD5EE70", VA = "0x180D5FA70")]
		public static NetworkSetterPermissionMode BBQZJAFBNAH(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class ANYDKCTSBKX<a> : ECIUCMGYGUO<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7260AD0", Offset = "0x725FED0", VA = "0x187260AD0")]
		public ANYDKCTSBKX([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x725FA80", Offset = "0x725EE80", VA = "0x18725FA80")]
		public ANYDKCTSBKX(RCSERIFJNPS a, PPTCRKDFMWF b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] KYWQGMNBKCS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x725D9A0", Offset = "0x725CDA0", VA = "0x18725D9A0")]
		public ANYDKCTSBKX(RCSERIFJNPS a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] KYWQGMNBKCS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x725F260", Offset = "0x725E660", VA = "0x18725F260")]
		public ANYDKCTSBKX(RCSERIFJNPS a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] KYWQGMNBKCS g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AODKHJNPKWG<a, b> : ECDNFFNAXJF<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7265740", Offset = "0x7264B40", VA = "0x187265740")]
		public AODKHJNPKWG([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7264E30", Offset = "0x7264230", VA = "0x187264E30")]
		public AODKHJNPKWG(RCSERIFJNPS a, PPTCRKDFMWF b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] KYWQGMNBKCS h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7263070", Offset = "0x7262470", VA = "0x187263070")]
		public AODKHJNPKWG(RCSERIFJNPS a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] KYWQGMNBKCS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x72623A0", Offset = "0x72617A0", VA = "0x1872623A0")]
		public AODKHJNPKWG(RCSERIFJNPS a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] KYWQGMNBKCS h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AOIREQHMUHP<a, b, c> : EBYGHYTDNXW<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7266EE0", Offset = "0x72662E0", VA = "0x187266EE0")]
		public AOIREQHMUHP([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7266C90", Offset = "0x7266090", VA = "0x187266C90")]
		public AOIREQHMUHP(RCSERIFJNPS a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] KYWQGMNBKCS h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AMXUXUYFGGE<a, b, c, d> : EDJCOUCLBZH<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x72596D0", Offset = "0x7258AD0", VA = "0x1872596D0")]
		public AMXUXUYFGGE([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7259BC0", Offset = "0x7258FC0", VA = "0x187259BC0")]
		public AMXUXUYFGGE(RCSERIFJNPS a, PPTCRKDFMWF b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] KYWQGMNBKCS j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7258EB0", Offset = "0x72582B0", VA = "0x187258EB0")]
		public AMXUXUYFGGE(RCSERIFJNPS a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] KYWQGMNBKCS i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ANDBVBSCPRN<a, b, c, d, e> : EDDVRNINSNY<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x725B100", Offset = "0x725A500", VA = "0x18725B100")]
		public ANDBVBSCPRN(RCSERIFJNPS a, PPTCRKDFMWF b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] KYWQGMNBKCS k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x725B6C0", Offset = "0x725AAC0", VA = "0x18725B6C0")]
		public ANDBVBSCPRN(RCSERIFJNPS a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] KYWQGMNBKCS j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class IRPLDGNELUY<a> : ECIUCMGYGUO<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6563C90", Offset = "0x6563090", VA = "0x186563C90")]
		public IRPLDGNELUY(PPTCRKDFMWF a, string b, a c, [Optional] Action d, [Optional] KYWQGMNBKCS e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ISFFVAUWOCZ<a, b> : ECDNFFNAXJF<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x65643F0", Offset = "0x65637F0", VA = "0x1865643F0")]
		public ISFFVAUWOCZ(PPTCRKDFMWF a, string b, a c, b d, [Optional] Action e, [Optional] KYWQGMNBKCS f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface CZZRUQERUMQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ANYDKCTSBKX<a> PNABXCLGEQU<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class FMQXCIYLVAN : CZZRUQERUMQ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly KYWQGMNBKCS XITDWDEIIVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly RCSERIFJNPS DGWPTYIAQJX;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xCFB220", Offset = "0xCFA620", VA = "0x180CFB220")]
		public FMQXCIYLVAN(KYWQGMNBKCS a, RCSERIFJNPS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3AA5AB0", Offset = "0x3AA4EB0", VA = "0x183AA5AB0", Slot = "4")]
		public ANYDKCTSBKX<a> PNABXCLGEQU<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface RQHQOBEQDPT : RCSERIFJNPS
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId YQZJKKFCAWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface RCSERIFJNPS
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool NHEZHBFUXHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool ZSDNRDOGIKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string ZCSVBZHEWOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool BBKXRTXWOVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(KBTHGARWTVA handler);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(KBTHGARWTVA handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class RYXZUVVPOKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x98D8890", Offset = "0x98D7C90", VA = "0x1898D8890")]
		public static bool DWQYYPJMAGZ(this RCSERIFJNPS a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface KYWQGMNBKCS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		PPTCRKDFMWF AFGQWFDUCRG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool GZHULXBNNNI
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object UUYZLOXZAEO(string a);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object SDWXGWRDBSI(PPTCRKDFMWF a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void XQZSFWDGQHU(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void FTKOVSRSGNC(PPTCRKDFMWF a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void OXFBIUFUXSB<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void OPVRATLVKBJ([CanBeNull] PPTCRKDFMWF photonPlayer, string a, KWMSJOCJUWI b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void HKPUEECHHYW([CanBeNull] PPTCRKDFMWF photonPlayer, string a, KWMSJOCJUWI b);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b EWMOUERKJTY<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object JBTSRSAFNXV<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		object EWMOUERKJTY(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		object JBTSRSAFNXV(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void UDUZXXRPGDI();

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void BBQRQYSRITO();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void BLGHIMZXRPJ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public PPTCRKDFMWF player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public RCSERIFJNPS context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public string key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NetworkSetterPermissionMode permissionMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public bool enforceInitialValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Action callback;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public KYWQGMNBKCS networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x98D8AD0", Offset = "0x98D7ED0", VA = "0x1898D8AD0")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x98D8930", Offset = "0x98D7D30", VA = "0x1898D8930")]
		public SyncData(RCSERIFJNPS context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] KYWQGMNBKCS networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x98D88E0", Offset = "0x98D7CE0", VA = "0x1898D88E0")]
		public static SyncData From(RCSERIFJNPS context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] KYWQGMNBKCS networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class XRMQHPRWNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x41121A0", Offset = "0x41115A0", VA = "0x1841121A0")]
		public static ANYDKCTSBKX<a> KWMSJOCJUWI<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x41110A0", Offset = "0x41104A0", VA = "0x1841110A0")]
		public static AODKHJNPKWG<b, c> KWMSJOCJUWI<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4111140", Offset = "0x4110540", VA = "0x184111140")]
		public static AOIREQHMUHP<d, e, f> KWMSJOCJUWI<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4111C50", Offset = "0x4111050", VA = "0x184111C50")]
		public static AMXUXUYFGGE<g, h, i, j> KWMSJOCJUWI<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4112420", Offset = "0x4111820", VA = "0x184112420")]
		public static LBHFSEIACUC<k> XYAHMNRWSAF<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x41122D0", Offset = "0x41116D0", VA = "0x1841122D0")]
		public static LBBYUXOCTIT<l, m> XYAHMNRWSAF<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4112370", Offset = "0x4111770", VA = "0x184112370")]
		public static LAWRXQUFJXK<n, o, p> XYAHMNRWSAF<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x41126F0", Offset = "0x4111AF0", VA = "0x1841126F0")]
		public static LARLAKAIAMB<q, r, s, t> XYAHMNRWSAF<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class KWMSJOCJUWI : KBTHGARWTVA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[Flags]
		private enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			Disposed = 1,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			LastSetLocally = 2,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			Synchronizing = 4,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			ModifiedOffline = 8,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			Default = 4
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static Stack<KYWQGMNBKCS> JVMOMEYRJNA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool QMRCWMZCGQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly PPTCRKDFMWF APPUHBXHBFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly RCSERIFJNPS DGWPTYIAQJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string WBDMRGPRNOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode YHQJCWFRPMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action SWPFRTXCLTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected KYWQGMNBKCS WEQANCKEXBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags GESQOZKUAEJ;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static KYWQGMNBKCS WOHZLHHGIKO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x98D5440", Offset = "0x98D4840", VA = "0x1898D5440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool BHPUUDHMBYW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x98D5AA0", Offset = "0x98D4EA0", VA = "0x1898D5AA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x98D4F10", Offset = "0x98D4310", VA = "0x1898D4F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool PKOXILTNYIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x98D5700", Offset = "0x98D4B00", VA = "0x1898D5700")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x98D5420", Offset = "0x98D4820", VA = "0x1898D5420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool ISTEUIMTJNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x98D4850", Offset = "0x98D3C50", VA = "0x1898D4850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x98D54C0", Offset = "0x98D48C0", VA = "0x1898D54C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool AWZPAQNAHKX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x98D56F0", Offset = "0x98D4AF0", VA = "0x1898D56F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x98D5560", Offset = "0x98D4960", VA = "0x1898D5560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object VZEVIODPGNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4E20", Offset = "0xCF4220", VA = "0x180CF4E20", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool BIYMBDZUSVC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x98D5510", Offset = "0x98D4910", VA = "0x1898D5510")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int TKVOWTFHNQT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xECD1E0", Offset = "0xECC5E0", VA = "0x180ECD1E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1AA5DF0", Offset = "0x1AA51F0", VA = "0x181AA5DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string GDITXKPDJXL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x98D4B20", Offset = "0x98D3F20", VA = "0x1898D4B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x98D47B0", Offset = "0x98D3BB0", VA = "0x1898D47B0")]
		public static void AGNYSVEVCGD(KYWQGMNBKCS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool XCIABATDDRH();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x98D5E60", Offset = "0x98D5260", VA = "0x1898D5E60")]
		protected KWMSJOCJUWI(PPTCRKDFMWF a, RCSERIFJNPS b, string c, NetworkSetterPermissionMode d, Action e, KYWQGMNBKCS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x98D4BE0", Offset = "0x98D3FE0", VA = "0x1898D4BE0", Slot = "1")]
		~KWMSJOCJUWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x98D49B0", Offset = "0x98D3DB0", VA = "0x1898D49B0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x98D4F30", Offset = "0x98D4330", VA = "0x1898D4F30")]
		private void HWEEUNKHNTN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x98D4FD0", Offset = "0x98D43D0", VA = "0x1898D4FD0")]
		private object IJEIKOAXCEZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x98D51A0", Offset = "0x98D45A0", VA = "0x1898D51A0")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x98D56B0", Offset = "0x98D4AB0", VA = "0x1898D56B0")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x98D5710", Offset = "0x98D4B10", VA = "0x1898D5710")]
		protected void TWJZZZNEIFM(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x98D5D50", Offset = "0x98D5150", VA = "0x1898D5D50")]
		internal void ZQUWVXGDJPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x98D5140", Offset = "0x98D4540", VA = "0x1898D5140")]
		private void IXPVDPETUSK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x98D4DA0", Offset = "0x98D41A0", VA = "0x1898D4DA0")]
		private void GCXPCUXNETP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x98D4B70", Offset = "0x98D3F70", VA = "0x1898D4B70", Slot = "4")]
		private void FYXKRACOZJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x98D54B0", Offset = "0x98D48B0", VA = "0x1898D54B0", Slot = "5")]
		private void LDMRKSXVNMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x98D5960", Offset = "0x98D4D60", VA = "0x1898D5960")]
		public bool TXDOVDCNQTE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x98D5AB0", Offset = "0x98D4EB0", VA = "0x1898D5AB0")]
		public bool WUKAUSFQTQM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x98D4860", Offset = "0x98D3C60", VA = "0x1898D4860")]
		private bool BJPPTIJKEJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x98D5370", Offset = "0x98D4770", VA = "0x1898D5370")]
		internal void JNDHJRWWWUM(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x98D4E00", Offset = "0x98D4200", VA = "0x1898D4E00")]
		private void GVIWWDTBGBG(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x98D54E0", Offset = "0x98D48E0", VA = "0x1898D54E0")]
		private bool MWIEJQURGJC(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x98D54F0", Offset = "0x98D48F0", VA = "0x1898D54F0")]
		private void OIAQBWNZQEA(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x98D5620", Offset = "0x98D4A20", VA = "0x1898D5620")]
		public static string QQSKWGIFCJA(PPTCRKDFMWF a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x98D5C70", Offset = "0x98D5070", VA = "0x1898D5C70")]
		public static string ZBOSZQFQSRI(RCSERIFJNPS a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x98D4C40", Offset = "0x98D4040", VA = "0x1898D4C40")]
		public static bool GBLWSMQEAIU(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class QJTINBCBJAG : KYWQGMNBKCS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> KAYHHUQWQYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> VOUAUEYJESJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> XBWPGSAZWPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> YEWFFQDMGTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool PRGHQFJWEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> LPCQBZDGUMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<PPTCRKDFMWF, Dictionary<string, object>> QAATELONKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> RJOHVTKIXMQ;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> SBHPBOIAEQE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int TQZKDGXLOWR
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract PPTCRKDFMWF AFGQWFDUCRG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool GZHULXBNNNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool TSMLSCQIVVL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDD0", Offset = "0xD0E1D0", VA = "0x180D0EDD0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool OAUPVOWZCYF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xD4DA50", Offset = "0xD4CE50", VA = "0x180D4DA50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3DF86E0", Offset = "0x3DF7AE0", VA = "0x183DF86E0", Slot = "12")]
		public void OXFBIUFUXSB<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x98D65A0", Offset = "0x98D59A0", VA = "0x1898D65A0", Slot = "11")]
		public void FTKOVSRSGNC(PPTCRKDFMWF a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x98D7A90", Offset = "0x98D6E90", VA = "0x1898D7A90", Slot = "9")]
		public object SDWXGWRDBSI(PPTCRKDFMWF a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x98D8300", Offset = "0x98D7700", VA = "0x1898D8300", Slot = "10")]
		public void XQZSFWDGQHU(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x98D7C90", Offset = "0x98D7090", VA = "0x1898D7C90", Slot = "8")]
		public object UUYZLOXZAEO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x98D7800", Offset = "0x98D6C00", VA = "0x1898D7800", Slot = "13")]
		public void OPVRATLVKBJ(PPTCRKDFMWF a, string b, KWMSJOCJUWI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x98D67C0", Offset = "0x98D5BC0", VA = "0x1898D67C0", Slot = "14")]
		public void HKPUEECHHYW(PPTCRKDFMWF a, string b, KWMSJOCJUWI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x98D7120", Offset = "0x98D6520", VA = "0x1898D7120")]
		private void JIRCXXIREZA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x98D63F0", Offset = "0x98D57F0", VA = "0x1898D63F0")]
		private void CVBBDNWYAYY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x98D7910", Offset = "0x98D6D10", VA = "0x1898D7910")]
		private void PIOZQRQMZFN(PPTCRKDFMWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x98D7170", Offset = "0x98D6570", VA = "0x1898D7170")]
		protected void KFALTVSFSAH(PPTCRKDFMWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x98D7710", Offset = "0x98D6B10", VA = "0x1898D7710")]
		protected void MSWVRCVRKVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x98D6160", Offset = "0x98D5560", VA = "0x1898D6160")]
		protected void BDISKVIVXSV(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x98D7F30", Offset = "0x98D7330", VA = "0x1898D7F30")]
		protected void VYJVXYSZLOL(PPTCRKDFMWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x98D7970", Offset = "0x98D6D70", VA = "0x1898D7970")]
		protected void PYNMLQMKLTN(PPTCRKDFMWF a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x98D6C90", Offset = "0x98D6090", VA = "0x1898D6C90")]
		private void IFNELZTMXCK(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x98D7D30", Offset = "0x98D7130", VA = "0x1898D7D30")]
		private static void VJZZKWQQCTE(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x98D7290", Offset = "0x98D6690", VA = "0x1898D7290")]
		private static void KNVTSSUCJOF(Dictionary<string, object> a, string b, KWMSJOCJUWI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x98D7540", Offset = "0x98D6940", VA = "0x1898D7540")]
		private static void MGNTHDVSYUA(Dictionary<string, object> a, string b, KWMSJOCJUWI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x98D7B90", Offset = "0x98D6F90", VA = "0x1898D7B90", Slot = "19")]
		public void UDUZXXRPGDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract void HMVHUAHALJF(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x98D6080", Offset = "0x98D5480", VA = "0x1898D6080", Slot = "20")]
		public void BBQRQYSRITO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		protected abstract void VLZNTGAMKIV(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x98D6A70", Offset = "0x98D5E70", VA = "0x1898D6A70")]
		private void HWHVXDHWQPK(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x98D8420", Offset = "0x98D7820", VA = "0x1898D8420")]
		private void ZJDNHSQBKNH(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x98D74B0", Offset = "0x98D68B0", VA = "0x1898D74B0")]
		public void LQLWSSXUFVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x98D66F0", Offset = "0x98D5AF0", VA = "0x1898D66F0")]
		public void GGIQQUNVHGW(PPTCRKDFMWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x98D7FA0", Offset = "0x98D73A0", VA = "0x1898D7FA0")]
		public void WOTESYYWYSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		protected abstract HashSet<int> YEWVJNRBWJV(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x98D6170", Offset = "0x98D5570", VA = "0x1898D6170", Slot = "21")]
		public void BLGHIMZXRPJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x98D7A00", Offset = "0x98D6E00", VA = "0x1898D7A00")]
		protected string QQSKWGIFCJA(PPTCRKDFMWF a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "32")]
		public abstract object JBTSRSAFNXV<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "33")]
		public abstract c EWMOUERKJTY<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "34")]
		public abstract object JBTSRSAFNXV(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "35")]
		public abstract object EWMOUERKJTY(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "36")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x98D6440", Offset = "0x98D5840", VA = "0x1898D6440", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "37")]
		protected virtual void UKODGKXTDBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x98D86A0", Offset = "0x98D7AA0", VA = "0x1898D86A0")]
		protected QJTINBCBJAG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class ECIUCMGYGUO<a> : KWMSJOCJUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a VTVRYVHVTCT;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a VSEJMZGHUMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x5AA4BA0", Offset = "0x5AA3FA0", VA = "0x185AA4BA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x5A9F200", Offset = "0x5A9E600", VA = "0x185A9F200", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object VZEVIODPGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x5A8D020", Offset = "0x5A8C420", VA = "0x185A8D020", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5A9FC80", Offset = "0x5A9F080", VA = "0x185A9FC80", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5AA4D90", Offset = "0x5AA4190", VA = "0x185AA4D90", Slot = "9")]
		protected override bool XCIABATDDRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5AA6480", Offset = "0x5AA5880", VA = "0x185AA6480")]
		protected ECIUCMGYGUO([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5AA6A10", Offset = "0x5AA5E10", VA = "0x185AA6A10")]
		protected ECIUCMGYGUO(PPTCRKDFMWF a, RCSERIFJNPS b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, KYWQGMNBKCS h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5316F80", Offset = "0x5316380", VA = "0x185316F80")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5AA1370", Offset = "0x5AA0770", VA = "0x185AA1370")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5AA4440", Offset = "0x5AA3840", VA = "0x185AA4440")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class ECDNFFNAXJF<a, b> : KWMSJOCJUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a VTVRYVHVTCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b VUAYWCBTCOC;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a VSEJMZGHUMA
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x10EA360", Offset = "0x10E9760", VA = "0x1810EA360", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x12CA6D0", Offset = "0x12C9AD0", VA = "0x1812CA6D0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b VSUEETNZWUB
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x327AD80", Offset = "0x327A180", VA = "0x18327AD80", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5A916D0", Offset = "0x5A90AD0", VA = "0x185A916D0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b FXFZYLLBABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x1728B60", Offset = "0x1727F60", VA = "0x181728B60")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object VZEVIODPGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x5A8D020", Offset = "0x5A8C420", VA = "0x185A8D020", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x5A92F70", Offset = "0x5A92370", VA = "0x185A92F70", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5A97820", Offset = "0x5A96C20", VA = "0x185A97820", Slot = "9")]
		protected override bool XCIABATDDRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5A9CD60", Offset = "0x5A9C160", VA = "0x185A9CD60")]
		protected ECDNFFNAXJF([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5A9C700", Offset = "0x5A9BB00", VA = "0x185A9C700")]
		protected ECDNFFNAXJF(PPTCRKDFMWF a, RCSERIFJNPS b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, KYWQGMNBKCS i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5316F80", Offset = "0x5316380", VA = "0x185316F80")]
		public a UZCCFHHVJMF()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5A910D0", Offset = "0x5A904D0", VA = "0x185A910D0")]
		public void MEKBTYVUTUJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1728B60", Offset = "0x1727F60", VA = "0x181728B60")]
		public b UYMHNNADHEE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5A90400", Offset = "0x5A8F800", VA = "0x185A90400")]
		public void MDUHCEOCRMI(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5A968F0", Offset = "0x5A95CF0", VA = "0x185A968F0")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class EBYGHYTDNXW<a, b, c> : KWMSJOCJUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a VTVRYVHVTCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b VUAYWCBTCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c VUGFTIVQLZL;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a VSEJMZGHUMA
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xD05F00", Offset = "0xD05300", VA = "0x180D05F00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xD05ED0", Offset = "0xD052D0", VA = "0x180D05ED0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b VSUEETNZWUB
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xEE4740", Offset = "0xEE3B40", VA = "0x180EE4740", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB5000", Offset = "0x2AB4400", VA = "0x182AB5000", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c VSOXHMUCNIS
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCF5540", Offset = "0xCF4940", VA = "0x180CF5540", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C70", Offset = "0xCF4070", VA = "0x180CF4C70", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a FWQFGRDIXTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5316F80", Offset = "0x5316380", VA = "0x185316F80")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b FXFZYLLBABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x1728B60", Offset = "0x1727F60", VA = "0x181728B60")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c FXATBERDQPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x5A86A80", Offset = "0x5A85E80", VA = "0x185A86A80")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object VZEVIODPGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x5A8D020", Offset = "0x5A8C420", VA = "0x185A8D020", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5A876E0", Offset = "0x5A86AE0", VA = "0x185A876E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5A8C5B0", Offset = "0x5A8B9B0", VA = "0x185A8C5B0", Slot = "9")]
		protected override bool XCIABATDDRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5A8F1E0", Offset = "0x5A8E5E0", VA = "0x185A8F1E0")]
		protected EBYGHYTDNXW([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5A8F810", Offset = "0x5A8EC10", VA = "0x185A8F810")]
		protected EBYGHYTDNXW(PPTCRKDFMWF a, RCSERIFJNPS b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, KYWQGMNBKCS j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5316F80", Offset = "0x5316380", VA = "0x185316F80")]
		public a UZCCFHHVJMF()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5A861A0", Offset = "0x5A855A0", VA = "0x185A861A0")]
		public void MEKBTYVUTUJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1728B60", Offset = "0x1727F60", VA = "0x181728B60")]
		public b UYMHNNADHEE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5A85220", Offset = "0x5A84620", VA = "0x185A85220")]
		public void MDUHCEOCRMI(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5A86A80", Offset = "0x5A85E80", VA = "0x185A86A80")]
		public c UYROKTUAQPN()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5A856F0", Offset = "0x5A84AF0", VA = "0x185A856F0")]
		public void MDZNZLIAAXR(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5A89300", Offset = "0x5A88700", VA = "0x185A89300")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class EDJCOUCLBZH<a, b, c, d> : KWMSJOCJUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a VTVRYVHVTCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b VUAYWCBTCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c VUGFTIVQLZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d VULMQPPNVKU;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a VSEJMZGHUMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xF77B60", Offset = "0xF76F60", VA = "0x180F77B60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x5AACDD0", Offset = "0x5AAC1D0", VA = "0x185AACDD0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b VSUEETNZWUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x148BD50", Offset = "0x148B150", VA = "0x18148BD50", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x148B920", Offset = "0x148AD20", VA = "0x18148B920", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c VSOXHMUCNIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x15276F0", Offset = "0x1526AF0", VA = "0x1815276F0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x5AB60E0", Offset = "0x5AB54E0", VA = "0x185AB60E0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d VTERZHBUPQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1D49DA0", Offset = "0x1D491A0", VA = "0x181D49DA0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x1687770", Offset = "0x1686B70", VA = "0x181687770", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b FXFZYLLBABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x5A86930", Offset = "0x5A85D30", VA = "0x185A86930")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c FXATBERDQPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x5A86A50", Offset = "0x5A85E50", VA = "0x185A86A50")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d FXQNSYYVSXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x15CD810", Offset = "0x15CCC10", VA = "0x1815CD810")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object VZEVIODPGNP
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x5A8D020", Offset = "0x5A8C420", VA = "0x185A8D020", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x5AB6B60", Offset = "0x5AB5F60", VA = "0x185AB6B60", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5ABC080", Offset = "0x5ABB480", VA = "0x185ABC080", Slot = "9")]
		protected override bool XCIABATDDRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5ABE160", Offset = "0x5ABD560", VA = "0x185ABE160")]
		protected EDJCOUCLBZH([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5ABC380", Offset = "0x5ABB780", VA = "0x185ABC380")]
		protected EDJCOUCLBZH(PPTCRKDFMWF a, RCSERIFJNPS b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, KYWQGMNBKCS k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5316F80", Offset = "0x5316380", VA = "0x185316F80")]
		public a UZCCFHHVJMF()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5AB5AD0", Offset = "0x5AB4ED0", VA = "0x185AB5AD0")]
		public void MEKBTYVUTUJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5A86930", Offset = "0x5A85D30", VA = "0x185A86930")]
		public b UYMHNNADHEE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4940", Offset = "0x5AB3D40", VA = "0x185AB4940")]
		public void MDUHCEOCRMI(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5A86A50", Offset = "0x5A85E50", VA = "0x185A86A50")]
		public c UYROKTUAQPN()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5AB4AE0", Offset = "0x5AB3EE0", VA = "0x185AB4AE0")]
		public void MDZNZLIAAXR(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15CD810", Offset = "0x15CCC10", VA = "0x1815CD810")]
		public d UZRWXBPNLUG()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3800", Offset = "0x5AB2C00", VA = "0x185AB3800")]
		public void MDJTHRAHYPQ(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5AB8B90", Offset = "0x5AB7F90", VA = "0x185AB8B90")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class EDDVRNINSNY<a, b, c, d, e> : KWMSJOCJUWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a VTVRYVHVTCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b VUAYWCBTCOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c VUGFTIVQLZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d VULMQPPNVKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e VUQTNWJLEWD;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a VSEJMZGHUMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xD05F00", Offset = "0xD05300", VA = "0x180D05F00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xD05ED0", Offset = "0xD052D0", VA = "0x180D05ED0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b VSUEETNZWUB
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xE06340", Offset = "0xE05740", VA = "0x180E06340", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x14A3170", Offset = "0x14A2570", VA = "0x1814A3170", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c VSOXHMUCNIS
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xE02F30", Offset = "0xE02330", VA = "0x180E02F30", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xE04030", Offset = "0xE03430", VA = "0x180E04030", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d VTERZHBUPQT
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD0F190", Offset = "0xD0E590", VA = "0x180D0F190", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xD1EE90", Offset = "0xD1E290", VA = "0x180D1EE90", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e VSZLCAHXGFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xD0EDE0", Offset = "0xD0E1E0", VA = "0x180D0EDE0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5AACB30", Offset = "0x5AABF30", VA = "0x185AACB30", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object VZEVIODPGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x5A8D020", Offset = "0x5A8C420", VA = "0x185A8D020", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x5AADA90", Offset = "0x5AACE90", VA = "0x185AADA90", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1A70", Offset = "0x5AB0E70", VA = "0x185AB1A70", Slot = "9")]
		protected override bool XCIABATDDRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3460", Offset = "0x5AB2860", VA = "0x185AB3460")]
		protected EDDVRNINSNY(PPTCRKDFMWF a, RCSERIFJNPS b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, KYWQGMNBKCS l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5316F80", Offset = "0x5316380", VA = "0x185316F80")]
		public a UZCCFHHVJMF()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC7D0", Offset = "0x5AABBD0", VA = "0x185AAC7D0")]
		public void MEKBTYVUTUJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1728B60", Offset = "0x1727F60", VA = "0x181728B60")]
		public b UYMHNNADHEE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5AAB8E0", Offset = "0x5AAACE0", VA = "0x185AAB8E0")]
		public void MDUHCEOCRMI(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5A86A80", Offset = "0x5A85E80", VA = "0x185A86A80")]
		public c UYROKTUAQPN()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5AAC080", Offset = "0x5AAB480", VA = "0x185AAC080")]
		public void MDZNZLIAAXR(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x15CD810", Offset = "0x15CCC10", VA = "0x1815CD810")]
		public d UZRWXBPNLUG()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5AAA880", Offset = "0x5AA9C80", VA = "0x185AAA880")]
		public void MDJTHRAHYPQ(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5AB0560", Offset = "0x5AAF960", VA = "0x185AB0560")]
		public e UZXDUIJKVFP()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5AAB1D0", Offset = "0x5AAA5D0", VA = "0x185AAB1D0")]
		public void MDPAEXUFIAZ(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5AAEE30", Offset = "0x5AAE230", VA = "0x185AAEE30")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, e newValue5)
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
