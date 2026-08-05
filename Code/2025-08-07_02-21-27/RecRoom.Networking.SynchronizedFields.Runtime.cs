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
	public interface KMCHCCTYLVI : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool LFHBOWBYBCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool WRFSOGDVXPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		WJBKOLNRRJE UOVWQPKPSBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int IGYUZRIQXUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool TBNVXENLXGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool YODVBCYYAMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action GYXFADDAXWV;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void PUQQVZFAJRC();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void TBTPGNGLLRY(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void CLQPDQOOUYE();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface BHUTGROXLMH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string XHMXRIOSRQI
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool AVBIPVWPJGO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface UOKMEDOMJKQ<a> : BHUTGROXLMH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a VVSEOIJDEZW
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RZSKQZBIDBX(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class QXYYRTDLFHD<a> : UOKMEDOMJKQ<a>, BHUTGROXLMH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly XSMAWYYPPRM<a> HQMSXBBPBCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly XSMAWYYPPRM<a> YZDXWBQLJSL;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string XHMXRIOSRQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x1006B50", Offset = "0x1005750", VA = "0x181006B50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EHQVCVRJYZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x623E920", Offset = "0x623D520", VA = "0x18623E920", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a BECXGHTJFJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x623BA00", Offset = "0x623A600", VA = "0x18623BA00", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x623AED0", Offset = "0x6239AD0", VA = "0x18623AED0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a VVSEOIJDEZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x623D600", Offset = "0x623C200", VA = "0x18623D600", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x623C420", Offset = "0x623B020", VA = "0x18623C420", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a ZSNEVPBDVJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x623D600", Offset = "0x623C200", VA = "0x18623D600")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x623DE10", Offset = "0x623CA10", VA = "0x18623DE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool AVBIPVWPJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x62295B0", Offset = "0x62281B0", VA = "0x1862295B0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6229550", Offset = "0x6228150", VA = "0x186229550", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool FXGVBLNCOGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x623A9A0", Offset = "0x62395A0", VA = "0x18623A9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x623D010", Offset = "0x623BC10", VA = "0x18623D010", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x623F950", Offset = "0x623E550", VA = "0x18623F950")]
		public QXYYRTDLFHD([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x623BED0", Offset = "0x623AAD0", VA = "0x18623BED0")]
		private void PRYHSWHQGAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x623C920", Offset = "0x623B520", VA = "0x18623C920", Slot = "5")]
		public void RZSKQZBIDBX(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x623C7F0", Offset = "0x623B3F0", VA = "0x18623C7F0")]
		public void RZSKQZBIDBX(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6229570", Offset = "0x6228170", VA = "0x186229570", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class QXJDZYVTCZC<a, b> : UOKMEDOMJKQ<(a, b)>, BHUTGROXLMH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly XSGTZSESGGD<a, b> HQMSXBBPBCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly XSGTZSESGGD<a, b> YZDXWBQLJSL;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string XHMXRIOSRQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1006B50", Offset = "0x1005750", VA = "0x181006B50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool EHQVCVRJYZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6231CF0", Offset = "0x62308F0", VA = "0x186231CF0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool OKUOZHTUKUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x622CCA0", Offset = "0x622B8A0", VA = "0x18622CCA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool OKEUHNMCIMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x622C680", Offset = "0x622B280", VA = "0x18622C680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) BECXGHTJFJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x622E320", Offset = "0x622CF20", VA = "0x18622E320", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x622D020", Offset = "0x622BC20", VA = "0x18622D020", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) VVSEOIJDEZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6230720", Offset = "0x622F320", VA = "0x186230720", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x622F2B0", Offset = "0x622DEB0", VA = "0x18622F2B0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) ZSNEVPBDVJU
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x622FD30", Offset = "0x622E930", VA = "0x18622FD30")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x62317B0", Offset = "0x62303B0", VA = "0x1862317B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a KCTPZSYBTDO
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x622C2D0", Offset = "0x622AED0", VA = "0x18622C2D0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x62316C0", Offset = "0x62302C0", VA = "0x1862316C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a CKCQBVWVFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x622C3B0", Offset = "0x622AFB0", VA = "0x18622C3B0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a KIYWZJBBCVP
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x622C3B0", Offset = "0x622AFB0", VA = "0x18622C3B0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x622FF30", Offset = "0x622EB30", VA = "0x18622FF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b KDJKRNFTVLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x622C1E0", Offset = "0x622ADE0", VA = "0x18622C1E0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6230D60", Offset = "0x622F960", VA = "0x186230D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b CKHWZCQSPAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x622C570", Offset = "0x622B170", VA = "0x18622C570")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b KIJCHOTJANO
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x622C570", Offset = "0x622B170", VA = "0x18622C570")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6230410", Offset = "0x622F010", VA = "0x186230410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool AVBIPVWPJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x62295B0", Offset = "0x62281B0", VA = "0x1862295B0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6229550", Offset = "0x6228150", VA = "0x186229550", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x622F850", Offset = "0x622E450", VA = "0x18622F850", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6232DC0", Offset = "0x62319C0", VA = "0x186232DC0")]
		public QXJDZYVTCZC([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x622EAB0", Offset = "0x622D6B0", VA = "0x18622EAB0")]
		private void PRYHSWHQGAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x622DCF0", Offset = "0x622C8F0", VA = "0x18622DCF0")]
		public void OJKMIWFAUSS(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x622F3C0", Offset = "0x622DFC0", VA = "0x18622F3C0")]
		public void RZSKQZBIDBX(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x622EC80", Offset = "0x622D880", VA = "0x18622EC80", Slot = "5")]
		private void PSMRFIFLQJE((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6229570", Offset = "0x6228170", VA = "0x186229570", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class QXOKXFPQMKL<a, b, c> : UOKMEDOMJKQ<(a, b, c)>, BHUTGROXLMH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly XSBNCLKUWUU<a, b, c> HQMSXBBPBCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly XSBNCLKUWUU<a, b, c> YZDXWBQLJSL;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string XHMXRIOSRQI
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x1006B50", Offset = "0x1005750", VA = "0x181006B50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool EHQVCVRJYZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6238FA0", Offset = "0x6237BA0", VA = "0x186238FA0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool OKUOZHTUKUZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x62355B0", Offset = "0x62341B0", VA = "0x1862355B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool OKEUHNMCIMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x62354E0", Offset = "0x62340E0", VA = "0x1862354E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool OKKBEUFZRYH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6235340", Offset = "0x6233F40", VA = "0x186235340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) BECXGHTJFJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x62367D0", Offset = "0x62353D0", VA = "0x1862367D0", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6235970", Offset = "0x6234570", VA = "0x186235970", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) VVSEOIJDEZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x62381D0", Offset = "0x6236DD0", VA = "0x1862381D0", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6236C60", Offset = "0x6235860", VA = "0x186236C60", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a KCTPZSYBTDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6234B70", Offset = "0x6233770", VA = "0x186234B70")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6238890", Offset = "0x6237490", VA = "0x186238890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a CKCQBVWVFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6234C50", Offset = "0x6233850", VA = "0x186234C50")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a KIYWZJBBCVP
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6234C50", Offset = "0x6233850", VA = "0x186234C50")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x62377F0", Offset = "0x62363F0", VA = "0x1862377F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b KDJKRNFTVLP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x62349B0", Offset = "0x62335B0", VA = "0x1862349B0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6238460", Offset = "0x6237060", VA = "0x186238460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b CKHWZCQSPAS
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6234E10", Offset = "0x6233A10", VA = "0x186234E10")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b KIJCHOTJANO
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6234E10", Offset = "0x6233A10", VA = "0x186234E10")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6237CB0", Offset = "0x62368B0", VA = "0x186237CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c KDEDUGLWMAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6234B40", Offset = "0x6233740", VA = "0x186234B40")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6238790", Offset = "0x6237390", VA = "0x186238790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c CKNDWJKPYMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6234D30", Offset = "0x6233930", VA = "0x186234D30")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c KIOJEVNGJYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6234D30", Offset = "0x6233930", VA = "0x186234D30")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x62379F0", Offset = "0x62365F0", VA = "0x1862379F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool AVBIPVWPJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x62295B0", Offset = "0x62281B0", VA = "0x1862295B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6237750", Offset = "0x6236350", VA = "0x186237750", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6239870", Offset = "0x6238470", VA = "0x186239870")]
		public QXOKXFPQMKL([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6236AA0", Offset = "0x62356A0", VA = "0x186236AA0")]
		private void PRYHSWHQGAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6236270", Offset = "0x6234E70", VA = "0x186236270")]
		public void OJKMIWFAUSS(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6238B70", Offset = "0x6237770", VA = "0x186238B70")]
		public void XLFFVCGOKFT(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6236FE0", Offset = "0x6235BE0", VA = "0x186236FE0")]
		public void QXZZOGNUWOI(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x62375B0", Offset = "0x62361B0", VA = "0x1862375B0")]
		public void RZSKQZBIDBX(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6234EF0", Offset = "0x6233AF0", VA = "0x186234EF0", Slot = "5")]
		private void INTTUKELNFV((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6229570", Offset = "0x6228170", VA = "0x186229570", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class QWYQFLHYKCK<a, b, c, d> : UOKMEDOMJKQ<(a, b, c, d)>, BHUTGROXLMH, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly XRWGFEQXNJL<a, b, c, d> HQMSXBBPBCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly XRWGFEQXNJL<a, b, c, d> YZDXWBQLJSL;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string XHMXRIOSRQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x1006B50", Offset = "0x1005750", VA = "0x181006B50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) VVSEOIJDEZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x622A3B0", Offset = "0x6228FB0", VA = "0x18622A3B0", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6229CC0", Offset = "0x62288C0", VA = "0x186229CC0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b CKHWZCQSPAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x622AA40", Offset = "0x6229640", VA = "0x18622AA40")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c CKNDWJKPYMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x622A960", Offset = "0x6229560", VA = "0x18622A960")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d CKSKTQENHXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x622A880", Offset = "0x6229480", VA = "0x18622A880")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool AVBIPVWPJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x62295B0", Offset = "0x62281B0", VA = "0x1862295B0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6229550", Offset = "0x6228150", VA = "0x186229550", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x622AEC0", Offset = "0x6229AC0", VA = "0x18622AEC0")]
		public QWYQFLHYKCK([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6229960", Offset = "0x6228560", VA = "0x186229960")]
		private void PRYHSWHQGAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x62295D0", Offset = "0x62281D0", VA = "0x1862295D0")]
		public void OJKMIWFAUSS(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x622A0B0", Offset = "0x6228CB0", VA = "0x18622A0B0")]
		public void RZSKQZBIDBX(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x622AE60", Offset = "0x6229A60", VA = "0x18622AE60", Slot = "5")]
		private void ZYXIVACWLAD((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6229570", Offset = "0x6228170", VA = "0x186229570", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class PIKWZKUTZXS
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8B66BB0", Offset = "0x8B657B0", VA = "0x188B66BB0")]
		public static string UREPOHEWMKL(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xDA5DB0", Offset = "0xDA49B0", VA = "0x180DA5DB0")]
		public static NetworkSetterPermissionMode MBYXRVLXRCQ(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class XSMAWYYPPRM<a> : XMBJBTLNRZF<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4479A40", Offset = "0x4478640", VA = "0x184479A40")]
		public XSMAWYYPPRM([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x447ABF0", Offset = "0x44797F0", VA = "0x18447ABF0")]
		public XSMAWYYPPRM(ENGUIRZTRVL a, WJBKOLNRRJE b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] EYQOJDBZNOZ g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4479A90", Offset = "0x4478690", VA = "0x184479A90")]
		public XSMAWYYPPRM(ENGUIRZTRVL a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] EYQOJDBZNOZ f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4477A30", Offset = "0x4476630", VA = "0x184477A30")]
		public XSMAWYYPPRM(ENGUIRZTRVL a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] EYQOJDBZNOZ g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class XSGTZSESGGD<a, b> : XMGPZAFLBKO<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4474DA0", Offset = "0x44739A0", VA = "0x184474DA0")]
		public XSGTZSESGGD([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4475750", Offset = "0x4474350", VA = "0x184475750")]
		public XSGTZSESGGD(ENGUIRZTRVL a, WJBKOLNRRJE b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] EYQOJDBZNOZ h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4476950", Offset = "0x4475550", VA = "0x184476950")]
		public XSGTZSESGGD(ENGUIRZTRVL a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] EYQOJDBZNOZ g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4472B40", Offset = "0x4471740", VA = "0x184472B40")]
		public XSGTZSESGGD(ENGUIRZTRVL a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] EYQOJDBZNOZ h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class XSBNCLKUWUU<a, b, c> : XMLWWGZIKVX<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4471A00", Offset = "0x4470600", VA = "0x184471A00")]
		public XSBNCLKUWUU([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4472370", Offset = "0x4470F70", VA = "0x184472370")]
		public XSBNCLKUWUU(ENGUIRZTRVL a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] EYQOJDBZNOZ h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class XRWGFEQXNJL<a, b, c, d> : XMRDTNTFUHG<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x446F020", Offset = "0x446DC20", VA = "0x18446F020")]
		public XRWGFEQXNJL([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x446EA40", Offset = "0x446D640", VA = "0x18446EA40")]
		public XRWGFEQXNJL(ENGUIRZTRVL a, WJBKOLNRRJE b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] EYQOJDBZNOZ j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x446F120", Offset = "0x446DD20", VA = "0x18446F120")]
		public XRWGFEQXNJL(ENGUIRZTRVL a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] EYQOJDBZNOZ i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class XRQZHXXADYC<a, b, c, d, e> : XMWKQUNDDSP<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x446D230", Offset = "0x446BE30", VA = "0x18446D230")]
		public XRQZHXXADYC(ENGUIRZTRVL a, WJBKOLNRRJE b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] EYQOJDBZNOZ k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x446D660", Offset = "0x446C260", VA = "0x18446D660")]
		public XRQZHXXADYC(ENGUIRZTRVL a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] EYQOJDBZNOZ j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class LTMCXAMDUNH<a> : XMBJBTLNRZF<a>
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x59D8C30", Offset = "0x59D7830", VA = "0x1859D8C30")]
		public LTMCXAMDUNH(WJBKOLNRRJE a, string b, a c, [Optional] Action d, [Optional] EYQOJDBZNOZ e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class LSWIFGELSFG<a, b> : XMGPZAFLBKO<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x59D8900", Offset = "0x59D7500", VA = "0x1859D8900")]
		public LSWIFGELSFG(WJBKOLNRRJE a, string b, a c, b d, [Optional] Action e, [Optional] EYQOJDBZNOZ f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface DSLYMXLKBDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		XSMAWYYPPRM<a> SHRJEMBSAYD<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class UJUGAEHQLKY : DSLYMXLKBDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly EYQOJDBZNOZ NSYSRRCMXDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly ENGUIRZTRVL KEBYUPXJULG;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
		public UJUGAEHQLKY(EYQOJDBZNOZ a, ENGUIRZTRVL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x4143370", Offset = "0x4141F70", VA = "0x184143370", Slot = "4")]
		public XSMAWYYPPRM<a> SHRJEMBSAYD<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface NKIPYOMYKIK : ENGUIRZTRVL
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId MANQSSDMLCY
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface ENGUIRZTRVL
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool OCPENFIYVDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool ZALVYUUURPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string NLTHPMXKSNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool JVRQGKSGIIH
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(IAQVLAAHTRJ handler);

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(IAQVLAAHTRJ handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class WQUEHBUERJB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8B66E50", Offset = "0x8B65A50", VA = "0x188B66E50")]
		public static bool KFEVCIUYEPS(this ENGUIRZTRVL a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface EYQOJDBZNOZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		WJBKOLNRRJE PJLHQEFHPQJ
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool FXGVBLNCOGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool OQWVSBVOFDD
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
		object WEHWKTZXEXT(string a);

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object PGLCTLNGZLF(WJBKOLNRRJE a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void CRZETXVAKMN(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void FRJPPJVOBKD(WJBKOLNRRJE a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void CYEIZHBNXOY<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void PRNYUFQQUMS([CanBeNull] WJBKOLNRRJE photonPlayer, string a, CLLIMHRVKUN b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void AWFVVBAIINF([CanBeNull] WJBKOLNRRJE photonPlayer, string a, CLLIMHRVKUN b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b PWUBIVKKSKN<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object HNSYZFAHXBW<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void XDXMQWXBPMJ();

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void DSWTOTIULVR();

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void INSBBLUETGS(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public WJBKOLNRRJE player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public ENGUIRZTRVL context;

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
		public EYQOJDBZNOZ networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8B66C40", Offset = "0x8B65840", VA = "0x188B66C40")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8B66CC0", Offset = "0x8B658C0", VA = "0x188B66CC0")]
		public SyncData(ENGUIRZTRVL context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] EYQOJDBZNOZ networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8B66BF0", Offset = "0x8B657F0", VA = "0x188B66BF0")]
		public static SyncData From(ENGUIRZTRVL context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] EYQOJDBZNOZ networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class JKNUKHIPRUE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x3C46F50", Offset = "0x3C45B50", VA = "0x183C46F50")]
		public static XSMAWYYPPRM<a> CLLIMHRVKUN<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3C45E50", Offset = "0x3C44A50", VA = "0x183C45E50")]
		public static XSGTZSESGGD<b, c> CLLIMHRVKUN<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3C45EF0", Offset = "0x3C44AF0", VA = "0x183C45EF0")]
		public static XSBNCLKUWUU<d, e, f> CLLIMHRVKUN<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3C46A00", Offset = "0x3C45600", VA = "0x183C46A00")]
		public static XRWGFEQXNJL<g, h, i, j> CLLIMHRVKUN<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3C471D0", Offset = "0x3C45DD0", VA = "0x183C471D0")]
		public static QXYYRTDLFHD<k> QHWNHHYQNFM<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3C47080", Offset = "0x3C45C80", VA = "0x183C47080")]
		public static QXJDZYVTCZC<l, m> QHWNHHYQNFM<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3C47120", Offset = "0x3C45D20", VA = "0x183C47120")]
		public static QXOKXFPQMKL<n, o, p> QHWNHHYQNFM<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3C474A0", Offset = "0x3C460A0", VA = "0x183C474A0")]
		public static QWYQFLHYKCK<q, r, s, t> QHWNHHYQNFM<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class CLLIMHRVKUN : IAQVLAAHTRJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[Flags]
		private enum Flags
		{
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			Disposed = 1,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			LastSetLocally = 2,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			Synchronizing = 4,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			ModifiedOffline = 8,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			Default = 4
		}

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static Stack<EYQOJDBZNOZ> SWISNWYUBFB;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool KYQSKWKTFSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly WJBKOLNRRJE ZYNXIZKHRSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly ENGUIRZTRVL KEBYUPXJULG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string NFHQLEPGVHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode TYLQGGAYTQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action COHZLVOMFVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected EYQOJDBZNOZ TPPVDZUHMSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags UPVGGEVLAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly string FNVVQHURVKK;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static EYQOJDBZNOZ FUYIITMLPWR
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x8B66390", Offset = "0x8B64F90", VA = "0x188B66390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool QWQFMTAUKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8B65690", Offset = "0x8B64290", VA = "0x188B65690")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8B667D0", Offset = "0x8B653D0", VA = "0x188B667D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool DRKVUEIGRAA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8B66240", Offset = "0x8B64E40", VA = "0x188B66240")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8B65280", Offset = "0x8B63E80", VA = "0x188B65280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool QQNMANQPGBT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8B65F70", Offset = "0x8B64B70", VA = "0x188B65F70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8B66720", Offset = "0x8B65320", VA = "0x188B66720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool AVBIPVWPJGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8B661D0", Offset = "0x8B64DD0", VA = "0x188B661D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8B651C0", Offset = "0x8B63DC0", VA = "0x188B651C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object DYBMBACJTSY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xB13B40", Offset = "0xB12740", VA = "0x180B13B40", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool AYVAUQSPHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8B66250", Offset = "0x8B64E50", VA = "0x188B66250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int VYHUDRKMPZC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xE1C0C0", Offset = "0xE1ACC0", VA = "0x180E1C0C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xE1C120", Offset = "0xE1AD20", VA = "0x180E1C120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string XHMXRIOSRQI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool FXGVBLNCOGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8B658C0", Offset = "0x8B644C0", VA = "0x188B658C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8B65ED0", Offset = "0x8B64AD0", VA = "0x188B65ED0")]
		public static void JOAVGWTIEJC(EYQOJDBZNOZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool NVUYPQPPZTM();

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8B66890", Offset = "0x8B65490", VA = "0x188B66890")]
		protected CLLIMHRVKUN(WJBKOLNRRJE a, ENGUIRZTRVL b, string c, NetworkSetterPermissionMode d, Action e, EYQOJDBZNOZ f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8B65860", Offset = "0x8B64460", VA = "0x188B65860", Slot = "1")]
		~CLLIMHRVKUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8B65520", Offset = "0x8B64120", VA = "0x188B65520", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B65AA0", Offset = "0x8B646A0", VA = "0x188B65AA0")]
		private void HCGQQXJHZRW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8B652D0", Offset = "0x8B63ED0", VA = "0x188B652D0")]
		private object CQKVRHQSXBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8B65D00", Offset = "0x8B64900", VA = "0x188B65D00")]
		protected void Initialize(bool enforceInitialValue, object initialValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8B66350", Offset = "0x8B64F50", VA = "0x188B66350")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8B65F80", Offset = "0x8B64B80", VA = "0x188B65F80")]
		protected void LTEBCPJLIJL(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8B65B40", Offset = "0x8B64740", VA = "0x188B65B40")]
		internal void HVSQMUYLXYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8B661E0", Offset = "0x8B64DE0", VA = "0x188B661E0")]
		private void OYHHAASMNRB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8B65A40", Offset = "0x8B64640", VA = "0x188B65A40")]
		private void GZYNIAGSYXY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8B66560", Offset = "0x8B65160", VA = "0x188B66560", Slot = "4")]
		private void UWVUIXBVULO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8B652C0", Offset = "0x8B63EC0", VA = "0x188B652C0", Slot = "5")]
		private void CHITZASKRAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8B65BC0", Offset = "0x8B647C0", VA = "0x188B65BC0")]
		public bool IYOSMKLDGSX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8B656A0", Offset = "0x8B642A0", VA = "0x188B656A0")]
		public bool EKMLQVQMDYP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8B665D0", Offset = "0x8B651D0", VA = "0x188B665D0")]
		private bool VVPQZLXOCAU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8B662A0", Offset = "0x8B64EA0", VA = "0x188B662A0")]
		internal void QVJZHGUHGWF(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8B65910", Offset = "0x8B64510", VA = "0x188B65910")]
		private void GLDQHHFZBZJ(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B65EC0", Offset = "0x8B64AC0", VA = "0x188B65EC0")]
		private bool JIWSKLSVDLH(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B652A0", Offset = "0x8B63EA0", VA = "0x188B652A0")]
		private void BXFALBKKJXT(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8B66740", Offset = "0x8B65340", VA = "0x188B66740")]
		public static string YGSSUDAJTIX(WJBKOLNRRJE a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8B65440", Offset = "0x8B64040", VA = "0x188B65440")]
		public static string CZTDQKXYGEX(ENGUIRZTRVL a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8B66400", Offset = "0x8B65000", VA = "0x188B66400")]
		public static bool UNJNKACPEJX(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class ABLEILFXQFJ : EYQOJDBZNOZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly Dictionary<object, object> FTVVCBFDXDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly List<string> KXOYHFVJHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly Dictionary<object, object> WQSWBXRNCSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly List<string> ZJDNPJOIARI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private bool DDIOUOLRIDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<string, object> HMCMYTXPKSM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		protected readonly Dictionary<WJBKOLNRRJE, Dictionary<string, object>> RBDEAOTZPQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly HashSet<string> UTICMYOPVXB;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> IPSIUXYQXRB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int EULWSMTJULK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract WJBKOLNRRJE PJLHQEFHPQJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool FXGVBLNCOGQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool OQWVSBVOFDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool HZALLYDVKOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool DSWOJSZHWRM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xC66AC0", Offset = "0xC656C0", VA = "0x180C66AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3558760", Offset = "0x3557360", VA = "0x183558760", Slot = "12")]
		public void CYEIZHBNXOY<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8B636F0", Offset = "0x8B622F0", VA = "0x188B636F0", Slot = "11")]
		public void FRJPPJVOBKD(WJBKOLNRRJE a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8B644C0", Offset = "0x8B630C0", VA = "0x188B644C0", Slot = "9")]
		public object PGLCTLNGZLF(WJBKOLNRRJE a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8B63270", Offset = "0x8B61E70", VA = "0x188B63270", Slot = "10")]
		public void CRZETXVAKMN(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8B64960", Offset = "0x8B63560", VA = "0x188B64960", Slot = "8")]
		public object WEHWKTZXEXT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8B645B0", Offset = "0x8B631B0", VA = "0x188B645B0", Slot = "13")]
		public void PRNYUFQQUMS(WJBKOLNRRJE a, string b, CLLIMHRVKUN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8B62C50", Offset = "0x8B61850", VA = "0x188B62C50", Slot = "14")]
		public void AWFVVBAIINF(WJBKOLNRRJE a, string b, CLLIMHRVKUN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8B646C0", Offset = "0x8B632C0", VA = "0x188B646C0")]
		private void PTWJRNMGNVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8B63FB0", Offset = "0x8B62BB0", VA = "0x188B63FB0")]
		private void JOQMAAIXPJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8B641D0", Offset = "0x8B62DD0", VA = "0x188B641D0")]
		private void KRTCOXMBAAQ(WJBKOLNRRJE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8B63390", Offset = "0x8B61F90", VA = "0x188B63390")]
		protected void DMGTUBLZFVQ(WJBKOLNRRJE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B64870", Offset = "0x8B63470", VA = "0x188B64870")]
		protected void VFMHOQCQUJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8B63260", Offset = "0x8B61E60", VA = "0x188B63260")]
		protected void CFQDZXATKBI(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B63F40", Offset = "0x8B62B40", VA = "0x188B63F40")]
		protected void IOBXNQYUEFE(WJBKOLNRRJE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8B64430", Offset = "0x8B63030", VA = "0x188B64430")]
		protected void NVIHOYTFVYU(WJBKOLNRRJE a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B63840", Offset = "0x8B62440", VA = "0x188B63840")]
		private void FYFWMVQJASL(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8B64230", Offset = "0x8B62E30", VA = "0x188B64230")]
		private static void LTWHDOWZGWT(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8B64A00", Offset = "0x8B63600", VA = "0x188B64A00")]
		private static void XCQGTQGPTPU(Dictionary<string, object> a, string b, CLLIMHRVKUN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8B64000", Offset = "0x8B62C00", VA = "0x188B64000")]
		private static void KGVCLYEKHJX(Dictionary<string, object> a, string b, CLLIMHRVKUN c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8B64C20", Offset = "0x8B63820", VA = "0x188B64C20", Slot = "17")]
		public void XDXMQWXBPMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract void VNXAYRWIQEI(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B634B0", Offset = "0x8B620B0", VA = "0x188B634B0", Slot = "18")]
		public void DSWTOTIULVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "28")]
		protected abstract void JREJSLYRFRA(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B64DB0", Offset = "0x8B639B0", VA = "0x188B64DB0")]
		private void ZHCSNEFQZJD(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8B629D0", Offset = "0x8B615D0", VA = "0x188B629D0")]
		private void AHKSYJQLRUY(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8B64710", Offset = "0x8B63310", VA = "0x188B64710")]
		public void RKSPVATJHJV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B647A0", Offset = "0x8B633A0", VA = "0x188B647A0")]
		public void SZIRHSBCQLR(WJBKOLNRRJE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B62F00", Offset = "0x8B61B00", VA = "0x188B62F00")]
		public void BQDOXFRXYZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract HashSet<int> UTFQNCZKVMU(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8B63CC0", Offset = "0x8B628C0", VA = "0x188B63CC0", Slot = "19")]
		public void INSBBLUETGS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B64D20", Offset = "0x8B63920", VA = "0x188B64D20")]
		protected string YGSSUDAJTIX(WJBKOLNRRJE a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "30")]
		public abstract object HNSYZFAHXBW<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "31")]
		public abstract c PWUBIVKKSKN<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "32")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8B63590", Offset = "0x8B62190", VA = "0x188B63590", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "33")]
		protected virtual void MCAKXCRJDVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B64FD0", Offset = "0x8B63BD0", VA = "0x188B64FD0")]
		protected ABLEILFXQFJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class XMBJBTLNRZF<a> : CLLIMHRVKUN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private a LZYQDFBTFXI;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a JXMBKOKVATH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x4414DD0", Offset = "0x44139D0", VA = "0x184414DD0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4414C70", Offset = "0x4413870", VA = "0x184414C70", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object DYBMBACJTSY
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x4415160", Offset = "0x4413D60", VA = "0x184415160", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x4414B40", Offset = "0x4413740", VA = "0x184414B40", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x44153C0", Offset = "0x4413FC0", VA = "0x1844153C0", Slot = "9")]
		protected override bool NVUYPQPPZTM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x441A9B0", Offset = "0x44195B0", VA = "0x18441A9B0")]
		protected XMBJBTLNRZF([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x441B9B0", Offset = "0x441A5B0", VA = "0x18441B9B0")]
		protected XMBJBTLNRZF(WJBKOLNRRJE a, ENGUIRZTRVL b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, EYQOJDBZNOZ h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4415050", Offset = "0x4413C50", VA = "0x184415050")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4418D40", Offset = "0x4417940", VA = "0x184418D40")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4416CC0", Offset = "0x44158C0", VA = "0x184416CC0")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class XMGPZAFLBKO<a, b> : CLLIMHRVKUN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private a LZYQDFBTFXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private b LZTJFYHVWLZ;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a JXMBKOKVATH
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xB131E0", Offset = "0xB11DE0", VA = "0x180B131E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xB13210", Offset = "0xB11E10", VA = "0x180B13210", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b JWWGSUDCYLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xB13A70", Offset = "0xB12670", VA = "0x180B13A70", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xB13250", Offset = "0xB11E50", VA = "0x180B13250", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b ZERKFIBNMPW
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4420A00", Offset = "0x441F600", VA = "0x184420A00")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object DYBMBACJTSY
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x4415160", Offset = "0x4413D60", VA = "0x184415160", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x441E610", Offset = "0x441D210", VA = "0x18441E610", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4421880", Offset = "0x4420480", VA = "0x184421880", Slot = "9")]
		protected override bool NVUYPQPPZTM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4427CB0", Offset = "0x44268B0", VA = "0x184427CB0")]
		protected XMGPZAFLBKO([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4429CF0", Offset = "0x44288F0", VA = "0x184429CF0")]
		protected XMGPZAFLBKO(WJBKOLNRRJE a, ENGUIRZTRVL b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, EYQOJDBZNOZ i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4414F30", Offset = "0x4413B30", VA = "0x184414F30")]
		public a QJYEMRVJHEG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4420360", Offset = "0x441EF60", VA = "0x184420360")]
		public void LXXMAIEBWTY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4420A00", Offset = "0x441F600", VA = "0x184420A00")]
		public b QJSXPLBLXSX()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x441FE30", Offset = "0x441EA30", VA = "0x18441FE30")]
		public void LXSFDBKENIP(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4423E90", Offset = "0x4422A90", VA = "0x184423E90")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class XMLWWGZIKVX<a, b, c> : CLLIMHRVKUN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private a LZYQDFBTFXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private b LZTJFYHVWLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private c LZOCIRNYNAQ;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a JXMBKOKVATH
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x1177B00", Offset = "0x1176700", VA = "0x181177B00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x1179250", Offset = "0x1177E50", VA = "0x181179250", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b JWWGSUDCYLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x1338B30", Offset = "0x1337730", VA = "0x181338B30", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x18E6FC0", Offset = "0x18E5BC0", VA = "0x1818E6FC0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c JXBNQAXAHWP
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAE0", Offset = "0xB2D6E0", VA = "0x180B2EAE0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x442AFC0", Offset = "0x4429BC0", VA = "0x18442AFC0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a ZFHEXCJFOXX
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x4414F30", Offset = "0x4413B30", VA = "0x184414F30")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b ZERKFIBNMPW
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x4420A00", Offset = "0x441F600", VA = "0x184420A00")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c ZEWRCOVKWBF
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x442CBB0", Offset = "0x442B7B0", VA = "0x18442CBB0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object DYBMBACJTSY
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4415160", Offset = "0x4413D60", VA = "0x184415160", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x442A490", Offset = "0x4429090", VA = "0x18442A490", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x442DC50", Offset = "0x442C850", VA = "0x18442DC50", Slot = "9")]
		protected override bool NVUYPQPPZTM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4431CA0", Offset = "0x44308A0", VA = "0x184431CA0")]
		protected XMLWWGZIKVX([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4431F90", Offset = "0x4430B90", VA = "0x184431F90")]
		protected XMLWWGZIKVX(WJBKOLNRRJE a, ENGUIRZTRVL b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, EYQOJDBZNOZ j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4414F30", Offset = "0x4413B30", VA = "0x184414F30")]
		public a QJYEMRVJHEG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x442C590", Offset = "0x442B190", VA = "0x18442C590")]
		public void LXXMAIEBWTY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4420A00", Offset = "0x441F600", VA = "0x184420A00")]
		public b QJSXPLBLXSX()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x442BCA0", Offset = "0x442A8A0", VA = "0x18442BCA0")]
		public void LXSFDBKENIP(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x442CBB0", Offset = "0x442B7B0", VA = "0x18442CBB0")]
		public c QJNQSEHOOHO()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x442B500", Offset = "0x442A100", VA = "0x18442B500")]
		public void LXMYFUQHDXG(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x442EF10", Offset = "0x442DB10", VA = "0x18442EF10")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class XMRDTNTFUHG<a, b, c, d> : CLLIMHRVKUN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private a LZYQDFBTFXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private b LZTJFYHVWLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private c LZOCIRNYNAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private d LZIVLKUBDPH;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a JXMBKOKVATH
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xDD2770", Offset = "0xDD1370", VA = "0x180DD2770", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x1154AF0", Offset = "0x11536F0", VA = "0x181154AF0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b JWWGSUDCYLG
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x22AB770", Offset = "0x22AA370", VA = "0x1822AB770", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x44330D0", Offset = "0x4431CD0", VA = "0x1844330D0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c JXBNQAXAHWP
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x4433140", Offset = "0x4431D40", VA = "0x184433140", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x4433090", Offset = "0x4431C90", VA = "0x184433090", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d JWLSYGPIFOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x179C790", Offset = "0x179B390", VA = "0x18179C790", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x17C0C40", Offset = "0x17BF840", VA = "0x1817C0C40", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b ZERKFIBNMPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x4420A20", Offset = "0x441F620", VA = "0x184420A20")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c ZEWRCOVKWBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x442CBD0", Offset = "0x442B7D0", VA = "0x18442CBD0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d ZEGWKUNSTTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x23B17C0", Offset = "0x23B03C0", VA = "0x1823B17C0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object DYBMBACJTSY
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x4415160", Offset = "0x4413D60", VA = "0x184415160", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x4432A10", Offset = "0x4431610", VA = "0x184432A10", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x4433DA0", Offset = "0x44329A0", VA = "0x184433DA0", Slot = "9")]
		protected override bool NVUYPQPPZTM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x44354E0", Offset = "0x44340E0", VA = "0x1844354E0")]
		protected XMRDTNTFUHG([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4435CB0", Offset = "0x44348B0", VA = "0x184435CB0")]
		protected XMRDTNTFUHG(WJBKOLNRRJE a, ENGUIRZTRVL b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, EYQOJDBZNOZ k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4414F30", Offset = "0x4413B30", VA = "0x184414F30")]
		public a QJYEMRVJHEG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4433940", Offset = "0x4432540", VA = "0x184433940")]
		public void LXXMAIEBWTY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4420A20", Offset = "0x441F620", VA = "0x184420A20")]
		public b QJSXPLBLXSX()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x44335A0", Offset = "0x44321A0", VA = "0x1844335A0")]
		public void LXSFDBKENIP(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x442CBD0", Offset = "0x442B7D0", VA = "0x18442CBD0")]
		public c QJNQSEHOOHO()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4433390", Offset = "0x4431F90", VA = "0x184433390")]
		public void LXMYFUQHDXG(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x23B17C0", Offset = "0x23B03C0", VA = "0x1823B17C0")]
		public d QJIJUXNREWF()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x4433AE0", Offset = "0x44326E0", VA = "0x184433AE0")]
		public void LYXUMPZORYR(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4434F30", Offset = "0x4433B30", VA = "0x184434F30")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class XMWKQUNDDSP<a, b, c, d, e> : CLLIMHRVKUN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private a LZYQDFBTFXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private b LZTJFYHVWLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private c LZOCIRNYNAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private d LZIVLKUBDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private e LZDOOEADUDY;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a JXMBKOKVATH
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xF343C0", Offset = "0xF32FC0", VA = "0x180F343C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x111EE80", Offset = "0x111DA80", VA = "0x18111EE80", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b JWWGSUDCYLG
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x139CB80", Offset = "0x139B780", VA = "0x18139CB80", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x16D92B0", Offset = "0x16D7EB0", VA = "0x1816D92B0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c JXBNQAXAHWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAE0", Offset = "0xB2D6E0", VA = "0x180B2EAE0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x442AFC0", Offset = "0x4429BC0", VA = "0x18442AFC0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d JWLSYGPIFOO
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xB4ACE0", Offset = "0xB498E0", VA = "0x180B4ACE0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xB4AD40", Offset = "0xB49940", VA = "0x180B4AD40", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e JWQZVNJFOZX
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x18E82D0", Offset = "0x18E6ED0", VA = "0x1818E82D0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x18EB630", Offset = "0x18EA230", VA = "0x1818EB630", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object DYBMBACJTSY
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x4415160", Offset = "0x4413D60", VA = "0x184415160", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x4463AD0", Offset = "0x44626D0", VA = "0x184463AD0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x4467EF0", Offset = "0x4466AF0", VA = "0x184467EF0", Slot = "9")]
		protected override bool NVUYPQPPZTM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x446B2E0", Offset = "0x4469EE0", VA = "0x18446B2E0")]
		protected XMWKQUNDDSP(WJBKOLNRRJE a, ENGUIRZTRVL b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, EYQOJDBZNOZ l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4414F30", Offset = "0x4413B30", VA = "0x184414F30")]
		public a QJYEMRVJHEG()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x4466340", Offset = "0x4464F40", VA = "0x184466340")]
		public void LXXMAIEBWTY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x4420A00", Offset = "0x441F600", VA = "0x184420A00")]
		public b QJSXPLBLXSX()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4465CD0", Offset = "0x44648D0", VA = "0x184465CD0")]
		public void LXSFDBKENIP(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x442CBB0", Offset = "0x442B7B0", VA = "0x18442CBB0")]
		public c QJNQSEHOOHO()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x44650B0", Offset = "0x4463CB0", VA = "0x1844650B0")]
		public void LXMYFUQHDXG(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x23B17C0", Offset = "0x23B03C0", VA = "0x1823B17C0")]
		public d QJIJUXNREWF()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x4467030", Offset = "0x4465C30", VA = "0x184467030")]
		public void LYXUMPZORYR(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x44681D0", Offset = "0x4466DD0", VA = "0x1844681D0")]
		public e QJDCXQTTVKW()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x4466420", Offset = "0x4465020", VA = "0x184466420")]
		public void LYSNPJFRINI(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x4469750", Offset = "0x4468350", VA = "0x184469750")]
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
