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
	public interface TNXDFZZFJLB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool OPANYMZIKBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool DBELDVLXABJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		JNIVCIZIPSX GTEUSLBWTMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int SMWUGCTYZQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool BUOUTWFYAZP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool BRYZTRAQBIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action XBEMTXJAKCG;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RANVWWIOYPZ();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void EHTEOOVUJBV(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void ROLQOYMLKOZ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface HOFBEYURLTK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string AZSKTLMZSBZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool YSNORTLCSYV
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface YVSEOKYZBGH<a> : HOFBEYURLTK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a PEBEEAIWOZX
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DORCTRMGYGM(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class FHUCOZRPXTW<a> : YVSEOKYZBGH<a>, HOFBEYURLTK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly VLUPMVMSGQJ<a> ZFQXKWPQBQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly VLUPMVMSGQJ<a> SUUZYRTUWQQ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string AZSKTLMZSBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xF74D10", Offset = "0xF73710", VA = "0x180F74D10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DVAXSKXABBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6347610", Offset = "0x6346010", VA = "0x186347610", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a OPCYQAJFYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x63466D0", Offset = "0x63450D0", VA = "0x1863466D0", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6348CB0", Offset = "0x63476B0", VA = "0x186348CB0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a PEBEEAIWOZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6346180", Offset = "0x6344B80", VA = "0x186346180", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6346380", Offset = "0x6344D80", VA = "0x186346380", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a YSLRVNQQVPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6346180", Offset = "0x6344B80", VA = "0x186346180")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6344C20", Offset = "0x6343620", VA = "0x186344C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool YSNORTLCSYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6346160", Offset = "0x6344B60", VA = "0x186346160", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6346100", Offset = "0x6344B00", VA = "0x186346100", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6347DD0", Offset = "0x63467D0", VA = "0x186347DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x63470C0", Offset = "0x6345AC0", VA = "0x1863470C0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6348E40", Offset = "0x6347840", VA = "0x186348E40")]
		public FHUCOZRPXTW([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x63469E0", Offset = "0x63453E0", VA = "0x1863469E0")]
		private void NDTHSFXGHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6345C60", Offset = "0x6344660", VA = "0x186345C60", Slot = "5")]
		public void DORCTRMGYGM(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6345980", Offset = "0x6344380", VA = "0x186345980")]
		public void DORCTRMGYGM(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6346120", Offset = "0x6344B20", VA = "0x186346120", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class FIJXGTZIABX<a, b> : YVSEOKYZBGH<(a, b)>, HOFBEYURLTK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly VLEUVBFAEII<a, b> ZFQXKWPQBQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly VLEUVBFAEII<a, b> SUUZYRTUWQQ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string AZSKTLMZSBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xF74D10", Offset = "0xF73710", VA = "0x180F74D10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DVAXSKXABBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6353FB0", Offset = "0x63529B0", VA = "0x186353FB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool OWXEQTZLRVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6353040", Offset = "0x6351A40", VA = "0x186353040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool OWRXTNFOIKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6352E90", Offset = "0x6351890", VA = "0x186352E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) OPCYQAJFYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6353830", Offset = "0x6352230", VA = "0x186353830", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x63541D0", Offset = "0x6352BD0", VA = "0x1863541D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) PEBEEAIWOZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6353C20", Offset = "0x6352620", VA = "0x186353C20", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6353700", Offset = "0x6352100", VA = "0x186353700", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) YSLRVNQQVPD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x63536C0", Offset = "0x63520C0", VA = "0x1863536C0")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6353200", Offset = "0x6351C00", VA = "0x186353200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a KQKMCTTYZER
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63538E0", Offset = "0x63522E0", VA = "0x1863538E0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x63534D0", Offset = "0x6351ED0", VA = "0x1863534D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a VEJPYWVTEKM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6353AF0", Offset = "0x63524F0", VA = "0x186353AF0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6352D60", Offset = "0x6351760", VA = "0x186352D60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a CCWBTCWQKHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6353AF0", Offset = "0x63524F0", VA = "0x186353AF0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x63533D0", Offset = "0x6351DD0", VA = "0x1863533D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b KPURKZMGWWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6353A80", Offset = "0x6352480", VA = "0x186353A80")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x63535B0", Offset = "0x6351FB0", VA = "0x1863535B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b VEZKQRDLGSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6353B50", Offset = "0x6352550", VA = "0x186353B50")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b CDLWKXEIMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6353B50", Offset = "0x6352550", VA = "0x186353B50")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6353340", Offset = "0x6351D40", VA = "0x186353340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool YSNORTLCSYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6346160", Offset = "0x6344B60", VA = "0x186346160", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6346100", Offset = "0x6344B00", VA = "0x186346100", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6353DE0", Offset = "0x63527E0", VA = "0x186353DE0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6354380", Offset = "0x6352D80", VA = "0x186354380")]
		public FIJXGTZIABX([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6353910", Offset = "0x6352310", VA = "0x186353910")]
		private void NDTHSFXGHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6353CD0", Offset = "0x63526D0", VA = "0x186353CD0")]
		public void RKNNZKVIWKF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6353240", Offset = "0x6351C40", VA = "0x186353240")]
		public void DORCTRMGYGM(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6353170", Offset = "0x6351B70", VA = "0x186353170", Slot = "5")]
		private void CRPWIAUWOET((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6346120", Offset = "0x6344B20", VA = "0x186346120", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class FIEQJNFKQQO<a, b, c> : YVSEOKYZBGH<(a, b, c)>, HOFBEYURLTK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly VLKBSHYXNTR<a, b, c> ZFQXKWPQBQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly VLKBSHYXNTR<a, b, c> SUUZYRTUWQQ;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string AZSKTLMZSBZ
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xF74D10", Offset = "0xF73710", VA = "0x180F74D10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool DVAXSKXABBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x634EA40", Offset = "0x634D440", VA = "0x18634EA40", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool OWXEQTZLRVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x634B7A0", Offset = "0x634A1A0", VA = "0x18634B7A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool OWRXTNFOIKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x634B310", Offset = "0x6349D10", VA = "0x18634B310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool OWMQWGLQYYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x634B6D0", Offset = "0x634A0D0", VA = "0x18634B6D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) OPCYQAJFYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x634D2A0", Offset = "0x634BCA0", VA = "0x18634D2A0", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x634F420", Offset = "0x634DE20", VA = "0x18634F420", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) PEBEEAIWOZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x634DD60", Offset = "0x634C760", VA = "0x18634DD60", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x634CE10", Offset = "0x634B810", VA = "0x18634CE10", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a KQKMCTTYZER
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x634D380", Offset = "0x634BD80", VA = "0x18634D380")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x634C2E0", Offset = "0x634ACE0", VA = "0x18634C2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a VEJPYWVTEKM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x634D9E0", Offset = "0x634C3E0", VA = "0x18634D9E0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a CCWBTCWQKHG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x634D9E0", Offset = "0x634C3E0", VA = "0x18634D9E0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x634C250", Offset = "0x634AC50", VA = "0x18634C250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b KPURKZMGWWQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x634D900", Offset = "0x634C300", VA = "0x18634D900")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x634CA10", Offset = "0x634B410", VA = "0x18634CA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b VEZKQRDLGSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x634DB70", Offset = "0x634C570", VA = "0x18634DB70")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b CDLWKXEIMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x634DB70", Offset = "0x634C570", VA = "0x18634DB70")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x634BDE0", Offset = "0x634A7E0", VA = "0x18634BDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c KPZYIGGEGHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x634D8D0", Offset = "0x634C2D0", VA = "0x18634D8D0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x634C590", Offset = "0x634AF90", VA = "0x18634C590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c VEUDTKJNXHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x634DC50", Offset = "0x634C650", VA = "0x18634DC50")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c CDGPNQKLDDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x634DC50", Offset = "0x634C650", VA = "0x18634DC50")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x634C060", Offset = "0x634AA60", VA = "0x18634C060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool YSNORTLCSYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6346160", Offset = "0x6344B60", VA = "0x186346160", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x634E4F0", Offset = "0x634CEF0", VA = "0x18634E4F0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x634FDC0", Offset = "0x634E7C0", VA = "0x18634FDC0")]
		public FIEQJNFKQQO([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x634D460", Offset = "0x634BE60", VA = "0x18634D460")]
		private void NDTHSFXGHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x634E440", Offset = "0x634CE40", VA = "0x18634E440")]
		public void RKNNZKVIWKF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x634AF90", Offset = "0x6349990", VA = "0x18634AF90")]
		public void BEAQZRHNTQW(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x634AC10", Offset = "0x6349610", VA = "0x18634AC10")]
		public void AHHBWJQEKZR(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x634BA50", Offset = "0x634A450", VA = "0x18634BA50")]
		public void DORCTRMGYGM(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x634E9E0", Offset = "0x634D3E0", VA = "0x18634E9E0", Slot = "5")]
		private void SAZEYIGPLDS((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6346120", Offset = "0x6344B20", VA = "0x186346120", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class FIULBHNCSYP<a, b, c, d> : YVSEOKYZBGH<(a, b, c, d)>, HOFBEYURLTK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly VMKKEPUKIYK<a, b, c, d> ZFQXKWPQBQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly VMKKEPUKIYK<a, b, c, d> SUUZYRTUWQQ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string AZSKTLMZSBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xF74D10", Offset = "0xF73710", VA = "0x180F74D10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) PEBEEAIWOZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x635AB90", Offset = "0x6359590", VA = "0x18635AB90", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x635A530", Offset = "0x6358F30", VA = "0x18635A530", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b VEZKQRDLGSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x635A9A0", Offset = "0x63593A0", VA = "0x18635A9A0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c VEUDTKJNXHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x635AA80", Offset = "0x6359480", VA = "0x18635AA80")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d VFJYLERFZPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x635AAB0", Offset = "0x63594B0", VA = "0x18635AAB0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool YSNORTLCSYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6346160", Offset = "0x6344B60", VA = "0x186346160", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6346100", Offset = "0x6344B00", VA = "0x186346100", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x635BE90", Offset = "0x635A890", VA = "0x18635BE90")]
		public FIULBHNCSYP([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x635A7F0", Offset = "0x63591F0", VA = "0x18635A7F0")]
		private void NDTHSFXGHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x635B310", Offset = "0x6359D10", VA = "0x18635B310")]
		public void RKNNZKVIWKF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x635A120", Offset = "0x6358B20", VA = "0x18635A120")]
		public void DORCTRMGYGM(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x635B400", Offset = "0x6359E00", VA = "0x18635B400", Slot = "5")]
		private void SIJRILQWLZE((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6346120", Offset = "0x6344B20", VA = "0x186346120", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class BVORJXRRLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9979BA0", Offset = "0x99785A0", VA = "0x189979BA0")]
		public static string KBKMIUPKXYI(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD3C390", Offset = "0xD3AD90", VA = "0x180D3C390")]
		public static NetworkSetterPermissionMode SIPUDFFQBBD(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class VLUPMVMSGQJ<a> : HLATNSVUQNW<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7EC65F0", Offset = "0x7EC4FF0", VA = "0x187EC65F0")]
		public VLUPMVMSGQJ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7EC2A80", Offset = "0x7EC1480", VA = "0x187EC2A80")]
		public VLUPMVMSGQJ(CIZSGDLSXXQ a, JNIVCIZIPSX b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] CHMQKBZFKAM g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7EC5F80", Offset = "0x7EC4980", VA = "0x187EC5F80")]
		public VLUPMVMSGQJ(CIZSGDLSXXQ a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] CHMQKBZFKAM f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7EC40C0", Offset = "0x7EC2AC0", VA = "0x187EC40C0")]
		public VLUPMVMSGQJ(CIZSGDLSXXQ a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] CHMQKBZFKAM g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class VLEUVBFAEII<a, b> : HLQOFNDMSVX<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7EBD760", Offset = "0x7EBC160", VA = "0x187EBD760")]
		public VLEUVBFAEII([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7EBC1A0", Offset = "0x7EBABA0", VA = "0x187EBC1A0")]
		public VLEUVBFAEII(CIZSGDLSXXQ a, JNIVCIZIPSX b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] CHMQKBZFKAM h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7EBBA40", Offset = "0x7EBA440", VA = "0x187EBBA40")]
		public VLEUVBFAEII(CIZSGDLSXXQ a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] CHMQKBZFKAM g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7EBCCA0", Offset = "0x7EBB6A0", VA = "0x187EBCCA0")]
		public VLEUVBFAEII(CIZSGDLSXXQ a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] CHMQKBZFKAM h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class VLKBSHYXNTR<a, b, c> : HLLHIGJPJKO<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7EC1AD0", Offset = "0x7EC04D0", VA = "0x187EC1AD0")]
		public VLKBSHYXNTR([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7EC1FC0", Offset = "0x7EC09C0", VA = "0x187EC1FC0")]
		public VLKBSHYXNTR(CIZSGDLSXXQ a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] CHMQKBZFKAM h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class VMKKEPUKIYK<a, b, c, d> : HMBCAARHLSP<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7EC7B60", Offset = "0x7EC6560", VA = "0x187EC7B60")]
		public VMKKEPUKIYK([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7EC72D0", Offset = "0x7EC5CD0", VA = "0x187EC72D0")]
		public VMKKEPUKIYK(CIZSGDLSXXQ a, JNIVCIZIPSX b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] CHMQKBZFKAM j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7EC8DF0", Offset = "0x7EC77F0", VA = "0x187EC8DF0")]
		public VMKKEPUKIYK(CIZSGDLSXXQ a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] CHMQKBZFKAM i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class VMPRBWOHSJT<a, b, c, d, e> : HLVVCTXKCHG<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7EC9070", Offset = "0x7EC7A70", VA = "0x187EC9070")]
		public VMPRBWOHSJT(CIZSGDLSXXQ a, JNIVCIZIPSX b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] CHMQKBZFKAM k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7EC9730", Offset = "0x7EC8130", VA = "0x187EC9730")]
		public VMPRBWOHSJT(CIZSGDLSXXQ a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] CHMQKBZFKAM j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class VPEHBKURMFI<a> : HLATNSVUQNW<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD9A0", Offset = "0x7ECC3A0", VA = "0x187ECD9A0")]
		public VPEHBKURMFI(JNIVCIZIPSX a, string b, a c, [Optional] Action d, [Optional] CHMQKBZFKAM e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class VOZAEEAUCTZ<a, b> : HLQOFNDMSVX<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7ECD5C0", Offset = "0x7ECBFC0", VA = "0x187ECD5C0")]
		public VOZAEEAUCTZ(JNIVCIZIPSX a, string b, a c, b d, [Optional] Action e, [Optional] CHMQKBZFKAM f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface VSUBMMFFBTY
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		VLUPMVMSGQJ<a> OKVIFFKEKES<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class UAVGAGEATJR : VSUBMMFFBTY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly CHMQKBZFKAM LBLRRFEUJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly CIZSGDLSXXQ VCAJEJENTLV;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xCD4A70", Offset = "0xCD3470", VA = "0x180CD4A70")]
		public UAVGAGEATJR(CHMQKBZFKAM a, CIZSGDLSXXQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x407C140", Offset = "0x407AB40", VA = "0x18407C140", Slot = "4")]
		public VLUPMVMSGQJ<a> OKVIFFKEKES<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface BCYDWJHSJSP : CIZSGDLSXXQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId WMBJLQNBEYF
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface CIZSGDLSXXQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool CYLTCGKDFUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool GWBZBMLVBPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string MLOMHKCSJCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool UPSQJLMHAPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(ZXBKPLWDANS handler);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(ZXBKPLWDANS handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class TVXJSFZSKQY
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x997DEF0", Offset = "0x997C8F0", VA = "0x18997DEF0")]
		public static bool DJEAVUFCVFV(this CIZSGDLSXXQ a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface CHMQKBZFKAM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		JNIVCIZIPSX HPFZNTESQRE
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool AUXCIJXMVYI
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
		object MEEQOUGEIRG(string a);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object XOLUVPEUUNY(JNIVCIZIPSX a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void XVLRBMXBFXK(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void BMDYWOMVLDM(JNIVCIZIPSX a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void REPRDDNTUSL<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void KKTAAVPLUYF([CanBeNull] JNIVCIZIPSX photonPlayer, string a, QPOMEWQYEQO b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void OOEKGCJAFXW([CanBeNull] JNIVCIZIPSX photonPlayer, string a, QPOMEWQYEQO b);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b EWNGHYBZNWE<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object JNFCTUUYGUB<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		object EWNGHYBZNWE(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		object JNFCTUUYGUB(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void CMULSMNIGUI();

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void BJPMKQMKZQK();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void CFROENWGNAZ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public JNIVCIZIPSX player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CIZSGDLSXXQ context;

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
		public CHMQKBZFKAM networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x997DCE0", Offset = "0x997C6E0", VA = "0x18997DCE0")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x997DD60", Offset = "0x997C760", VA = "0x18997DD60")]
		public SyncData(CIZSGDLSXXQ context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] CHMQKBZFKAM networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x997DC90", Offset = "0x997C690", VA = "0x18997DC90")]
		public static SyncData From(CIZSGDLSXXQ context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] CHMQKBZFKAM networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class PYYKKTMDHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D82C50", Offset = "0x3D81650", VA = "0x183D82C50")]
		public static VLUPMVMSGQJ<a> QPOMEWQYEQO<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D82240", Offset = "0x3D80C40", VA = "0x183D82240")]
		public static VLEUVBFAEII<b, c> QPOMEWQYEQO<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D822E0", Offset = "0x3D80CE0", VA = "0x183D822E0")]
		public static VLKBSHYXNTR<d, e, f> QPOMEWQYEQO<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D82700", Offset = "0x3D81100", VA = "0x183D82700")]
		public static VMKKEPUKIYK<g, h, i, j> QPOMEWQYEQO<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D81250", Offset = "0x3D7FC50", VA = "0x183D81250")]
		public static FHUCOZRPXTW<k> OTDLLCUKOZB<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D81100", Offset = "0x3D7FB00", VA = "0x183D81100")]
		public static FIJXGTZIABX<l, m> OTDLLCUKOZB<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D811A0", Offset = "0x3D7FBA0", VA = "0x183D811A0")]
		public static FIEQJNFKQQO<n, o, p> OTDLLCUKOZB<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D81C50", Offset = "0x3D80650", VA = "0x183D81C50")]
		public static FIULBHNCSYP<q, r, s, t> OTDLLCUKOZB<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class QPOMEWQYEQO : ZXBKPLWDANS, IDisposable
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
		private static Stack<CHMQKBZFKAM> NEVRPOFFVBG;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool LVGZWBURLUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly JNIVCIZIPSX ZVRGIMZDIMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly CIZSGDLSXXQ VCAJEJENTLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string OXRGMRPMYAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode PYDHJQXTVBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action OTLTFWAVXED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected CHMQKBZFKAM XPLUTNUNLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags XHLSMLWWHCX;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static CHMQKBZFKAM MGYNPNPWGIU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x997D4B0", Offset = "0x997BEB0", VA = "0x18997D4B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool YWFAPUGNDFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x997D270", Offset = "0x997BC70", VA = "0x18997D270")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x997C690", Offset = "0x997B090", VA = "0x18997C690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool CJEVASSGRXV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x997D950", Offset = "0x997C350", VA = "0x18997D950")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x997CB50", Offset = "0x997B550", VA = "0x18997CB50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool XJRAGXQLVCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x997C770", Offset = "0x997B170", VA = "0x18997C770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x997CFB0", Offset = "0x997B9B0", VA = "0x18997CFB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool YSNORTLCSYV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x997C8F0", Offset = "0x997B2F0", VA = "0x18997C8F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x997C6B0", Offset = "0x997B0B0", VA = "0x18997C6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object DRRYLFOYJRR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCD7CF0", Offset = "0xCD66F0", VA = "0x180CD7CF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xCD76A0", Offset = "0xCD60A0", VA = "0x180CD76A0", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool QDCQLTFWCIW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x997CFD0", Offset = "0x997B9D0", VA = "0x18997CFD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int MCLKUHQCRTH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xEA8A40", Offset = "0xEA7440", VA = "0x180EA8A40")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1A9A900", Offset = "0x1A99300", VA = "0x181A9A900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string AZSKTLMZSBZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x997D5F0", Offset = "0x997BFF0", VA = "0x18997D5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x997CD40", Offset = "0x997B740", VA = "0x18997CD40")]
		public static void JCTVPPTCXBP(CHMQKBZFKAM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool PQFWYVDNDFR();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x997DA70", Offset = "0x997C470", VA = "0x18997DA70")]
		protected QPOMEWQYEQO(JNIVCIZIPSX a, CIZSGDLSXXQ b, string c, NetworkSetterPermissionMode d, Action e, CHMQKBZFKAM f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x997C900", Offset = "0x997B300", VA = "0x18997C900", Slot = "1")]
		~QPOMEWQYEQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x997C780", Offset = "0x997B180", VA = "0x18997C780", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x997C570", Offset = "0x997AF70", VA = "0x18997C570")]
		private void AVVNBTQOTNT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x997CE40", Offset = "0x997B840", VA = "0x18997CE40")]
		private object JQJHVELVILR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x997CB70", Offset = "0x997B570", VA = "0x18997CB70")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x997D5B0", Offset = "0x997BFB0", VA = "0x18997D5B0")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x997D020", Offset = "0x997BA20", VA = "0x18997D020")]
		protected void KNLLTZMWXQA(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x997C610", Offset = "0x997B010", VA = "0x18997C610")]
		internal void AZBCXZQNDYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x997CDE0", Offset = "0x997B7E0", VA = "0x18997CDE0")]
		private void JFEREFUXWOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x997D8F0", Offset = "0x997C2F0", VA = "0x18997D8F0")]
		private void WLPLAFIHLVZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x997D960", Offset = "0x997C360", VA = "0x18997D960", Slot = "4")]
		private void ZKPWRGVAXUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x997D2B0", Offset = "0x997BCB0", VA = "0x18997D2B0", Slot = "5")]
		private void NBCLRAZZQTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x997D2C0", Offset = "0x997BCC0", VA = "0x18997D2C0")]
		public bool NUESHVAAUKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x997C3B0", Offset = "0x997ADB0", VA = "0x18997C3B0")]
		public bool ARIQEFXXHBQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x997D7A0", Offset = "0x997C1A0", VA = "0x18997D7A0")]
		private bool WKDCHMIACOF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x997D400", Offset = "0x997BE00", VA = "0x18997D400")]
		internal void NVXRAZBQPMW(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x997C960", Offset = "0x997B360", VA = "0x18997C960")]
		private void GZVZLBHWNUK(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x997D280", Offset = "0x997BC80", VA = "0x18997D280")]
		private bool MFCVNDNHJSS(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x997D290", Offset = "0x997BC90", VA = "0x18997D290")]
		private void MUILLMWPCOK(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x997D520", Offset = "0x997BF20", VA = "0x18997D520")]
		public static string SOOMCABFMPG(JNIVCIZIPSX a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x997CA70", Offset = "0x997B470", VA = "0x18997CA70")]
		public static string HABPSKKWKPO(CIZSGDLSXXQ a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x997D640", Offset = "0x997C040", VA = "0x18997D640")]
		public static bool WJNQPFNORNA(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class HQKOEQLMDOE : CHMQKBZFKAM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> SBYUTKNJKUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> TPNSDQJFVPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> TBJKRZWWUPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> QCDEMPQFFBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool VYFQZHHNBDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> KEFVWRVFBGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<JNIVCIZIPSX, Dictionary<string, object>> FPMKFQFEHYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> IXWZSZOCCFM;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> DNJFIWMKIFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int CKMVYADUYJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract JNIVCIZIPSX HPFZNTESQRE
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool AUXCIJXMVYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool GYSDEQWHMQD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xCEBB90", Offset = "0xCEA590", VA = "0x180CEBB90", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool WJCYHWPRZIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xD2E420", Offset = "0xD2CE20", VA = "0x180D2E420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3B18F50", Offset = "0x3B17950", VA = "0x183B18F50", Slot = "12")]
		public void REPRDDNTUSL<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x997A180", Offset = "0x9978B80", VA = "0x18997A180", Slot = "11")]
		public void BMDYWOMVLDM(JNIVCIZIPSX a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x997BEE0", Offset = "0x997A8E0", VA = "0x18997BEE0", Slot = "9")]
		public object XOLUVPEUUNY(JNIVCIZIPSX a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x997BFD0", Offset = "0x997A9D0", VA = "0x18997BFD0", Slot = "10")]
		public void XVLRBMXBFXK(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x997B3E0", Offset = "0x9979DE0", VA = "0x18997B3E0", Slot = "8")]
		public object MEEQOUGEIRG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x997AD50", Offset = "0x9979750", VA = "0x18997AD50", Slot = "13")]
		public void KKTAAVPLUYF(JNIVCIZIPSX a, string b, QPOMEWQYEQO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x997B6B0", Offset = "0x997A0B0", VA = "0x18997B6B0", Slot = "14")]
		public void OOEKGCJAFXW(JNIVCIZIPSX a, string b, QPOMEWQYEQO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9979BE0", Offset = "0x99785E0", VA = "0x189979BE0")]
		private void BDAONYUGHAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x997ABE0", Offset = "0x99795E0", VA = "0x18997ABE0")]
		private void JXEJOSJLLCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x997B650", Offset = "0x997A050", VA = "0x18997B650")]
		private void OAZKEMPTBOB(JNIVCIZIPSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x997AC30", Offset = "0x9979630", VA = "0x18997AC30")]
		protected void KKFVYLKEPNP(JNIVCIZIPSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x997AAF0", Offset = "0x99794F0", VA = "0x18997AAF0")]
		protected void FRVAVXWVKVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x997BCD0", Offset = "0x997A6D0", VA = "0x18997BCD0")]
		protected void WEUSWEDACHF(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x997BBD0", Offset = "0x997A5D0", VA = "0x18997BBD0")]
		protected void QGNQPKGLUUN(JNIVCIZIPSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x997A9D0", Offset = "0x99793D0", VA = "0x18997A9D0")]
		protected void EGADHTHBJZP(JNIVCIZIPSX a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9979C30", Offset = "0x9978630", VA = "0x189979C30")]
		private void BINQQTSJVFC(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x997BCE0", Offset = "0x997A6E0", VA = "0x18997BCE0")]
		private static void XKCWCWEVUEU(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x997A550", Offset = "0x9978F50", VA = "0x18997A550")]
		private static void CKDCXVSNWML(Dictionary<string, object> a, string b, QPOMEWQYEQO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x997B480", Offset = "0x9979E80", VA = "0x18997B480")]
		private static void MXNZPZVKSKC(Dictionary<string, object> a, string b, QPOMEWQYEQO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x997A770", Offset = "0x9979170", VA = "0x18997A770", Slot = "19")]
		public void CMULSMNIGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract void QCNXMFABQTD(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x997A0A0", Offset = "0x9978AA0", VA = "0x18997A0A0", Slot = "20")]
		public void BJPMKQMKZQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		protected abstract void ZDUJDJBAQFB(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x997B1C0", Offset = "0x9979BC0", VA = "0x18997B1C0")]
		private void LLGSNKOIFCS(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x997B960", Offset = "0x997A360", VA = "0x18997B960")]
		private void OSJWIKZHINZ(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x997AA60", Offset = "0x9979460", VA = "0x18997AA60")]
		public void FONETRENWAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x997C0F0", Offset = "0x997AAF0", VA = "0x18997C0F0")]
		public void YJQMCHIZGDG(JNIVCIZIPSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x997AE60", Offset = "0x9979860", VA = "0x18997AE60")]
		public void KPWPOGKPFTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		protected abstract HashSet<int> GTLCPYFQBAF(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x997A2D0", Offset = "0x9978CD0", VA = "0x18997A2D0", Slot = "21")]
		public void CFROENWGNAZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x997BC40", Offset = "0x997A640", VA = "0x18997BC40")]
		protected string SOOMCABFMPG(JNIVCIZIPSX a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "32")]
		public abstract object JNFCTUUYGUB<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "33")]
		public abstract c EWNGHYBZNWE<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "34")]
		public abstract object JNFCTUUYGUB(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "35")]
		public abstract object EWNGHYBZNWE(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "36")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x997A870", Offset = "0x9979270", VA = "0x18997A870", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xCD14C0", Offset = "0xCCFEC0", VA = "0x180CD14C0", Slot = "37")]
		protected virtual void BRKNCCSWHSA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x997C1C0", Offset = "0x997ABC0", VA = "0x18997C1C0")]
		protected HQKOEQLMDOE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class HLATNSVUQNW<a> : QPOMEWQYEQO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a RJIIGJQVGZL;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a YXUIATPUHGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x64E7490", Offset = "0x64E5E90", VA = "0x1864E7490", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x64E7200", Offset = "0x64E5C00", VA = "0x1864E7200", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object DRRYLFOYJRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x64EE160", Offset = "0x64ECB60", VA = "0x1864EE160", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x64ED8B0", Offset = "0x64EC2B0", VA = "0x1864ED8B0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x64E7660", Offset = "0x64E6060", VA = "0x1864E7660", Slot = "9")]
		protected override bool PQFWYVDNDFR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x64F1600", Offset = "0x64F0000", VA = "0x1864F1600")]
		protected HLATNSVUQNW([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x64EF8E0", Offset = "0x64EE2E0", VA = "0x1864EF8E0")]
		protected HLATNSVUQNW(JNIVCIZIPSX a, CIZSGDLSXXQ b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, CHMQKBZFKAM h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x5466F50", Offset = "0x5465950", VA = "0x185466F50")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x64ECEE0", Offset = "0x64EB8E0", VA = "0x1864ECEE0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x64EA6C0", Offset = "0x64E90C0", VA = "0x1864EA6C0")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class HLQOFNDMSVX<a, b> : QPOMEWQYEQO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a RJIIGJQVGZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b RISNOPJDERK;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a YXUIATPUHGG
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x10CADC0", Offset = "0x10C97C0", VA = "0x1810CADC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x12B2A70", Offset = "0x12B1470", VA = "0x1812B2A70", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b YXPBDMVWXUX
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x327D300", Offset = "0x327BD00", VA = "0x18327D300", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x64FC610", Offset = "0x64FB010", VA = "0x1864FC610", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b YHEPZUHMJGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x1714D50", Offset = "0x1713750", VA = "0x181714D50")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object DRRYLFOYJRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x64EE160", Offset = "0x64ECB60", VA = "0x1864EE160", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x65056A0", Offset = "0x65040A0", VA = "0x1865056A0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x64FF200", Offset = "0x64FDC00", VA = "0x1864FF200", Slot = "9")]
		protected override bool PQFWYVDNDFR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x65091E0", Offset = "0x6507BE0", VA = "0x1865091E0")]
		protected HLQOFNDMSVX([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6506F20", Offset = "0x6505920", VA = "0x186506F20")]
		protected HLQOFNDMSVX(JNIVCIZIPSX a, CIZSGDLSXXQ b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, CHMQKBZFKAM i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5466F50", Offset = "0x5465950", VA = "0x185466F50")]
		public a XGTJZRBSFRV()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x64FD0D0", Offset = "0x64FBAD0", VA = "0x1864FD0D0")]
		public void LGRLPVKHCQH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x1714D50", Offset = "0x1713750", VA = "0x181714D50")]
		public b XGYQWXVPPDE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x64FD290", Offset = "0x64FBC90", VA = "0x1864FD290")]
		public void LGWSNCEEMBQ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x65005D0", Offset = "0x64FEFD0", VA = "0x1865005D0")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class HLLHIGJPJKO<a, b, c> : QPOMEWQYEQO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a RJIIGJQVGZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b RISNOPJDERK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c RIXULWDAOCT;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a YXUIATPUHGG
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xCE2D70", Offset = "0xCE1770", VA = "0x180CE2D70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xCE2C40", Offset = "0xCE1640", VA = "0x180CE2C40", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b YXPBDMVWXUX
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xEAEDE0", Offset = "0xEAD7E0", VA = "0x180EAEDE0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2AADDF0", Offset = "0x2AAC7F0", VA = "0x182AADDF0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c YXJUGGBZOJO
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCDB1B0", Offset = "0xCD9BB0", VA = "0x180CDB1B0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xCDB340", Offset = "0xCD9D40", VA = "0x180CDB340", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a YHJWXBBJSRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5466F50", Offset = "0x5465950", VA = "0x185466F50")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b YHEPZUHMJGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x1714D50", Offset = "0x1713750", VA = "0x181714D50")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c YGZJCNNOZVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x64F1A30", Offset = "0x64F0430", VA = "0x1864F1A30")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object DRRYLFOYJRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x64EE160", Offset = "0x64ECB60", VA = "0x1864EE160", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x64F8450", Offset = "0x64F6E50", VA = "0x1864F8450", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x64F3B50", Offset = "0x64F2550", VA = "0x1864F3B50", Slot = "9")]
		protected override bool PQFWYVDNDFR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x64F9A80", Offset = "0x64F8480", VA = "0x1864F9A80")]
		protected HLLHIGJPJKO([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x64FB670", Offset = "0x64FA070", VA = "0x1864FB670")]
		protected HLLHIGJPJKO(JNIVCIZIPSX a, CIZSGDLSXXQ b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, CHMQKBZFKAM j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5466F50", Offset = "0x5465950", VA = "0x185466F50")]
		public a XGTJZRBSFRV()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x64F2130", Offset = "0x64F0B30", VA = "0x1864F2130")]
		public void LGRLPVKHCQH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x1714D50", Offset = "0x1713750", VA = "0x181714D50")]
		public b XGYQWXVPPDE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x64F2BF0", Offset = "0x64F15F0", VA = "0x1864F2BF0")]
		public void LGWSNCEEMBQ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x64F1A30", Offset = "0x64F0430", VA = "0x1864F1A30")]
		public c XHDXUEPMYON()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x64F30E0", Offset = "0x64F1AE0", VA = "0x1864F30E0")]
		public void LHBZKIYBVMZ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x64F6AE0", Offset = "0x64F54E0", VA = "0x1864F6AE0")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class HMBCAARHLSP<a, b, c, d> : QPOMEWQYEQO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a RJIIGJQVGZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b RISNOPJDERK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c RIXULWDAOCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d RIHZUBVILUS;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a YXUIATPUHGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xF4F610", Offset = "0xF4E010", VA = "0x180F4F610", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6528680", Offset = "0x6527080", VA = "0x186528680", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b YXPBDMVWXUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1474B10", Offset = "0x1473510", VA = "0x181474B10", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1471560", Offset = "0x146FF60", VA = "0x181471560", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c YXJUGGBZOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x15104E0", Offset = "0x150EEE0", VA = "0x1815104E0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6531890", Offset = "0x6530290", VA = "0x186531890", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d YYUQNBLHCKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1D3AA00", Offset = "0x1D39400", VA = "0x181D3AA00", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x165F960", Offset = "0x165E360", VA = "0x18165F960", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b YHEPZUHMJGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x64F1910", Offset = "0x64F0310", VA = "0x1864F1910")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c YGZJCNNOZVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x64F1A90", Offset = "0x64F0490", VA = "0x1864F1A90")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d YIKFJIWWNWN
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x15BA2A0", Offset = "0x15B8CA0", VA = "0x1815BA2A0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object DRRYLFOYJRR
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x64EE160", Offset = "0x64ECB60", VA = "0x1864EE160", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x6538F90", Offset = "0x6537990", VA = "0x186538F90", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6535A50", Offset = "0x6534450", VA = "0x186535A50", Slot = "9")]
		protected override bool PQFWYVDNDFR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x653C850", Offset = "0x653B250", VA = "0x18653C850")]
		protected HMBCAARHLSP([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x653AB40", Offset = "0x6539540", VA = "0x18653AB40")]
		protected HMBCAARHLSP(JNIVCIZIPSX a, CIZSGDLSXXQ b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, CHMQKBZFKAM k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5466F50", Offset = "0x5465950", VA = "0x185466F50")]
		public a XGTJZRBSFRV()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x6532AF0", Offset = "0x65314F0", VA = "0x186532AF0")]
		public void LGRLPVKHCQH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x64F1910", Offset = "0x64F0310", VA = "0x1864F1910")]
		public b XGYQWXVPPDE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6533670", Offset = "0x6532070", VA = "0x186533670")]
		public void LGWSNCEEMBQ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x64F1A90", Offset = "0x64F0490", VA = "0x1864F1A90")]
		public c XHDXUEPMYON()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x6533950", Offset = "0x6532350", VA = "0x186533950")]
		public void LHBZKIYBVMZ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15BA2A0", Offset = "0x15B8CA0", VA = "0x1815BA2A0")]
		public d XHJERLJKHZW()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x65322C0", Offset = "0x6530CC0", VA = "0x1865322C0")]
		public void LFRDDNOUHLO(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x65386F0", Offset = "0x65370F0", VA = "0x1865386F0")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class HLVVCTXKCHG<a, b, c, d, e> : QPOMEWQYEQO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a RJIIGJQVGZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b RISNOPJDERK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c RIXULWDAOCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d RIHZUBVILUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e RINGRIPFVGB;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a YXUIATPUHGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xCE2D70", Offset = "0xCE1770", VA = "0x180CE2D70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xCE2C40", Offset = "0xCE1640", VA = "0x180CE2C40", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b YXPBDMVWXUX
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xDE68B0", Offset = "0xDE52B0", VA = "0x180DE68B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x148B700", Offset = "0x148A100", VA = "0x18148B700", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c YXJUGGBZOJO
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xDDC890", Offset = "0xDDB290", VA = "0x180DDC890", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xDDCC00", Offset = "0xDDB600", VA = "0x180DDCC00", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d YYUQNBLHCKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xCEBF60", Offset = "0xCEA960", VA = "0x180CEBF60", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xCFBCF0", Offset = "0xCFA6F0", VA = "0x180CFBCF0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e YYPJPURJSZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xCEBBA0", Offset = "0xCEA5A0", VA = "0x180CEBBA0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x65283E0", Offset = "0x6526DE0", VA = "0x1865283E0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object DRRYLFOYJRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x64EE160", Offset = "0x64ECB60", VA = "0x1864EE160", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x652EB30", Offset = "0x652D530", VA = "0x18652EB30", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x652AF10", Offset = "0x6529910", VA = "0x18652AF10", Slot = "9")]
		protected override bool PQFWYVDNDFR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6530690", Offset = "0x652F090", VA = "0x186530690")]
		protected HLVVCTXKCHG(JNIVCIZIPSX a, CIZSGDLSXXQ b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, CHMQKBZFKAM l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5466F50", Offset = "0x5465950", VA = "0x185466F50")]
		public a XGTJZRBSFRV()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6529550", Offset = "0x6527F50", VA = "0x186529550")]
		public void LGRLPVKHCQH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x1714D50", Offset = "0x1713750", VA = "0x181714D50")]
		public b XGYQWXVPPDE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6529DD0", Offset = "0x65287D0", VA = "0x186529DD0")]
		public void LGWSNCEEMBQ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x64F1A30", Offset = "0x64F0430", VA = "0x1864F1A30")]
		public c XHDXUEPMYON()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x652A980", Offset = "0x6529380", VA = "0x18652A980")]
		public void LHBZKIYBVMZ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x15BA2A0", Offset = "0x15B8CA0", VA = "0x1815BA2A0")]
		public d XHJERLJKHZW()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6528C00", Offset = "0x6527600", VA = "0x186528C00")]
		public void LFRDDNOUHLO(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x652FAD0", Offset = "0x652E4D0", VA = "0x18652FAD0")]
		public e XHOLOSDHRLF()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x6528FF0", Offset = "0x65279F0", VA = "0x186528FF0")]
		public void LFWKAUIRQWX(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x652C870", Offset = "0x652B270", VA = "0x18652C870")]
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
