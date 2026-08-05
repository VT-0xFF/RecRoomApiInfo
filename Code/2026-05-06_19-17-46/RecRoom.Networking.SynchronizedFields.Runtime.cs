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
			[Cpp2IlInjected.Address(RVA = "0xF78BD0", Offset = "0xF775D0", VA = "0x180F78BD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AVNRZDBPYFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x691C980", Offset = "0x691B380", VA = "0x18691C980", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a MBOJBLRLUXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x691DF40", Offset = "0x691C940", VA = "0x18691DF40", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x691A640", Offset = "0x6919040", VA = "0x18691A640", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a OKPHEENBODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x691BDE0", Offset = "0x691A7E0", VA = "0x18691BDE0", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x691BFF0", Offset = "0x691A9F0", VA = "0x18691BFF0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a FCAQLXAUMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x691BDE0", Offset = "0x691A7E0", VA = "0x18691BDE0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x691D2C0", Offset = "0x691BCC0", VA = "0x18691D2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool AWZPAQNAHKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x690C430", Offset = "0x690AE30", VA = "0x18690C430", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x690C000", Offset = "0x690AA00", VA = "0x18690C000", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6919D10", Offset = "0x6918710", VA = "0x186919D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x691C370", Offset = "0x691AD70", VA = "0x18691C370", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x691FC40", Offset = "0x691E640", VA = "0x18691FC40")]
		public LBHFSEIACUC([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x691AD80", Offset = "0x6919780", VA = "0x18691AD80")]
		private void LNQKBZDHKGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x691B6B0", Offset = "0x691A0B0", VA = "0x18691B6B0", Slot = "5")]
		public void NNNYBGONPRQ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x691BC60", Offset = "0x691A660", VA = "0x18691BC60")]
		public void NNNYBGONPRQ(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x690B940", Offset = "0x690A340", VA = "0x18690B940", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xF78BD0", Offset = "0xF775D0", VA = "0x180F78BD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool AVNRZDBPYFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6915210", Offset = "0x6913C10", VA = "0x186915210", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool TLGSHGGEVKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6916260", Offset = "0x6914C60", VA = "0x186916260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool TLWMZANWXSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6916700", Offset = "0x6915100", VA = "0x186916700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) MBOJBLRLUXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6916080", Offset = "0x6914A80", VA = "0x186916080", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x69141C0", Offset = "0x6912BC0", VA = "0x1869141C0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) OKPHEENBODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6915620", Offset = "0x6914020", VA = "0x186915620", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6914A70", Offset = "0x6913470", VA = "0x186914A70", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) FCAQLXAUMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x69149E0", Offset = "0x69133E0", VA = "0x1869149E0")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6915800", Offset = "0x6914200", VA = "0x186915800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a JHZOMUOKJLR
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6912DD0", Offset = "0x69117D0", VA = "0x186912DD0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6913560", Offset = "0x6911F60", VA = "0x186913560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a LVVNDRBRRMW
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x69131F0", Offset = "0x6911BF0", VA = "0x1869131F0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x69130F0", Offset = "0x6911AF0", VA = "0x1869130F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a EGPPWFQWXWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x69131F0", Offset = "0x6911BF0", VA = "0x1869131F0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6915B40", Offset = "0x6914540", VA = "0x186915B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b JIEVKBIHSXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6912D60", Offset = "0x6911760", VA = "0x186912D60")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6913320", Offset = "0x6911D20", VA = "0x186913320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b LVQGGKHUIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x69131B0", Offset = "0x6911BB0", VA = "0x1869131B0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b EGKIYYWZOLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x69131B0", Offset = "0x6911BB0", VA = "0x1869131B0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6915DB0", Offset = "0x69147B0", VA = "0x186915DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool AWZPAQNAHKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x690C430", Offset = "0x690AE30", VA = "0x18690C430", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x690C000", Offset = "0x690AA00", VA = "0x18690C000", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6914D20", Offset = "0x6913720", VA = "0x186914D20", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6916C30", Offset = "0x6915630", VA = "0x186916C30")]
		public LBBYUXOCTIT([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6914420", Offset = "0x6912E20", VA = "0x186914420")]
		private void LNQKBZDHKGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6912F00", Offset = "0x6911900", VA = "0x186912F00")]
		public void BCUOVOJJQPF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x69147F0", Offset = "0x69131F0", VA = "0x1869147F0")]
		public void NNNYBGONPRQ(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6913900", Offset = "0x6912300", VA = "0x186913900", Slot = "5")]
		private void HIGVUDPSPVH((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x690B940", Offset = "0x690A340", VA = "0x18690B940", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xF78BD0", Offset = "0xF775D0", VA = "0x180F78BD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool AVNRZDBPYFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6910710", Offset = "0x690F110", VA = "0x186910710", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool TLGSHGGEVKY
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6911CB0", Offset = "0x69106B0", VA = "0x186911CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool TLWMZANWXSZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6912070", Offset = "0x6910A70", VA = "0x186912070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool TLRGBTTZOHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6912320", Offset = "0x6910D20", VA = "0x186912320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) MBOJBLRLUXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x69117D0", Offset = "0x69101D0", VA = "0x1869117D0", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x690F400", Offset = "0x690DE00", VA = "0x18690F400", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) OKPHEENBODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6911110", Offset = "0x690FB10", VA = "0x186911110", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x690FCD0", Offset = "0x690E6D0", VA = "0x18690FCD0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a JHZOMUOKJLR
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x690DA70", Offset = "0x690C470", VA = "0x18690DA70")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x690E8B0", Offset = "0x690D2B0", VA = "0x18690E8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a LVVNDRBRRMW
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x690E0A0", Offset = "0x690CAA0", VA = "0x18690E0A0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a EGPPWFQWXWK
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x690E0A0", Offset = "0x690CAA0", VA = "0x18690E0A0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6911360", Offset = "0x690FD60", VA = "0x186911360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b JIEVKBIHSXA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x690D990", Offset = "0x690C390", VA = "0x18690D990")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x690E440", Offset = "0x690CE40", VA = "0x18690E440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b LVQGGKHUIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x690DEE0", Offset = "0x690C8E0", VA = "0x18690DEE0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b EGKIYYWZOLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x690DEE0", Offset = "0x690C8E0", VA = "0x18690DEE0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x69113F0", Offset = "0x690FDF0", VA = "0x1869113F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c JIKCHICFCIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x690D8B0", Offset = "0x690C2B0", VA = "0x18690D8B0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x690E3C0", Offset = "0x690CDC0", VA = "0x18690E3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c LVKZJDNWYQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x690E070", Offset = "0x690CA70", VA = "0x18690E070")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c EGFCBSDCEZS
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x690E070", Offset = "0x690CA70", VA = "0x18690E070")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x69116D0", Offset = "0x69100D0", VA = "0x1869116D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool AWZPAQNAHKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x690C430", Offset = "0x690AE30", VA = "0x18690C430", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6910180", Offset = "0x690EB80", VA = "0x186910180", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6912B70", Offset = "0x6911570", VA = "0x186912B70")]
		public LAWRXQUFJXK([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x690F900", Offset = "0x690E300", VA = "0x18690F900")]
		private void LNQKBZDHKGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x690DB50", Offset = "0x690C550", VA = "0x18690DB50")]
		public void BCUOVOJJQPF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6910A40", Offset = "0x690F440", VA = "0x186910A40")]
		public void UPLRVXHJHRS(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x69102D0", Offset = "0x690ECD0", VA = "0x1869102D0")]
		public void SGBAYPOOBZT(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x690F9E0", Offset = "0x690E3E0", VA = "0x18690F9E0")]
		public void NNNYBGONPRQ(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x690EA00", Offset = "0x690D400", VA = "0x18690EA00", Slot = "5")]
		private void GMLRJUXRGMO((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x690B940", Offset = "0x690A340", VA = "0x18690B940", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xF78BD0", Offset = "0xF775D0", VA = "0x180F78BD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) OKPHEENBODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x690C810", Offset = "0x690B210", VA = "0x18690C810", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x690C3E0", Offset = "0x690ADE0", VA = "0x18690C3E0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b LVQGGKHUIBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x690B780", Offset = "0x690A180", VA = "0x18690B780")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c LVKZJDNWYQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x690B860", Offset = "0x690A260", VA = "0x18690B860")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d LVFSLWTZPEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x690B6A0", Offset = "0x690A0A0", VA = "0x18690B6A0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool AWZPAQNAHKX
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x690C430", Offset = "0x690AE30", VA = "0x18690C430", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x690C000", Offset = "0x690AA00", VA = "0x18690C000", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x690CCF0", Offset = "0x690B6F0", VA = "0x18690CCF0")]
		public LARLAKAIAMB([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x690BBF0", Offset = "0x690A5F0", VA = "0x18690BBF0")]
		private void LNQKBZDHKGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x690B5B0", Offset = "0x6909FB0", VA = "0x18690B5B0")]
		public void BCUOVOJJQPF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x690BCF0", Offset = "0x690A6F0", VA = "0x18690BCF0")]
		public void NNNYBGONPRQ(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x690C7B0", Offset = "0x690B1B0", VA = "0x18690C7B0", Slot = "5")]
		private void UJPBWBMSKPC((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x690B940", Offset = "0x690A340", VA = "0x18690B940", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x99A5150", Offset = "0x99A3B50", VA = "0x1899A5150")]
		public static string PSGRWNXQKWS(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD418E0", Offset = "0xD402E0", VA = "0x180D418E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72F30C0", Offset = "0x72F1AC0", VA = "0x1872F30C0")]
		public ANYDKCTSBKX([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x72F2070", Offset = "0x72F0A70", VA = "0x1872F2070")]
		public ANYDKCTSBKX(RCSERIFJNPS a, PPTCRKDFMWF b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] KYWQGMNBKCS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x72EFF80", Offset = "0x72EE980", VA = "0x1872EFF80")]
		public ANYDKCTSBKX(RCSERIFJNPS a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] KYWQGMNBKCS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x72F1850", Offset = "0x72F0250", VA = "0x1872F1850")]
		public ANYDKCTSBKX(RCSERIFJNPS a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] KYWQGMNBKCS g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AODKHJNPKWG<a, b> : ECDNFFNAXJF<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x72F7D60", Offset = "0x72F6760", VA = "0x1872F7D60")]
		public AODKHJNPKWG([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x72F7450", Offset = "0x72F5E50", VA = "0x1872F7450")]
		public AODKHJNPKWG(RCSERIFJNPS a, PPTCRKDFMWF b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] KYWQGMNBKCS h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x72F5670", Offset = "0x72F4070", VA = "0x1872F5670")]
		public AODKHJNPKWG(RCSERIFJNPS a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] KYWQGMNBKCS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x72F4990", Offset = "0x72F3390", VA = "0x1872F4990")]
		public AODKHJNPKWG(RCSERIFJNPS a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] KYWQGMNBKCS h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AOIREQHMUHP<a, b, c> : EBYGHYTDNXW<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x72F9520", Offset = "0x72F7F20", VA = "0x1872F9520")]
		public AOIREQHMUHP([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x72F92D0", Offset = "0x72F7CD0", VA = "0x1872F92D0")]
		public AOIREQHMUHP(RCSERIFJNPS a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] KYWQGMNBKCS h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AMXUXUYFGGE<a, b, c, d> : EDJCOUCLBZH<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x72EBC50", Offset = "0x72EA650", VA = "0x1872EBC50")]
		public AMXUXUYFGGE([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x72EC150", Offset = "0x72EAB50", VA = "0x1872EC150")]
		public AMXUXUYFGGE(RCSERIFJNPS a, PPTCRKDFMWF b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] KYWQGMNBKCS j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x72EB430", Offset = "0x72E9E30", VA = "0x1872EB430")]
		public AMXUXUYFGGE(RCSERIFJNPS a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] KYWQGMNBKCS i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ANDBVBSCPRN<a, b, c, d, e> : EDDVRNINSNY<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x72ED6C0", Offset = "0x72EC0C0", VA = "0x1872ED6C0")]
		public ANDBVBSCPRN(RCSERIFJNPS a, PPTCRKDFMWF b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] KYWQGMNBKCS k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x72EDC80", Offset = "0x72EC680", VA = "0x1872EDC80")]
		public ANDBVBSCPRN(RCSERIFJNPS a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] KYWQGMNBKCS j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class IRPLDGNELUY<a> : ECIUCMGYGUO<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x65EE120", Offset = "0x65ECB20", VA = "0x1865EE120")]
		public IRPLDGNELUY(PPTCRKDFMWF a, string b, a c, [Optional] Action d, [Optional] KYWQGMNBKCS e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ISFFVAUWOCZ<a, b> : ECDNFFNAXJF<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x65EE8A0", Offset = "0x65ED2A0", VA = "0x1865EE8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCDD200", Offset = "0xCDBC00", VA = "0x180CDD200")]
		public FMQXCIYLVAN(KYWQGMNBKCS a, RCSERIFJNPS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3AB18C0", Offset = "0x3AB02C0", VA = "0x183AB18C0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x99A4EA0", Offset = "0x99A38A0", VA = "0x1899A4EA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x99A50D0", Offset = "0x99A3AD0", VA = "0x1899A50D0")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x99A4F40", Offset = "0x99A3940", VA = "0x1899A4F40")]
		public SyncData(RCSERIFJNPS context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] KYWQGMNBKCS networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x99A4EF0", Offset = "0x99A38F0", VA = "0x1899A4EF0")]
		public static SyncData From(RCSERIFJNPS context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] KYWQGMNBKCS networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class XRMQHPRWNAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x411D920", Offset = "0x411C320", VA = "0x18411D920")]
		public static ANYDKCTSBKX<a> KWMSJOCJUWI<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x411C7E0", Offset = "0x411B1E0", VA = "0x18411C7E0")]
		public static AODKHJNPKWG<b, c> KWMSJOCJUWI<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x411C880", Offset = "0x411B280", VA = "0x18411C880")]
		public static AOIREQHMUHP<d, e, f> KWMSJOCJUWI<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x411D3D0", Offset = "0x411BDD0", VA = "0x18411D3D0")]
		public static AMXUXUYFGGE<g, h, i, j> KWMSJOCJUWI<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x411DBA0", Offset = "0x411C5A0", VA = "0x18411DBA0")]
		public static LBHFSEIACUC<k> XYAHMNRWSAF<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x411DA50", Offset = "0x411C450", VA = "0x18411DA50")]
		public static LBBYUXOCTIT<l, m> XYAHMNRWSAF<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x411DAF0", Offset = "0x411C4F0", VA = "0x18411DAF0")]
		public static LAWRXQUFJXK<n, o, p> XYAHMNRWSAF<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x411DE70", Offset = "0x411C870", VA = "0x18411DE70")]
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
			[Cpp2IlInjected.Address(RVA = "0x99A1A80", Offset = "0x99A0480", VA = "0x1899A1A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool BHPUUDHMBYW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x99A20E0", Offset = "0x99A0AE0", VA = "0x1899A20E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x99A1550", Offset = "0x999FF50", VA = "0x1899A1550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool PKOXILTNYIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x99A1D40", Offset = "0x99A0740", VA = "0x1899A1D40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x99A1A60", Offset = "0x99A0460", VA = "0x1899A1A60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool ISTEUIMTJNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x99A0E90", Offset = "0x999F890", VA = "0x1899A0E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x99A1B00", Offset = "0x99A0500", VA = "0x1899A1B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool AWZPAQNAHKX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x99A1D30", Offset = "0x99A0730", VA = "0x1899A1D30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x99A1BA0", Offset = "0x99A05A0", VA = "0x1899A1BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object VZEVIODPGNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E10", Offset = "0xCD5810", VA = "0x180CD6E10", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool BIYMBDZUSVC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x99A1B50", Offset = "0x99A0550", VA = "0x1899A1B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int TKVOWTFHNQT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xEB4070", Offset = "0xEB2A70", VA = "0x180EB4070")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1A98950", Offset = "0x1A97350", VA = "0x181A98950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string GDITXKPDJXL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool ISZNRAMYENF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x99A1160", Offset = "0x999FB60", VA = "0x1899A1160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x99A0DF0", Offset = "0x999F7F0", VA = "0x1899A0DF0")]
		public static void AGNYSVEVCGD(KYWQGMNBKCS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool XCIABATDDRH();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x99A24B0", Offset = "0x99A0EB0", VA = "0x1899A24B0")]
		protected KWMSJOCJUWI(PPTCRKDFMWF a, RCSERIFJNPS b, string c, NetworkSetterPermissionMode d, Action e, KYWQGMNBKCS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x99A1220", Offset = "0x999FC20", VA = "0x1899A1220", Slot = "1")]
		~KWMSJOCJUWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x99A0FF0", Offset = "0x999F9F0", VA = "0x1899A0FF0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x99A1570", Offset = "0x999FF70", VA = "0x1899A1570")]
		private void HWEEUNKHNTN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x99A1610", Offset = "0x99A0010", VA = "0x1899A1610")]
		private object IJEIKOAXCEZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x99A17E0", Offset = "0x99A01E0", VA = "0x1899A17E0")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x99A1CF0", Offset = "0x99A06F0", VA = "0x1899A1CF0")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x99A1D50", Offset = "0x99A0750", VA = "0x1899A1D50")]
		protected void TWJZZZNEIFM(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x99A2390", Offset = "0x99A0D90", VA = "0x1899A2390")]
		internal void ZQUWVXGDJPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x99A1780", Offset = "0x99A0180", VA = "0x1899A1780")]
		private void IXPVDPETUSK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x99A13E0", Offset = "0x999FDE0", VA = "0x1899A13E0")]
		private void GCXPCUXNETP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x99A11B0", Offset = "0x999FBB0", VA = "0x1899A11B0", Slot = "4")]
		private void FYXKRACOZJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x99A1AF0", Offset = "0x99A04F0", VA = "0x1899A1AF0", Slot = "5")]
		private void LDMRKSXVNMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x99A1FA0", Offset = "0x99A09A0", VA = "0x1899A1FA0")]
		public bool TXDOVDCNQTE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x99A20F0", Offset = "0x99A0AF0", VA = "0x1899A20F0")]
		public bool WUKAUSFQTQM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x99A0EA0", Offset = "0x999F8A0", VA = "0x1899A0EA0")]
		private bool BJPPTIJKEJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x99A19B0", Offset = "0x99A03B0", VA = "0x1899A19B0")]
		internal void JNDHJRWWWUM(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x99A1440", Offset = "0x999FE40", VA = "0x1899A1440")]
		private void GVIWWDTBGBG(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x99A1B20", Offset = "0x99A0520", VA = "0x1899A1B20")]
		private bool MWIEJQURGJC(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x99A1B30", Offset = "0x99A0530", VA = "0x1899A1B30")]
		private void OIAQBWNZQEA(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x99A1C60", Offset = "0x99A0660", VA = "0x1899A1C60")]
		public static string QQSKWGIFCJA(PPTCRKDFMWF a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x99A22B0", Offset = "0x99A0CB0", VA = "0x1899A22B0")]
		public static string ZBOSZQFQSRI(RCSERIFJNPS a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x99A1280", Offset = "0x999FC80", VA = "0x1899A1280")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool OAUPVOWZCYF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xD2F810", Offset = "0xD2E210", VA = "0x180D2F810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3DFF670", Offset = "0x3DFE070", VA = "0x183DFF670", Slot = "12")]
		public void OXFBIUFUXSB<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x99A2BF0", Offset = "0x99A15F0", VA = "0x1899A2BF0", Slot = "11")]
		public void FTKOVSRSGNC(PPTCRKDFMWF a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x99A40C0", Offset = "0x99A2AC0", VA = "0x1899A40C0", Slot = "9")]
		public object SDWXGWRDBSI(PPTCRKDFMWF a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x99A4920", Offset = "0x99A3320", VA = "0x1899A4920", Slot = "10")]
		public void XQZSFWDGQHU(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x99A42B0", Offset = "0x99A2CB0", VA = "0x1899A42B0", Slot = "8")]
		public object UUYZLOXZAEO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x99A3E30", Offset = "0x99A2830", VA = "0x1899A3E30", Slot = "13")]
		public void OPVRATLVKBJ(PPTCRKDFMWF a, string b, KWMSJOCJUWI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x99A2E10", Offset = "0x99A1810", VA = "0x1899A2E10", Slot = "14")]
		public void HKPUEECHHYW(PPTCRKDFMWF a, string b, KWMSJOCJUWI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x99A3750", Offset = "0x99A2150", VA = "0x1899A3750")]
		private void JIRCXXIREZA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x99A2A40", Offset = "0x99A1440", VA = "0x1899A2A40")]
		private void CVBBDNWYAYY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x99A3F40", Offset = "0x99A2940", VA = "0x1899A3F40")]
		private void PIOZQRQMZFN(PPTCRKDFMWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x99A37A0", Offset = "0x99A21A0", VA = "0x1899A37A0")]
		protected void KFALTVSFSAH(PPTCRKDFMWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x99A3D40", Offset = "0x99A2740", VA = "0x1899A3D40")]
		protected void MSWVRCVRKVH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x99A27B0", Offset = "0x99A11B0", VA = "0x1899A27B0")]
		protected void BDISKVIVXSV(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x99A4550", Offset = "0x99A2F50", VA = "0x1899A4550")]
		protected void VYJVXYSZLOL(PPTCRKDFMWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x99A3FA0", Offset = "0x99A29A0", VA = "0x1899A3FA0")]
		protected void PYNMLQMKLTN(PPTCRKDFMWF a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x99A32E0", Offset = "0x99A1CE0", VA = "0x1899A32E0")]
		private void IFNELZTMXCK(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x99A4350", Offset = "0x99A2D50", VA = "0x1899A4350")]
		private static void VJZZKWQQCTE(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x99A38C0", Offset = "0x99A22C0", VA = "0x1899A38C0")]
		private static void KNVTSSUCJOF(Dictionary<string, object> a, string b, KWMSJOCJUWI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x99A3B70", Offset = "0x99A2570", VA = "0x1899A3B70")]
		private static void MGNTHDVSYUA(Dictionary<string, object> a, string b, KWMSJOCJUWI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x99A41B0", Offset = "0x99A2BB0", VA = "0x1899A41B0", Slot = "19")]
		public void UDUZXXRPGDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract void HMVHUAHALJF(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x99A26D0", Offset = "0x99A10D0", VA = "0x1899A26D0", Slot = "20")]
		public void BBQRQYSRITO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		protected abstract void VLZNTGAMKIV(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x99A30C0", Offset = "0x99A1AC0", VA = "0x1899A30C0")]
		private void HWHVXDHWQPK(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x99A4A40", Offset = "0x99A3440", VA = "0x1899A4A40")]
		private void ZJDNHSQBKNH(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x99A3AE0", Offset = "0x99A24E0", VA = "0x1899A3AE0")]
		public void LQLWSSXUFVI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x99A2D40", Offset = "0x99A1740", VA = "0x1899A2D40")]
		public void GGIQQUNVHGW(PPTCRKDFMWF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x99A45C0", Offset = "0x99A2FC0", VA = "0x1899A45C0")]
		public void WOTESYYWYSF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		protected abstract HashSet<int> YEWVJNRBWJV(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x99A27C0", Offset = "0x99A11C0", VA = "0x1899A27C0", Slot = "21")]
		public void BLGHIMZXRPJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x99A4030", Offset = "0x99A2A30", VA = "0x1899A4030")]
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
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "36")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x99A2A90", Offset = "0x99A1490", VA = "0x1899A2A90", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "37")]
		protected virtual void UKODGKXTDBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x99A4CB0", Offset = "0x99A36B0", VA = "0x1899A4CB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5B2C3C0", Offset = "0x5B2ADC0", VA = "0x185B2C3C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x5B269C0", Offset = "0x5B253C0", VA = "0x185B269C0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object VZEVIODPGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x5B0F960", Offset = "0x5B0E360", VA = "0x185B0F960", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x5B273A0", Offset = "0x5B25DA0", VA = "0x185B273A0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5B2C5B0", Offset = "0x5B2AFB0", VA = "0x185B2C5B0", Slot = "9")]
		protected override bool XCIABATDDRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5B2DCA0", Offset = "0x5B2C6A0", VA = "0x185B2DCA0")]
		protected ECIUCMGYGUO([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5B2E230", Offset = "0x5B2CC30", VA = "0x185B2E230")]
		protected ECIUCMGYGUO(PPTCRKDFMWF a, RCSERIFJNPS b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, KYWQGMNBKCS h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5397EF0", Offset = "0x53968F0", VA = "0x185397EF0")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5B28B20", Offset = "0x5B27520", VA = "0x185B28B20")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5B2BC50", Offset = "0x5B2A650", VA = "0x185B2BC50")]
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
			[Cpp2IlInjected.Address(RVA = "0x10D4D30", Offset = "0x10D3730", VA = "0x1810D4D30", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x12B6EB0", Offset = "0x12B58B0", VA = "0x1812B6EB0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b VSUEETNZWUB
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x32827C0", Offset = "0x32811C0", VA = "0x1832827C0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5B18E70", Offset = "0x5B17870", VA = "0x185B18E70", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b FXFZYLLBABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x1718A80", Offset = "0x1717480", VA = "0x181718A80")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object VZEVIODPGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x5B0F960", Offset = "0x5B0E360", VA = "0x185B0F960", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x5B1A710", Offset = "0x5B19110", VA = "0x185B1A710", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5B1EFD0", Offset = "0x5B1D9D0", VA = "0x185B1EFD0", Slot = "9")]
		protected override bool XCIABATDDRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5B24520", Offset = "0x5B22F20", VA = "0x185B24520")]
		protected ECDNFFNAXJF([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5B23EC0", Offset = "0x5B228C0", VA = "0x185B23EC0")]
		protected ECDNFFNAXJF(PPTCRKDFMWF a, RCSERIFJNPS b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, KYWQGMNBKCS i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5397EF0", Offset = "0x53968F0", VA = "0x185397EF0")]
		public a UZCCFHHVJMF()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5B18850", Offset = "0x5B17250", VA = "0x185B18850")]
		public void MEKBTYVUTUJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1718A80", Offset = "0x1717480", VA = "0x181718A80")]
		public b UYMHNNADHEE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5B17B70", Offset = "0x5B16570", VA = "0x185B17B70")]
		public void MDUHCEOCRMI(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5B1E0A0", Offset = "0x5B1CAA0", VA = "0x185B1E0A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7F00", Offset = "0xCE6900", VA = "0x180CE7F00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xCE7ED0", Offset = "0xCE68D0", VA = "0x180CE7ED0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b VSUEETNZWUB
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xECCFB0", Offset = "0xECB9B0", VA = "0x180ECCFB0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2AB3F50", Offset = "0x2AB2950", VA = "0x182AB3F50", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c VSOXHMUCNIS
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCD7530", Offset = "0xCD5F30", VA = "0x180CD7530", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C60", Offset = "0xCD5660", VA = "0x180CD6C60", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a FWQFGRDIXTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5397EF0", Offset = "0x53968F0", VA = "0x185397EF0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b FXFZYLLBABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x1718A80", Offset = "0x1717480", VA = "0x181718A80")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c FXATBERDQPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x5B0CF70", Offset = "0x5B0B970", VA = "0x185B0CF70")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object VZEVIODPGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x5B0F960", Offset = "0x5B0E360", VA = "0x185B0F960", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5B0D120", Offset = "0x5B0BB20", VA = "0x185B0D120", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5B0F480", Offset = "0x5B0DE80", VA = "0x185B0F480", Slot = "9")]
		protected override bool XCIABATDDRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5B10640", Offset = "0x5B0F040", VA = "0x185B10640")]
		protected EBYGHYTDNXW([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5B10940", Offset = "0x5B0F340", VA = "0x185B10940")]
		protected EBYGHYTDNXW(PPTCRKDFMWF a, RCSERIFJNPS b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, KYWQGMNBKCS j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5397EF0", Offset = "0x53968F0", VA = "0x185397EF0")]
		public a UZCCFHHVJMF()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5B0CC20", Offset = "0x5B0B620", VA = "0x185B0CC20")]
		public void MEKBTYVUTUJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1718A80", Offset = "0x1717480", VA = "0x181718A80")]
		public b UYMHNNADHEE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x5B0C560", Offset = "0x5B0AF60", VA = "0x185B0C560")]
		public void MDUHCEOCRMI(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5B0CF70", Offset = "0x5B0B970", VA = "0x185B0CF70")]
		public c UYROKTUAQPN()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5B0C880", Offset = "0x5B0B280", VA = "0x185B0C880")]
		public void MDZNZLIAAXR(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5B0DA70", Offset = "0x5B0C470", VA = "0x185B0DA70")]
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
			[Cpp2IlInjected.Address(RVA = "0xF60D90", Offset = "0xF5F790", VA = "0x180F60D90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x5B362D0", Offset = "0x5B34CD0", VA = "0x185B362D0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b VSUEETNZWUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1479060", Offset = "0x1477A60", VA = "0x181479060", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1478C10", Offset = "0x1477610", VA = "0x181478C10", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c VSOXHMUCNIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x1515110", Offset = "0x1513B10", VA = "0x181515110", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x5B3D9F0", Offset = "0x5B3C3F0", VA = "0x185B3D9F0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d VTERZHBUPQT
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1D3F7E0", Offset = "0x1D3E1E0", VA = "0x181D3F7E0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x16769B0", Offset = "0x16753B0", VA = "0x1816769B0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b FXFZYLLBABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x5B0CF00", Offset = "0x5B0B900", VA = "0x185B0CF00")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c FXATBERDQPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x5B0CF40", Offset = "0x5B0B940", VA = "0x185B0CF40")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d FXQNSYYVSXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x15BC050", Offset = "0x15BAA50", VA = "0x1815BC050")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object VZEVIODPGNP
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x5B0F960", Offset = "0x5B0E360", VA = "0x185B0F960", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x5B3E460", Offset = "0x5B3CE60", VA = "0x185B3E460", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5B43910", Offset = "0x5B42310", VA = "0x185B43910", Slot = "9")]
		protected override bool XCIABATDDRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5B45A30", Offset = "0x5B44430", VA = "0x185B45A30")]
		protected EDJCOUCLBZH([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5B43C10", Offset = "0x5B42610", VA = "0x185B43C10")]
		protected EDJCOUCLBZH(PPTCRKDFMWF a, RCSERIFJNPS b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, KYWQGMNBKCS k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5397EF0", Offset = "0x53968F0", VA = "0x185397EF0")]
		public a UZCCFHHVJMF()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5B3D3D0", Offset = "0x5B3BDD0", VA = "0x185B3D3D0")]
		public void MEKBTYVUTUJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x5B0CF00", Offset = "0x5B0B900", VA = "0x185B0CF00")]
		public b UYMHNNADHEE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C220", Offset = "0x5B3AC20", VA = "0x185B3C220")]
		public void MDUHCEOCRMI(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5B0CF40", Offset = "0x5B0B940", VA = "0x185B0CF40")]
		public c UYROKTUAQPN()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5B3C3C0", Offset = "0x5B3ADC0", VA = "0x185B3C3C0")]
		public void MDZNZLIAAXR(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15BC050", Offset = "0x15BAA50", VA = "0x1815BC050")]
		public d UZRWXBPNLUG()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5B3B0C0", Offset = "0x5B39AC0", VA = "0x185B3B0C0")]
		public void MDJTHRAHYPQ(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x5B40420", Offset = "0x5B3EE20", VA = "0x185B40420")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE7F00", Offset = "0xCE6900", VA = "0x180CE7F00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xCE7ED0", Offset = "0xCE68D0", VA = "0x180CE7ED0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b VSUEETNZWUB
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xDE9CA0", Offset = "0xDE86A0", VA = "0x180DE9CA0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x14906C0", Offset = "0x148F0C0", VA = "0x1814906C0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c VSOXHMUCNIS
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xDE6B00", Offset = "0xDE5500", VA = "0x180DE6B00", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xDE7C10", Offset = "0xDE6610", VA = "0x180DE7C10", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d VTERZHBUPQT
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xCF0FF0", Offset = "0xCEF9F0", VA = "0x180CF0FF0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xD00BC0", Offset = "0xCFF5C0", VA = "0x180D00BC0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e VSZLCAHXGFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C30", Offset = "0xCEF630", VA = "0x180CF0C30", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5B325D0", Offset = "0x5B30FD0", VA = "0x185B325D0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object VZEVIODPGNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x5B0F960", Offset = "0x5B0E360", VA = "0x185B0F960", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x5B327E0", Offset = "0x5B311E0", VA = "0x185B327E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5B33860", Offset = "0x5B32260", VA = "0x185B33860", Slot = "9")]
		protected override bool XCIABATDDRH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5B33ED0", Offset = "0x5B328D0", VA = "0x185B33ED0")]
		protected EDDVRNINSNY(PPTCRKDFMWF a, RCSERIFJNPS b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, KYWQGMNBKCS l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5397EF0", Offset = "0x53968F0", VA = "0x185397EF0")]
		public a UZCCFHHVJMF()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5B32410", Offset = "0x5B30E10", VA = "0x185B32410")]
		public void MEKBTYVUTUJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1718A80", Offset = "0x1717480", VA = "0x181718A80")]
		public b UYMHNNADHEE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5B32170", Offset = "0x5B30B70", VA = "0x185B32170")]
		public void MDUHCEOCRMI(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5B0CF70", Offset = "0x5B0B970", VA = "0x185B0CF70")]
		public c UYROKTUAQPN()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5B32250", Offset = "0x5B30C50", VA = "0x185B32250")]
		public void MDZNZLIAAXR(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x15BC050", Offset = "0x15BAA50", VA = "0x1815BC050")]
		public d UZRWXBPNLUG()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x5B31DF0", Offset = "0x5B307F0", VA = "0x185B31DF0")]
		public void MDJTHRAHYPQ(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5B33570", Offset = "0x5B31F70", VA = "0x185B33570")]
		public e UZXDUIJKVFP()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x5B31FB0", Offset = "0x5B309B0", VA = "0x185B31FB0")]
		public void MDPAEXUFIAZ(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x5B329E0", Offset = "0x5B313E0", VA = "0x185B329E0")]
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
