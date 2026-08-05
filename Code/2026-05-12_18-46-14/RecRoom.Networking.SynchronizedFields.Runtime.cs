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
			[Cpp2IlInjected.Address(RVA = "0xFB0030", Offset = "0xFAEA30", VA = "0x180FB0030", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DVAXSKXABBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x63E7290", Offset = "0x63E5C90", VA = "0x1863E7290", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a OPCYQAJFYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x63E6240", Offset = "0x63E4C40", VA = "0x1863E6240", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x63E8AF0", Offset = "0x63E74F0", VA = "0x1863E8AF0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a PEBEEAIWOZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x63E5CB0", Offset = "0x63E46B0", VA = "0x1863E5CB0", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x63E5ED0", Offset = "0x63E48D0", VA = "0x1863E5ED0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a YSLRVNQQVPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x63E5CB0", Offset = "0x63E46B0", VA = "0x1863E5CB0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x63E45E0", Offset = "0x63E2FE0", VA = "0x1863E45E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool YSNORTLCSYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x63E5C90", Offset = "0x63E4690", VA = "0x1863E5C90", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x63E5C30", Offset = "0x63E4630", VA = "0x1863E5C30", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x63E7AF0", Offset = "0x63E64F0", VA = "0x1863E7AF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x63E6CD0", Offset = "0x63E56D0", VA = "0x1863E6CD0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x63E8CA0", Offset = "0x63E76A0", VA = "0x1863E8CA0")]
		public FHUCOZRPXTW([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x63E6570", Offset = "0x63E4F70", VA = "0x1863E6570")]
		private void NDTHSFXGHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x63E5750", Offset = "0x63E4150", VA = "0x1863E5750", Slot = "5")]
		public void DORCTRMGYGM(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x63E5450", Offset = "0x63E3E50", VA = "0x1863E5450")]
		public void DORCTRMGYGM(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x63E5C50", Offset = "0x63E4650", VA = "0x1863E5C50", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xFB0030", Offset = "0xFAEA30", VA = "0x180FB0030", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DVAXSKXABBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x63F84D0", Offset = "0x63F6ED0", VA = "0x1863F84D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool OWXEQTZLRVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x63F3A10", Offset = "0x63F2410", VA = "0x1863F3A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool OWRXTNFOIKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x63F3760", Offset = "0x63F2160", VA = "0x1863F3760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) OPCYQAJFYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63F66F0", Offset = "0x63F50F0", VA = "0x1863F66F0", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x63F91C0", Offset = "0x63F7BC0", VA = "0x1863F91C0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) PEBEEAIWOZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x63F7890", Offset = "0x63F6290", VA = "0x1863F7890", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x63F5FA0", Offset = "0x63F49A0", VA = "0x1863F5FA0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) YSLRVNQQVPD
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x63F5DB0", Offset = "0x63F47B0", VA = "0x1863F5DB0")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x63F4190", Offset = "0x63F2B90", VA = "0x1863F4190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a KQKMCTTYZER
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63F6990", Offset = "0x63F5390", VA = "0x1863F6990")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x63F50A0", Offset = "0x63F3AA0", VA = "0x1863F50A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a VEJPYWVTEKM
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x63F71B0", Offset = "0x63F5BB0", VA = "0x1863F71B0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x63F3410", Offset = "0x63F1E10", VA = "0x1863F3410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a CCWBTCWQKHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63F71B0", Offset = "0x63F5BB0", VA = "0x1863F71B0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x63F4B60", Offset = "0x63F3560", VA = "0x1863F4B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b KPURKZMGWWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x63F70B0", Offset = "0x63F5AB0", VA = "0x1863F70B0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x63F5770", Offset = "0x63F4170", VA = "0x1863F5770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b VEZKQRDLGSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x63F7370", Offset = "0x63F5D70", VA = "0x1863F7370")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b CDLWKXEIMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x63F7370", Offset = "0x63F5D70", VA = "0x1863F7370")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x63F4AC0", Offset = "0x63F34C0", VA = "0x1863F4AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool YSNORTLCSYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x63E5C90", Offset = "0x63E4690", VA = "0x1863E5C90", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x63E5C30", Offset = "0x63E4630", VA = "0x1863E5C30", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63F81E0", Offset = "0x63F6BE0", VA = "0x1863F81E0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x63F9B00", Offset = "0x63F8500", VA = "0x1863F9B00")]
		public FIJXGTZIABX([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x63F6B30", Offset = "0x63F5530", VA = "0x1863F6B30")]
		private void NDTHSFXGHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x63F7B80", Offset = "0x63F6580", VA = "0x1863F7B80")]
		public void RKNNZKVIWKF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x63F4490", Offset = "0x63F2E90", VA = "0x1863F4490")]
		public void DORCTRMGYGM(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x63F4060", Offset = "0x63F2A60", VA = "0x1863F4060", Slot = "5")]
		private void CRPWIAUWOET((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x63E5C50", Offset = "0x63E4650", VA = "0x1863E5C50", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xFB0030", Offset = "0xFAEA30", VA = "0x180FB0030", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool DVAXSKXABBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x63EED80", Offset = "0x63ED780", VA = "0x1863EED80", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool OWXEQTZLRVQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x63EB800", Offset = "0x63EA200", VA = "0x1863EB800")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool OWRXTNFOIKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x63EB300", Offset = "0x63E9D00", VA = "0x1863EB300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool OWMQWGLQYYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x63EB720", Offset = "0x63EA120", VA = "0x1863EB720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) OPCYQAJFYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x63ED4D0", Offset = "0x63EBED0", VA = "0x1863ED4D0", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x63EF7F0", Offset = "0x63EE1F0", VA = "0x1863EF7F0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) PEBEEAIWOZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x63EDFF0", Offset = "0x63EC9F0", VA = "0x1863EDFF0", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x63ED000", Offset = "0x63EBA00", VA = "0x1863ED000", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a KQKMCTTYZER
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x63ED5C0", Offset = "0x63EBFC0", VA = "0x1863ED5C0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x63EC430", Offset = "0x63EAE30", VA = "0x1863EC430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a VEJPYWVTEKM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x63EDC60", Offset = "0x63EC660", VA = "0x1863EDC60")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a CCWBTCWQKHG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x63EDC60", Offset = "0x63EC660", VA = "0x1863EDC60")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x63EC390", Offset = "0x63EAD90", VA = "0x1863EC390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b KPURKZMGWWQ
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x63EDB80", Offset = "0x63EC580", VA = "0x1863EDB80")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x63ECBC0", Offset = "0x63EB5C0", VA = "0x1863ECBC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b VEZKQRDLGSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x63EDDF0", Offset = "0x63EC7F0", VA = "0x1863EDDF0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b CDLWKXEIMPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x63EDDF0", Offset = "0x63EC7F0", VA = "0x1863EDDF0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x63EBEB0", Offset = "0x63EA8B0", VA = "0x1863EBEB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c KPZYIGGEGHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x63EDB50", Offset = "0x63EC550", VA = "0x1863EDB50")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x63EC720", Offset = "0x63EB120", VA = "0x1863EC720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c VEUDTKJNXHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x63EDED0", Offset = "0x63EC8D0", VA = "0x1863EDED0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c CDGPNQKLDDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x63EDED0", Offset = "0x63EC8D0", VA = "0x1863EDED0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x63EC170", Offset = "0x63EAB70", VA = "0x1863EC170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool YSNORTLCSYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x63E5C90", Offset = "0x63E4690", VA = "0x1863E5C90", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x63EE7F0", Offset = "0x63ED1F0", VA = "0x1863EE7F0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x63F01E0", Offset = "0x63EEBE0", VA = "0x1863F01E0")]
		public FIEQJNFKQQO([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x63ED6A0", Offset = "0x63EC0A0", VA = "0x1863ED6A0")]
		private void NDTHSFXGHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x63EE730", Offset = "0x63ED130", VA = "0x1863EE730")]
		public void RKNNZKVIWKF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x63EAF40", Offset = "0x63E9940", VA = "0x1863EAF40")]
		public void BEAQZRHNTQW(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x63EAB80", Offset = "0x63E9580", VA = "0x1863EAB80")]
		public void AHHBWJQEKZR(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x63EBAF0", Offset = "0x63EA4F0", VA = "0x1863EBAF0")]
		public void DORCTRMGYGM(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x63EED20", Offset = "0x63ED720", VA = "0x1863EED20", Slot = "5")]
		private void SAZEYIGPLDS((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x63E5C50", Offset = "0x63E4650", VA = "0x1863E5C50", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0xFB0030", Offset = "0xFAEA30", VA = "0x180FB0030", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) PEBEEAIWOZX
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x63FB6F0", Offset = "0x63FA0F0", VA = "0x1863FB6F0", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x63FB050", Offset = "0x63F9A50", VA = "0x1863FB050", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b VEZKQRDLGSN
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x63FB500", Offset = "0x63F9F00", VA = "0x1863FB500")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c VEUDTKJNXHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x63FB5E0", Offset = "0x63F9FE0", VA = "0x1863FB5E0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d VFJYLERFZPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x63FB610", Offset = "0x63FA010", VA = "0x1863FB610")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool YSNORTLCSYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x63E5C90", Offset = "0x63E4690", VA = "0x1863E5C90", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x63E5C30", Offset = "0x63E4630", VA = "0x1863E5C30", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x63FCAB0", Offset = "0x63FB4B0", VA = "0x1863FCAB0")]
		public FIULBHNCSYP([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x63FB340", Offset = "0x63F9D40", VA = "0x1863FB340")]
		private void NDTHSFXGHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x63FBED0", Offset = "0x63FA8D0", VA = "0x1863FBED0")]
		public void RKNNZKVIWKF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x63FAC10", Offset = "0x63F9610", VA = "0x1863FAC10")]
		public void DORCTRMGYGM(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x63FBFC0", Offset = "0x63FA9C0", VA = "0x1863FBFC0", Slot = "5")]
		private void SIJRILQWLZE((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x63E5C50", Offset = "0x63E4650", VA = "0x1863E5C50", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x9ADBF10", Offset = "0x9ADA910", VA = "0x189ADBF10")]
		public static string KBKMIUPKXYI(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xD75790", Offset = "0xD74190", VA = "0x180D75790")]
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
		[Cpp2IlInjected.Address(RVA = "0x8027CE0", Offset = "0x80266E0", VA = "0x188027CE0")]
		public VLUPMVMSGQJ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8024110", Offset = "0x8022B10", VA = "0x188024110")]
		public VLUPMVMSGQJ(CIZSGDLSXXQ a, JNIVCIZIPSX b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] CHMQKBZFKAM g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8027660", Offset = "0x8026060", VA = "0x188027660")]
		public VLUPMVMSGQJ(CIZSGDLSXXQ a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] CHMQKBZFKAM f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8025780", Offset = "0x8024180", VA = "0x188025780")]
		public VLUPMVMSGQJ(CIZSGDLSXXQ a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] CHMQKBZFKAM g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class VLEUVBFAEII<a, b> : HLQOFNDMSVX<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x801EBA0", Offset = "0x801D5A0", VA = "0x18801EBA0")]
		public VLEUVBFAEII([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x801D560", Offset = "0x801BF60", VA = "0x18801D560")]
		public VLEUVBFAEII(CIZSGDLSXXQ a, JNIVCIZIPSX b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] CHMQKBZFKAM h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x801CDE0", Offset = "0x801B7E0", VA = "0x18801CDE0")]
		public VLEUVBFAEII(CIZSGDLSXXQ a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] CHMQKBZFKAM g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x801E0C0", Offset = "0x801CAC0", VA = "0x18801E0C0")]
		public VLEUVBFAEII(CIZSGDLSXXQ a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] CHMQKBZFKAM h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class VLKBSHYXNTR<a, b, c> : HLLHIGJPJKO<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8023110", Offset = "0x8021B10", VA = "0x188023110")]
		public VLKBSHYXNTR([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8023620", Offset = "0x8022020", VA = "0x188023620")]
		public VLKBSHYXNTR(CIZSGDLSXXQ a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] CHMQKBZFKAM h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class VMKKEPUKIYK<a, b, c, d> : HMBCAARHLSP<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8029280", Offset = "0x8027C80", VA = "0x188029280")]
		public VMKKEPUKIYK([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x80289D0", Offset = "0x80273D0", VA = "0x1880289D0")]
		public VMKKEPUKIYK(CIZSGDLSXXQ a, JNIVCIZIPSX b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] CHMQKBZFKAM j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x802A5C0", Offset = "0x8028FC0", VA = "0x18802A5C0")]
		public VMKKEPUKIYK(CIZSGDLSXXQ a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] CHMQKBZFKAM i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class VMPRBWOHSJT<a, b, c, d, e> : HLVVCTXKCHG<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x802A850", Offset = "0x8029250", VA = "0x18802A850")]
		public VMPRBWOHSJT(CIZSGDLSXXQ a, JNIVCIZIPSX b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] CHMQKBZFKAM k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x802AF20", Offset = "0x8029920", VA = "0x18802AF20")]
		public VMPRBWOHSJT(CIZSGDLSXXQ a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] CHMQKBZFKAM j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class VPEHBKURMFI<a> : HLATNSVUQNW<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x802F1C0", Offset = "0x802DBC0", VA = "0x18802F1C0")]
		public VPEHBKURMFI(JNIVCIZIPSX a, string b, a c, [Optional] Action d, [Optional] CHMQKBZFKAM e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class VOZAEEAUCTZ<a, b> : HLQOFNDMSVX<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x802EDC0", Offset = "0x802D7C0", VA = "0x18802EDC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD0DA70", Offset = "0xD0C470", VA = "0x180D0DA70")]
		public UAVGAGEATJR(CHMQKBZFKAM a, CIZSGDLSXXQ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x409F660", Offset = "0x409E060", VA = "0x18409F660", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AE0260", Offset = "0x9ADEC60", VA = "0x189AE0260")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AE0050", Offset = "0x9ADEA50", VA = "0x189AE0050")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9AE00D0", Offset = "0x9ADEAD0", VA = "0x189AE00D0")]
		public SyncData(CIZSGDLSXXQ context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] CHMQKBZFKAM networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9AE0000", Offset = "0x9ADEA00", VA = "0x189AE0000")]
		public static SyncData From(CIZSGDLSXXQ context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] CHMQKBZFKAM networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class PYYKKTMDHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D993C0", Offset = "0x3D97DC0", VA = "0x183D993C0")]
		public static VLUPMVMSGQJ<a> QPOMEWQYEQO<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D989B0", Offset = "0x3D973B0", VA = "0x183D989B0")]
		public static VLEUVBFAEII<b, c> QPOMEWQYEQO<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3D98A50", Offset = "0x3D97450", VA = "0x183D98A50")]
		public static VLKBSHYXNTR<d, e, f> QPOMEWQYEQO<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3D98E70", Offset = "0x3D97870", VA = "0x183D98E70")]
		public static VMKKEPUKIYK<g, h, i, j> QPOMEWQYEQO<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3D979C0", Offset = "0x3D963C0", VA = "0x183D979C0")]
		public static FHUCOZRPXTW<k> OTDLLCUKOZB<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3D97870", Offset = "0x3D96270", VA = "0x183D97870")]
		public static FIJXGTZIABX<l, m> OTDLLCUKOZB<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3D97910", Offset = "0x3D96310", VA = "0x183D97910")]
		public static FIEQJNFKQQO<n, o, p> OTDLLCUKOZB<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3D983C0", Offset = "0x3D96DC0", VA = "0x183D983C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9ADF830", Offset = "0x9ADE230", VA = "0x189ADF830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool YWFAPUGNDFS
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9ADF5F0", Offset = "0x9ADDFF0", VA = "0x189ADF5F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9ADEA10", Offset = "0x9ADD410", VA = "0x189ADEA10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool CJEVASSGRXV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x9ADFCD0", Offset = "0x9ADE6D0", VA = "0x189ADFCD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x9ADEED0", Offset = "0x9ADD8D0", VA = "0x189ADEED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool XJRAGXQLVCK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x9ADEAF0", Offset = "0x9ADD4F0", VA = "0x189ADEAF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x9ADF330", Offset = "0x9ADDD30", VA = "0x189ADF330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool YSNORTLCSYV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x9ADEC70", Offset = "0x9ADD670", VA = "0x189ADEC70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9ADEA30", Offset = "0x9ADD430", VA = "0x189ADEA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object DRRYLFOYJRR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xD10CF0", Offset = "0xD0F6F0", VA = "0x180D10CF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xD106A0", Offset = "0xD0F0A0", VA = "0x180D106A0", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool QDCQLTFWCIW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x9ADF350", Offset = "0x9ADDD50", VA = "0x189ADF350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int MCLKUHQCRTH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xEFA630", Offset = "0xEF9030", VA = "0x180EFA630")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x1AC8070", Offset = "0x1AC6A70", VA = "0x181AC8070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string AZSKTLMZSBZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool KNEWBKQPCIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x9ADF970", Offset = "0x9ADE370", VA = "0x189ADF970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF0C0", Offset = "0x9ADDAC0", VA = "0x189ADF0C0")]
		public static void JCTVPPTCXBP(CHMQKBZFKAM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool PQFWYVDNDFR();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9ADFDE0", Offset = "0x9ADE7E0", VA = "0x189ADFDE0")]
		protected QPOMEWQYEQO(JNIVCIZIPSX a, CIZSGDLSXXQ b, string c, NetworkSetterPermissionMode d, Action e, CHMQKBZFKAM f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x9ADEC80", Offset = "0x9ADD680", VA = "0x189ADEC80", Slot = "1")]
		~QPOMEWQYEQO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x9ADEB00", Offset = "0x9ADD500", VA = "0x189ADEB00", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x9ADE8F0", Offset = "0x9ADD2F0", VA = "0x189ADE8F0")]
		private void AVVNBTQOTNT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF1C0", Offset = "0x9ADDBC0", VA = "0x189ADF1C0")]
		private object JQJHVELVILR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9ADEEF0", Offset = "0x9ADD8F0", VA = "0x189ADEEF0")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF930", Offset = "0x9ADE330", VA = "0x189ADF930")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF3A0", Offset = "0x9ADDDA0", VA = "0x189ADF3A0")]
		protected void KNLLTZMWXQA(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9ADE990", Offset = "0x9ADD390", VA = "0x189ADE990")]
		internal void AZBCXZQNDYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF160", Offset = "0x9ADDB60", VA = "0x189ADF160")]
		private void JFEREFUXWOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9ADFC70", Offset = "0x9ADE670", VA = "0x189ADFC70")]
		private void WLPLAFIHLVZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9ADFCE0", Offset = "0x9ADE6E0", VA = "0x189ADFCE0", Slot = "4")]
		private void ZKPWRGVAXUL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF630", Offset = "0x9ADE030", VA = "0x189ADF630", Slot = "5")]
		private void NBCLRAZZQTS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF640", Offset = "0x9ADE040", VA = "0x189ADF640")]
		public bool NUESHVAAUKI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9ADE730", Offset = "0x9ADD130", VA = "0x189ADE730")]
		public bool ARIQEFXXHBQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9ADFB20", Offset = "0x9ADE520", VA = "0x189ADFB20")]
		private bool WKDCHMIACOF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF780", Offset = "0x9ADE180", VA = "0x189ADF780")]
		internal void NVXRAZBQPMW(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9ADECE0", Offset = "0x9ADD6E0", VA = "0x189ADECE0")]
		private void GZVZLBHWNUK(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF600", Offset = "0x9ADE000", VA = "0x189ADF600")]
		private bool MFCVNDNHJSS(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF610", Offset = "0x9ADE010", VA = "0x189ADF610")]
		private void MUILLMWPCOK(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF8A0", Offset = "0x9ADE2A0", VA = "0x189ADF8A0")]
		public static string SOOMCABFMPG(JNIVCIZIPSX a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9ADEDF0", Offset = "0x9ADD7F0", VA = "0x189ADEDF0")]
		public static string HABPSKKWKPO(CIZSGDLSXXQ a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9ADF9C0", Offset = "0x9ADE3C0", VA = "0x189ADF9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD24D80", Offset = "0xD23780", VA = "0x180D24D80", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool WJCYHWPRZIP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xD677E0", Offset = "0xD661E0", VA = "0x180D677E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3B2D0E0", Offset = "0x3B2BAE0", VA = "0x183B2D0E0", Slot = "12")]
		public void REPRDDNTUSL<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9ADC500", Offset = "0x9ADAF00", VA = "0x189ADC500", Slot = "11")]
		public void BMDYWOMVLDM(JNIVCIZIPSX a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9ADE260", Offset = "0x9ADCC60", VA = "0x189ADE260", Slot = "9")]
		public object XOLUVPEUUNY(JNIVCIZIPSX a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9ADE350", Offset = "0x9ADCD50", VA = "0x189ADE350", Slot = "10")]
		public void XVLRBMXBFXK(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD760", Offset = "0x9ADC160", VA = "0x189ADD760", Slot = "8")]
		public object MEEQOUGEIRG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD0D0", Offset = "0x9ADBAD0", VA = "0x189ADD0D0", Slot = "13")]
		public void KKTAAVPLUYF(JNIVCIZIPSX a, string b, QPOMEWQYEQO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9ADDA30", Offset = "0x9ADC430", VA = "0x189ADDA30", Slot = "14")]
		public void OOEKGCJAFXW(JNIVCIZIPSX a, string b, QPOMEWQYEQO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9ADBF50", Offset = "0x9ADA950", VA = "0x189ADBF50")]
		private void BDAONYUGHAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9ADCF60", Offset = "0x9ADB960", VA = "0x189ADCF60")]
		private void JXEJOSJLLCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD9D0", Offset = "0x9ADC3D0", VA = "0x189ADD9D0")]
		private void OAZKEMPTBOB(JNIVCIZIPSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9ADCFB0", Offset = "0x9ADB9B0", VA = "0x189ADCFB0")]
		protected void KKFVYLKEPNP(JNIVCIZIPSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9ADCE70", Offset = "0x9ADB870", VA = "0x189ADCE70")]
		protected void FRVAVXWVKVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9ADE050", Offset = "0x9ADCA50", VA = "0x189ADE050")]
		protected void WEUSWEDACHF(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9ADDF50", Offset = "0x9ADC950", VA = "0x189ADDF50")]
		protected void QGNQPKGLUUN(JNIVCIZIPSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9ADCD50", Offset = "0x9ADB750", VA = "0x189ADCD50")]
		protected void EGADHTHBJZP(JNIVCIZIPSX a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9ADBFA0", Offset = "0x9ADA9A0", VA = "0x189ADBFA0")]
		private void BINQQTSJVFC(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9ADE060", Offset = "0x9ADCA60", VA = "0x189ADE060")]
		private static void XKCWCWEVUEU(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9ADC8D0", Offset = "0x9ADB2D0", VA = "0x189ADC8D0")]
		private static void CKDCXVSNWML(Dictionary<string, object> a, string b, QPOMEWQYEQO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD800", Offset = "0x9ADC200", VA = "0x189ADD800")]
		private static void MXNZPZVKSKC(Dictionary<string, object> a, string b, QPOMEWQYEQO c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9ADCAF0", Offset = "0x9ADB4F0", VA = "0x189ADCAF0", Slot = "19")]
		public void CMULSMNIGUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract void QCNXMFABQTD(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9ADC420", Offset = "0x9ADAE20", VA = "0x189ADC420", Slot = "20")]
		public void BJPMKQMKZQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		protected abstract void ZDUJDJBAQFB(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD540", Offset = "0x9ADBF40", VA = "0x189ADD540")]
		private void LLGSNKOIFCS(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9ADDCE0", Offset = "0x9ADC6E0", VA = "0x189ADDCE0")]
		private void OSJWIKZHINZ(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9ADCDE0", Offset = "0x9ADB7E0", VA = "0x189ADCDE0")]
		public void FONETRENWAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9ADE470", Offset = "0x9ADCE70", VA = "0x189ADE470")]
		public void YJQMCHIZGDG(JNIVCIZIPSX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9ADD1E0", Offset = "0x9ADBBE0", VA = "0x189ADD1E0")]
		public void KPWPOGKPFTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		protected abstract HashSet<int> GTLCPYFQBAF(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9ADC650", Offset = "0x9ADB050", VA = "0x189ADC650", Slot = "21")]
		public void CFROENWGNAZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9ADDFC0", Offset = "0x9ADC9C0", VA = "0x189ADDFC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "36")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9ADCBF0", Offset = "0x9ADB5F0", VA = "0x189ADCBF0", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "37")]
		protected virtual void BRKNCCSWHSA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9ADE540", Offset = "0x9ADCF40", VA = "0x189ADE540")]
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
			[Cpp2IlInjected.Address(RVA = "0x65A59D0", Offset = "0x65A43D0", VA = "0x1865A59D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x65A5740", Offset = "0x65A4140", VA = "0x1865A5740", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object DRRYLFOYJRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x65ACB50", Offset = "0x65AB550", VA = "0x1865ACB50", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x65AC2E0", Offset = "0x65AACE0", VA = "0x1865AC2E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x65A5BB0", Offset = "0x65A45B0", VA = "0x1865A5BB0", Slot = "9")]
		protected override bool PQFWYVDNDFR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x65B0090", Offset = "0x65AEA90", VA = "0x1865B0090")]
		protected HLATNSVUQNW([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x65AE320", Offset = "0x65ACD20", VA = "0x1865AE320")]
		protected HLATNSVUQNW(JNIVCIZIPSX a, CIZSGDLSXXQ b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, CHMQKBZFKAM h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x54B4040", Offset = "0x54B2A40", VA = "0x1854B4040")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x65AB8B0", Offset = "0x65AA2B0", VA = "0x1865AB8B0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x65A9000", Offset = "0x65A7A00", VA = "0x1865A9000")]
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
			[Cpp2IlInjected.Address(RVA = "0x1112110", Offset = "0x1110B10", VA = "0x181112110", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x12E0670", Offset = "0x12DF070", VA = "0x1812E0670", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b YXPBDMVWXUX
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x32906F0", Offset = "0x328F0F0", VA = "0x1832906F0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x65BB410", Offset = "0x65B9E10", VA = "0x1865BB410", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b YHEPZUHMJGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x17675E0", Offset = "0x1765FE0", VA = "0x1817675E0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object DRRYLFOYJRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x65ACB50", Offset = "0x65AB550", VA = "0x1865ACB50", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x65BBF70", Offset = "0x65BA970", VA = "0x1865BBF70", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x65BB770", Offset = "0x65BA170", VA = "0x1865BB770", Slot = "9")]
		protected override bool PQFWYVDNDFR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x65BC510", Offset = "0x65BAF10", VA = "0x1865BC510")]
		protected HLQOFNDMSVX([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x65BC090", Offset = "0x65BAA90", VA = "0x1865BC090")]
		protected HLQOFNDMSVX(JNIVCIZIPSX a, CIZSGDLSXXQ b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, CHMQKBZFKAM i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x54B4040", Offset = "0x54B2A40", VA = "0x1854B4040")]
		public a XGTJZRBSFRV()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x65BB4A0", Offset = "0x65B9EA0", VA = "0x1865BB4A0")]
		public void LGRLPVKHCQH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x17675E0", Offset = "0x1765FE0", VA = "0x1817675E0")]
		public b XGYQWXVPPDE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x65BB510", Offset = "0x65B9F10", VA = "0x1865BB510")]
		public void LGWSNCEEMBQ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x65BB8C0", Offset = "0x65BA2C0", VA = "0x1865BB8C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1BD50", Offset = "0xD1A750", VA = "0x180D1BD50", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xD1BC20", Offset = "0xD1A620", VA = "0x180D1BC20", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b YXPBDMVWXUX
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xEFE9B0", Offset = "0xEFD3B0", VA = "0x180EFE9B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x2ACDC30", Offset = "0x2ACC630", VA = "0x182ACDC30", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c YXJUGGBZOJO
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xD141B0", Offset = "0xD12BB0", VA = "0x180D141B0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xD14340", Offset = "0xD12D40", VA = "0x180D14340", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a YHJWXBBJSRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x54B4040", Offset = "0x54B2A40", VA = "0x1854B4040")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b YHEPZUHMJGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x17675E0", Offset = "0x1765FE0", VA = "0x1817675E0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c YGZJCNNOZVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x65B04D0", Offset = "0x65AEED0", VA = "0x1865B04D0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object DRRYLFOYJRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x65ACB50", Offset = "0x65AB550", VA = "0x1865ACB50", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x65B71C0", Offset = "0x65B5BC0", VA = "0x1865B71C0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x65B2680", Offset = "0x65B1080", VA = "0x1865B2680", Slot = "9")]
		protected override bool PQFWYVDNDFR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x65B88A0", Offset = "0x65B72A0", VA = "0x1865B88A0")]
		protected HLLHIGJPJKO([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x65BA530", Offset = "0x65B8F30", VA = "0x1865BA530")]
		protected HLLHIGJPJKO(JNIVCIZIPSX a, CIZSGDLSXXQ b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, CHMQKBZFKAM j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x54B4040", Offset = "0x54B2A40", VA = "0x1854B4040")]
		public a XGTJZRBSFRV()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x65B0BF0", Offset = "0x65AF5F0", VA = "0x1865B0BF0")]
		public void LGRLPVKHCQH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x17675E0", Offset = "0x1765FE0", VA = "0x1817675E0")]
		public b XGYQWXVPPDE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x65B16D0", Offset = "0x65B00D0", VA = "0x1865B16D0")]
		public void LGWSNCEEMBQ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x65B04D0", Offset = "0x65AEED0", VA = "0x1865B04D0")]
		public c XHDXUEPMYON()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x65B1BE0", Offset = "0x65B05E0", VA = "0x1865B1BE0")]
		public void LHBZKIYBVMZ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x65B5790", Offset = "0x65B4190", VA = "0x1865B5790")]
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
			[Cpp2IlInjected.Address(RVA = "0xF76930", Offset = "0xF75330", VA = "0x180F76930", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x65C8F20", Offset = "0x65C7920", VA = "0x1865C8F20", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b YXPBDMVWXUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x149AEF0", Offset = "0x14998F0", VA = "0x18149AEF0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1497990", Offset = "0x1496390", VA = "0x181497990", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c YXJUGGBZOJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x1537300", Offset = "0x1535D00", VA = "0x181537300", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x65D25F0", Offset = "0x65D0FF0", VA = "0x1865D25F0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d YYUQNBLHCKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1D64C60", Offset = "0x1D63660", VA = "0x181D64C60", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x168FD30", Offset = "0x168E730", VA = "0x18168FD30", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b YHEPZUHMJGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x65B03B0", Offset = "0x65AEDB0", VA = "0x1865B03B0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c YGZJCNNOZVC
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x65B0530", Offset = "0x65AEF30", VA = "0x1865B0530")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d YIKFJIWWNWN
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x15CD940", Offset = "0x15CC340", VA = "0x1815CD940")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object DRRYLFOYJRR
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x65ACB50", Offset = "0x65AB550", VA = "0x1865ACB50", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x65DA060", Offset = "0x65D8A60", VA = "0x1865DA060", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x65D69B0", Offset = "0x65D53B0", VA = "0x1865D69B0", Slot = "9")]
		protected override bool PQFWYVDNDFR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x65DDAC0", Offset = "0x65DC4C0", VA = "0x1865DDAC0")]
		protected HMBCAARHLSP([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x65DBD20", Offset = "0x65DA720", VA = "0x1865DBD20")]
		protected HMBCAARHLSP(JNIVCIZIPSX a, CIZSGDLSXXQ b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, CHMQKBZFKAM k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x54B4040", Offset = "0x54B2A40", VA = "0x1854B4040")]
		public a XGTJZRBSFRV()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x65D38C0", Offset = "0x65D22C0", VA = "0x1865D38C0")]
		public void LGRLPVKHCQH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x65B03B0", Offset = "0x65AEDB0", VA = "0x1865B03B0")]
		public b XGYQWXVPPDE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x65D4490", Offset = "0x65D2E90", VA = "0x1865D4490")]
		public void LGWSNCEEMBQ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x65B0530", Offset = "0x65AEF30", VA = "0x1865B0530")]
		public c XHDXUEPMYON()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x65D4770", Offset = "0x65D3170", VA = "0x1865D4770")]
		public void LHBZKIYBVMZ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x15CD940", Offset = "0x15CC340", VA = "0x1815CD940")]
		public d XHJERLJKHZW()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x65D3050", Offset = "0x65D1A50", VA = "0x1865D3050")]
		public void LFRDDNOUHLO(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x65D97A0", Offset = "0x65D81A0", VA = "0x1865D97A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD1BD50", Offset = "0xD1A750", VA = "0x180D1BD50", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xD1BC20", Offset = "0xD1A620", VA = "0x180D1BC20", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b YXPBDMVWXUX
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xE1CB40", Offset = "0xE1B540", VA = "0x180E1CB40", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x14C9600", Offset = "0x14C8000", VA = "0x1814C9600", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c YXJUGGBZOJO
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xE2FFB0", Offset = "0xE2E9B0", VA = "0x180E2FFB0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xE30320", Offset = "0xE2ED20", VA = "0x180E30320", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d YYUQNBLHCKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD25150", Offset = "0xD23B50", VA = "0x180D25150", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xD35060", Offset = "0xD33A60", VA = "0x180D35060", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e YYPJPURJSZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xD24D90", Offset = "0xD23790", VA = "0x180D24D90", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x65C8C80", Offset = "0x65C7680", VA = "0x1865C8C80", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object DRRYLFOYJRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x65ACB50", Offset = "0x65AB550", VA = "0x1865ACB50", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x65CF770", Offset = "0x65CE170", VA = "0x1865CF770", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x65CB920", Offset = "0x65CA320", VA = "0x1865CB920", Slot = "9")]
		protected override bool PQFWYVDNDFR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x65D1380", Offset = "0x65CFD80", VA = "0x1865D1380")]
		protected HLVVCTXKCHG(JNIVCIZIPSX a, CIZSGDLSXXQ b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, CHMQKBZFKAM l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x54B4040", Offset = "0x54B2A40", VA = "0x1854B4040")]
		public a XGTJZRBSFRV()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x65C9E80", Offset = "0x65C8880", VA = "0x1865C9E80")]
		public void LGRLPVKHCQH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x17675E0", Offset = "0x1765FE0", VA = "0x1817675E0")]
		public b XGYQWXVPPDE()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x65CA730", Offset = "0x65C9130", VA = "0x1865CA730")]
		public void LGWSNCEEMBQ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x65B04D0", Offset = "0x65AEED0", VA = "0x1865B04D0")]
		public c XHDXUEPMYON()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x65CB330", Offset = "0x65C9D30", VA = "0x1865CB330")]
		public void LHBZKIYBVMZ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x15CD940", Offset = "0x15CC340", VA = "0x1815CD940")]
		public d XHJERLJKHZW()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x65C94D0", Offset = "0x65C7ED0", VA = "0x1865C94D0")]
		public void LFRDDNOUHLO(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x65D0790", Offset = "0x65CF190", VA = "0x1865D0790")]
		public e XHOLOSDHRLF()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x65C98E0", Offset = "0x65C82E0", VA = "0x1865C98E0")]
		public void LFWKAUIRQWX(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x65CD370", Offset = "0x65CBD70", VA = "0x1865CD370")]
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
