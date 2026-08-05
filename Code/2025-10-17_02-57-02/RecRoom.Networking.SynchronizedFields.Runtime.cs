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
	public interface AMDZXHYHDEL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool ZKZFWPWZXCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool VXKSQLMMBFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		LRIABUPBGVB AJONJKJKGNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int HLSLFHRMXFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool MAROQPLENCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool MYOBGIBTMKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action PHTTCSZYAOC;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void DQXILTYEHIX();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void OPAUHAVGJZR(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RNKGVAMKKTL();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface JAOTGKZFMPK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string SSZWFWYFAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool TLFNZYRVMNH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface UWRTYBGJRVN<a> : JAOTGKZFMPK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a GUGNVNRXCTX
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LYYHXAKXFFW(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class AJQNENDZCLO<a> : UWRTYBGJRVN<a>, JAOTGKZFMPK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly AYVYPJUCGNL<a> FFPKQUXIJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly AYVYPJUCGNL<a> IQOXQKPSEHW;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string SSZWFWYFAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xFDE8C0", Offset = "0xFDCEC0", VA = "0x180FDE8C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KZXJAWGWRBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5609420", Offset = "0x5607A20", VA = "0x185609420", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a ZDLTBDTRPKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x5609910", Offset = "0x5607F10", VA = "0x185609910", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5605850", Offset = "0x5603E50", VA = "0x185605850", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a GUGNVNRXCTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5606630", Offset = "0x5604C30", VA = "0x185606630", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5608DE0", Offset = "0x56073E0", VA = "0x185608DE0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a HOYELULZOXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x5606630", Offset = "0x5604C30", VA = "0x185606630")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x5607900", Offset = "0x5605F00", VA = "0x185607900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool TLFNZYRVMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x5604810", Offset = "0x5602E10", VA = "0x185604810", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x5603E50", Offset = "0x5602450", VA = "0x185603E50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool SQPIDTYDNKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5606DF0", Offset = "0x56053F0", VA = "0x185606DF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x56087B0", Offset = "0x5606DB0", VA = "0x1856087B0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x560A870", Offset = "0x5608E70", VA = "0x18560A870")]
		public AJQNENDZCLO([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5606AE0", Offset = "0x56050E0", VA = "0x185606AE0")]
		private void CWQMRRUDZEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5608210", Offset = "0x5606810", VA = "0x185608210", Slot = "5")]
		public void LYYHXAKXFFW(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5607F80", Offset = "0x5606580", VA = "0x185607F80")]
		public void LYYHXAKXFFW(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5603F50", Offset = "0x5602550", VA = "0x185603F50", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class AKGHWHLRETP<a, b> : UWRTYBGJRVN<(a, b)>, JAOTGKZFMPK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly AYGDXPMKEFK<a, b> FFPKQUXIJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly AYGDXPMKEFK<a, b> IQOXQKPSEHW;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string SSZWFWYFAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xFDE8C0", Offset = "0xFDCEC0", VA = "0x180FDE8C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool KZXJAWGWRBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5615BF0", Offset = "0x56141F0", VA = "0x185615BF0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ICAADNZLFDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5611F20", Offset = "0x5610520", VA = "0x185611F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool IBUTGHFNVRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5611E40", Offset = "0x5610440", VA = "0x185611E40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) ZDLTBDTRPKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5616590", Offset = "0x5614B90", VA = "0x185616590", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5610C10", Offset = "0x560F210", VA = "0x185610C10", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) GUGNVNRXCTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5612690", Offset = "0x5610C90", VA = "0x185612690", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5615590", Offset = "0x5613B90", VA = "0x185615590", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) HOYELULZOXT
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5615950", Offset = "0x5613F50", VA = "0x185615950")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x56132F0", Offset = "0x56118F0", VA = "0x1856132F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a FEXEUDPMSFP
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5613680", Offset = "0x5611C80", VA = "0x185613680")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5614B20", Offset = "0x5613120", VA = "0x185614B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a PJUCYCSODEI
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5611A60", Offset = "0x5610060", VA = "0x185611A60")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a KYTNBDBNUUI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5611A60", Offset = "0x5610060", VA = "0x185611A60")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5614870", Offset = "0x5612E70", VA = "0x185614870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b FEHKCJHUPXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5613790", Offset = "0x5611D90", VA = "0x185613790")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x56152E0", Offset = "0x56138E0", VA = "0x1856152E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b PKJXPXAGFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5611A20", Offset = "0x5610020", VA = "0x185611A20")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b KZJHSXJFXCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5611A20", Offset = "0x5610020", VA = "0x185611A20")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5614110", Offset = "0x5612710", VA = "0x185614110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool TLFNZYRVMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5604810", Offset = "0x5602E10", VA = "0x185604810", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5603E50", Offset = "0x5602450", VA = "0x185603E50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5613CD0", Offset = "0x56122D0", VA = "0x185613CD0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5616EE0", Offset = "0x56154E0", VA = "0x185616EE0")]
		public AKGHWHLRETP([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5612DA0", Offset = "0x56113A0", VA = "0x185612DA0")]
		private void CWQMRRUDZEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5612220", Offset = "0x5610820", VA = "0x185612220")]
		public void BUEQTSRXOTH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x56133D0", Offset = "0x56119D0", VA = "0x1856133D0")]
		public void LYYHXAKXFFW(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5613C00", Offset = "0x5612200", VA = "0x185613C00", Slot = "5")]
		private void NBHSNEOUHSX((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5603F50", Offset = "0x5602550", VA = "0x185603F50", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class AKBAZARTVIG<a, b, c> : UWRTYBGJRVN<(a, b, c)>, JAOTGKZFMPK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly AYLKUWGHNQT<a, b, c> FFPKQUXIJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly AYLKUWGHNQT<a, b, c> IQOXQKPSEHW;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string SSZWFWYFAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xFDE8C0", Offset = "0xFDCEC0", VA = "0x180FDE8C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool KZXJAWGWRBR
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x560FC50", Offset = "0x560E250", VA = "0x18560FC50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ICAADNZLFDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x560C9E0", Offset = "0x560AFE0", VA = "0x18560C9E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool IBUTGHFNVRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x560C530", Offset = "0x560AB30", VA = "0x18560C530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool IBPMJALQMGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x560C7F0", Offset = "0x560ADF0", VA = "0x18560C7F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) ZDLTBDTRPKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x56100E0", Offset = "0x560E6E0", VA = "0x1856100E0", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x560BF50", Offset = "0x560A550", VA = "0x18560BF50", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) GUGNVNRXCTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x560CFF0", Offset = "0x560B5F0", VA = "0x18560CFF0", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x560F750", Offset = "0x560DD50", VA = "0x18560F750", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a FEXEUDPMSFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x560E120", Offset = "0x560C720", VA = "0x18560E120")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x560F0D0", Offset = "0x560D6D0", VA = "0x18560F0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a PJUCYCSODEI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x560C330", Offset = "0x560A930", VA = "0x18560C330")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a KYTNBDBNUUI
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x560C330", Offset = "0x560A930", VA = "0x18560C330")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x560ED20", Offset = "0x560D320", VA = "0x18560ED20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b FEHKCJHUPXO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x560E2E0", Offset = "0x560C8E0", VA = "0x18560E2E0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x560F6D0", Offset = "0x560DCD0", VA = "0x18560F6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b PKJXPXAGFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x560C220", Offset = "0x560A820", VA = "0x18560C220")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b KZJHSXJFXCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x560C220", Offset = "0x560A820", VA = "0x18560C220")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x560EAB0", Offset = "0x560D0B0", VA = "0x18560EAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c FEMQZQBRZIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x560E200", Offset = "0x560C800", VA = "0x18560E200")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x560F410", Offset = "0x560DA10", VA = "0x18560F410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c PKEQSQGIWBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x560C300", Offset = "0x560A900", VA = "0x18560C300")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c KZEAVQPINRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x560C300", Offset = "0x560A900", VA = "0x18560C300")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x560EBC0", Offset = "0x560D1C0", VA = "0x18560EBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool TLFNZYRVMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5604810", Offset = "0x5602E10", VA = "0x185604810", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x560E8A0", Offset = "0x560CEA0", VA = "0x18560E8A0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x56102A0", Offset = "0x560E8A0", VA = "0x1856102A0")]
		public AKBAZARTVIG([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x560D6D0", Offset = "0x560BCD0", VA = "0x18560D6D0")]
		private void CWQMRRUDZEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x560CE60", Offset = "0x560B460", VA = "0x18560CE60")]
		public void BUEQTSRXOTH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x560D9D0", Offset = "0x560BFD0", VA = "0x18560D9D0")]
		public void FWSPGRZOCXQ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x560E690", Offset = "0x560CC90", VA = "0x18560E690")]
		public void PYPGBOLMOFN(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x560E0A0", Offset = "0x560C6A0", VA = "0x18560E0A0")]
		public void LYYHXAKXFFW(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x560DDC0", Offset = "0x560C3C0", VA = "0x18560DDC0", Slot = "5")]
		private void LNFBQRIGOBO((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5603F50", Offset = "0x5602550", VA = "0x185603F50", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class AJASMSWHADN<a, b, c, d> : UWRTYBGJRVN<(a, b, c, d)>, JAOTGKZFMPK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly AXVQDBYPLIS<a, b, c, d> FFPKQUXIJAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly AXVQDBYPLIS<a, b, c, d> IQOXQKPSEHW;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string SSZWFWYFAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xFDE8C0", Offset = "0xFDCEC0", VA = "0x180FDE8C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) GUGNVNRXCTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5603600", Offset = "0x5601C00", VA = "0x185603600", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5604830", Offset = "0x5602E30", VA = "0x185604830", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b PKJXPXAGFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x5603F90", Offset = "0x5602590", VA = "0x185603F90")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c PKEQSQGIWBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x5604070", Offset = "0x5602670", VA = "0x185604070")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d PJEIGIKWAWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x5603E70", Offset = "0x5602470", VA = "0x185603E70")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool TLFNZYRVMNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x5604810", Offset = "0x5602E10", VA = "0x185604810", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x5603E50", Offset = "0x5602450", VA = "0x185603E50", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5604C30", Offset = "0x5603230", VA = "0x185604C30")]
		public AJASMSWHADN([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5603AE0", Offset = "0x56020E0", VA = "0x185603AE0")]
		private void CWQMRRUDZEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5603510", Offset = "0x5601B10", VA = "0x185603510")]
		public void BUEQTSRXOTH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5604410", Offset = "0x5602A10", VA = "0x185604410")]
		public void LYYHXAKXFFW(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5604460", Offset = "0x5602A60", VA = "0x185604460", Slot = "5")]
		private void TBGBFVVQCHY((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5603F50", Offset = "0x5602550", VA = "0x185603F50", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class UNIJNAIQDRD
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8650A20", Offset = "0x864F020", VA = "0x188650A20")]
		public static string SPEYCVNXEQI(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xB02440", Offset = "0xB00A40", VA = "0x180B02440")]
		public static NetworkSetterPermissionMode QBNGNSDVATH(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AYVYPJUCGNL<a> : HBFTAEYASSI<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x575E1F0", Offset = "0x575C7F0", VA = "0x18575E1F0")]
		public AYVYPJUCGNL([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x57610A0", Offset = "0x575F6A0", VA = "0x1857610A0")]
		public AYVYPJUCGNL(UXWMPOTYTVA a, LRIABUPBGVB b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] OYVCUVSYCVW g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x57620D0", Offset = "0x57606D0", VA = "0x1857620D0")]
		public AYVYPJUCGNL(UXWMPOTYTVA a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] OYVCUVSYCVW f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x57611A0", Offset = "0x575F7A0", VA = "0x1857611A0")]
		public AYVYPJUCGNL(UXWMPOTYTVA a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] OYVCUVSYCVW g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class AYGDXPMKEFK<a, b> : HBVNRZFSVAJ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x575B7F0", Offset = "0x5759DF0", VA = "0x18575B7F0")]
		public AYGDXPMKEFK([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x57587D0", Offset = "0x5756DD0", VA = "0x1857587D0")]
		public AYGDXPMKEFK(UXWMPOTYTVA a, LRIABUPBGVB b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] OYVCUVSYCVW h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5759010", Offset = "0x5757610", VA = "0x185759010")]
		public AYGDXPMKEFK(UXWMPOTYTVA a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] OYVCUVSYCVW g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5758F20", Offset = "0x5757520", VA = "0x185758F20")]
		public AYGDXPMKEFK(UXWMPOTYTVA a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] OYVCUVSYCVW h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AYLKUWGHNQT<a, b, c> : HBQGUSLVLPA<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x575CD70", Offset = "0x575B370", VA = "0x18575CD70")]
		public AYLKUWGHNQT([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x575CD90", Offset = "0x575B390", VA = "0x18575CD90")]
		public AYLKUWGHNQT(UXWMPOTYTVA a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] OYVCUVSYCVW h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AXVQDBYPLIS<a, b, c, d> : HAPYIKQIQKH<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5755BE0", Offset = "0x57541E0", VA = "0x185755BE0")]
		public AXVQDBYPLIS([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5756DE0", Offset = "0x57553E0", VA = "0x185756DE0")]
		public AXVQDBYPLIS(UXWMPOTYTVA a, LRIABUPBGVB b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] OYVCUVSYCVW j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5756CB0", Offset = "0x57552B0", VA = "0x185756CB0")]
		public AXVQDBYPLIS(UXWMPOTYTVA a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] OYVCUVSYCVW i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class AYAXAISMUUB<a, b, c, d, e> : HAKRLDWLGYY<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5757040", Offset = "0x5755640", VA = "0x185757040")]
		public AYAXAISMUUB(UXWMPOTYTVA a, LRIABUPBGVB b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] OYVCUVSYCVW k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5757EC0", Offset = "0x57564C0", VA = "0x185757EC0")]
		public AYAXAISMUUB(UXWMPOTYTVA a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] OYVCUVSYCVW j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class JFQACFCYYMO<a> : HBFTAEYASSI<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x52AC4A0", Offset = "0x52AAAA0", VA = "0x1852AC4A0")]
		public JFQACFCYYMO(LRIABUPBGVB a, string b, a c, [Optional] Action d, [Optional] OYVCUVSYCVW e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class JFKTEYJBPBF<a, b> : HBVNRZFSVAJ<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x52ABD90", Offset = "0x52AA390", VA = "0x1852ABD90")]
		public JFKTEYJBPBF(LRIABUPBGVB a, string b, a c, b d, [Optional] Action e, [Optional] OYVCUVSYCVW f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface MVRFEQGHMZM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AYVYPJUCGNL<a> JSGSJAGTTCG<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CGKMCPNBAID : MVRFEQGHMZM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly OYVCUVSYCVW BRDKVTELWBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly UXWMPOTYTVA KLMAUBTUXBV;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xAAC450", Offset = "0xAAAA50", VA = "0x180AAC450")]
		public CGKMCPNBAID(OYVCUVSYCVW a, UXWMPOTYTVA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x36C4C30", Offset = "0x36C3230", VA = "0x1836C4C30", Slot = "4")]
		public AYVYPJUCGNL<a> JSGSJAGTTCG<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface YJHBJOYDIOX : UXWMPOTYTVA
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId NCFUGXARWYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface UXWMPOTYTVA
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool TLRCQRCHQIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool QHXYVHQMKTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string ITNDOYAGFFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool DQHFTMJOHVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(XACNGKUEJNS handler);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(XACNGKUEJNS handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class UVPSMBUCCIU
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8650A60", Offset = "0x864F060", VA = "0x188650A60")]
		public static bool SYWSYJTRENF(this UXWMPOTYTVA a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface OYVCUVSYCVW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		LRIABUPBGVB MWFWHJISHRM
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool SQPIDTYDNKF
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool IDWXSXREGXS
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Initialize();

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "4")]
		object UVMYVGIKULG(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object RHDURXAKXKG(LRIABUPBGVB a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void FTZQEXFGVXO(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void HJAOHJTEXXA(LRIABUPBGVB a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void CBCJQRHZYGH<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void ANNVTVTXHGB([CanBeNull] LRIABUPBGVB photonPlayer, string a, HCJBDWJWEHM b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void ZFALOPVEUCA([CanBeNull] LRIABUPBGVB photonPlayer, string a, HCJBDWJWEHM b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b PAOWUNCUYEY<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object VGPNUSLKKVD<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void QTFVZVRSZLC();

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ZSCNRIKXRTI();

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void TLVHSDZMBLP(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public LRIABUPBGVB player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public UXWMPOTYTVA context;

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
		public OYVCUVSYCVW networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8650810", Offset = "0x864EE10", VA = "0x188650810")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8650890", Offset = "0x864EE90", VA = "0x188650890")]
		public SyncData(UXWMPOTYTVA context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] OYVCUVSYCVW networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x86507C0", Offset = "0x864EDC0", VA = "0x1886507C0")]
		public static SyncData From(UXWMPOTYTVA context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] OYVCUVSYCVW networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class PWUNUPDISKR
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3B2E250", Offset = "0x3B2C850", VA = "0x183B2E250")]
		public static AYVYPJUCGNL<a> HCJBDWJWEHM<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3B2D840", Offset = "0x3B2BE40", VA = "0x183B2D840")]
		public static AYGDXPMKEFK<b, c> HCJBDWJWEHM<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3B2D8E0", Offset = "0x3B2BEE0", VA = "0x183B2D8E0")]
		public static AYLKUWGHNQT<d, e, f> HCJBDWJWEHM<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3B2DD00", Offset = "0x3B2C300", VA = "0x183B2DD00")]
		public static AXVQDBYPLIS<g, h, i, j> HCJBDWJWEHM<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3B2C850", Offset = "0x3B2AE50", VA = "0x183B2C850")]
		public static AJQNENDZCLO<k> BDAUWYIAULJ<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3B2C700", Offset = "0x3B2AD00", VA = "0x183B2C700")]
		public static AKGHWHLRETP<l, m> BDAUWYIAULJ<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3B2C7A0", Offset = "0x3B2ADA0", VA = "0x183B2C7A0")]
		public static AKBAZARTVIG<n, o, p> BDAUWYIAULJ<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3B2D250", Offset = "0x3B2B850", VA = "0x183B2D250")]
		public static AJASMSWHADN<q, r, s, t> BDAUWYIAULJ<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class HCJBDWJWEHM : XACNGKUEJNS, IDisposable
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
		private static Stack<OYVCUVSYCVW> HARHLIDVHLO;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool VPXVBRHNOUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly LRIABUPBGVB ASTARSJXVOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly UXWMPOTYTVA KLMAUBTUXBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string PYMENAUFSNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode KITQLUXTOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action CXPPTSBKHFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected OYVCUVSYCVW RGGQDBBPEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags PHVDAZUACKP;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static OYVCUVSYCVW GVQFXPQMDPW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8650390", Offset = "0x864E990", VA = "0x188650390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool PCWJWUKNTZO
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x864EF10", Offset = "0x864D510", VA = "0x18864EF10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x864FA10", Offset = "0x864E010", VA = "0x18864FA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool QOYFJSSVSUL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x864EF20", Offset = "0x864D520", VA = "0x18864EF20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x864F220", Offset = "0x864D820", VA = "0x18864F220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool KTOPNNWHNPU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x86504B0", Offset = "0x864EAB0", VA = "0x1886504B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x864EEF0", Offset = "0x864D4F0", VA = "0x18864EEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool TLFNZYRVMNH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x86502C0", Offset = "0x864E8C0", VA = "0x1886502C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x864EF30", Offset = "0x864D530", VA = "0x18864EF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object VYANXXDWHSL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAB1500", Offset = "0xAAFB00", VA = "0x180AB1500", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool SPROJKRPMAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x86504C0", Offset = "0x864EAC0", VA = "0x1886504C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int VLICHKSCGOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xF33300", Offset = "0xF31900", VA = "0x180F33300")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x1ACCEF0", Offset = "0x1ACB4F0", VA = "0x181ACCEF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string SSZWFWYFAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool SQPIDTYDNKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x864F1D0", Offset = "0x864D7D0", VA = "0x18864F1D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x86502D0", Offset = "0x864E8D0", VA = "0x1886502D0")]
		public static void VFLWBPKOBRT(OYVCUVSYCVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool RNRFTTRIHIH();

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x86505A0", Offset = "0x864EBA0", VA = "0x1886505A0")]
		protected HCJBDWJWEHM(LRIABUPBGVB a, UXWMPOTYTVA b, string c, NetworkSetterPermissionMode d, Action e, OYVCUVSYCVW f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x864F170", Offset = "0x864D770", VA = "0x18864F170", Slot = "1")]
		~HCJBDWJWEHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x864EFF0", Offset = "0x864D5F0", VA = "0x18864EFF0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8650130", Offset = "0x864E730", VA = "0x188650130")]
		private void TYQVMTHVUUV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x864F4F0", Offset = "0x864DAF0", VA = "0x18864F4F0")]
		private object JXGJYHDXAXV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x864F320", Offset = "0x864D920", VA = "0x18864F320")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x86500F0", Offset = "0x864E6F0", VA = "0x1886500F0")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x864FD50", Offset = "0x864E350", VA = "0x18864FD50")]
		protected void RHECNJTGNTG(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8650240", Offset = "0x864E840", VA = "0x188650240")]
		internal void VANXZYEHBXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x864FBE0", Offset = "0x864E1E0", VA = "0x18864FBE0")]
		private void OAZTHALVISY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x864FB70", Offset = "0x864E170", VA = "0x18864FB70")]
		private void NIKNBVIGHNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x86501D0", Offset = "0x864E7D0", VA = "0x1886501D0", Slot = "4")]
		private void VAFUIBRHODV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x864FBD0", Offset = "0x864E1D0", VA = "0x18864FBD0", Slot = "5")]
		private void NITLDEWSTWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x864FA30", Offset = "0x864E030", VA = "0x18864FA30")]
		public bool MKSQQBXCOQY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x864F850", Offset = "0x864DE50", VA = "0x18864F850")]
		public bool MIXAEMJIBDA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x864FFA0", Offset = "0x864E5A0", VA = "0x18864FFA0")]
		private bool SDMNWXLKTBH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8650400", Offset = "0x864EA00", VA = "0x188650400")]
		internal void YOWHVAUXODA(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x864FC40", Offset = "0x864E240", VA = "0x18864FC40")]
		private void OEFKBEQOQUS(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x864F160", Offset = "0x864D760", VA = "0x18864F160")]
		private bool EFHRAOMOAWC(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8650370", Offset = "0x864E970", VA = "0x188650370")]
		private void YDJENYLGMIK(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x864F660", Offset = "0x864DC60", VA = "0x18864F660")]
		public static string KXBSPCXCTQU(LRIABUPBGVB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x864F240", Offset = "0x864D840", VA = "0x18864F240")]
		public static string HJBQTPGBEXS(UXWMPOTYTVA a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x864F6F0", Offset = "0x864DCF0", VA = "0x18864F6F0")]
		public static bool LVXRNPHMZHQ(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class WSLICTGMJGA : OYVCUVSYCVW, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> EMXUOLMVRAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> CYGAXWOLZPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> DSWRUZOKFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> JIXRVLAFOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool ADKFKWBUFYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> YFQZCXMMRAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<LRIABUPBGVB, Dictionary<string, object>> OMOWRMSNSNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> GMLZMJJXSLU;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> JDOTWZXTVTI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int ZCXIOIWDZAD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract LRIABUPBGVB MWFWHJISHRM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool SQPIDTYDNKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool IDWXSXREGXS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool WULUGZOJKHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool SHXMMQDRCHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xAFD4E0", Offset = "0xAFBAE0", VA = "0x180AFD4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3EC5C80", Offset = "0x3EC4280", VA = "0x183EC5C80", Slot = "12")]
		public void CBCJQRHZYGH<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8651350", Offset = "0x864F950", VA = "0x188651350", Slot = "11")]
		public void HJAOHJTEXXA(LRIABUPBGVB a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8652300", Offset = "0x8650900", VA = "0x188652300", Slot = "9")]
		public object RHDURXAKXKG(LRIABUPBGVB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x86511A0", Offset = "0x864F7A0", VA = "0x1886511A0", Slot = "10")]
		public void FTZQEXFGVXO(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x86527A0", Offset = "0x8650DA0", VA = "0x1886527A0", Slot = "8")]
		public object UVMYVGIKULG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8650CD0", Offset = "0x864F2D0", VA = "0x188650CD0", Slot = "13")]
		public void ANNVTVTXHGB(LRIABUPBGVB a, string b, HCJBDWJWEHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8652D10", Offset = "0x8651310", VA = "0x188652D10", Slot = "14")]
		public void ZFALOPVEUCA(LRIABUPBGVB a, string b, HCJBDWJWEHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8652CC0", Offset = "0x86512C0", VA = "0x188652CC0")]
		private void XQXWOSLAPXW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8651800", Offset = "0x864FE00", VA = "0x188651800")]
		private void JYCVSIPHTIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x86523F0", Offset = "0x86509F0", VA = "0x1886523F0")]
		private void SZHISMHBQKR(LRIABUPBGVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x86520E0", Offset = "0x86506E0", VA = "0x1886520E0")]
		protected void QJCYVFBLNMF(LRIABUPBGVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8651DD0", Offset = "0x86503D0", VA = "0x188651DD0")]
		protected void PFZVUEZBKRR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8652840", Offset = "0x8650E40", VA = "0x188652840")]
		protected void UVUUKNDMAPB(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x86518E0", Offset = "0x864FEE0", VA = "0x1886518E0")]
		protected void LINLLRWVZYV(LRIABUPBGVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x86512C0", Offset = "0x864F8C0", VA = "0x1886512C0")]
		protected void HHMZJRRBJRL(LRIABUPBGVB a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8652850", Offset = "0x8650E50", VA = "0x188652850")]
		private void WYATHIJHGIE(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8651950", Offset = "0x864FF50", VA = "0x188651950")]
		private static void ORSQHXKXIEI(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8651EC0", Offset = "0x86504C0", VA = "0x188651EC0")]
		private static void QDQSTAGGXDF(Dictionary<string, object> a, string b, HCJBDWJWEHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8650E70", Offset = "0x864F470", VA = "0x188650E70")]
		private static void CADBGTSCGFQ(Dictionary<string, object> a, string b, HCJBDWJWEHM c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8652200", Offset = "0x8650800", VA = "0x188652200", Slot = "17")]
		public void QTFVZVRSZLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract void NKEGHBVRFUZ(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8652FC0", Offset = "0x86515C0", VA = "0x188652FC0", Slot = "18")]
		public void ZSCNRIKXRTI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "28")]
		protected abstract void SEWCYFORSAP(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8650AB0", Offset = "0x864F0B0", VA = "0x188650AB0")]
		private void AKDKDKYOHJA(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8651B50", Offset = "0x8650150", VA = "0x188651B50")]
		private void PFISYWXGPFR(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8650DE0", Offset = "0x864F3E0", VA = "0x188650DE0")]
		public void BJHONPFIJPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x86526D0", Offset = "0x8650CD0", VA = "0x1886526D0")]
		public void TPNMCLFIIFG(LRIABUPBGVB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x86514A0", Offset = "0x864FAA0", VA = "0x1886514A0")]
		public void JCMMLDKWDAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract HashSet<int> WEIIKRTZDSV(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8652450", Offset = "0x8650A50", VA = "0x188652450", Slot = "19")]
		public void TLVHSDZMBLP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8651850", Offset = "0x864FE50", VA = "0x188651850")]
		protected string KXBSPCXCTQU(LRIABUPBGVB a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		public abstract object VGPNUSLKKVD<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		public abstract c PAOWUNCUYEY<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "32")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8651040", Offset = "0x864F640", VA = "0x188651040", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "33")]
		protected virtual void TSMCTNTROSI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x86530A0", Offset = "0x86516A0", VA = "0x1886530A0")]
		protected WSLICTGMJGA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class HBFTAEYASSI<a> : HCJBDWJWEHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a EGLBIRZIYQR;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a BXPWCKFPNLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x1082D10", Offset = "0x1081310", VA = "0x181082D10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x1082D00", Offset = "0x1081300", VA = "0x181082D00", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object VYANXXDWHSL
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x50BF880", Offset = "0x50BDE80", VA = "0x1850BF880", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x50D85E0", Offset = "0x50D6BE0", VA = "0x1850D85E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x50D95F0", Offset = "0x50D7BF0", VA = "0x1850D95F0", Slot = "9")]
		protected override bool RNRFTTRIHIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x50E13A0", Offset = "0x50DF9A0", VA = "0x1850E13A0")]
		protected HBFTAEYASSI([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x50DEA30", Offset = "0x50DD030", VA = "0x1850DEA30")]
		protected HBFTAEYASSI(LRIABUPBGVB a, UXWMPOTYTVA b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, OYVCUVSYCVW h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x50CCA10", Offset = "0x50CB010", VA = "0x1850CCA10")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x50DD0E0", Offset = "0x50DB6E0", VA = "0x1850DD0E0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x50DACE0", Offset = "0x50D92E0", VA = "0x1850DACE0")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class HBVNRZFSVAJ<a, b> : HCJBDWJWEHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a EGLBIRZIYQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b EFVGQXRQWIQ;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a BXPWCKFPNLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x112FD00", Offset = "0x112E300", VA = "0x18112FD00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x131BBF0", Offset = "0x131A1F0", VA = "0x18131BBF0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b BXKPFDLSDZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x31F0840", Offset = "0x31EEE40", VA = "0x1831F0840", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x510D7B0", Offset = "0x510BDB0", VA = "0x18510D7B0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b WTYGFZNGGSD
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x1758C70", Offset = "0x1757270", VA = "0x181758C70")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object VYANXXDWHSL
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x50BF880", Offset = "0x50BDE80", VA = "0x1850BF880", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x510D370", Offset = "0x510B970", VA = "0x18510D370", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x510F1B0", Offset = "0x510D7B0", VA = "0x18510F1B0", Slot = "9")]
		protected override bool RNRFTTRIHIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5115740", Offset = "0x5113D40", VA = "0x185115740")]
		protected HBVNRZFSVAJ([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5115CC0", Offset = "0x51142C0", VA = "0x185115CC0")]
		protected HBVNRZFSVAJ(LRIABUPBGVB a, UXWMPOTYTVA b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, OYVCUVSYCVW i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x50BD640", Offset = "0x50BBC40", VA = "0x1850BD640")]
		public a LXRVXXOCWXB()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5113560", Offset = "0x5111B60", VA = "0x185113560")]
		public void ZQGCTYDEOJJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x1758C70", Offset = "0x1757270", VA = "0x181758C70")]
		public b LXXCVEIAGIK()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5114530", Offset = "0x5112B30", VA = "0x185114530")]
		public void ZQLJREXBXUS(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x510FA60", Offset = "0x510E060", VA = "0x18510FA60")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class HBQGUSLVLPA<a, b, c> : HCJBDWJWEHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a EGLBIRZIYQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b EFVGQXRQWIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c EGANOELOFTZ;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a BXPWCKFPNLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xAB7E90", Offset = "0xAB6490", VA = "0x180AB7E90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAB7860", Offset = "0xAB5E60", VA = "0x180AB7860", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b BXKPFDLSDZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xF33200", Offset = "0xF31800", VA = "0x180F33200", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x2A380A0", Offset = "0x2A366A0", VA = "0x182A380A0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c BXFIHWRUUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB090", VA = "0x180AACA90", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAACA60", Offset = "0xAAB060", VA = "0x180AACA60", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a WUDNDGHDQDM
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x50BD640", Offset = "0x50BBC40", VA = "0x1850BD640")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b WTYGFZNGGSD
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x1758C70", Offset = "0x1757270", VA = "0x181758C70")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c WTSZISTIXGU
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x50BD6A0", Offset = "0x50BBCA0", VA = "0x1850BD6A0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object VYANXXDWHSL
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x50BF880", Offset = "0x50BDE80", VA = "0x1850BF880", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x50E4CF0", Offset = "0x50E32F0", VA = "0x1850E4CF0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x50E5660", Offset = "0x50E3C60", VA = "0x1850E5660", Slot = "9")]
		protected override bool RNRFTTRIHIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x50E9740", Offset = "0x50E7D40", VA = "0x1850E9740")]
		protected HBQGUSLVLPA([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x50E87F0", Offset = "0x50E6DF0", VA = "0x1850E87F0")]
		protected HBQGUSLVLPA(LRIABUPBGVB a, UXWMPOTYTVA b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, OYVCUVSYCVW j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x50BD640", Offset = "0x50BBC40", VA = "0x1850BD640")]
		public a LXRVXXOCWXB()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x50E76E0", Offset = "0x50E5CE0", VA = "0x1850E76E0")]
		public void ZQGCTYDEOJJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x1758C70", Offset = "0x1757270", VA = "0x181758C70")]
		public b LXXCVEIAGIK()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x50E7B30", Offset = "0x50E6130", VA = "0x1850E7B30")]
		public void ZQLJREXBXUS(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x50BD6A0", Offset = "0x50BBCA0", VA = "0x1850BD6A0")]
		public c LYCJSLBXPTT()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x50E7E10", Offset = "0x50E6410", VA = "0x1850E7E10")]
		public void ZQQQOLQZHGB(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x50E6770", Offset = "0x50E4D70", VA = "0x1850E6770")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class HAPYIKQIQKH<a, b, c, d> : HCJBDWJWEHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a EGLBIRZIYQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b EFVGQXRQWIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c EGANOELOFTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d EHAWAMHBAYS;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a BXPWCKFPNLI
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xFD1590", Offset = "0xFCFB90", VA = "0x180FD1590", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x50C27A0", Offset = "0x50C0DA0", VA = "0x1850C27A0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b BXKPFDLSDZZ
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x2118BA0", Offset = "0x21171A0", VA = "0x182118BA0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x21143E0", Offset = "0x21129E0", VA = "0x1821143E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c BXFIHWRUUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x50D16C0", Offset = "0x50CFCC0", VA = "0x1850D16C0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x50CCC20", Offset = "0x50CB220", VA = "0x1850CCC20", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d BXABKPXXLDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x1D44B20", Offset = "0x1D43120", VA = "0x181D44B20", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x16A71B0", Offset = "0x16A57B0", VA = "0x1816A71B0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b WTYGFZNGGSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x50BD660", Offset = "0x50BBC60", VA = "0x1850BD660")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c WTSZISTIXGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x50CC920", Offset = "0x50CAF20", VA = "0x1850CC920")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d WTNSLLZLNVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x214AB70", Offset = "0x2149170", VA = "0x18214AB70")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object VYANXXDWHSL
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x50BF880", Offset = "0x50BDE80", VA = "0x1850BF880", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x50CBEA0", Offset = "0x50CA4A0", VA = "0x1850CBEA0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x50CDCE0", Offset = "0x50CC2E0", VA = "0x1850CDCE0", Slot = "9")]
		protected override bool RNRFTTRIHIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x50D63C0", Offset = "0x50D49C0", VA = "0x1850D63C0")]
		protected HAPYIKQIQKH([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x50D55A0", Offset = "0x50D3BA0", VA = "0x1850D55A0")]
		protected HAPYIKQIQKH(LRIABUPBGVB a, UXWMPOTYTVA b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, OYVCUVSYCVW k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x50BD640", Offset = "0x50BBC40", VA = "0x1850BD640")]
		public a LXRVXXOCWXB()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x50D2130", Offset = "0x50D0730", VA = "0x1850D2130")]
		public void ZQGCTYDEOJJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x50BD660", Offset = "0x50BBC60", VA = "0x1850BD660")]
		public b LXXCVEIAGIK()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x50D22E0", Offset = "0x50D08E0", VA = "0x1850D22E0")]
		public void ZQLJREXBXUS(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x50CC920", Offset = "0x50CAF20", VA = "0x1850CC920")]
		public c LYCJSLBXPTT()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x50D3180", Offset = "0x50D1780", VA = "0x1850D3180")]
		public void ZQQQOLQZHGB(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x214AB70", Offset = "0x2149170", VA = "0x18214AB70")]
		public d LWRNLPSQBSI()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x50D3940", Offset = "0x50D1F40", VA = "0x1850D3940")]
		public void ZQVXLSKWQRK(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x50D0670", Offset = "0x50CEC70", VA = "0x1850D0670")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class HAKRLDWLGYY<a, b, c, d, e> : HCJBDWJWEHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a EGLBIRZIYQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b EFVGQXRQWIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c EGANOELOFTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d EHAWAMHBAYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e EHGCXTAYKKB;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a BXPWCKFPNLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAB7E90", Offset = "0xAB6490", VA = "0x180AB7E90", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAB7860", Offset = "0xAB5E60", VA = "0x180AB7860", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b BXKPFDLSDZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xE57680", Offset = "0xE55C80", VA = "0x180E57680", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x14F94A0", Offset = "0x14F7AA0", VA = "0x1814F94A0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c BXFIHWRUUOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xE7D6C0", Offset = "0xE7BCC0", VA = "0x180E7D6C0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xE7DD80", Offset = "0xE7C380", VA = "0x180E7DD80", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d BXABKPXXLDH
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAC1710", Offset = "0xABFD10", VA = "0x180AC1710", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAD0F30", Offset = "0xACF530", VA = "0x180AD0F30", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e BWUUNJEABRY
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAC1360", Offset = "0xABF960", VA = "0x180AC1360", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x50BD6E0", Offset = "0x50BBCE0", VA = "0x1850BD6E0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object VYANXXDWHSL
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x50BF880", Offset = "0x50BDE80", VA = "0x1850BF880", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x50BD160", Offset = "0x50BB760", VA = "0x1850BD160", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x50BDF10", Offset = "0x50BC510", VA = "0x1850BDF10", Slot = "9")]
		protected override bool RNRFTTRIHIH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x50C1650", Offset = "0x50BFC50", VA = "0x1850C1650")]
		protected HAKRLDWLGYY(LRIABUPBGVB a, UXWMPOTYTVA b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, OYVCUVSYCVW l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x50BD640", Offset = "0x50BBC40", VA = "0x1850BD640")]
		public a LXRVXXOCWXB()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x50BF990", Offset = "0x50BDF90", VA = "0x1850BF990")]
		public void ZQGCTYDEOJJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x1758C70", Offset = "0x1757270", VA = "0x181758C70")]
		public b LXXCVEIAGIK()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x50BFE60", Offset = "0x50BE460", VA = "0x1850BFE60")]
		public void ZQLJREXBXUS(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x50BD6A0", Offset = "0x50BBCA0", VA = "0x1850BD6A0")]
		public c LYCJSLBXPTT()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x50C02F0", Offset = "0x50BE8F0", VA = "0x1850C02F0")]
		public void ZQQQOLQZHGB(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x214AB70", Offset = "0x2149170", VA = "0x18214AB70")]
		public d LWRNLPSQBSI()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x50C03D0", Offset = "0x50BE9D0", VA = "0x1850C03D0")]
		public void ZQVXLSKWQRK(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x50BD620", Offset = "0x50BBC20", VA = "0x1850BD620")]
		public e LWWUIWMNLDR()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x50C0960", Offset = "0x50BEF60", VA = "0x1850C0960")]
		public void ZRBEIZEUACT(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x50BEDA0", Offset = "0x50BD3A0", VA = "0x1850BEDA0")]
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
