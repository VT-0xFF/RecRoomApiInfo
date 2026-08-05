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
	public interface SPLOTWJQNFG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool KOPZKLVCEIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool RVAGALPZPNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HNNNRVHBOIU HBUDJRHIPFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int PCXEAUQSUJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool ARXEAWQKOLU
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool XRRKWSSEHOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action HFTGNZTZUVV;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void VLLKUKSRNRI();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void MMHYMQJGSEY(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void JBYHRJQIRXA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface YWHCFYGBIDL : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string GBMCKJFKCKS
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool NCLRXXCLXKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface MSGVTBEDALQ<a> : YWHCFYGBIDL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a TSOJYCBIEXQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DBBZOHWCEPN(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class BGEKOOZVRBJ<a> : MSGVTBEDALQ<a>, YWHCFYGBIDL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly QWTRHDGVOIQ<a> DBWOPTTDZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly QWTRHDGVOIQ<a> AOKUUMCQGQB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string GBMCKJFKCKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xC7C110", Offset = "0xC7AD10", VA = "0x180C7C110", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NXVLIHQZAYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6D81C80", Offset = "0x6D80880", VA = "0x186D81C80", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a LVGYLMYNEVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6D83BF0", Offset = "0x6D827F0", VA = "0x186D83BF0", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6D82F00", Offset = "0x6D81B00", VA = "0x186D82F00", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a TSOJYCBIEXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6D81000", Offset = "0x6D7FC00", VA = "0x186D81000", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6D83A80", Offset = "0x6D82680", VA = "0x186D83A80", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a KBCQUAEOSXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6D81000", Offset = "0x6D7FC00", VA = "0x186D81000")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6D80B90", Offset = "0x6D7F790", VA = "0x186D80B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool NCLRXXCLXKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6CB8900", Offset = "0x6CB7500", VA = "0x186CB8900", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6CB8FC0", Offset = "0x6CB7BC0", VA = "0x186CB8FC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool GBDJMNVPWAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6D7F760", Offset = "0x6D7E360", VA = "0x186D7F760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D83700", Offset = "0x6D82300", VA = "0x186D83700", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6D84680", Offset = "0x6D83280", VA = "0x186D84680")]
		public BGEKOOZVRBJ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6D817D0", Offset = "0x6D803D0", VA = "0x186D817D0")]
		private void JBMXPXRLXTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6D7FEB0", Offset = "0x6D7EAB0", VA = "0x186D7FEB0", Slot = "5")]
		public void DBBZOHWCEPN(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6D7FC30", Offset = "0x6D7E830", VA = "0x186D7FC30")]
		public void DBBZOHWCEPN(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7CD0", Offset = "0x6CB68D0", VA = "0x186CB7CD0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class BGJRLVTTAMS<a, b> : MSGVTBEDALQ<(a, b)>, YWHCFYGBIDL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly QXJLYXONQQR<a, b> DBWOPTTDZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly QXJLYXONQQR<a, b> AOKUUMCQGQB;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string GBMCKJFKCKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xC7C110", Offset = "0xC7AD10", VA = "0x180C7C110", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool NXVLIHQZAYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6D889F0", Offset = "0x6D875F0", VA = "0x186D889F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool GLTVYCGYFQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6D8AB90", Offset = "0x6D89790", VA = "0x186D8AB90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool GLZCVJAVPCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6D8B190", Offset = "0x6D89D90", VA = "0x186D8B190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) LVGYLMYNEVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6D8B670", Offset = "0x6D8A270", VA = "0x186D8B670", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6D89110", Offset = "0x6D87D10", VA = "0x186D89110", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) TSOJYCBIEXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6D871D0", Offset = "0x6D85DD0", VA = "0x186D871D0", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A1A0", Offset = "0x6D88DA0", VA = "0x186D8A1A0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) KBCQUAEOSXO
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6D89AD0", Offset = "0x6D886D0", VA = "0x186D89AD0")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6D867F0", Offset = "0x6D853F0", VA = "0x186D867F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a DEHKBMGXXTU
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6D86980", Offset = "0x6D85580", VA = "0x186D86980")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6D88140", Offset = "0x6D86D40", VA = "0x186D88140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a TYXLXFCSXNX
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6D87060", Offset = "0x6D85C60", VA = "0x186D87060")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6D8A920", Offset = "0x6D89520", VA = "0x186D8A920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a VPZCKQUEYOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6D87060", Offset = "0x6D85C60", VA = "0x186D87060")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6D86070", Offset = "0x6D84C70", VA = "0x186D86070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b DECDEFNAOIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6D86A90", Offset = "0x6D85690", VA = "0x186D86A90")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6D885D0", Offset = "0x6D871D0", VA = "0x186D885D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b TYHRFKVAVFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6D86F40", Offset = "0x6D85B40", VA = "0x186D86F40")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b VQEJHXOCHZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6D86F40", Offset = "0x6D85B40", VA = "0x186D86F40")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D85CB0", Offset = "0x6D848B0", VA = "0x186D85CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool NCLRXXCLXKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6CB8900", Offset = "0x6CB7500", VA = "0x186CB8900", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6CB8FC0", Offset = "0x6CB7BC0", VA = "0x186CB8FC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6D89CA0", Offset = "0x6D888A0", VA = "0x186D89CA0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6D8BF90", Offset = "0x6D8AB90", VA = "0x186D8BF90")]
		public BGJRLVTTAMS([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6D87BA0", Offset = "0x6D867A0", VA = "0x186D87BA0")]
		private void JBMXPXRLXTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6D86CE0", Offset = "0x6D858E0", VA = "0x186D86CE0")]
		public void ETNXZSMHSPK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6D86660", Offset = "0x6D85260", VA = "0x186D86660")]
		public void DBBZOHWCEPN(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6D8A840", Offset = "0x6D89440", VA = "0x186D8A840", Slot = "5")]
		private void VIHPPJDFOYQ((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7CD0", Offset = "0x6CB68D0", VA = "0x186CB7CD0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class BGOYJCNQJYB<a, b, c> : MSGVTBEDALQ<(a, b, c)>, YWHCFYGBIDL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly QXEFBQUQHFI<a, b, c> DBWOPTTDZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly QXEFBQUQHFI<a, b, c> AOKUUMCQGQB;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string GBMCKJFKCKS
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xC7C110", Offset = "0xC7AD10", VA = "0x180C7C110", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool NXVLIHQZAYA
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6D8EF60", Offset = "0x6D8DB60", VA = "0x186D8EF60", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool GLTVYCGYFQX
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6D90460", Offset = "0x6D8F060", VA = "0x186D90460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool GLZCVJAVPCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6D908C0", Offset = "0x6D8F4C0", VA = "0x186D908C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool GMEJSPUSYNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6D90600", Offset = "0x6D8F200", VA = "0x186D90600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) LVGYLMYNEVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x6D90A70", Offset = "0x6D8F670", VA = "0x186D90A70", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x6D8F240", Offset = "0x6D8DE40", VA = "0x186D8F240", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) TSOJYCBIEXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DE90", Offset = "0x6D8CA90", VA = "0x186D8DE90", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6D8FD90", Offset = "0x6D8E990", VA = "0x186D8FD90", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a DEHKBMGXXTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x6D8D240", Offset = "0x6D8BE40", VA = "0x186D8D240")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6D8E960", Offset = "0x6D8D560", VA = "0x186D8E960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a TYXLXFCSXNX
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DDB0", Offset = "0x6D8C9B0", VA = "0x186D8DDB0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a VPZCKQUEYOL
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DDB0", Offset = "0x6D8C9B0", VA = "0x186D8DDB0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x6D8CE20", Offset = "0x6D8BA20", VA = "0x186D8CE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b DECDEFNAOIL
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6D8D320", Offset = "0x6D8BF20", VA = "0x186D8D320")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6D8EBA0", Offset = "0x6D8D7A0", VA = "0x186D8EBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b TYHRFKVAVFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DD80", Offset = "0x6D8C980", VA = "0x186D8DD80")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b VQEJHXOCHZU
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DD80", Offset = "0x6D8C980", VA = "0x186D8DD80")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x6D8CD00", Offset = "0x6D8B900", VA = "0x186D8CD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c DDWWGYTDEXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6D8D400", Offset = "0x6D8C000", VA = "0x186D8D400")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6D8EEE0", Offset = "0x6D8DAE0", VA = "0x186D8EEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c TYMYCROYERF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DBF0", Offset = "0x6D8C7F0", VA = "0x186D8DBF0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c VQJQFEHZRLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6D8DBF0", Offset = "0x6D8C7F0", VA = "0x186D8DBF0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6D8C9B0", Offset = "0x6D8B5B0", VA = "0x186D8C9B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool NCLRXXCLXKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6CB8900", Offset = "0x6CB7500", VA = "0x186CB8900", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6D8FCB0", Offset = "0x6D8E8B0", VA = "0x186D8FCB0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6D911B0", Offset = "0x6D8FDB0", VA = "0x186D911B0")]
		public BGOYJCNQJYB([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6D8E650", Offset = "0x6D8D250", VA = "0x186D8E650")]
		private void JBMXPXRLXTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D7C0", Offset = "0x6D8C3C0", VA = "0x186D8D7C0")]
		public void ETNXZSMHSPK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D870", Offset = "0x6D8C470", VA = "0x186D8D870")]
		public void FQGMJZSXKOH(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6D90300", Offset = "0x6D8EF00", VA = "0x186D90300")]
		public void XIMJRWNKRNU(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6D8D200", Offset = "0x6D8BE00", VA = "0x186D8D200")]
		public void DBBZOHWCEPN(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6D90E70", Offset = "0x6D8FA70", VA = "0x186D90E70", Slot = "5")]
		private void ZQAIHWRMLXL((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7CD0", Offset = "0x6CB68D0", VA = "0x186CB7CD0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class BFECCHEIVWQ<a, b, c, d> : MSGVTBEDALQ<(a, b, c, d)>, YWHCFYGBIDL, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly QXTZTLCIJNJ<a, b, c, d> DBWOPTTDZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly QXTZTLCIJNJ<a, b, c, d> AOKUUMCQGQB;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string GBMCKJFKCKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xC7C110", Offset = "0xC7AD10", VA = "0x180C7C110", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) TSOJYCBIEXQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6CB8480", Offset = "0x6CB7080", VA = "0x186CB8480", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6CB8CD0", Offset = "0x6CB78D0", VA = "0x186CB8CD0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b TYHRFKVAVFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x6CB8E00", Offset = "0x6CB7A00", VA = "0x186CB8E00")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c TYMYCROYERF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6CB8DD0", Offset = "0x6CB79D0", VA = "0x186CB8DD0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d TXXDKXHGCJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x6CB8EE0", Offset = "0x6CB7AE0", VA = "0x186CB8EE0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool NCLRXXCLXKQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x6CB8900", Offset = "0x6CB7500", VA = "0x186CB8900", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6CB8FC0", Offset = "0x6CB7BC0", VA = "0x186CB8FC0", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9390", Offset = "0x6CB7F90", VA = "0x186CB9390")]
		public BFECCHEIVWQ([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6CB8590", Offset = "0x6CB7190", VA = "0x186CB8590")]
		private void JBMXPXRLXTG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7D10", Offset = "0x6CB6910", VA = "0x186CB7D10")]
		public void ETNXZSMHSPK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7C80", Offset = "0x6CB6880", VA = "0x186CB7C80")]
		public void DBBZOHWCEPN(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6CB9330", Offset = "0x6CB7F30", VA = "0x186CB9330", Slot = "5")]
		private void YPQGQTSWCHX((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6CB7CD0", Offset = "0x6CB68D0", VA = "0x186CB7CD0", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class GCDFFZYLDZI
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8306730", Offset = "0x8305330", VA = "0x188306730")]
		public static string CSSXVDSXBKJ(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB5A490", Offset = "0xB59090", VA = "0x180B5A490")]
		public static NetworkSetterPermissionMode PIWAPWBQTWK(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class QWTRHDGVOIQ<a> : QJUSWNJMGOV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5A83080", Offset = "0x5A81C80", VA = "0x185A83080")]
		public QWTRHDGVOIQ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5A81F20", Offset = "0x5A80B20", VA = "0x185A81F20")]
		public QWTRHDGVOIQ(CCOVUQOLKKP a, HNNNRVHBOIU b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] EVQDAQPAKJJ g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5A81780", Offset = "0x5A80380", VA = "0x185A81780")]
		public QWTRHDGVOIQ(CCOVUQOLKKP a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] EVQDAQPAKJJ f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5A82A40", Offset = "0x5A81640", VA = "0x185A82A40")]
		public QWTRHDGVOIQ(CCOVUQOLKKP a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] EVQDAQPAKJJ g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class QXJLYXONQQR<a, b> : QJEYETBUEGU<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5A886D0", Offset = "0x5A872D0", VA = "0x185A886D0")]
		public QXJLYXONQQR([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5A89E00", Offset = "0x5A88A00", VA = "0x185A89E00")]
		public QXJLYXONQQR(CCOVUQOLKKP a, HNNNRVHBOIU b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] EVQDAQPAKJJ h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5A8A1D0", Offset = "0x5A88DD0", VA = "0x185A8A1D0")]
		public QXJLYXONQQR(CCOVUQOLKKP a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] EVQDAQPAKJJ g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5A89EF0", Offset = "0x5A88AF0", VA = "0x185A89EF0")]
		public QXJLYXONQQR(CCOVUQOLKKP a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] EVQDAQPAKJJ h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class QXEFBQUQHFI<a, b, c> : QJKFBZVRNSD<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5A87640", Offset = "0x5A86240", VA = "0x185A87640")]
		public QXEFBQUQHFI([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5A87380", Offset = "0x5A85F80", VA = "0x185A87380")]
		public QXEFBQUQHFI(CCOVUQOLKKP a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] EVQDAQPAKJJ h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class QXTZTLCIJNJ<a, b, c, d> : QKKNOHREIWW<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5A8E150", Offset = "0x5A8CD50", VA = "0x185A8E150")]
		public QXTZTLCIJNJ([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5A8EB60", Offset = "0x5A8D760", VA = "0x185A8EB60")]
		public QXTZTLCIJNJ(CCOVUQOLKKP a, HNNNRVHBOIU b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] EVQDAQPAKJJ j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5A8E440", Offset = "0x5A8D040", VA = "0x185A8E440")]
		public QXTZTLCIJNJ(CCOVUQOLKKP a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] EVQDAQPAKJJ i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class QXOSWEILACA<a, b, c, d, e> : QKPULOLBSIF<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5A8BDA0", Offset = "0x5A8A9A0", VA = "0x185A8BDA0")]
		public QXOSWEILACA(CCOVUQOLKKP a, HNNNRVHBOIU b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] EVQDAQPAKJJ k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5A8CCF0", Offset = "0x5A8B8F0", VA = "0x185A8CCF0")]
		public QXOSWEILACA(CCOVUQOLKKP a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] EVQDAQPAKJJ j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PGGQBTPDMFZ<a> : QJUSWNJMGOV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x59BEEB0", Offset = "0x59BDAB0", VA = "0x1859BEEB0")]
		public PGGQBTPDMFZ(HNNNRVHBOIU a, string b, a c, [Optional] Action d, [Optional] EVQDAQPAKJJ e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class PGLWZAJAVRI<a, b> : QJEYETBUEGU<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x59C0160", Offset = "0x59BED60", VA = "0x1859C0160")]
		public PGLWZAJAVRI(HNNNRVHBOIU a, string b, a c, b d, [Optional] Action e, [Optional] EVQDAQPAKJJ f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface IKBMPLYGKTX
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		QWTRHDGVOIQ<a> BYWQVAAKIGR<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class YKKWYVPDRCS : IKBMPLYGKTX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly EVQDAQPAKJJ XTBIOBKWPXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly CCOVUQOLKKP CKDYJTAIIFM;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA99D10", Offset = "0xA98910", VA = "0x180A99D10")]
		public YKKWYVPDRCS(EVQDAQPAKJJ a, CCOVUQOLKKP b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3C02060", Offset = "0x3C00C60", VA = "0x183C02060", Slot = "4")]
		public QWTRHDGVOIQ<a> BYWQVAAKIGR<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface DWUKVYICZCY : CCOVUQOLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId WATNWFASMIS
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface CCOVUQOLKKP
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool HQIWCPIRRRA
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool AEQGHCUNGOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string EOBMQILZMAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool YFCQPAGNVFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(ZWRFJLBCOQZ handler);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(ZWRFJLBCOQZ handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class IHMBQMIKCPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8306770", Offset = "0x8305370", VA = "0x188306770")]
		public static bool BIEOZOLPYLU(this CCOVUQOLKKP a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface EVQDAQPAKJJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		HNNNRVHBOIU XLUZORLMXGH
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool GBDJMNVPWAC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool UQYTEXVZYJV
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
		object NEPNJXWHDGP(string a);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object FVYLOVXTTHL(HNNNRVHBOIU a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void NTWEVFQWTDB(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void TIXFPYTJGON(HNNNRVHBOIU a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void UTOMRJFRKPU<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void KFVPJSSCDIU([CanBeNull] HNNNRVHBOIU photonPlayer, string a, CZFSATCABIX b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void WRLADFODVLX([CanBeNull] HNNNRVHBOIU photonPlayer, string a, CZFSATCABIX b);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b DBIQEGQIXTN<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object BMCXCWDYJIG<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ABGIHELCVVV();

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void AWSLVHFARYJ();

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void HJQSQQAGBZC(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public HNNNRVHBOIU player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public CCOVUQOLKKP context;

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
		public EVQDAQPAKJJ networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8309010", Offset = "0x8307C10", VA = "0x188309010")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8309090", Offset = "0x8307C90", VA = "0x188309090")]
		public SyncData(CCOVUQOLKKP context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] EVQDAQPAKJJ networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8308FC0", Offset = "0x8307BC0", VA = "0x188308FC0")]
		public static SyncData From(CCOVUQOLKKP context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] EVQDAQPAKJJ networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class SXPSPGOMYEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3A3EE50", Offset = "0x3A3DA50", VA = "0x183A3EE50")]
		public static QWTRHDGVOIQ<a> CZFSATCABIX<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3A3DD10", Offset = "0x3A3C910", VA = "0x183A3DD10")]
		public static QXJLYXONQQR<b, c> CZFSATCABIX<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3A3DDB0", Offset = "0x3A3C9B0", VA = "0x183A3DDB0")]
		public static QXEFBQUQHFI<d, e, f> CZFSATCABIX<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E900", Offset = "0x3A3D500", VA = "0x183A3E900")]
		public static QXTZTLCIJNJ<g, h, i, j> CZFSATCABIX<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3A3F0D0", Offset = "0x3A3DCD0", VA = "0x183A3F0D0")]
		public static BGEKOOZVRBJ<k> KRYEXLFUTJW<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A3EF80", Offset = "0x3A3DB80", VA = "0x183A3EF80")]
		public static BGJRLVTTAMS<l, m> KRYEXLFUTJW<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3A3F020", Offset = "0x3A3DC20", VA = "0x183A3F020")]
		public static BGOYJCNQJYB<n, o, p> KRYEXLFUTJW<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A3F3A0", Offset = "0x3A3DFA0", VA = "0x183A3F3A0")]
		public static BFECCHEIVWQ<q, r, s, t> KRYEXLFUTJW<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class CZFSATCABIX : ZWRFJLBCOQZ, IDisposable
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
		private static Stack<EVQDAQPAKJJ> OQRVLRMQMUB;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool KYMAVRNDWQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly HNNNRVHBOIU VPMDGNNGAYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly CCOVUQOLKKP CKDYJTAIIFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string QDRJQNEVYTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode LTJGRCYQFYH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action SLSYDVJPTJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected EVQDAQPAKJJ STJLZWAKFAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags KUHTOXMTJTU;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static EVQDAQPAKJJ QLADASCADML
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8305390", Offset = "0x8303F90", VA = "0x188305390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool MWZICYUKJDV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8305AE0", Offset = "0x83046E0", VA = "0x188305AE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8305AC0", Offset = "0x83046C0", VA = "0x188305AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool MLAHAJMCUVQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8305D10", Offset = "0x8304910", VA = "0x188305D10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8305DC0", Offset = "0x83049C0", VA = "0x188305DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool NVCRLKHUDLZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8305D00", Offset = "0x8304900", VA = "0x188305D00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8305AF0", Offset = "0x83046F0", VA = "0x188305AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool NCLRXXCLXKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8305D60", Offset = "0x8304960", VA = "0x188305D60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8305E70", Offset = "0x8304A70", VA = "0x188305E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object ZZILBUZQHDY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xA988D0", Offset = "0xA974D0", VA = "0x180A988D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA988A0", Offset = "0xA974A0", VA = "0x180A988A0", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool LNDSCRNQHQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8305D70", Offset = "0x8304970", VA = "0x188305D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int NSRNKSRWXSG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xBAC640", Offset = "0xBAB240", VA = "0x180BAC640")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x17A37D0", Offset = "0x17A23D0", VA = "0x1817A37D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string GBMCKJFKCKS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool GBDJMNVPWAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x8305020", Offset = "0x8303C20", VA = "0x188305020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x83058D0", Offset = "0x83044D0", VA = "0x1883058D0")]
		public static void KMVTZMJMVNQ(EVQDAQPAKJJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool NCXQNSUSOPO();

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8306510", Offset = "0x8305110", VA = "0x188306510")]
		protected CZFSATCABIX(HNNNRVHBOIU a, CCOVUQOLKKP b, string c, NetworkSetterPermissionMode d, Action e, EVQDAQPAKJJ f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8305400", Offset = "0x8304000", VA = "0x188305400", Slot = "1")]
		~CZFSATCABIX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8305070", Offset = "0x8303C70", VA = "0x188305070", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8305A20", Offset = "0x8304620", VA = "0x188305A20")]
		private void LFLRYHXLHEW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8305480", Offset = "0x8304080", VA = "0x188305480")]
		private object HHRLVKHKODY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x83055F0", Offset = "0x83041F0", VA = "0x1883055F0")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8305D20", Offset = "0x8304920", VA = "0x188305D20")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8306070", Offset = "0x8304C70", VA = "0x188306070")]
		protected void YDDZKAJUDWH(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8305DE0", Offset = "0x83049E0", VA = "0x188305DE0")]
		internal void VYQYIJPEHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x83062C0", Offset = "0x8304EC0", VA = "0x1883062C0")]
		private void YGDXMZEJPLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x83051E0", Offset = "0x8303DE0", VA = "0x1883051E0")]
		private void EHRVYMJPDAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8306320", Offset = "0x8304F20", VA = "0x188306320", Slot = "4")]
		private void YGGJDJHFVBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8305E60", Offset = "0x8304A60", VA = "0x188305E60", Slot = "5")]
		private void WHACVUIDCXF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8305F30", Offset = "0x8304B30", VA = "0x188305F30")]
		public bool XQZSPETYMUR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8304E50", Offset = "0x8303A50", VA = "0x188304E50")]
		public bool BETHAFZJJPL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8305240", Offset = "0x8303E40", VA = "0x188305240")]
		private bool EPWBYEEHSPQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8305970", Offset = "0x8304570", VA = "0x188305970")]
		internal void KXKXBPTUWOP(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x83057C0", Offset = "0x83043C0", VA = "0x1883057C0")]
		private void KMDCWQTNUUB(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8305010", Offset = "0x8303C10", VA = "0x188305010")]
		private bool CDINUVGCRSD(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8305460", Offset = "0x8304060", VA = "0x188305460")]
		private void GSLPGAQIALB(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8305C70", Offset = "0x8304870", VA = "0x188305C70")]
		public static string RIHSHXQWRQN(HNNNRVHBOIU a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8306390", Offset = "0x8304F90", VA = "0x188306390")]
		public static string YZTYSFSZYEV(CCOVUQOLKKP a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8305B10", Offset = "0x8304710", VA = "0x188305B10")]
		public static bool RFFJKPWWBKP(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class MMJGFEXELXX : EVQDAQPAKJJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> BWFZTLVEURM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> AGJEQQQYWYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> VVXJYSGDCKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> DOOWVTHGOPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool QGMIBIQZRNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> YSUEOERYFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<HNNNRVHBOIU, Dictionary<string, object>> NDBZITITJTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> INOVNCRQREN;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> LNUUYNIORCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int XEZBEUSRWUS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract HNNNRVHBOIU XLUZORLMXGH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool GBDJMNVPWAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool UQYTEXVZYJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool ANFOORDJRQA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool TDZVKIVXUAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xAF8F90", Offset = "0xAF7B90", VA = "0x180AF8F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x37B4620", Offset = "0x37B3220", VA = "0x1837B4620", Slot = "12")]
		public void UTOMRJFRKPU<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8308000", Offset = "0x8306C00", VA = "0x188308000", Slot = "11")]
		public void TIXFPYTJGON(HNNNRVHBOIU a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8307010", Offset = "0x8305C10", VA = "0x188307010", Slot = "9")]
		public object FVYLOVXTTHL(HNNNRVHBOIU a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8307BF0", Offset = "0x83067F0", VA = "0x188307BF0", Slot = "10")]
		public void NTWEVFQWTDB(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8307A60", Offset = "0x8306660", VA = "0x188307A60", Slot = "8")]
		public object NEPNJXWHDGP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x83077C0", Offset = "0x83063C0", VA = "0x1883077C0", Slot = "13")]
		public void KFVPJSSCDIU(HNNNRVHBOIU a, string b, CZFSATCABIX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8308150", Offset = "0x8306D50", VA = "0x188308150", Slot = "14")]
		public void WRLADFODVLX(HNNNRVHBOIU a, string b, CZFSATCABIX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8307A10", Offset = "0x8306610", VA = "0x188307A10")]
		private void MMINMTZNMTL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8308510", Offset = "0x8307110", VA = "0x188308510")]
		private void ZQRKDLDVZTB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8306E50", Offset = "0x8305A50", VA = "0x188306E50")]
		private void CXYUATIUFKS(HNNNRVHBOIU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x83083F0", Offset = "0x8306FF0", VA = "0x1883083F0")]
		protected void ZDCUGRKLJZC(HNNNRVHBOIU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8307B00", Offset = "0x8306700", VA = "0x188307B00")]
		protected void NEQBKBVCSDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8307590", Offset = "0x8306190", VA = "0x188307590")]
		protected void JEPRVDNONQI(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x83078D0", Offset = "0x83064D0", VA = "0x1883078D0")]
		protected void KSNDIAOPTGE(HNNNRVHBOIU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8307D10", Offset = "0x8306910", VA = "0x188307D10")]
		protected void PKGSUTUUDVU(HNNNRVHBOIU a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8308950", Offset = "0x8307550", VA = "0x188308950")]
		private void ZYVKXJJFRRD(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8307390", Offset = "0x8305F90", VA = "0x188307390")]
		private static void IMMOGUFVEOR(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8306C30", Offset = "0x8305830", VA = "0x188306C30")]
		private static void CWHGMZGXQMY(Dictionary<string, object> a, string b, CZFSATCABIX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8307E30", Offset = "0x8306A30", VA = "0x188307E30")]
		private static void SFCEMVUPXUT(Dictionary<string, object> a, string b, CZFSATCABIX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x83067C0", Offset = "0x83053C0", VA = "0x1883067C0", Slot = "17")]
		public void ABGIHELCVVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract void NCKJYJBHNOS(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8306B50", Offset = "0x8305750", VA = "0x188306B50", Slot = "18")]
		public void AWSLVHFARYJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "28")]
		protected abstract void DXTJYLCJDEM(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x83075A0", Offset = "0x83061A0", VA = "0x1883075A0")]
		private void JHCACAJHSSD(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x83068C0", Offset = "0x83054C0", VA = "0x1883068C0")]
		private void AMGJQUSJLLI(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x83088C0", Offset = "0x83074C0", VA = "0x1883088C0")]
		public void ZWGKVOENZWB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8307940", Offset = "0x8306540", VA = "0x188307940")]
		public void LWITCFCYDKJ(HNNNRVHBOIU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8308560", Offset = "0x8307160", VA = "0x188308560")]
		public void ZVXXJHAXDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract HashSet<int> GQCKSWRBUXY(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8307110", Offset = "0x8305D10", VA = "0x188307110", Slot = "19")]
		public void HJQSQQAGBZC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8307DA0", Offset = "0x83069A0", VA = "0x188307DA0")]
		protected string RIHSHXQWRQN(HNNNRVHBOIU a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "30")]
		public abstract object BMCXCWDYJIG<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "31")]
		public abstract c DBIQEGQIXTN<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "32")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8306EB0", Offset = "0x8305AB0", VA = "0x188306EB0", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "33")]
		protected virtual void XZKXYDULVXX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8308DD0", Offset = "0x83079D0", VA = "0x188308DD0")]
		protected MMJGFEXELXX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class QJUSWNJMGOV<a> : CZFSATCABIX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a YTDPEFAMTGI;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a NCFEXMPPRQD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD217A0", Offset = "0xD203A0", VA = "0x180D217A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD21790", Offset = "0xD20390", VA = "0x180D21790", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object ZZILBUZQHDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x5A470A0", Offset = "0x5A45CA0", VA = "0x185A470A0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x5A602E0", Offset = "0x5A5EEE0", VA = "0x185A602E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F020", Offset = "0x5A5DC20", VA = "0x185A5F020", Slot = "9")]
		protected override bool NCXQNSUSOPO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5A661E0", Offset = "0x5A64DE0", VA = "0x185A661E0")]
		protected QJUSWNJMGOV([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5A65C80", Offset = "0x5A64880", VA = "0x185A65C80")]
		protected QJUSWNJMGOV(HNNNRVHBOIU a, CCOVUQOLKKP b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, EVQDAQPAKJJ h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5A5E560", Offset = "0x5A5D160", VA = "0x185A5E560")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5A60C50", Offset = "0x5A5F850", VA = "0x185A60C50")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5A60660", Offset = "0x5A5F260", VA = "0x185A60660")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class QJEYETBUEGU<a, b> : CZFSATCABIX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a YTDPEFAMTGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b YTTJVZIEVOJ;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a NCFEXMPPRQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xDFE470", Offset = "0xDFD070", VA = "0x180DFE470", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xFC4310", Offset = "0xFC2F10", VA = "0x180FC4310", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b NCKLUTJNBBM
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2FA96B0", Offset = "0x2FA82B0", VA = "0x182FA96B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5A49580", Offset = "0x5A48180", VA = "0x185A49580", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b GOKTMBZZNQW
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x141E800", Offset = "0x141D400", VA = "0x18141E800")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object ZZILBUZQHDY
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5A470A0", Offset = "0x5A45CA0", VA = "0x185A470A0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5A4A0E0", Offset = "0x5A48CE0", VA = "0x185A4A0E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5A49070", Offset = "0x5A47C70", VA = "0x185A49070", Slot = "9")]
		protected override bool NCXQNSUSOPO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5A4FA00", Offset = "0x5A4E600", VA = "0x185A4FA00")]
		protected QJEYETBUEGU([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5A4E350", Offset = "0x5A4CF50", VA = "0x185A4E350")]
		protected QJEYETBUEGU(HNNNRVHBOIU a, CCOVUQOLKKP b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, EVQDAQPAKJJ i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5A470C0", Offset = "0x5A45CC0", VA = "0x185A470C0")]
		public a KMICIGGLICU()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5A47580", Offset = "0x5A46180", VA = "0x185A47580")]
		public void LPNEZKLPARC(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x141E800", Offset = "0x141D400", VA = "0x18141E800")]
		public b KMXXAAODKKV()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5A47E40", Offset = "0x5A46A40", VA = "0x185A47E40")]
		public void LQCZRETHCZD(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5A4B430", Offset = "0x5A4A030", VA = "0x185A4B430")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class QJKFBZVRNSD<a, b, c> : CZFSATCABIX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a YTDPEFAMTGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b YTTJVZIEVOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c YTOCYSOHMDA;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a NCFEXMPPRQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAA7D10", Offset = "0xAA6910", VA = "0x180AA7D10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAA7700", Offset = "0xAA6300", VA = "0x180AA7700", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b NCKLUTJNBBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xBC3FE0", Offset = "0xBC2BE0", VA = "0x180BC3FE0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x27DA230", Offset = "0x27D8E30", VA = "0x1827DA230", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c NCPSSADKKMV
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xA9EA20", Offset = "0xA9D620", VA = "0x180A9EA20", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xA9EA10", Offset = "0xA9D610", VA = "0x180A9EA10", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a GOFMOVGCEFN
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x5A470C0", Offset = "0x5A45CC0", VA = "0x185A470C0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b GOKTMBZZNQW
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x141E800", Offset = "0x141D400", VA = "0x18141E800")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c GOQAJITWXCF
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5A12FD0", Offset = "0x5A11BD0", VA = "0x185A12FD0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object ZZILBUZQHDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5A470A0", Offset = "0x5A45CA0", VA = "0x185A470A0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x5A57D60", Offset = "0x5A56960", VA = "0x185A57D60", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5A56320", Offset = "0x5A54F20", VA = "0x185A56320", Slot = "9")]
		protected override bool NCXQNSUSOPO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5A5E470", Offset = "0x5A5D070", VA = "0x185A5E470")]
		protected QJKFBZVRNSD([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5A5DC30", Offset = "0x5A5C830", VA = "0x185A5DC30")]
		protected QJKFBZVRNSD(HNNNRVHBOIU a, CCOVUQOLKKP b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, EVQDAQPAKJJ j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5A470C0", Offset = "0x5A45CC0", VA = "0x185A470C0")]
		public a KMICIGGLICU()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5A53FE0", Offset = "0x5A52BE0", VA = "0x185A53FE0")]
		public void LPNEZKLPARC(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x141E800", Offset = "0x141D400", VA = "0x18141E800")]
		public b KMXXAAODKKV()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5A55290", Offset = "0x5A53E90", VA = "0x185A55290")]
		public void LQCZRETHCZD(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5A12FD0", Offset = "0x5A11BD0", VA = "0x185A12FD0")]
		public c KMSQCTUGAZM()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5A54750", Offset = "0x5A53350", VA = "0x185A54750")]
		public void LPXSTXZJTNU(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5A5AA70", Offset = "0x5A59670", VA = "0x185A5AA70")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class QKKNOHREIWW<a, b, c, d> : CZFSATCABIX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a YTDPEFAMTGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b YTTJVZIEVOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c YTOCYSOHMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d YUDXQMVZOLB;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a NCFEXMPPRQD
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xC68360", Offset = "0xC66F60", VA = "0x180C68360", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x5A6C060", Offset = "0x5A6AC60", VA = "0x185A6C060", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b NCKLUTJNBBM
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x1220DC0", Offset = "0x121F9C0", VA = "0x181220DC0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x121FF30", Offset = "0x121EB30", VA = "0x18121FF30", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c NCPSSADKKMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x11FB410", Offset = "0x11FA010", VA = "0x1811FB410", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x5A6C160", Offset = "0x5A6AD60", VA = "0x185A6C160", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d NBEWLEUCWLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1A22190", Offset = "0x1A20D90", VA = "0x181A22190", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x13538F0", Offset = "0x13524F0", VA = "0x1813538F0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b GOKTMBZZNQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x5A47110", Offset = "0x5A45D10", VA = "0x185A47110")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c GOQAJITWXCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x5A538F0", Offset = "0x5A524F0", VA = "0x185A538F0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d GNFECNKPJAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x136A510", Offset = "0x1369110", VA = "0x18136A510")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object ZZILBUZQHDY
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x5A470A0", Offset = "0x5A45CA0", VA = "0x185A470A0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x5A6C600", Offset = "0x5A6B200", VA = "0x185A6C600", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x5A6B480", Offset = "0x5A6A080", VA = "0x185A6B480", Slot = "9")]
		protected override bool NCXQNSUSOPO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x5A72C20", Offset = "0x5A71820", VA = "0x185A72C20")]
		protected QKKNOHREIWW([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x5A71CE0", Offset = "0x5A708E0", VA = "0x185A71CE0")]
		protected QKKNOHREIWW(HNNNRVHBOIU a, CCOVUQOLKKP b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, EVQDAQPAKJJ k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5A470C0", Offset = "0x5A45CC0", VA = "0x185A470C0")]
		public a KMICIGGLICU()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x5A69490", Offset = "0x5A68090", VA = "0x185A69490")]
		public void LPNEZKLPARC(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5A47110", Offset = "0x5A45D10", VA = "0x185A47110")]
		public b KMXXAAODKKV()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x5A6A460", Offset = "0x5A69060", VA = "0x185A6A460")]
		public void LQCZRETHCZD(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5A538F0", Offset = "0x5A524F0", VA = "0x185A538F0")]
		public c KMSQCTUGAZM()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x5A69B70", Offset = "0x5A68770", VA = "0x185A69B70")]
		public void LPXSTXZJTNU(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x136A510", Offset = "0x1369110", VA = "0x18136A510")]
		public d KNIKUOBYDHN()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x5A687A0", Offset = "0x5A673A0", VA = "0x185A687A0")]
		public void LOXKHQDWYJB(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5A6E780", Offset = "0x5A6D380", VA = "0x185A6E780")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class QKPULOLBSIF<a, b, c, d, e> : CZFSATCABIX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a YTDPEFAMTGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b YTTJVZIEVOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c YTOCYSOHMDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d YUDXQMVZOLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e YTYQTGCCEZS;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a NCFEXMPPRQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAA7D10", Offset = "0xAA6910", VA = "0x180AA7D10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAA7700", Offset = "0xAA6300", VA = "0x180AA7700", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b NCKLUTJNBBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xB06540", Offset = "0xB05140", VA = "0x180B06540", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x118DAA0", Offset = "0x118C6A0", VA = "0x18118DAA0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c NCPSSADKKMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAFC100", Offset = "0xAFAD00", VA = "0x180AFC100", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAFCFA0", Offset = "0xAFBBA0", VA = "0x180AFCFA0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d NBEWLEUCWLK
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAB0E70", Offset = "0xAAFA70", VA = "0x180AB0E70", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F00", Offset = "0xABFB00", VA = "0x180AC0F00", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e NBKDILOAFWT
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAB0AC0", Offset = "0xAAF6C0", VA = "0x180AB0AC0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x5A6C350", Offset = "0x5A6AF50", VA = "0x185A6C350", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object ZZILBUZQHDY
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x5A470A0", Offset = "0x5A45CA0", VA = "0x185A470A0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x5A73FF0", Offset = "0x5A72BF0", VA = "0x185A73FF0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5A73A40", Offset = "0x5A72640", VA = "0x185A73A40", Slot = "9")]
		protected override bool NCXQNSUSOPO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5A75340", Offset = "0x5A73F40", VA = "0x185A75340")]
		protected QKPULOLBSIF(HNNNRVHBOIU a, CCOVUQOLKKP b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, EVQDAQPAKJJ l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5A470C0", Offset = "0x5A45CC0", VA = "0x185A470C0")]
		public a KMICIGGLICU()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5A735E0", Offset = "0x5A721E0", VA = "0x185A735E0")]
		public void LPNEZKLPARC(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x141E800", Offset = "0x141D400", VA = "0x18141E800")]
		public b KMXXAAODKKV()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5A73960", Offset = "0x5A72560", VA = "0x185A73960")]
		public void LQCZRETHCZD(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5A12FD0", Offset = "0x5A11BD0", VA = "0x185A12FD0")]
		public c KMSQCTUGAZM()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x5A736C0", Offset = "0x5A722C0", VA = "0x185A736C0")]
		public void LPXSTXZJTNU(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x136A510", Offset = "0x1369110", VA = "0x18136A510")]
		public d KNIKUOBYDHN()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x5A73420", Offset = "0x5A72020", VA = "0x185A73420")]
		public void LOXKHQDWYJB(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5A73160", Offset = "0x5A71D60", VA = "0x185A73160")]
		public e KNDDXHIATWE()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x5A73180", Offset = "0x5A71D80", VA = "0x185A73180")]
		public void LOSDKJJZOXS(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5A743F0", Offset = "0x5A72FF0", VA = "0x185A743F0")]
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
