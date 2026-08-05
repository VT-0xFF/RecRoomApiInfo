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
	public interface CBGEPDLAAOU : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool ZNXVADSEIQR
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool IINZHALAGCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		RHIZVYSCBOY MNIKJCFNKAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int NIBLNONNVSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool PWDWVIODHLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool FUMCWMWZXKW
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action RWKHUVMKOSX;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void MXUSMOARVYO();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void XCMZEIZZXEA(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RBOFITFJLNY();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface QACKCHIQBEZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string XQUUXFGLFNM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool TJGRXWMJENK
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface VTXPDSRNURI<a> : QACKCHIQBEZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a IOPWWZHZOZA
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MKNRKXXRTGH(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class OFIFEKLRRXJ<a> : VTXPDSRNURI<a>, QACKCHIQBEZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly YWQGIVZNLUA<a> MIZJQLNTRTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly YWQGIVZNLUA<a> VIRODSDSEVD;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string XQUUXFGLFNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCCAF70", Offset = "0xCC9770", VA = "0x180CCAF70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool VOZATQZAVYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x596F350", Offset = "0x596DB50", VA = "0x18596F350", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a KYEYSZMJEXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x596EE20", Offset = "0x596D620", VA = "0x18596EE20", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x596CFA0", Offset = "0x596B7A0", VA = "0x18596CFA0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a IOPWWZHZOZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x596EF90", Offset = "0x596D790", VA = "0x18596EF90", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5970B00", Offset = "0x596F300", VA = "0x185970B00", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a GJDRZFRFPRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x596EF90", Offset = "0x596D790", VA = "0x18596EF90")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x596DEB0", Offset = "0x596C6B0", VA = "0x18596DEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool TJGRXWMJENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x596ED80", Offset = "0x596D580", VA = "0x18596ED80", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5970870", Offset = "0x596F070", VA = "0x185970870", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool WMZXLLLZHRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x596D650", Offset = "0x596BE50", VA = "0x18596D650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5970360", Offset = "0x596EB60", VA = "0x185970360", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x59712D0", Offset = "0x596FAD0", VA = "0x1859712D0")]
		public OFIFEKLRRXJ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x596DCB0", Offset = "0x596C4B0", VA = "0x18596DCB0")]
		private void CRUNWAMTQRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x596FB60", Offset = "0x596E360", VA = "0x18596FB60", Slot = "5")]
		public void MKNRKXXRTGH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x596FDB0", Offset = "0x596E5B0", VA = "0x18596FDB0")]
		public void MKNRKXXRTGH(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x596ED40", Offset = "0x596D540", VA = "0x18596ED40", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class OFNMBRFPBIS<a, b> : VTXPDSRNURI<(a, b)>, QACKCHIQBEZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly YXGBAQHFOCB<a, b> MIZJQLNTRTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly YXGBAQHFOCB<a, b> VIRODSDSEVD;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string XQUUXFGLFNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCCAF70", Offset = "0xCC9770", VA = "0x180CCAF70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool VOZATQZAVYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5975C00", Offset = "0x5974400", VA = "0x185975C00", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PIPXUIYBWUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5976F80", Offset = "0x5975780", VA = "0x185976F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PIVERPRZGFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x59771F0", Offset = "0x59759F0", VA = "0x1859771F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) KYEYSZMJEXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5974980", Offset = "0x5973180", VA = "0x185974980", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5973720", Offset = "0x5971F20", VA = "0x185973720", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) IOPWWZHZOZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5976960", Offset = "0x5975160", VA = "0x185976960", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5978800", Offset = "0x5977000", VA = "0x185978800", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) GJDRZFRFPRC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5974E30", Offset = "0x5973630", VA = "0x185974E30")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5974620", Offset = "0x5972E20", VA = "0x185974620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a FALGUUIQBVE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5973D70", Offset = "0x5972570", VA = "0x185973D70")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5977CA0", Offset = "0x59764A0", VA = "0x185977CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a HJNGCLXMKNH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5974780", Offset = "0x5972F80", VA = "0x185974780")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5978960", Offset = "0x5977160", VA = "0x185978960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a HRVVMIMFXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5974780", Offset = "0x5972F80", VA = "0x185974780")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5975910", Offset = "0x5974110", VA = "0x185975910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b FAFZXNOSSJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5973F30", Offset = "0x5972730", VA = "0x185973F30")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5978350", Offset = "0x5976B50", VA = "0x185978350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b HIXLKRPUIFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5974690", Offset = "0x5972E90", VA = "0x185974690")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b HSBCJPGDGYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5974690", Offset = "0x5972E90", VA = "0x185974690")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5975510", Offset = "0x5973D10", VA = "0x185975510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool TJGRXWMJENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x596ED80", Offset = "0x596D580", VA = "0x18596ED80", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x5970870", Offset = "0x596F070", VA = "0x185970870", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5977880", Offset = "0x5976080", VA = "0x185977880", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x59799F0", Offset = "0x59781F0", VA = "0x1859799F0")]
		public OFNMBRFPBIS([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5974220", Offset = "0x5972A20", VA = "0x185974220")]
		private void CRUNWAMTQRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5978BE0", Offset = "0x59773E0", VA = "0x185978BE0")]
		public void YIGAQWLIGYE(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5976020", Offset = "0x5974820", VA = "0x185976020")]
		public void MKNRKXXRTGH(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x59763A0", Offset = "0x5974BA0", VA = "0x1859763A0", Slot = "5")]
		private void NWBMALWNHDK((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x596ED40", Offset = "0x596D540", VA = "0x18596ED40", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class OFSSYXZMKUB<a, b, c> : VTXPDSRNURI<(a, b, c)>, QACKCHIQBEZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly YXAUDJNIEQS<a, b, c> MIZJQLNTRTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly YXAUDJNIEQS<a, b, c> VIRODSDSEVD;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string XQUUXFGLFNM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xCCAF70", Offset = "0xCC9770", VA = "0x180CCAF70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool VOZATQZAVYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x597C360", Offset = "0x597AB60", VA = "0x18597C360", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool PIPXUIYBWUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x597D150", Offset = "0x597B950", VA = "0x18597D150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool PIVERPRZGFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x597D5B0", Offset = "0x597BDB0", VA = "0x18597D5B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool PJALOWLWPQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x597D4E0", Offset = "0x597BCE0", VA = "0x18597D4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) KYEYSZMJEXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x597BBC0", Offset = "0x597A3C0", VA = "0x18597BBC0", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x597A540", Offset = "0x5978D40", VA = "0x18597A540", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) IOPWWZHZOZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x597CD50", Offset = "0x597B550", VA = "0x18597CD50", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x597E0B0", Offset = "0x597C8B0", VA = "0x18597E0B0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a FALGUUIQBVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x597AD00", Offset = "0x5979500", VA = "0x18597AD00")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x597D880", Offset = "0x597C080", VA = "0x18597D880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a HJNGCLXMKNH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x597B7C0", Offset = "0x5979FC0", VA = "0x18597B7C0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a HRVVMIMFXMX
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x597B7C0", Offset = "0x5979FC0", VA = "0x18597B7C0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x597C2D0", Offset = "0x597AAD0", VA = "0x18597C2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b FAFZXNOSSJV
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x597AD30", Offset = "0x5979530", VA = "0x18597AD30")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x597DB30", Offset = "0x597C330", VA = "0x18597DB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b HIXLKRPUIFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x597B6E0", Offset = "0x5979EE0", VA = "0x18597B6E0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b HSBCJPGDGYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x597B6E0", Offset = "0x5979EE0", VA = "0x18597B6E0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x597BF60", Offset = "0x597A760", VA = "0x18597BF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c FAATAGUVIYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x597AE10", Offset = "0x5979610", VA = "0x18597AE10")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x597DFB0", Offset = "0x597C7B0", VA = "0x18597DFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c HJCSHYJRRQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x597B6B0", Offset = "0x5979EB0", VA = "0x18597B6B0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c HSGJGWAAQJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x597B6B0", Offset = "0x5979EB0", VA = "0x18597B6B0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x597BD80", Offset = "0x597A580", VA = "0x18597BD80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool TJGRXWMJENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x596ED80", Offset = "0x596D580", VA = "0x18596ED80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x597D680", Offset = "0x597BE80", VA = "0x18597D680", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x597EF50", Offset = "0x597D750", VA = "0x18597EF50")]
		public OFSSYXZMKUB([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x597B440", Offset = "0x5979C40", VA = "0x18597B440")]
		private void CRUNWAMTQRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x597E440", Offset = "0x597CC40", VA = "0x18597E440")]
		public void YIGAQWLIGYE(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x597A050", Offset = "0x5978850", VA = "0x18597A050")]
		public void AFVETUSRCMH(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x597C6F0", Offset = "0x597AEF0", VA = "0x18597C6F0")]
		public void LOBTBCUSLNY(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x597C9C0", Offset = "0x597B1C0", VA = "0x18597C9C0")]
		public void MKNRKXXRTGH(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x597B190", Offset = "0x5979990", VA = "0x18597B190", Slot = "5")]
		private void COYQYGNOQZX((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x596ED40", Offset = "0x596D540", VA = "0x18596ED40", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class OFXZWETJUFK<a, b, c, d> : VTXPDSRNURI<(a, b, c, d)>, QACKCHIQBEZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly YWALRBRVJLZ<a, b, c, d> MIZJQLNTRTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly YWALRBRVJLZ<a, b, c, d> VIRODSDSEVD;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string XQUUXFGLFNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCCAF70", Offset = "0xCC9770", VA = "0x180CCAF70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) IOPWWZHZOZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x59F2860", Offset = "0x59F1060", VA = "0x1859F2860", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x59F3100", Offset = "0x59F1900", VA = "0x1859F3100", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b HIXLKRPUIFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x59F2520", Offset = "0x59F0D20", VA = "0x1859F2520")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c HJCSHYJRRQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x59F2440", Offset = "0x59F0C40", VA = "0x1859F2440")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d HKDAUGFEMVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x59F2360", Offset = "0x59F0B60", VA = "0x1859F2360")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool TJGRXWMJENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x596ED80", Offset = "0x596D580", VA = "0x18596ED80", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5970870", Offset = "0x596F070", VA = "0x185970870", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x59F3F80", Offset = "0x59F2780", VA = "0x1859F3F80")]
		public OFXZWETJUFK([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x59F1F40", Offset = "0x59F0740", VA = "0x1859F1F40")]
		private void CRUNWAMTQRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x59F37C0", Offset = "0x59F1FC0", VA = "0x1859F37C0")]
		public void YIGAQWLIGYE(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x59F2550", Offset = "0x59F0D50", VA = "0x1859F2550")]
		public void MKNRKXXRTGH(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x59F2D40", Offset = "0x59F1540", VA = "0x1859F2D40", Slot = "5")]
		private void TTFLELGMUNX((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x596ED40", Offset = "0x596D540", VA = "0x18596ED40", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class SRCDTIKQFZE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x837D5D0", Offset = "0x837BDD0", VA = "0x18837D5D0")]
		public static string VDNBFPUDMTX(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB89940", Offset = "0xB88140", VA = "0x180B89940")]
		public static NetworkSetterPermissionMode GJMKVCPFWQG(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class YWQGIVZNLUA<a> : UUJWQCTRNUZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3E0A590", Offset = "0x3E08D90", VA = "0x183E0A590")]
		public YWQGIVZNLUA([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3E08590", Offset = "0x3E06D90", VA = "0x183E08590")]
		public YWQGIVZNLUA(GPQEQALGKDB a, RHIZVYSCBOY b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] PBERQMVJJMT g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3E07A80", Offset = "0x3E06280", VA = "0x183E07A80")]
		public YWQGIVZNLUA(GPQEQALGKDB a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] PBERQMVJJMT f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3E08E60", Offset = "0x3E07660", VA = "0x183E08E60")]
		public YWQGIVZNLUA(GPQEQALGKDB a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] PBERQMVJJMT g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class YXGBAQHFOCB<a, b> : UTUBYILZLMY<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F770", Offset = "0x3E0DF70", VA = "0x183E0F770")]
		public YXGBAQHFOCB([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3E112B0", Offset = "0x3E0FAB0", VA = "0x183E112B0")]
		public YXGBAQHFOCB(GPQEQALGKDB a, RHIZVYSCBOY b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] PBERQMVJJMT h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3E0F8A0", Offset = "0x3E0E0A0", VA = "0x183E0F8A0")]
		public YXGBAQHFOCB(GPQEQALGKDB a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] PBERQMVJJMT g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3E10620", Offset = "0x3E0EE20", VA = "0x183E10620")]
		public YXGBAQHFOCB(GPQEQALGKDB a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] PBERQMVJJMT h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class YXAUDJNIEQS<a, b, c> : UTZIVPFWUYH<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3E0C6C0", Offset = "0x3E0AEC0", VA = "0x183E0C6C0")]
		public YXAUDJNIEQS([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3E0CAE0", Offset = "0x3E0B2E0", VA = "0x183E0CAE0")]
		public YXAUDJNIEQS(GPQEQALGKDB a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] PBERQMVJJMT h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class YWALRBRVJLZ<a, b, c, d> : UTJODUYESQG<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3E02290", Offset = "0x3E00A90", VA = "0x183E02290")]
		public YWALRBRVJLZ([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3E02BB0", Offset = "0x3E013B0", VA = "0x183E02BB0")]
		public YWALRBRVJLZ(GPQEQALGKDB a, RHIZVYSCBOY b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] PBERQMVJJMT j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3E02CE0", Offset = "0x3E014E0", VA = "0x183E02CE0")]
		public YWALRBRVJLZ(GPQEQALGKDB a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] PBERQMVJJMT i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class YVVETUXYAAQ<a, b, c, d, e> : UTOVBBSCCBP<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3E00FC0", Offset = "0x3DFF7C0", VA = "0x183E00FC0")]
		public YVVETUXYAAQ(GPQEQALGKDB a, RHIZVYSCBOY b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] PBERQMVJJMT k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3E00EB0", Offset = "0x3DFF6B0", VA = "0x183E00EB0")]
		public YVVETUXYAAQ(GPQEQALGKDB a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] PBERQMVJJMT j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class WHKPPTKHNYD<a> : UUJWQCTRNUZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x660FAE0", Offset = "0x660E2E0", VA = "0x18660FAE0")]
		public WHKPPTKHNYD(RHIZVYSCBOY a, string b, a c, [Optional] Action d, [Optional] PBERQMVJJMT e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class WHPWNAEEXJM<a, b> : UTUBYILZLMY<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6612E30", Offset = "0x6611630", VA = "0x186612E30")]
		public WHPWNAEEXJM(RHIZVYSCBOY a, string b, a c, b d, [Optional] Action e, [Optional] PBERQMVJJMT f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface PBAJZVTYAYB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		YWQGIVZNLUA<a> RQBMUWAGVBD<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class LTCJOOLLZTE : PBAJZVTYAYB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly PBERQMVJJMT RXCGXTBRYKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly GPQEQALGKDB ZJYUDPTNQRI;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAA71B0", Offset = "0xAA59B0", VA = "0x180AA71B0")]
		public LTCJOOLLZTE(PBERQMVJJMT a, GPQEQALGKDB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x374BDC0", Offset = "0x374A5C0", VA = "0x18374BDC0", Slot = "4")]
		public YWQGIVZNLUA<a> RQBMUWAGVBD<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface YXCJTLIQRXC : GPQEQALGKDB
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId QNYDEQJWDXU
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface GPQEQALGKDB
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool KLYIAAEMXPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool LHYUNIINVRQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string PJTKIJZTVAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool MZBGYDVMOZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(UNSAYDJFQCJ handler);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(UNSAYDJFQCJ handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class RQWZIOZXMAR
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x837D580", Offset = "0x837BD80", VA = "0x18837D580")]
		public static bool BSHIQPEUQKS(this GPQEQALGKDB a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface PBERQMVJJMT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		RHIZVYSCBOY PMVKNQAWXFN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool WMZXLLLZHRY
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool FOFSXANJMUT
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
		object TJYYSNNSWZJ(string a);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object QXBTMAAZFVL(RHIZVYSCBOY a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void QIPAOSQPUXR(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void TCZWAZAFCNT(RHIZVYSCBOY a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void UYYHMGOZVMS<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void OZIJOJYNJEY([CanBeNull] RHIZVYSCBOY photonPlayer, string a, HJDNNOWCJGH b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void SPECJUFEIFL([CanBeNull] RHIZVYSCBOY photonPlayer, string a, HJDNNOWCJGH b);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b QXVOIGGUOKX<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object LOHWPILZPRA<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void PINJGLMJKDB();

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void PPCQRABDQQR();

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void IOVIGYTAMDO(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public RHIZVYSCBOY player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public GPQEQALGKDB context;

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
		public PBERQMVJJMT networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x837D660", Offset = "0x837BE60", VA = "0x18837D660")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x837D6E0", Offset = "0x837BEE0", VA = "0x18837D6E0")]
		public SyncData(GPQEQALGKDB context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] PBERQMVJJMT networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x837D610", Offset = "0x837BE10", VA = "0x18837D610")]
		public static SyncData From(GPQEQALGKDB context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] PBERQMVJJMT networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class LGJMDCCHALQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x37477D0", Offset = "0x3745FD0", VA = "0x1837477D0")]
		public static YWQGIVZNLUA<a> HJDNNOWCJGH<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3746DC0", Offset = "0x37455C0", VA = "0x183746DC0")]
		public static YXGBAQHFOCB<b, c> HJDNNOWCJGH<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3746E60", Offset = "0x3745660", VA = "0x183746E60")]
		public static YXAUDJNIEQS<d, e, f> HJDNNOWCJGH<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3747280", Offset = "0x3745A80", VA = "0x183747280")]
		public static YWALRBRVJLZ<g, h, i, j> HJDNNOWCJGH<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3745DD0", Offset = "0x37445D0", VA = "0x183745DD0")]
		public static OFIFEKLRRXJ<k> FLRRSYARKVG<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3745C80", Offset = "0x3744480", VA = "0x183745C80")]
		public static OFNMBRFPBIS<l, m> FLRRSYARKVG<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3745D20", Offset = "0x3744520", VA = "0x183745D20")]
		public static OFSSYXZMKUB<n, o, p> FLRRSYARKVG<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x37467D0", Offset = "0x3744FD0", VA = "0x1837467D0")]
		public static OFXZWETJUFK<q, r, s, t> FLRRSYARKVG<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class HJDNNOWCJGH : UNSAYDJFQCJ, IDisposable
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
		private static Stack<PBERQMVJJMT> FTHZXXJJIWB;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool XQSPMRGWTKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly RHIZVYSCBOY WYLMFSILFHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly GPQEQALGKDB ZJYUDPTNQRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string UWHDEJCLXLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode EEWWKRUEOPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action HOUIHRVFKXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected PBERQMVJJMT CPLEEQYIQQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags OLLNIORNCPE;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static PBERQMVJJMT IUGZWHNPGLV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8379640", Offset = "0x8377E40", VA = "0x188379640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool PXOKUXWRNAX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x837A440", Offset = "0x8378C40", VA = "0x18837A440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x83799F0", Offset = "0x83781F0", VA = "0x1883799F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool DAGYHFJTCPY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x837AA70", Offset = "0x8379270", VA = "0x18837AA70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x837A8B0", Offset = "0x83790B0", VA = "0x18837A8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool XGTZNDNXQOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8379DE0", Offset = "0x83785E0", VA = "0x188379DE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x837A1B0", Offset = "0x83789B0", VA = "0x18837A1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool TJGRXWMJENK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8379980", Offset = "0x8378180", VA = "0x188379980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x837A450", Offset = "0x8378C50", VA = "0x18837A450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object WHXERYUCZBY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAA3260", Offset = "0xAA1A60", VA = "0x180AA3260", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool TVDXYEOAKQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8379B40", Offset = "0x8378340", VA = "0x188379B40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int RRYRRKFLARA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xBDFD20", Offset = "0xBDE520", VA = "0x180BDFD20")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x17C6240", Offset = "0x17C4A40", VA = "0x1817C6240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string XQUUXFGLFNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool WMZXLLLZHRY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x83795F0", Offset = "0x8377DF0", VA = "0x1883795F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x837A3A0", Offset = "0x8378BA0", VA = "0x18837A3A0")]
		public static void QSRTXXIJIYC(PBERQMVJJMT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool CHNXLMNUERG();

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x837AB90", Offset = "0x8379390", VA = "0x18837AB90")]
		protected HJDNNOWCJGH(RHIZVYSCBOY a, GPQEQALGKDB b, string c, NetworkSetterPermissionMode d, Action e, PBERQMVJJMT f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8379990", Offset = "0x8378190", VA = "0x188379990", Slot = "1")]
		~HJDNNOWCJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8379810", Offset = "0x8378010", VA = "0x188379810", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8379AA0", Offset = "0x83782A0", VA = "0x188379AA0")]
		private void HWDOBJBWULA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x837A1D0", Offset = "0x83789D0", VA = "0x18837A1D0")]
		private object MHEUQCXUIEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8379FE0", Offset = "0x83787E0", VA = "0x188379FE0")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x837A5F0", Offset = "0x8378DF0", VA = "0x18837A5F0")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8379B90", Offset = "0x8378390", VA = "0x188379B90")]
		protected void IJIBMMFNTNN(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x837AA80", Offset = "0x8379280", VA = "0x18837AA80")]
		internal void XHGUFPBYMNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x837A340", Offset = "0x8378B40", VA = "0x18837A340")]
		private void MKSHNTZONPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x837A8D0", Offset = "0x83790D0", VA = "0x18837A8D0")]
		private void WBYKFCHSBBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8379A10", Offset = "0x8378210", VA = "0x188379A10", Slot = "4")]
		private void GIJNFXXSSBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8379DF0", Offset = "0x83785F0", VA = "0x188379DF0", Slot = "5")]
		private void IUBLVUZCMOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x837A930", Offset = "0x8379130", VA = "0x18837A930")]
		public bool WNVORQLIGJT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x837A640", Offset = "0x8378E40", VA = "0x18837A640")]
		public bool TLIRVKGTLVD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8379E00", Offset = "0x8378600", VA = "0x188379E00")]
		private bool IYOWZFYTQYK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x837A800", Offset = "0x8379000", VA = "0x18837A800")]
		internal void UNIPCADLWDB(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x83794E0", Offset = "0x8377CE0", VA = "0x1883794E0")]
		private void AVHKWPHBPKF(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x837A630", Offset = "0x8378E30", VA = "0x18837A630")]
		private bool TBGDPSWFCMX(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8379A80", Offset = "0x8378280", VA = "0x188379A80")]
		private void GQXCTKJEARB(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8379F50", Offset = "0x8378750", VA = "0x188379F50")]
		public static string IZUZKMMGVBX(RHIZVYSCBOY a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x837A510", Offset = "0x8378D10", VA = "0x18837A510")]
		public static string SPNYGZJVJQF(GPQEQALGKDB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x83796B0", Offset = "0x8377EB0", VA = "0x1883796B0")]
		public static bool DDTPHRXFEMD(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class OBQUNMLNCOZ : PBERQMVJJMT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> GWRNQNGOHXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> UNXKNRPMFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> GUMQQDDVIUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> FIHWLADGCEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool IWZTIHAPXBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> ONYPJFUBGDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<RHIZVYSCBOY, Dictionary<string, object>> WCRVQQADPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> WCGLRQQIOWZ;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> QZHNTGBBEGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int SMOWZSLRZYK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract RHIZVYSCBOY PMVKNQAWXFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool WMZXLLLZHRY
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool FOFSXANJMUT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool IYZSEKNFENG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool MJQWBVQVIEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB02810", Offset = "0xB01010", VA = "0x180B02810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x38886A0", Offset = "0x3886EA0", VA = "0x1838886A0", Slot = "12")]
		public void UYYHMGOZVMS<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x837C9A0", Offset = "0x837B1A0", VA = "0x18837C9A0", Slot = "11")]
		public void TCZWAZAFCNT(RHIZVYSCBOY a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x837C610", Offset = "0x837AE10", VA = "0x18837C610", Slot = "9")]
		public object QXBTMAAZFVL(RHIZVYSCBOY a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x837C4F0", Offset = "0x837ACF0", VA = "0x18837C4F0", Slot = "10")]
		public void QIPAOSQPUXR(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x837CAF0", Offset = "0x837B2F0", VA = "0x18837CAF0", Slot = "8")]
		public object TJYYSNNSWZJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x837BD90", Offset = "0x837A590", VA = "0x18837BD90", Slot = "13")]
		public void OZIJOJYNJEY(RHIZVYSCBOY a, string b, HJDNNOWCJGH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x837C700", Offset = "0x837AF00", VA = "0x18837C700", Slot = "14")]
		public void SPECJUFEIFL(RHIZVYSCBOY a, string b, HJDNNOWCJGH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x837ADC0", Offset = "0x83795C0", VA = "0x18837ADC0")]
		private void ANYBBDRVLGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x837D340", Offset = "0x837BB40", VA = "0x18837D340")]
		private void ZSAQDPRAGOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x837B000", Offset = "0x8379800", VA = "0x18837B000")]
		private void EOUELQNDOUO(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x837B280", Offset = "0x8379A80", VA = "0x18837B280")]
		protected void IAFJLWFQGIE(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x837B9B0", Offset = "0x837A1B0", VA = "0x18837B9B0")]
		protected void KWXDPJSIFVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x837ADB0", Offset = "0x83795B0", VA = "0x18837ADB0")]
		protected void AGBMQMOEKEI(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x837B620", Offset = "0x8379E20", VA = "0x18837B620")]
		protected void ISZSYRWTEFW(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x837AF70", Offset = "0x8379770", VA = "0x18837AF70")]
		protected void EJQHLRTPENM(RHIZVYSCBOY a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x837BFA0", Offset = "0x837A7A0", VA = "0x18837BFA0")]
		private void PKHDDDPIGVL(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x837B720", Offset = "0x8379F20", VA = "0x18837B720")]
		private static void IZSDHOKTRUN(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x837B060", Offset = "0x8379860", VA = "0x18837B060")]
		private static void HFGXMEYOGNC(Dictionary<string, object> a, string b, HJDNNOWCJGH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x837CB90", Offset = "0x837B390", VA = "0x18837CB90")]
		private static void VTCHPVPKAJZ(Dictionary<string, object> a, string b, HJDNNOWCJGH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x837BEA0", Offset = "0x837A6A0", VA = "0x18837BEA0", Slot = "17")]
		public void PINJGLMJKDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract void KQQJHJBDOKS(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x837C410", Offset = "0x837AC10", VA = "0x18837C410", Slot = "18")]
		public void PPCQRABDQQR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "28")]
		protected abstract void WBWUKYCKWJK(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x837BAA0", Offset = "0x837A2A0", VA = "0x18837BAA0")]
		private void LYRKRZIGMHF(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x837CD60", Offset = "0x837B560", VA = "0x18837CD60")]
		private void WTWOOPIMEHY(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x837B690", Offset = "0x8379E90", VA = "0x18837B690")]
		public void IUCDCDPZBPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x837BCC0", Offset = "0x837A4C0", VA = "0x18837BCC0")]
		public void LYTZEOBJMFL(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x837CFE0", Offset = "0x837B7E0", VA = "0x18837CFE0")]
		public void XOUZTRCSLPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract HashSet<int> YIEWQTNRFVE(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x837B3A0", Offset = "0x8379BA0", VA = "0x18837B3A0", Slot = "19")]
		public void IOVIGYTAMDO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x837B920", Offset = "0x837A120", VA = "0x18837B920")]
		protected string IZUZKMMGVBX(RHIZVYSCBOY a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "30")]
		public abstract object LOHWPILZPRA<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "31")]
		public abstract c QXVOIGGUOKX<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "32")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x837AE10", Offset = "0x8379610", VA = "0x18837AE10", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "33")]
		protected virtual void NTIXYXUUUDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x837D390", Offset = "0x837BB90", VA = "0x18837D390")]
		protected OBQUNMLNCOZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class UUJWQCTRNUZ<a> : HJDNNOWCJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a GQIPDAIUOFK;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a ZLRVRIFFBKL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD53760", Offset = "0xD51F60", VA = "0x180D53760", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD53750", Offset = "0xD51F50", VA = "0x180D53750", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object WHXERYUCZBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x6124350", Offset = "0x6122B50", VA = "0x186124350", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6151BC0", Offset = "0x61503C0", VA = "0x186151BC0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x614C820", Offset = "0x614B020", VA = "0x18614C820", Slot = "9")]
		protected override bool CHNXLMNUERG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6154820", Offset = "0x6153020", VA = "0x186154820")]
		protected UUJWQCTRNUZ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6153AE0", Offset = "0x61522E0", VA = "0x186153AE0")]
		protected UUJWQCTRNUZ(RHIZVYSCBOY a, GPQEQALGKDB b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, PBERQMVJJMT h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x6123F80", Offset = "0x6122780", VA = "0x186123F80")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x61503A0", Offset = "0x614EBA0", VA = "0x1861503A0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x614FAB0", Offset = "0x614E2B0", VA = "0x18614FAB0")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class UTUBYILZLMY<a, b> : HJDNNOWCJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a GQIPDAIUOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b GQYJUUQMQNL;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a ZLRVRIFFBKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xE2B450", Offset = "0xE29C50", VA = "0x180E2B450", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xFEF2E0", Offset = "0xFEDAE0", VA = "0x180FEF2E0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b ZLXCOOZCKVU
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2FAEB00", Offset = "0x2FAD300", VA = "0x182FAEB00", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x61367A0", Offset = "0x6134FA0", VA = "0x1861367A0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b GCTPVAPVYYW
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x144AA00", Offset = "0x1449200", VA = "0x18144AA00")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object WHXERYUCZBY
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6124350", Offset = "0x6122B50", VA = "0x186124350", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x613C670", Offset = "0x613AE70", VA = "0x18613C670", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6136570", Offset = "0x6134D70", VA = "0x186136570", Slot = "9")]
		protected override bool CHNXLMNUERG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x613E370", Offset = "0x613CB70", VA = "0x18613E370")]
		protected UTUBYILZLMY([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x613FEA0", Offset = "0x613E6A0", VA = "0x18613FEA0")]
		protected UTUBYILZLMY(RHIZVYSCBOY a, GPQEQALGKDB b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, PBERQMVJJMT i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6123F60", Offset = "0x6122760", VA = "0x186123F60")]
		public a FIYFQHWQRMI()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6136E50", Offset = "0x6135650", VA = "0x186136E50")]
		public void FFRBMLQNKUI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x144AA00", Offset = "0x1449200", VA = "0x18144AA00")]
		public b FJOAICEITUJ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6137910", Offset = "0x6136110", VA = "0x186137910")]
		public void FGGWEFYFNCJ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x613B0C0", Offset = "0x61398C0", VA = "0x18613B0C0")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class UTZIVPFWUYH<a, b, c> : HJDNNOWCJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a GQIPDAIUOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b GQYJUUQMQNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c GQTCXNWPHCC;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a ZLRVRIFFBKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAB1020", Offset = "0xAAF820", VA = "0x180AB1020", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAB0FF0", Offset = "0xAAF7F0", VA = "0x180AB0FF0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b ZLXCOOZCKVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xBEB790", Offset = "0xBE9F90", VA = "0x180BEB790", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x27EC000", Offset = "0x27EA800", VA = "0x1827EC000", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c ZMCJLVSZUHD
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xA9E130", Offset = "0xA9C930", VA = "0x180A9E130", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xA9E410", Offset = "0xA9CC10", VA = "0x180A9E410", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a GCOIXTVYPNN
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6123F60", Offset = "0x6122760", VA = "0x186123F60")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b GCTPVAPVYYW
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x144AA00", Offset = "0x1449200", VA = "0x18144AA00")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c GCYWSHJTIKF
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5B46BA0", Offset = "0x5B453A0", VA = "0x185B46BA0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object WHXERYUCZBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x6124350", Offset = "0x6122B50", VA = "0x186124350", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x6142320", Offset = "0x6140B20", VA = "0x186142320", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6141040", Offset = "0x613F840", VA = "0x186141040", Slot = "9")]
		protected override bool CHNXLMNUERG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6142D60", Offset = "0x6141560", VA = "0x186142D60")]
		protected UTZIVPFWUYH([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6142AD0", Offset = "0x61412D0", VA = "0x186142AD0")]
		protected UTZIVPFWUYH(RHIZVYSCBOY a, GPQEQALGKDB b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, PBERQMVJJMT j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6123F60", Offset = "0x6122760", VA = "0x186123F60")]
		public a FIYFQHWQRMI()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x61414B0", Offset = "0x613FCB0", VA = "0x1861414B0")]
		public void FFRBMLQNKUI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x144AA00", Offset = "0x1449200", VA = "0x18144AA00")]
		public b FJOAICEITUJ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6141700", Offset = "0x613FF00", VA = "0x186141700")]
		public void FGGWEFYFNCJ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5B46BA0", Offset = "0x5B453A0", VA = "0x185B46BA0")]
		public c FJITKVKLKJA()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6141540", Offset = "0x613FD40", VA = "0x186141540")]
		public void FGBPGZEIDRA(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6141C60", Offset = "0x6140460", VA = "0x186141C60")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class UTJODUYESQG<a, b, c, d> : HJDNNOWCJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a GQIPDAIUOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b GQYJUUQMQNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c GQTCXNWPHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d GPSULGBCLXJ;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a ZLRVRIFFBKL
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xCA6850", Offset = "0xCA5050", VA = "0x180CA6850", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x61215F0", Offset = "0x611FDF0", VA = "0x1861215F0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b ZLXCOOZCKVU
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x122DA00", Offset = "0x122C200", VA = "0x18122DA00", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x122C1E0", Offset = "0x122A9E0", VA = "0x18122C1E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c ZMCJLVSZUHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x1240F40", Offset = "0x123F740", VA = "0x181240F40", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6121710", Offset = "0x611FF10", VA = "0x186121710", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d ZMHQJCMXDSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1A46FD0", Offset = "0x1A457D0", VA = "0x181A46FD0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x13A2C00", Offset = "0x13A1400", VA = "0x1813A2C00", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b GCTPVAPVYYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x6124280", Offset = "0x6122A80", VA = "0x186124280")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c GCYWSHJTIKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6124130", Offset = "0x6122930", VA = "0x186124130")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d GDEDPODQRVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x13770E0", Offset = "0x13758E0", VA = "0x1813770E0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object WHXERYUCZBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x6124350", Offset = "0x6122B50", VA = "0x186124350", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x61285B0", Offset = "0x6126DB0", VA = "0x1861285B0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x611FC10", Offset = "0x611E410", VA = "0x18611FC10", Slot = "9")]
		protected override bool CHNXLMNUERG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x61292A0", Offset = "0x6127AA0", VA = "0x1861292A0")]
		protected UTJODUYESQG([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x612A6F0", Offset = "0x6128EF0", VA = "0x18612A6F0")]
		protected UTJODUYESQG(RHIZVYSCBOY a, GPQEQALGKDB b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, PBERQMVJJMT k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6123F60", Offset = "0x6122760", VA = "0x186123F60")]
		public a FIYFQHWQRMI()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6121A20", Offset = "0x6120220", VA = "0x186121A20")]
		public void FFRBMLQNKUI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6124280", Offset = "0x6122A80", VA = "0x186124280")]
		public b FJOAICEITUJ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6123060", Offset = "0x6121860", VA = "0x186123060")]
		public void FGGWEFYFNCJ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x6124130", Offset = "0x6122930", VA = "0x186124130")]
		public c FJITKVKLKJA()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6122660", Offset = "0x6120E60", VA = "0x186122660")]
		public void FGBPGZEIDRA(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x13770E0", Offset = "0x13758E0", VA = "0x1813770E0")]
		public d FIIKYNOYPEH()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6123970", Offset = "0x6122170", VA = "0x186123970")]
		public void FGRJYTMAFZB(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6126DD0", Offset = "0x61255D0", VA = "0x186126DD0")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class UTOVBBSCCBP<a, b, c, d, e> : HJDNNOWCJGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a GQIPDAIUOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b GQYJUUQMQNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c GQTCXNWPHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d GPSULGBCLXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e GPNNNZHFCMA;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a ZLRVRIFFBKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAB1020", Offset = "0xAAF820", VA = "0x180AB1020", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAB0FF0", Offset = "0xAAF7F0", VA = "0x180AB0FF0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b ZLXCOOZCKVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xB33A50", Offset = "0xB32250", VA = "0x180B33A50", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x11B7B60", Offset = "0x11B6360", VA = "0x1811B7B60", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c ZMCJLVSZUHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xB391A0", Offset = "0xB379A0", VA = "0x180B391A0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xB3A2A0", Offset = "0xB38AA0", VA = "0x180B3A2A0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d ZMHQJCMXDSM
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xABA880", Offset = "0xAB9080", VA = "0x180ABA880", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xACA250", Offset = "0xAC8A50", VA = "0x180ACA250", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e ZMMXGJGUNDV
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xABA4E0", Offset = "0xAB8CE0", VA = "0x180ABA4E0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x6121430", Offset = "0x611FC30", VA = "0x186121430", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object WHXERYUCZBY
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x6124350", Offset = "0x6122B50", VA = "0x186124350", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x6132C00", Offset = "0x6131400", VA = "0x186132C00", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x612BD20", Offset = "0x612A520", VA = "0x18612BD20", Slot = "9")]
		protected override bool CHNXLMNUERG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6132E00", Offset = "0x6131600", VA = "0x186132E00")]
		protected UTOVBBSCCBP(RHIZVYSCBOY a, GPQEQALGKDB b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, PBERQMVJJMT l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6123F60", Offset = "0x6122760", VA = "0x186123F60")]
		public a FIYFQHWQRMI()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x612D1A0", Offset = "0x612B9A0", VA = "0x18612D1A0")]
		public void FFRBMLQNKUI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x144AA00", Offset = "0x1449200", VA = "0x18144AA00")]
		public b FJOAICEITUJ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x612E150", Offset = "0x612C950", VA = "0x18612E150")]
		public void FGGWEFYFNCJ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5B46BA0", Offset = "0x5B453A0", VA = "0x185B46BA0")]
		public c FJITKVKLKJA()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x612D430", Offset = "0x612BC30", VA = "0x18612D430")]
		public void FGBPGZEIDRA(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x13770E0", Offset = "0x13758E0", VA = "0x1813770E0")]
		public d FIIKYNOYPEH()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x612EF50", Offset = "0x612D750", VA = "0x18612EF50")]
		public void FGRJYTMAFZB(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x612F1F0", Offset = "0x612D9F0", VA = "0x18612F1F0")]
		public e FIDEBGVBFSY()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x612E310", Offset = "0x612CB10", VA = "0x18612E310")]
		public void FGMDBMSCWNS(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x6130360", Offset = "0x612EB60", VA = "0x186130360")]
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
