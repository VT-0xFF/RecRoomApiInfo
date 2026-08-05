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
			[Cpp2IlInjected.Address(RVA = "0xCE2260", Offset = "0xCE0C60", VA = "0x180CE2260", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool VOZATQZAVYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5A293D0", Offset = "0x5A27DD0", VA = "0x185A293D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a KYEYSZMJEXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5A28E50", Offset = "0x5A27850", VA = "0x185A28E50", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5A26D90", Offset = "0x5A25790", VA = "0x185A26D90", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a IOPWWZHZOZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5A28FD0", Offset = "0x5A279D0", VA = "0x185A28FD0", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5A2ACF0", Offset = "0x5A296F0", VA = "0x185A2ACF0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a GJDRZFRFPRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5A28FD0", Offset = "0x5A279D0", VA = "0x185A28FD0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5A27DB0", Offset = "0x5A267B0", VA = "0x185A27DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool TJGRXWMJENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5A28DB0", Offset = "0x5A277B0", VA = "0x185A28DB0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5A2AA30", Offset = "0x5A29430", VA = "0x185A2AA30", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool WMZXLLLZHRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5A274D0", Offset = "0x5A25ED0", VA = "0x185A274D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5A2A4B0", Offset = "0x5A28EB0", VA = "0x185A2A4B0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x5A2B4F0", Offset = "0x5A29EF0", VA = "0x185A2B4F0")]
		public OFIFEKLRRXJ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5A27B80", Offset = "0x5A26580", VA = "0x185A27B80")]
		private void CRUNWAMTQRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5A29C50", Offset = "0x5A28650", VA = "0x185A29C50", Slot = "5")]
		public void MKNRKXXRTGH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5A29EB0", Offset = "0x5A288B0", VA = "0x185A29EB0")]
		public void MKNRKXXRTGH(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5A28D70", Offset = "0x5A27770", VA = "0x185A28D70", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE2260", Offset = "0xCE0C60", VA = "0x180CE2260", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool VOZATQZAVYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5A30200", Offset = "0x5A2EC00", VA = "0x185A30200", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool PIPXUIYBWUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5A31670", Offset = "0x5A30070", VA = "0x185A31670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool PIVERPRZGFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5A31910", Offset = "0x5A30310", VA = "0x185A31910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) KYEYSZMJEXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5A2EE40", Offset = "0x5A2D840", VA = "0x185A2EE40", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5A2DAD0", Offset = "0x5A2C4D0", VA = "0x185A2DAD0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) IOPWWZHZOZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5A30FE0", Offset = "0x5A2F9E0", VA = "0x185A30FE0", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5A33070", Offset = "0x5A31A70", VA = "0x185A33070", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) GJDRZFRFPRC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5A2F330", Offset = "0x5A2DD30", VA = "0x185A2F330")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5A2EAB0", Offset = "0x5A2D4B0", VA = "0x185A2EAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a FALGUUIQBVE
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5A2E190", Offset = "0x5A2CB90", VA = "0x185A2E190")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5A32470", Offset = "0x5A30E70", VA = "0x185A32470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a HJNGCLXMKNH
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5A2EC20", Offset = "0x5A2D620", VA = "0x185A2EC20")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5A331D0", Offset = "0x5A31BD0", VA = "0x185A331D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a HRVVMIMFXMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5A2EC20", Offset = "0x5A2D620", VA = "0x185A2EC20")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5A2FEF0", Offset = "0x5A2E8F0", VA = "0x185A2FEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b FAFZXNOSSJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5A2E350", Offset = "0x5A2CD50", VA = "0x185A2E350")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5A32B90", Offset = "0x5A31590", VA = "0x185A32B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b HIXLKRPUIFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5A2EB20", Offset = "0x5A2D520", VA = "0x185A2EB20")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b HSBCJPGDGYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5A2EB20", Offset = "0x5A2D520", VA = "0x185A2EB20")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5A2FA90", Offset = "0x5A2E490", VA = "0x185A2FA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool TJGRXWMJENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5A28DB0", Offset = "0x5A277B0", VA = "0x185A28DB0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x5A2AA30", Offset = "0x5A29430", VA = "0x185A2AA30", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5A32010", Offset = "0x5A30A10", VA = "0x185A32010", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5A342C0", Offset = "0x5A32CC0", VA = "0x185A342C0")]
		public OFNMBRFPBIS([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5A2E680", Offset = "0x5A2D080", VA = "0x185A2E680")]
		private void CRUNWAMTQRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5A33460", Offset = "0x5A31E60", VA = "0x185A33460")]
		public void YIGAQWLIGYE(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5A30650", Offset = "0x5A2F050", VA = "0x185A30650")]
		public void MKNRKXXRTGH(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5A309F0", Offset = "0x5A2F3F0", VA = "0x185A309F0", Slot = "5")]
		private void NWBMALWNHDK((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5A28D70", Offset = "0x5A27770", VA = "0x185A28D70", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE2260", Offset = "0xCE0C60", VA = "0x180CE2260", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool VOZATQZAVYQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x5A36DF0", Offset = "0x5A357F0", VA = "0x185A36DF0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool PIPXUIYBWUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5A37C80", Offset = "0x5A36680", VA = "0x185A37C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool PIVERPRZGFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x5A38130", Offset = "0x5A36B30", VA = "0x185A38130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool PJALOWLWPQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5A38050", Offset = "0x5A36A50", VA = "0x185A38050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) KYEYSZMJEXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x5A365D0", Offset = "0x5A34FD0", VA = "0x185A365D0", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x5A34E90", Offset = "0x5A33890", VA = "0x185A34E90", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) IOPWWZHZOZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x5A37850", Offset = "0x5A36250", VA = "0x185A37850", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5A38CC0", Offset = "0x5A376C0", VA = "0x185A38CC0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a FALGUUIQBVE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x5A356A0", Offset = "0x5A340A0", VA = "0x185A356A0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5A38420", Offset = "0x5A36E20", VA = "0x185A38420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a HJNGCLXMKNH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5A361B0", Offset = "0x5A34BB0", VA = "0x185A361B0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a HRVVMIMFXMX
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5A361B0", Offset = "0x5A34BB0", VA = "0x185A361B0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5A36D50", Offset = "0x5A35750", VA = "0x185A36D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b FAFZXNOSSJV
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x5A356D0", Offset = "0x5A340D0", VA = "0x185A356D0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5A38700", Offset = "0x5A37100", VA = "0x185A38700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b HIXLKRPUIFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5A360D0", Offset = "0x5A34AD0", VA = "0x185A360D0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b HSBCJPGDGYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x5A360D0", Offset = "0x5A34AD0", VA = "0x185A360D0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x5A369B0", Offset = "0x5A353B0", VA = "0x185A369B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c FAATAGUVIYM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x5A357B0", Offset = "0x5A341B0", VA = "0x185A357B0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5A38BC0", Offset = "0x5A375C0", VA = "0x185A38BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c HJCSHYJRRQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5A360A0", Offset = "0x5A34AA0", VA = "0x185A360A0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c HSGJGWAAQJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x5A360A0", Offset = "0x5A34AA0", VA = "0x185A360A0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5A367B0", Offset = "0x5A351B0", VA = "0x185A367B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool TJGRXWMJENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5A28DB0", Offset = "0x5A277B0", VA = "0x185A28DB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5A38210", Offset = "0x5A36C10", VA = "0x185A38210", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5A39BD0", Offset = "0x5A385D0", VA = "0x185A39BD0")]
		public OFSSYXZMKUB([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5A35E10", Offset = "0x5A34810", VA = "0x185A35E10")]
		private void CRUNWAMTQRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5A39080", Offset = "0x5A37A80", VA = "0x185A39080")]
		public void YIGAQWLIGYE(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5A34950", Offset = "0x5A33350", VA = "0x185A34950")]
		public void AFVETUSRCMH(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5A371B0", Offset = "0x5A35BB0", VA = "0x185A371B0")]
		public void LOBTBCUSLNY(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5A374A0", Offset = "0x5A35EA0", VA = "0x185A374A0")]
		public void MKNRKXXRTGH(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5A35B40", Offset = "0x5A34540", VA = "0x185A35B40", Slot = "5")]
		private void COYQYGNOQZX((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5A28D70", Offset = "0x5A27770", VA = "0x185A28D70", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xCE2260", Offset = "0xCE0C60", VA = "0x180CE2260", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) IOPWWZHZOZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5AB1B60", Offset = "0x5AB0560", VA = "0x185AB1B60", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5AB2440", Offset = "0x5AB0E40", VA = "0x185AB2440", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b HIXLKRPUIFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5AB1810", Offset = "0x5AB0210", VA = "0x185AB1810")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c HJCSHYJRRQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5AB1730", Offset = "0x5AB0130", VA = "0x185AB1730")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d HKDAUGFEMVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5AB1650", Offset = "0x5AB0050", VA = "0x185AB1650")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool TJGRXWMJENK
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5A28DB0", Offset = "0x5A277B0", VA = "0x185A28DB0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5A2AA30", Offset = "0x5A29430", VA = "0x185A2AA30", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5AB3300", Offset = "0x5AB1D00", VA = "0x185AB3300")]
		public OFXZWETJUFK([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1200", Offset = "0x5AAFC00", VA = "0x185AB1200")]
		private void CRUNWAMTQRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5AB2B30", Offset = "0x5AB1530", VA = "0x185AB2B30")]
		public void YIGAQWLIGYE(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1840", Offset = "0x5AB0240", VA = "0x185AB1840")]
		public void MKNRKXXRTGH(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5AB2060", Offset = "0x5AB0A60", VA = "0x185AB2060", Slot = "5")]
		private void TTFLELGMUNX((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5A28D70", Offset = "0x5A27770", VA = "0x185A28D70", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x84807B0", Offset = "0x847F1B0", VA = "0x1884807B0")]
		public static string VDNBFPUDMTX(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xBA0AD0", Offset = "0xB9F4D0", VA = "0x180BA0AD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E28420", Offset = "0x3E26E20", VA = "0x183E28420")]
		public YWQGIVZNLUA([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3E26400", Offset = "0x3E24E00", VA = "0x183E26400")]
		public YWQGIVZNLUA(GPQEQALGKDB a, RHIZVYSCBOY b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] PBERQMVJJMT g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x3E258C0", Offset = "0x3E242C0", VA = "0x183E258C0")]
		public YWQGIVZNLUA(GPQEQALGKDB a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] PBERQMVJJMT f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3E26CE0", Offset = "0x3E256E0", VA = "0x183E26CE0")]
		public YWQGIVZNLUA(GPQEQALGKDB a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] PBERQMVJJMT g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class YXGBAQHFOCB<a, b> : UTUBYILZLMY<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x3E2D6B0", Offset = "0x3E2C0B0", VA = "0x183E2D6B0")]
		public YXGBAQHFOCB([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3E2F280", Offset = "0x3E2DC80", VA = "0x183E2F280")]
		public YXGBAQHFOCB(GPQEQALGKDB a, RHIZVYSCBOY b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] PBERQMVJJMT h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3E2D7E0", Offset = "0x3E2C1E0", VA = "0x183E2D7E0")]
		public YXGBAQHFOCB(GPQEQALGKDB a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] PBERQMVJJMT g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x3E2E5A0", Offset = "0x3E2CFA0", VA = "0x183E2E5A0")]
		public YXGBAQHFOCB(GPQEQALGKDB a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] PBERQMVJJMT h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class YXAUDJNIEQS<a, b, c> : UTZIVPFWUYH<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A580", Offset = "0x3E28F80", VA = "0x183E2A580")]
		public YXAUDJNIEQS([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2A9B0", Offset = "0x3E293B0", VA = "0x183E2A9B0")]
		public YXAUDJNIEQS(GPQEQALGKDB a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] PBERQMVJJMT h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class YWALRBRVJLZ<a, b, c, d> : UTJODUYESQG<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3E1FED0", Offset = "0x3E1E8D0", VA = "0x183E1FED0")]
		public YWALRBRVJLZ([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3E20810", Offset = "0x3E1F210", VA = "0x183E20810")]
		public YWALRBRVJLZ(GPQEQALGKDB a, RHIZVYSCBOY b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] PBERQMVJJMT j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3E20940", Offset = "0x3E1F340", VA = "0x183E20940")]
		public YWALRBRVJLZ(GPQEQALGKDB a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] PBERQMVJJMT i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class YVVETUXYAAQ<a, b, c, d, e> : UTOVBBSCCBP<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3E1EBA0", Offset = "0x3E1D5A0", VA = "0x183E1EBA0")]
		public YVVETUXYAAQ(GPQEQALGKDB a, RHIZVYSCBOY b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] PBERQMVJJMT k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x3E1EA90", Offset = "0x3E1D490", VA = "0x183E1EA90")]
		public YVVETUXYAAQ(GPQEQALGKDB a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] PBERQMVJJMT j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class WHKPPTKHNYD<a> : UUJWQCTRNUZ<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x670E750", Offset = "0x670D150", VA = "0x18670E750")]
		public WHKPPTKHNYD(RHIZVYSCBOY a, string b, a c, [Optional] Action d, [Optional] PBERQMVJJMT e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class WHPWNAEEXJM<a, b> : UTUBYILZLMY<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6711CD0", Offset = "0x67106D0", VA = "0x186711CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xABE110", Offset = "0xABCB10", VA = "0x180ABE110")]
		public LTCJOOLLZTE(PBERQMVJJMT a, GPQEQALGKDB b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3765C10", Offset = "0x3764610", VA = "0x183765C10", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x8480760", Offset = "0x847F160", VA = "0x188480760")]
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
		[Cpp2IlInjected.Address(RVA = "0x8480840", Offset = "0x847F240", VA = "0x188480840")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x84808C0", Offset = "0x847F2C0", VA = "0x1884808C0")]
		public SyncData(GPQEQALGKDB context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] PBERQMVJJMT networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x84807F0", Offset = "0x847F1F0", VA = "0x1884807F0")]
		public static SyncData From(GPQEQALGKDB context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] PBERQMVJJMT networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class LGJMDCCHALQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3761600", Offset = "0x3760000", VA = "0x183761600")]
		public static YWQGIVZNLUA<a> HJDNNOWCJGH<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3760BF0", Offset = "0x375F5F0", VA = "0x183760BF0")]
		public static YXGBAQHFOCB<b, c> HJDNNOWCJGH<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3760C90", Offset = "0x375F690", VA = "0x183760C90")]
		public static YXAUDJNIEQS<d, e, f> HJDNNOWCJGH<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x37610B0", Offset = "0x375FAB0", VA = "0x1837610B0")]
		public static YWALRBRVJLZ<g, h, i, j> HJDNNOWCJGH<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x375FC40", Offset = "0x375E640", VA = "0x18375FC40")]
		public static OFIFEKLRRXJ<k> FLRRSYARKVG<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x375FAF0", Offset = "0x375E4F0", VA = "0x18375FAF0")]
		public static OFNMBRFPBIS<l, m> FLRRSYARKVG<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x375FB90", Offset = "0x375E590", VA = "0x18375FB90")]
		public static OFSSYXZMKUB<n, o, p> FLRRSYARKVG<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3760600", Offset = "0x375F000", VA = "0x183760600")]
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
			[Cpp2IlInjected.Address(RVA = "0x847C800", Offset = "0x847B200", VA = "0x18847C800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool PXOKUXWRNAX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x847D600", Offset = "0x847C000", VA = "0x18847D600")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x847CBB0", Offset = "0x847B5B0", VA = "0x18847CBB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool DAGYHFJTCPY
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x847DC30", Offset = "0x847C630", VA = "0x18847DC30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x847DA70", Offset = "0x847C470", VA = "0x18847DA70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool XGTZNDNXQOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x847CFA0", Offset = "0x847B9A0", VA = "0x18847CFA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x847D370", Offset = "0x847BD70", VA = "0x18847D370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool TJGRXWMJENK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x847CB40", Offset = "0x847B540", VA = "0x18847CB40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x847D610", Offset = "0x847C010", VA = "0x18847D610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object WHXERYUCZBY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xABA1F0", Offset = "0xAB8BF0", VA = "0x180ABA1F0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xABA200", Offset = "0xAB8C00", VA = "0x180ABA200", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool TVDXYEOAKQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x847CD00", Offset = "0x847B700", VA = "0x18847CD00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int RRYRRKFLARA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xBF6EC0", Offset = "0xBF58C0", VA = "0x180BF6EC0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x17DDC70", Offset = "0x17DC670", VA = "0x1817DDC70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string XQUUXFGLFNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool WMZXLLLZHRY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x847C7B0", Offset = "0x847B1B0", VA = "0x18847C7B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x847D560", Offset = "0x847BF60", VA = "0x18847D560")]
		public static void QSRTXXIJIYC(PBERQMVJJMT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool CHNXLMNUERG();

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x847DD50", Offset = "0x847C750", VA = "0x18847DD50")]
		protected HJDNNOWCJGH(RHIZVYSCBOY a, GPQEQALGKDB b, string c, NetworkSetterPermissionMode d, Action e, PBERQMVJJMT f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x847CB50", Offset = "0x847B550", VA = "0x18847CB50", Slot = "1")]
		~HJDNNOWCJGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x847C9D0", Offset = "0x847B3D0", VA = "0x18847C9D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x847CC60", Offset = "0x847B660", VA = "0x18847CC60")]
		private void HWDOBJBWULA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x847D390", Offset = "0x847BD90", VA = "0x18847D390")]
		private object MHEUQCXUIEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x847D1A0", Offset = "0x847BBA0", VA = "0x18847D1A0")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x847D7B0", Offset = "0x847C1B0", VA = "0x18847D7B0")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x847CD50", Offset = "0x847B750", VA = "0x18847CD50")]
		protected void IJIBMMFNTNN(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x847DC40", Offset = "0x847C640", VA = "0x18847DC40")]
		internal void XHGUFPBYMNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x847D500", Offset = "0x847BF00", VA = "0x18847D500")]
		private void MKSHNTZONPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x847DA90", Offset = "0x847C490", VA = "0x18847DA90")]
		private void WBYKFCHSBBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x847CBD0", Offset = "0x847B5D0", VA = "0x18847CBD0", Slot = "4")]
		private void GIJNFXXSSBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x847CFB0", Offset = "0x847B9B0", VA = "0x18847CFB0", Slot = "5")]
		private void IUBLVUZCMOT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x847DAF0", Offset = "0x847C4F0", VA = "0x18847DAF0")]
		public bool WNVORQLIGJT()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x847D800", Offset = "0x847C200", VA = "0x18847D800")]
		public bool TLIRVKGTLVD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x847CFC0", Offset = "0x847B9C0", VA = "0x18847CFC0")]
		private bool IYOWZFYTQYK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x847D9C0", Offset = "0x847C3C0", VA = "0x18847D9C0")]
		internal void UNIPCADLWDB(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x847C6A0", Offset = "0x847B0A0", VA = "0x18847C6A0")]
		private void AVHKWPHBPKF(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x847D7F0", Offset = "0x847C1F0", VA = "0x18847D7F0")]
		private bool TBGDPSWFCMX(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x847CC40", Offset = "0x847B640", VA = "0x18847CC40")]
		private void GQXCTKJEARB(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x847D110", Offset = "0x847BB10", VA = "0x18847D110")]
		public static string IZUZKMMGVBX(RHIZVYSCBOY a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x847D6D0", Offset = "0x847C0D0", VA = "0x18847D6D0")]
		public static string SPNYGZJVJQF(GPQEQALGKDB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x847C870", Offset = "0x847B270", VA = "0x18847C870")]
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
			[Cpp2IlInjected.Address(RVA = "0xAD13F0", Offset = "0xACFDF0", VA = "0x180AD13F0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool MJQWBVQVIEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB199C0", Offset = "0xB183C0", VA = "0x180B199C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x38A3F40", Offset = "0x38A2940", VA = "0x1838A3F40", Slot = "12")]
		public void UYYHMGOZVMS<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x847FB80", Offset = "0x847E580", VA = "0x18847FB80", Slot = "11")]
		public void TCZWAZAFCNT(RHIZVYSCBOY a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x847F7E0", Offset = "0x847E1E0", VA = "0x18847F7E0", Slot = "9")]
		public object QXBTMAAZFVL(RHIZVYSCBOY a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x847F6C0", Offset = "0x847E0C0", VA = "0x18847F6C0", Slot = "10")]
		public void QIPAOSQPUXR(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x847FCD0", Offset = "0x847E6D0", VA = "0x18847FCD0", Slot = "8")]
		public object TJYYSNNSWZJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x847EF50", Offset = "0x847D950", VA = "0x18847EF50", Slot = "13")]
		public void OZIJOJYNJEY(RHIZVYSCBOY a, string b, HJDNNOWCJGH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x847F8E0", Offset = "0x847E2E0", VA = "0x18847F8E0", Slot = "14")]
		public void SPECJUFEIFL(RHIZVYSCBOY a, string b, HJDNNOWCJGH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x847DF80", Offset = "0x847C980", VA = "0x18847DF80")]
		private void ANYBBDRVLGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8480520", Offset = "0x847EF20", VA = "0x188480520")]
		private void ZSAQDPRAGOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x847E1C0", Offset = "0x847CBC0", VA = "0x18847E1C0")]
		private void EOUELQNDOUO(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x847E440", Offset = "0x847CE40", VA = "0x18847E440")]
		protected void IAFJLWFQGIE(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x847EB70", Offset = "0x847D570", VA = "0x18847EB70")]
		protected void KWXDPJSIFVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x847DF70", Offset = "0x847C970", VA = "0x18847DF70")]
		protected void AGBMQMOEKEI(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x847E7E0", Offset = "0x847D1E0", VA = "0x18847E7E0")]
		protected void ISZSYRWTEFW(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x847E130", Offset = "0x847CB30", VA = "0x18847E130")]
		protected void EJQHLRTPENM(RHIZVYSCBOY a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x847F160", Offset = "0x847DB60", VA = "0x18847F160")]
		private void PKHDDDPIGVL(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x847E8E0", Offset = "0x847D2E0", VA = "0x18847E8E0")]
		private static void IZSDHOKTRUN(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x847E220", Offset = "0x847CC20", VA = "0x18847E220")]
		private static void HFGXMEYOGNC(Dictionary<string, object> a, string b, HJDNNOWCJGH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x847FD70", Offset = "0x847E770", VA = "0x18847FD70")]
		private static void VTCHPVPKAJZ(Dictionary<string, object> a, string b, HJDNNOWCJGH c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x847F060", Offset = "0x847DA60", VA = "0x18847F060", Slot = "17")]
		public void PINJGLMJKDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract void KQQJHJBDOKS(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x847F5E0", Offset = "0x847DFE0", VA = "0x18847F5E0", Slot = "18")]
		public void PPCQRABDQQR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "28")]
		protected abstract void WBWUKYCKWJK(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x847EC60", Offset = "0x847D660", VA = "0x18847EC60")]
		private void LYRKRZIGMHF(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x847FF40", Offset = "0x847E940", VA = "0x18847FF40")]
		private void WTWOOPIMEHY(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x847E850", Offset = "0x847D250", VA = "0x18847E850")]
		public void IUCDCDPZBPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x847EE80", Offset = "0x847D880", VA = "0x18847EE80")]
		public void LYTZEOBJMFL(RHIZVYSCBOY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x84801C0", Offset = "0x847EBC0", VA = "0x1884801C0")]
		public void XOUZTRCSLPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract HashSet<int> YIEWQTNRFVE(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x847E560", Offset = "0x847CF60", VA = "0x18847E560", Slot = "19")]
		public void IOVIGYTAMDO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x847EAE0", Offset = "0x847D4E0", VA = "0x18847EAE0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "32")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x847DFD0", Offset = "0x847C9D0", VA = "0x18847DFD0", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "33")]
		protected virtual void NTIXYXUUUDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8480570", Offset = "0x847EF70", VA = "0x188480570")]
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
			[Cpp2IlInjected.Address(RVA = "0xD6AD90", Offset = "0xD69790", VA = "0x180D6AD90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD6AD80", Offset = "0xD69780", VA = "0x180D6AD80", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object WHXERYUCZBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x620B640", Offset = "0x620A040", VA = "0x18620B640", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6239DE0", Offset = "0x62387E0", VA = "0x186239DE0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x62347A0", Offset = "0x62331A0", VA = "0x1862347A0", Slot = "9")]
		protected override bool CHNXLMNUERG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x623CAA0", Offset = "0x623B4A0", VA = "0x18623CAA0")]
		protected UUJWQCTRNUZ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x623BD50", Offset = "0x623A750", VA = "0x18623BD50")]
		protected UUJWQCTRNUZ(RHIZVYSCBOY a, GPQEQALGKDB b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, PBERQMVJJMT h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x620B270", Offset = "0x6209C70", VA = "0x18620B270")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6238520", Offset = "0x6236F20", VA = "0x186238520")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6237BF0", Offset = "0x62365F0", VA = "0x186237BF0")]
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
			[Cpp2IlInjected.Address(RVA = "0xE42D60", Offset = "0xE41760", VA = "0x180E42D60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x1006B00", Offset = "0x1005500", VA = "0x181006B00", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b ZLXCOOZCKVU
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2FC4010", Offset = "0x2FC2A10", VA = "0x182FC4010", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x621E0E0", Offset = "0x621CAE0", VA = "0x18621E0E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b GCTPVAPVYYW
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1461E90", Offset = "0x1460890", VA = "0x181461E90")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object WHXERYUCZBY
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x620B640", Offset = "0x620A040", VA = "0x18620B640", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x62241E0", Offset = "0x6222BE0", VA = "0x1862241E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x621DEA0", Offset = "0x621C8A0", VA = "0x18621DEA0", Slot = "9")]
		protected override bool CHNXLMNUERG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6225F90", Offset = "0x6224990", VA = "0x186225F90")]
		protected UTUBYILZLMY([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6227AF0", Offset = "0x62264F0", VA = "0x186227AF0")]
		protected UTUBYILZLMY(RHIZVYSCBOY a, GPQEQALGKDB b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, PBERQMVJJMT i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x620B250", Offset = "0x6209C50", VA = "0x18620B250")]
		public a FIYFQHWQRMI()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x621E7C0", Offset = "0x621D1C0", VA = "0x18621E7C0")]
		public void FFRBMLQNKUI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1461E90", Offset = "0x1460890", VA = "0x181461E90")]
		public b FJOAICEITUJ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x621F2E0", Offset = "0x621DCE0", VA = "0x18621F2E0")]
		public void FGGWEFYFNCJ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6222B90", Offset = "0x6221590", VA = "0x186222B90")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC7EC0", Offset = "0xAC68C0", VA = "0x180AC7EC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAC7E90", Offset = "0xAC6890", VA = "0x180AC7E90", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b ZLXCOOZCKVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xC029C0", Offset = "0xC013C0", VA = "0x180C029C0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x27FE790", Offset = "0x27FD190", VA = "0x1827FE790", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c ZMCJLVSZUHD
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5130", Offset = "0xAB3B30", VA = "0x180AB5130", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xAB53F0", Offset = "0xAB3DF0", VA = "0x180AB53F0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a GCOIXTVYPNN
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x620B250", Offset = "0x6209C50", VA = "0x18620B250")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b GCTPVAPVYYW
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x1461E90", Offset = "0x1460890", VA = "0x181461E90")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c GCYWSHJTIKF
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5C10BB0", Offset = "0x5C0F5B0", VA = "0x185C10BB0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object WHXERYUCZBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x620B640", Offset = "0x620A040", VA = "0x18620B640", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x6229FF0", Offset = "0x62289F0", VA = "0x186229FF0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6228CC0", Offset = "0x62276C0", VA = "0x186228CC0", Slot = "9")]
		protected override bool CHNXLMNUERG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x622AA60", Offset = "0x6229460", VA = "0x18622AA60")]
		protected UTZIVPFWUYH([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x622A7D0", Offset = "0x62291D0", VA = "0x18622A7D0")]
		protected UTZIVPFWUYH(RHIZVYSCBOY a, GPQEQALGKDB b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, PBERQMVJJMT j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x620B250", Offset = "0x6209C50", VA = "0x18620B250")]
		public a FIYFQHWQRMI()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6229140", Offset = "0x6227B40", VA = "0x186229140")]
		public void FFRBMLQNKUI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1461E90", Offset = "0x1460890", VA = "0x181461E90")]
		public b FJOAICEITUJ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6229390", Offset = "0x6227D90", VA = "0x186229390")]
		public void FGGWEFYFNCJ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5C10BB0", Offset = "0x5C0F5B0", VA = "0x185C10BB0")]
		public c FJITKVKLKJA()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x62291D0", Offset = "0x6227BD0", VA = "0x1862291D0")]
		public void FGBPGZEIDRA(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6229910", Offset = "0x6228310", VA = "0x186229910")]
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
			[Cpp2IlInjected.Address(RVA = "0xCBDBB0", Offset = "0xCBC5B0", VA = "0x180CBDBB0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x6208820", Offset = "0x6207220", VA = "0x186208820", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b ZLXCOOZCKVU
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x1245CC0", Offset = "0x12446C0", VA = "0x181245CC0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x12444A0", Offset = "0x1242EA0", VA = "0x1812444A0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c ZMCJLVSZUHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x1259240", Offset = "0x1257C40", VA = "0x181259240", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6208940", Offset = "0x6207340", VA = "0x186208940", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d ZMHQJCMXDSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1A5E0C0", Offset = "0x1A5CAC0", VA = "0x181A5E0C0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x13BA190", Offset = "0x13B8B90", VA = "0x1813BA190", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b GCTPVAPVYYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x620B570", Offset = "0x6209F70", VA = "0x18620B570")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c GCYWSHJTIKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x620B420", Offset = "0x6209E20", VA = "0x18620B420")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d GDEDPODQRVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x138E8B0", Offset = "0x138D2B0", VA = "0x18138E8B0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object WHXERYUCZBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x620B640", Offset = "0x620A040", VA = "0x18620B640", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x620FA30", Offset = "0x620E430", VA = "0x18620FA30", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6206D60", Offset = "0x6205760", VA = "0x186206D60", Slot = "9")]
		protected override bool CHNXLMNUERG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6210760", Offset = "0x620F160", VA = "0x186210760")]
		protected UTJODUYESQG([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6211BD0", Offset = "0x62105D0", VA = "0x186211BD0")]
		protected UTJODUYESQG(RHIZVYSCBOY a, GPQEQALGKDB b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, PBERQMVJJMT k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x620B250", Offset = "0x6209C50", VA = "0x18620B250")]
		public a FIYFQHWQRMI()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6208C60", Offset = "0x6207660", VA = "0x186208C60")]
		public void FFRBMLQNKUI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x620B570", Offset = "0x6209F70", VA = "0x18620B570")]
		public b FJOAICEITUJ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x620A320", Offset = "0x6208D20", VA = "0x18620A320")]
		public void FGGWEFYFNCJ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x620B420", Offset = "0x6209E20", VA = "0x18620B420")]
		public c FJITKVKLKJA()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x62098F0", Offset = "0x62082F0", VA = "0x1862098F0")]
		public void FGBPGZEIDRA(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x138E8B0", Offset = "0x138D2B0", VA = "0x18138E8B0")]
		public d FIIKYNOYPEH()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x620AC40", Offset = "0x6209640", VA = "0x18620AC40")]
		public void FGRJYTMAFZB(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x620E1A0", Offset = "0x620CBA0", VA = "0x18620E1A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAC7EC0", Offset = "0xAC68C0", VA = "0x180AC7EC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAC7E90", Offset = "0xAC6890", VA = "0x180AC7E90", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b ZLXCOOZCKVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xB4AB80", Offset = "0xB49580", VA = "0x180B4AB80", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x11CFB40", Offset = "0x11CE540", VA = "0x1811CFB40", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c ZMCJLVSZUHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xB502F0", Offset = "0xB4ECF0", VA = "0x180B502F0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xB513F0", Offset = "0xB4FDF0", VA = "0x180B513F0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d ZMHQJCMXDSM
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAD17B0", Offset = "0xAD01B0", VA = "0x180AD17B0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAE11A0", Offset = "0xADFBA0", VA = "0x180AE11A0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e ZMMXGJGUNDV
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAD1400", Offset = "0xACFE00", VA = "0x180AD1400", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x6208660", Offset = "0x6207060", VA = "0x186208660", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object WHXERYUCZBY
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x620B640", Offset = "0x620A040", VA = "0x18620B640", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x621A3C0", Offset = "0x6218DC0", VA = "0x18621A3C0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6213250", Offset = "0x6211C50", VA = "0x186213250", Slot = "9")]
		protected override bool CHNXLMNUERG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x621A5D0", Offset = "0x6218FD0", VA = "0x18621A5D0")]
		protected UTOVBBSCCBP(RHIZVYSCBOY a, GPQEQALGKDB b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, PBERQMVJJMT l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x620B250", Offset = "0x6209C50", VA = "0x18620B250")]
		public a FIYFQHWQRMI()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6214750", Offset = "0x6213150", VA = "0x186214750")]
		public void FFRBMLQNKUI(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x1461E90", Offset = "0x1460890", VA = "0x181461E90")]
		public b FJOAICEITUJ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6215740", Offset = "0x6214140", VA = "0x186215740")]
		public void FGGWEFYFNCJ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5C10BB0", Offset = "0x5C0F5B0", VA = "0x185C10BB0")]
		public c FJITKVKLKJA()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x62149F0", Offset = "0x62133F0", VA = "0x1862149F0")]
		public void FGBPGZEIDRA(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x138E8B0", Offset = "0x138D2B0", VA = "0x18138E8B0")]
		public d FIIKYNOYPEH()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6216580", Offset = "0x6214F80", VA = "0x186216580")]
		public void FGRJYTMAFZB(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6216830", Offset = "0x6215230", VA = "0x186216830")]
		public e FIDEBGVBFSY()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6215900", Offset = "0x6214300", VA = "0x186215900")]
		public void FGMDBMSCWNS(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x62179F0", Offset = "0x62163F0", VA = "0x1862179F0")]
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
