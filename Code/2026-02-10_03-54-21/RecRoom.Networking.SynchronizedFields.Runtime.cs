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
	public interface YAYBBSDNNTZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool VECEDKJKZNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool NWUFBDTJKLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HJIMNRPSBJR QOGJHDXGNNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int PUGNORUCQUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool USWKZHEOPOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool JVONSTFDKGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action XWOANYLKGRY;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void DFRLOZJHUEX();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void UFZISKLXYJJ(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void CHSULZDLDXD();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface HOTZSFNLTSM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string WLDJEQTQAKH
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool TUDEYBUYEMN
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface HGIIHBHMMCD<a> : HOTZSFNLTSM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a NGGMBUMGYYR
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AIEYYKUOFOA(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class YPGLKRJJGUY<a> : HGIIHBHMMCD<a>, HOTZSFNLTSM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly LPVOWFTEPLP<a> AUUFTUCYROZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly LPVOWFTEPLP<a> OSTUZMSYXDW;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string WLDJEQTQAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD25120", Offset = "0xD24320", VA = "0x180D25120", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NHNRBPRUWXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x3E801F0", Offset = "0x3E7F3F0", VA = "0x183E801F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a FOWWALAEODQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F090", Offset = "0x3E7E290", VA = "0x183E7F090", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F730", Offset = "0x3E7E930", VA = "0x183E7F730", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a NGGMBUMGYYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F280", Offset = "0x3E7E480", VA = "0x183E7F280", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F1F0", Offset = "0x3E7E3F0", VA = "0x183E7F1F0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a LRBPAVAYBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F280", Offset = "0x3E7E480", VA = "0x183E7F280")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x3E7FD90", Offset = "0x3E7EF90", VA = "0x183E7FD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool TUDEYBUYEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F150", Offset = "0x3E7E350", VA = "0x183E7F150", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F300", Offset = "0x3E7E500", VA = "0x183E7F300", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HGHFTNKEEPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F320", Offset = "0x3E7E520", VA = "0x183E7F320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F400", Offset = "0x3E7E600", VA = "0x183E7F400", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3E803E0", Offset = "0x3E7F5E0", VA = "0x183E803E0")]
		public YPGLKRJJGUY([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F690", Offset = "0x3E7E890", VA = "0x183E7F690")]
		private void SPALBUFNOGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EF30", Offset = "0x3E7E130", VA = "0x183E7EF30", Slot = "5")]
		public void AIEYYKUOFOA(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7EE80", Offset = "0x3E7E080", VA = "0x183E7EE80")]
		public void AIEYYKUOFOA(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F110", Offset = "0x3E7E310", VA = "0x183E7F110", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class YPWGCLRBJCZ<a, b> : HGIIHBHMMCD<(a, b)>, HOTZSFNLTSM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly LPFUELLMNDO<a, b> AUUFTUCYROZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly LPFUELLMNDO<a, b> OSTUZMSYXDW;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string WLDJEQTQAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xD25120", Offset = "0xD24320", VA = "0x180D25120", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool NHNRBPRUWXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3EB6FE0", Offset = "0x3EB61E0", VA = "0x183EB6FE0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DXOQXPXHHNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3EB24F0", Offset = "0x3EB16F0", VA = "0x183EB24F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool DXJKAJDJYCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3EB21E0", Offset = "0x3EB13E0", VA = "0x183EB21E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) FOWWALAEODQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3EB16F0", Offset = "0x3EB08F0", VA = "0x183EB16F0", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3EB68D0", Offset = "0x3EB5AD0", VA = "0x183EB68D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) NGGMBUMGYYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3EB5B40", Offset = "0x3EB4D40", VA = "0x183EB5B40", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3EB2AF0", Offset = "0x3EB1CF0", VA = "0x183EB2AF0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) LRBPAVAYBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3EB2E10", Offset = "0x3EB2010", VA = "0x183EB2E10")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x3EB6AA0", Offset = "0x3EB5CA0", VA = "0x183EB6AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a FSIALWFAKCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x3EB2B40", Offset = "0x3EB1D40", VA = "0x183EB2B40")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x3EB4DC0", Offset = "0x3EB3FC0", VA = "0x183EB4DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a IVHMRIFALOY
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x3EB1570", Offset = "0x3EB0770", VA = "0x183EB1570")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x3EB3160", Offset = "0x3EB2360", VA = "0x183EB3160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a HMSWJKNCSJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3EB1570", Offset = "0x3EB0770", VA = "0x183EB1570")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3EB4050", Offset = "0x3EB3250", VA = "0x183EB4050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b FRSFUBXIHUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x3EB2D00", Offset = "0x3EB1F00", VA = "0x183EB2D00")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x3EB5180", Offset = "0x3EB4380", VA = "0x183EB5180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b IVXHJCMSNWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x3EB1470", Offset = "0x3EB0670", VA = "0x183EB1470")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b HNIRBEUUURL
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x3EB1470", Offset = "0x3EB0670", VA = "0x183EB1470")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x3EB3B40", Offset = "0x3EB2D40", VA = "0x183EB3B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool TUDEYBUYEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F150", Offset = "0x3E7E350", VA = "0x183E7F150", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F300", Offset = "0x3E7E500", VA = "0x183E7F300", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3EB43E0", Offset = "0x3EB35E0", VA = "0x183EB43E0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3EB7C20", Offset = "0x3EB6E20", VA = "0x183EB7C20")]
		public YPWGCLRBJCZ([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB4670", Offset = "0x3EB3870", VA = "0x183EB4670")]
		private void SPALBUFNOGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB35D0", Offset = "0x3EB27D0", VA = "0x183EB35D0")]
		public void NZSNAGQLZRD(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3EB1100", Offset = "0x3EB0300", VA = "0x183EB1100")]
		public void AIEYYKUOFOA(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3EB1E30", Offset = "0x3EB1030", VA = "0x183EB1E30", Slot = "5")]
		private void BGWATGIYEDN((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F110", Offset = "0x3E7E310", VA = "0x183E7F110", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class YPQZFEXDZRQ<a, b, c> : HGIIHBHMMCD<(a, b, c)>, HOTZSFNLTSM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly LPLBBSFJWOX<a, b, c> AUUFTUCYROZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly LPLBBSFJWOX<a, b, c> OSTUZMSYXDW;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string WLDJEQTQAKH
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xD25120", Offset = "0xD24320", VA = "0x180D25120", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool NHNRBPRUWXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x3EB05E0", Offset = "0x3EAF7E0", VA = "0x183EB05E0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool DXOQXPXHHNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x3EAC9A0", Offset = "0x3EABBA0", VA = "0x183EAC9A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool DXJKAJDJYCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x3EAC4C0", Offset = "0x3EAB6C0", VA = "0x183EAC4C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool DXEDDCJMOQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x3EAC7A0", Offset = "0x3EAB9A0", VA = "0x183EAC7A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) FOWWALAEODQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x3EABFB0", Offset = "0x3EAB1B0", VA = "0x183EABFB0", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x3EB0000", Offset = "0x3EAF200", VA = "0x183EB0000", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) NGGMBUMGYYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF6C0", Offset = "0x3EAE8C0", VA = "0x183EAF6C0", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x3EAD3F0", Offset = "0x3EAC5F0", VA = "0x183EAD3F0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a FSIALWFAKCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x3EAD7B0", Offset = "0x3EAC9B0", VA = "0x183EAD7B0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x3EAEF20", Offset = "0x3EAE120", VA = "0x183EAEF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a IVHMRIFALOY
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x3EABED0", Offset = "0x3EAB0D0", VA = "0x183EABED0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a HMSWJKNCSJK
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x3EABED0", Offset = "0x3EAB0D0", VA = "0x183EABED0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3EAE210", Offset = "0x3EAD410", VA = "0x183EAE210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b FRSFUBXIHUY
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3EADA20", Offset = "0x3EACC20", VA = "0x183EADA20")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF550", Offset = "0x3EAE750", VA = "0x183EAF550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b IVXHJCMSNWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3EABDC0", Offset = "0x3EAAFC0", VA = "0x183EABDC0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b HNIRBEUUURL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x3EABDC0", Offset = "0x3EAAFC0", VA = "0x183EABDC0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3EADE10", Offset = "0x3EAD010", VA = "0x183EADE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c FRXMRIRFRGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3EAD940", Offset = "0x3EACB40", VA = "0x183EAD940")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x3EAF040", Offset = "0x3EAE240", VA = "0x183EAF040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c IVSALVSVELQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x3EABDF0", Offset = "0x3EAAFF0", VA = "0x183EABDF0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c HNDKDYAXLGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3EABDF0", Offset = "0x3EAAFF0", VA = "0x183EABDF0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x3EAE180", Offset = "0x3EAD380", VA = "0x183EAE180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool TUDEYBUYEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F150", Offset = "0x3E7E350", VA = "0x183E7F150", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3EAE780", Offset = "0x3EAD980", VA = "0x183EAE780", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x3EB0F00", Offset = "0x3EB0100", VA = "0x183EB0F00")]
		public YPQZFEXDZRQ([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x3EAE980", Offset = "0x3EADB80", VA = "0x183EAE980")]
		private void SPALBUFNOGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x3EADD50", Offset = "0x3EACF50", VA = "0x183EADD50")]
		public void NZSNAGQLZRD(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x3EAD0F0", Offset = "0x3EAC2F0", VA = "0x183EAD0F0")]
		public void IAORYWATMIK(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x3EACD40", Offset = "0x3EABF40", VA = "0x183EACD40")]
		public void FIXAMENYBPR(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x3EABA50", Offset = "0x3EAAC50", VA = "0x183EABA50")]
		public void AIEYYKUOFOA(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3EAE720", Offset = "0x3EAD920", VA = "0x183EAE720", Slot = "5")]
		private void OKAENKZBWOQ((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F110", Offset = "0x3E7E310", VA = "0x183E7F110", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class YQGTWZEWBZR<a, b, c, d> : HGIIHBHMMCD<(a, b, c, d)>, HOTZSFNLTSM, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly LQLJOAAWRTQ<a, b, c, d> AUUFTUCYROZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly LQLJOAAWRTQ<a, b, c, d> OSTUZMSYXDW;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string WLDJEQTQAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD25120", Offset = "0xD24320", VA = "0x180D25120", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) NGGMBUMGYYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3EB9450", Offset = "0x3EB8650", VA = "0x183EB9450", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x3EB88E0", Offset = "0x3EB7AE0", VA = "0x183EB88E0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b IVXHJCMSNWZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x3EB9940", Offset = "0x3EB8B40", VA = "0x183EB9940")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c IVSALVSVELQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x3EB9AD0", Offset = "0x3EB8CD0", VA = "0x183EB9AD0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d IWHVDQANGTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x3EB9BB0", Offset = "0x3EB8DB0", VA = "0x183EB9BB0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool TUDEYBUYEMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F150", Offset = "0x3E7E350", VA = "0x183E7F150", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x3E7F300", Offset = "0x3E7E500", VA = "0x183E7F300", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3EBA2E0", Offset = "0x3EB94E0", VA = "0x183EBA2E0")]
		public YQGTWZEWBZR([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x3EB9340", Offset = "0x3EB8540", VA = "0x183EB9340")]
		private void SPALBUFNOGT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8930", Offset = "0x3EB7B30", VA = "0x183EB8930")]
		public void NZSNAGQLZRD(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x3EB81D0", Offset = "0x3EB73D0", VA = "0x183EB81D0")]
		public void AIEYYKUOFOA(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8CE0", Offset = "0x3EB7EE0", VA = "0x183EB8CE0", Slot = "5")]
		private void PVUBBJTMDJM((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7F110", Offset = "0x3E7E310", VA = "0x183E7F110", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class WTFSNWNWRCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x856A5B0", Offset = "0x85697B0", VA = "0x18856A5B0")]
		public static string NVYKDCKOTOU(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xBECF30", Offset = "0xBEC130", VA = "0x180BECF30")]
		public static NetworkSetterPermissionMode YEYGCMMLQAB(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class LPVOWFTEPLP<a> : LMCRHQMFXYM<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x53BE9A0", Offset = "0x53BDBA0", VA = "0x1853BE9A0")]
		public LPVOWFTEPLP([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x53C0E20", Offset = "0x53C0020", VA = "0x1853C0E20")]
		public LPVOWFTEPLP(BAHQEQVTEDE a, HJIMNRPSBJR b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] BHDECTQSWEE g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x53BD9C0", Offset = "0x53BCBC0", VA = "0x1853BD9C0")]
		public LPVOWFTEPLP(BAHQEQVTEDE a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] BHDECTQSWEE f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x53BECB0", Offset = "0x53BDEB0", VA = "0x1853BECB0")]
		public LPVOWFTEPLP(BAHQEQVTEDE a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] BHDECTQSWEE g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class LPFUELLMNDO<a, b> : LMSLZKTYAGN<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x53B8220", Offset = "0x53B7420", VA = "0x1853B8220")]
		public LPFUELLMNDO([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x53BBBA0", Offset = "0x53BADA0", VA = "0x1853BBBA0")]
		public LPFUELLMNDO(BAHQEQVTEDE a, HJIMNRPSBJR b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] BHDECTQSWEE h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x53BAD50", Offset = "0x53B9F50", VA = "0x1853BAD50")]
		public LPFUELLMNDO(BAHQEQVTEDE a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] BHDECTQSWEE g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x53BB8A0", Offset = "0x53BAAA0", VA = "0x1853BB8A0")]
		public LPFUELLMNDO(BAHQEQVTEDE a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] BHDECTQSWEE h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class LPLBBSFJWOX<a, b, c> : LMNFCEAAQVE<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x53BC4F0", Offset = "0x53BB6F0", VA = "0x1853BC4F0")]
		public LPLBBSFJWOX([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x53BC9A0", Offset = "0x53BBBA0", VA = "0x1853BC9A0")]
		public LPLBBSFJWOX(BAHQEQVTEDE a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] BHDECTQSWEE h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class LQLJOAAWRTQ<a, b, c, d> : LNCZTYHSTDF<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x53C54A0", Offset = "0x53C46A0", VA = "0x1853C54A0")]
		public LQLJOAAWRTQ([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x53C5B40", Offset = "0x53C4D40", VA = "0x1853C5B40")]
		public LQLJOAAWRTQ(BAHQEQVTEDE a, HJIMNRPSBJR b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] BHDECTQSWEE j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x53C4C80", Offset = "0x53C3E80", VA = "0x1853C4C80")]
		public LQLJOAAWRTQ(BAHQEQVTEDE a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] BHDECTQSWEE i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class LQQQLGUUBEZ<a, b, c, d, e> : LMXSWRNVJRW<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x53C7500", Offset = "0x53C6700", VA = "0x1853C7500")]
		public LQQQLGUUBEZ(BAHQEQVTEDE a, HJIMNRPSBJR b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] BHDECTQSWEE k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x53C73F0", Offset = "0x53C65F0", VA = "0x1853C73F0")]
		public LQQQLGUUBEZ(BAHQEQVTEDE a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] BHDECTQSWEE j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PXUHBFBRMWG<a> : LMCRHQMFXYM<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5C1A630", Offset = "0x5C19830", VA = "0x185C1A630")]
		public PXUHBFBRMWG(HJIMNRPSBJR a, string b, a c, [Optional] Action d, [Optional] BHDECTQSWEE e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class PXPADYHUDKX<a, b> : LMSLZKTYAGN<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5C19F00", Offset = "0x5C19100", VA = "0x185C19F00")]
		public PXPADYHUDKX(HJIMNRPSBJR a, string b, a c, b d, [Optional] Action e, [Optional] BHDECTQSWEE f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface AFUDZIBQQVI
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		LPVOWFTEPLP<a> BZPEIXUMZDY<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class COYRJSYHUYH : AFUDZIBQQVI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly BHDECTQSWEE XWFUVUHYFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly BAHQEQVTEDE PHYSJKMZSSL;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xAC0190", VA = "0x180AC0F90")]
		public COYRJSYHUYH(BHDECTQSWEE a, BAHQEQVTEDE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x34DDB60", Offset = "0x34DCD60", VA = "0x1834DDB60", Slot = "4")]
		public LPVOWFTEPLP<a> BZPEIXUMZDY<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface VKWWBVSXTRR : BAHQEQVTEDE
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId JCVABXACALH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface BAHQEQVTEDE
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool DYXYIVZUZXP
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool SXJJHMHZFCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string TBAXUBWOMHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool IVBSYIBZKVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(JSKFFZQLBTK handler);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(JSKFFZQLBTK handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class FBDBKEKGCDS
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8566260", Offset = "0x8565460", VA = "0x188566260")]
		public static bool UKMUJTEAXUP(this BAHQEQVTEDE a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface BHDECTQSWEE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		HJIMNRPSBJR KWHQLHEEHBA
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool HGHFTNKEEPL
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool EBMDIHEHQPW
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
		object TBBXRHHRYTC(string a);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object TGKNBBMMLRM(HJIMNRPSBJR a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void LDRLKMAEDQI(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void WBHHUTHOCBE(HJIMNRPSBJR a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RXBVSWZPEQX<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void XHGSTINUILX([CanBeNull] HJIMNRPSBJR photonPlayer, string a, JJFNUFKEFJI b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void STTZDMQWWPK([CanBeNull] HJIMNRPSBJR photonPlayer, string a, JJFNUFKEFJI b);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b KTRQPHLJXRW<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object ZOSTHCSFGLL<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void PWUMFMXOPWY();

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void WBYTRWFHFWO();

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void FPGAVPDNEZT(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public HJIMNRPSBJR player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public BAHQEQVTEDE context;

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
		public BHDECTQSWEE networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x856A3A0", Offset = "0x85695A0", VA = "0x18856A3A0")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x856A420", Offset = "0x8569620", VA = "0x18856A420")]
		public SyncData(BAHQEQVTEDE context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] BHDECTQSWEE networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x856A350", Offset = "0x8569550", VA = "0x18856A350")]
		public static SyncData From(BAHQEQVTEDE context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] BHDECTQSWEE networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class TXDTXPXPZOR
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1290", Offset = "0x3AF0490", VA = "0x183AF1290")]
		public static LPVOWFTEPLP<a> JJFNUFKEFJI<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0150", Offset = "0x3AEF350", VA = "0x183AF0150")]
		public static LPFUELLMNDO<b, c> JJFNUFKEFJI<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3AF01F0", Offset = "0x3AEF3F0", VA = "0x183AF01F0")]
		public static LPLBBSFJWOX<d, e, f> JJFNUFKEFJI<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3AF0D40", Offset = "0x3AEFF40", VA = "0x183AF0D40")]
		public static LQLJOAAWRTQ<g, h, i, j> JJFNUFKEFJI<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1510", Offset = "0x3AF0710", VA = "0x183AF1510")]
		public static YPGLKRJJGUY<k> KVINDMBTUOX<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3AF13C0", Offset = "0x3AF05C0", VA = "0x183AF13C0")]
		public static YPWGCLRBJCZ<l, m> KVINDMBTUOX<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1460", Offset = "0x3AF0660", VA = "0x183AF1460")]
		public static YPQZFEXDZRQ<n, o, p> KVINDMBTUOX<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3AF17E0", Offset = "0x3AF09E0", VA = "0x183AF17E0")]
		public static YQGTWZEWBZR<q, r, s, t> KVINDMBTUOX<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class JJFNUFKEFJI : JSKFFZQLBTK, IDisposable
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
		private static Stack<BHDECTQSWEE> XPPKVMSXKAE;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool GWWUEBWBHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly HJIMNRPSBJR BTOPYNOEDOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly BAHQEQVTEDE PHYSJKMZSSL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string GNIQKUTBWSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode KJBIBDJWTKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action TUNSJZJYGBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected BHDECTQSWEE MKWKWXCBVAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags MLSWMABILCP;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static BHDECTQSWEE WGRXDIMXNYY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8567400", Offset = "0x8566600", VA = "0x188567400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool SVNJMBSFNTG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8567470", Offset = "0x8566670", VA = "0x188567470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8566F00", Offset = "0x8566100", VA = "0x188566F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool APKGUEZIBOX
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8567770", Offset = "0x8566970", VA = "0x188567770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x85674C0", Offset = "0x85666C0", VA = "0x1885674C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool BUECMTBDEUC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8566A70", Offset = "0x8565C70", VA = "0x188566A70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8567750", Offset = "0x8566950", VA = "0x188567750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool TUDEYBUYEMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x85665B0", Offset = "0x85657B0", VA = "0x1885665B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8566B70", Offset = "0x8565D70", VA = "0x188566B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object OAVHUUDPALB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAB9970", Offset = "0xAB8B70", VA = "0x180AB9970", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAB92F0", Offset = "0xAB84F0", VA = "0x180AB92F0", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool GPRJZZDPLIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x85663F0", Offset = "0x85655F0", VA = "0x1885663F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int NUGLPBYAIDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xC45940", Offset = "0xC44B40", VA = "0x180C45940")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x1841780", Offset = "0x1840980", VA = "0x181841780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string WLDJEQTQAKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool HGHFTNKEEPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x85670E0", Offset = "0x85662E0", VA = "0x1885670E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x85674E0", Offset = "0x85666E0", VA = "0x1885674E0")]
		public static void UOYESZTBNWV(BHDECTQSWEE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool AAIFTDEXDKH();

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8567960", Offset = "0x8566B60", VA = "0x188567960")]
		protected JJFNUFKEFJI(HJIMNRPSBJR a, BAHQEQVTEDE b, string c, NetworkSetterPermissionMode d, Action e, BHDECTQSWEE f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85665E0", Offset = "0x85657E0", VA = "0x1885665E0", Slot = "1")]
		~JJFNUFKEFJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8566440", Offset = "0x8565640", VA = "0x188566440", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8566640", Offset = "0x8565840", VA = "0x188566640")]
		private void GCRQNJIFZJD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8566D90", Offset = "0x8565F90", VA = "0x188566D90")]
		private object OSKXXYXUQOD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8566790", Offset = "0x8565990", VA = "0x188566790")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8567480", Offset = "0x8566680", VA = "0x188567480")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8567130", Offset = "0x8566330", VA = "0x188567130")]
		protected void QRNTCYUTWDG(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8567380", Offset = "0x8566580", VA = "0x188567380")]
		internal void RLZMCPIBWZY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8566B10", Offset = "0x8565D10", VA = "0x188566B10")]
		private void MGODOPWIHNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8566390", Offset = "0x8565590", VA = "0x188566390")]
		private void BMAMACOWFID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x85676D0", Offset = "0x85668D0", VA = "0x1885676D0", Slot = "4")]
		private void VDYWYEYQHFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8567740", Offset = "0x8566940", VA = "0x188567740", Slot = "5")]
		private void WBTZEAYPVFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8567790", Offset = "0x8566990", VA = "0x188567790")]
		public bool ZFHNJLTIZYQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8566F20", Offset = "0x8566120", VA = "0x188566F20")]
		public bool QAAXXNIOYDI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8567580", Offset = "0x8566780", VA = "0x188567580")]
		private bool VCBVNIJVWMJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x85666E0", Offset = "0x85658E0", VA = "0x1885666E0")]
		internal void GDMIVLUUUTU(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8566960", Offset = "0x8565B60", VA = "0x188566960")]
		private void JHXAQCKRGXI(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8567780", Offset = "0x8566980", VA = "0x188567780")]
		private bool YYYFOJDGKDE(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x85665C0", Offset = "0x85657C0", VA = "0x1885665C0")]
		private void FHAIMATVQDY(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8566A80", Offset = "0x8565C80", VA = "0x188566A80")]
		public static string LVHXOFDJQQE(HJIMNRPSBJR a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x85662B0", Offset = "0x85654B0", VA = "0x1885662B0")]
		public static string AUOHNACSRQA(BAHQEQVTEDE a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8566C30", Offset = "0x8565E30", VA = "0x188566C30")]
		public static bool NHWGMCDFZNQ(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class NJSULVABPBW : BHDECTQSWEE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> EBXSHSDTTHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> CDTRWZEVJXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> ZLGDURIQHAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> JEXQWGNLJDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool RTQSCYEYDGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> WMRSUNPJUQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<HJIMNRPSBJR, Dictionary<string, object>> ZFTEJGKROJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> KVTSZXFPJIC;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> BHSHUHAUAHY
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int YQBNWHADCTV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract HJIMNRPSBJR KWHQLHEEHBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool HGHFTNKEEPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool EBMDIHEHQPW
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool QOXXDHBRNZN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xAD1330", Offset = "0xAD0530", VA = "0x180AD1330", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool UJRFHDXYQLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB1BF50", Offset = "0xB1B150", VA = "0x180B1BF50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x38E9B70", Offset = "0x38E8D70", VA = "0x1838E9B70", Slot = "12")]
		public void RXBVSWZPEQX<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8569210", Offset = "0x8568410", VA = "0x188569210", Slot = "11")]
		public void WBHHUTHOCBE(HJIMNRPSBJR a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8569110", Offset = "0x8568310", VA = "0x188569110", Slot = "9")]
		public object TGKNBBMMLRM(HJIMNRPSBJR a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8568830", Offset = "0x8567A30", VA = "0x188568830", Slot = "10")]
		public void LDRLKMAEDQI(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8569070", Offset = "0x8568270", VA = "0x188569070", Slot = "8")]
		public object TBBXRHHRYTC(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8569AE0", Offset = "0x8568CE0", VA = "0x188569AE0", Slot = "13")]
		public void XHGSTINUILX(HJIMNRPSBJR a, string b, JJFNUFKEFJI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8568DC0", Offset = "0x8567FC0", VA = "0x188568DC0", Slot = "14")]
		public void STTZDMQWWPK(HJIMNRPSBJR a, string b, JJFNUFKEFJI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8568D70", Offset = "0x8567F70", VA = "0x188568D70")]
		private void RAYMYIVAQSI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x85684F0", Offset = "0x85676F0", VA = "0x1885684F0")]
		private void HVJJMDYWILE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8567DA0", Offset = "0x8566FA0", VA = "0x188567DA0")]
		private void DIWIHAKYKUB(HJIMNRPSBJR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8568540", Offset = "0x8567740", VA = "0x188568540")]
		protected void HXTRVUCBUVL(HJIMNRPSBJR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8568180", Offset = "0x8567380", VA = "0x188568180")]
		protected void FBFLZGHQZLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8569200", Offset = "0x8568400", VA = "0x188569200")]
		protected void VMRXBUNYWWX(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8569BF0", Offset = "0x8568DF0", VA = "0x188569BF0")]
		protected void ZBGSEYHRXRX(HJIMNRPSBJR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x856A0D0", Offset = "0x85692D0", VA = "0x18856A0D0")]
		protected void ZKDQWTTVMAF(HJIMNRPSBJR a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8569C60", Offset = "0x8568E60", VA = "0x188569C60")]
		private void ZFSNUWQZFOQ(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8568AE0", Offset = "0x8567CE0", VA = "0x188568AE0")]
		private static void QFTVKBDFGRC(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8567F60", Offset = "0x8567160", VA = "0x188567F60")]
		private static void EBBRVULDSZB(Dictionary<string, object> a, string b, JJFNUFKEFJI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8568660", Offset = "0x8567860", VA = "0x188568660")]
		private static void JEEVLOWGVLU(Dictionary<string, object> a, string b, JJFNUFKEFJI c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x85689E0", Offset = "0x8567BE0", VA = "0x1885689E0", Slot = "17")]
		public void PWUMFMXOPWY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract void IPAKJLQHIDL(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8569360", Offset = "0x8568560", VA = "0x188569360", Slot = "18")]
		public void WBYTRWFHFWO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "28")]
		protected abstract void HCPDYUEWCIT(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8567B80", Offset = "0x8566D80", VA = "0x188567B80")]
		private void BXMFOJMJIRA(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8569870", Offset = "0x8568A70", VA = "0x188569870")]
		private void WNOZRMOZFHJ(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8568CE0", Offset = "0x8567EE0", VA = "0x188568CE0")]
		public void QIPLPZVJJAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x85697A0", Offset = "0x85689A0", VA = "0x1885697A0")]
		public void WIBHOUFJJZW(HJIMNRPSBJR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8569440", Offset = "0x8568640", VA = "0x188569440")]
		public void WHFVBUTDBPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract HashSet<int> VIXSAMNHBLX(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8568270", Offset = "0x8567470", VA = "0x188568270", Slot = "19")]
		public void FPGAVPDNEZT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8568950", Offset = "0x8567B50", VA = "0x188568950")]
		protected string LVHXOFDJQQE(HJIMNRPSBJR a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "30")]
		public abstract object ZOSTHCSFGLL<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "31")]
		public abstract c KTRQPHLJXRW<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "32")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8567E00", Offset = "0x8567000", VA = "0x188567E00", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "33")]
		protected virtual void YKSGQSGTGHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x856A160", Offset = "0x8569360", VA = "0x18856A160")]
		protected NJSULVABPBW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class LMCRHQMFXYM<a> : JJFNUFKEFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a RBMMNFPTPFH;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a DJPLFEHAUQW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xDC31D0", Offset = "0xDC23D0", VA = "0x180DC31D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xDC31C0", Offset = "0xDC23C0", VA = "0x180DC31C0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object OAVHUUDPALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x5380AE0", Offset = "0x537FCE0", VA = "0x185380AE0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x537FB20", Offset = "0x537ED20", VA = "0x18537FB20", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x537EEA0", Offset = "0x537E0A0", VA = "0x18537EEA0", Slot = "9")]
		protected override bool AAIFTDEXDKH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5385DF0", Offset = "0x5384FF0", VA = "0x185385DF0")]
		protected LMCRHQMFXYM([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5387FE0", Offset = "0x53871E0", VA = "0x185387FE0")]
		protected LMCRHQMFXYM(HJIMNRPSBJR a, BAHQEQVTEDE b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, BHDECTQSWEE h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x53809D0", Offset = "0x537FBD0", VA = "0x1853809D0")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5385250", Offset = "0x5384450", VA = "0x185385250")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5382270", Offset = "0x5381470", VA = "0x185382270")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class LMSLZKTYAGN<a, b> : JJFNUFKEFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a RBMMNFPTPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b RAWRVLIBMXG;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a DJPLFEHAUQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xE75ED0", Offset = "0xE750D0", VA = "0x180E75ED0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x105C550", Offset = "0x105B750", VA = "0x18105C550", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b DJKEHXNDLFN
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2FFA730", Offset = "0x2FF9930", VA = "0x182FFA730", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x5398C10", Offset = "0x5397E10", VA = "0x185398C10", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b HPVTJCJYEFB
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x14B8130", Offset = "0x14B7330", VA = "0x1814B8130")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object OAVHUUDPALB
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5380AE0", Offset = "0x537FCE0", VA = "0x185380AE0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x53971B0", Offset = "0x53963B0", VA = "0x1853971B0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5394540", Offset = "0x5393740", VA = "0x185394540", Slot = "9")]
		protected override bool AAIFTDEXDKH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x539D0C0", Offset = "0x539C2C0", VA = "0x18539D0C0")]
		protected LMSLZKTYAGN([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x539E180", Offset = "0x539D380", VA = "0x18539E180")]
		protected LMSLZKTYAGN(HJIMNRPSBJR a, BAHQEQVTEDE b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, BHDECTQSWEE i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5380930", Offset = "0x537FB30", VA = "0x185380930")]
		public a LGJXMBZERIH()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5395CB0", Offset = "0x5394EB0", VA = "0x185395CB0")]
		public void EKKNKGOHLBR(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x14B8130", Offset = "0x14B7330", VA = "0x1814B8130")]
		public b LGPEJITCATQ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5396550", Offset = "0x5395750", VA = "0x185396550")]
		public void EKPUHNIEUNA(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x53990A0", Offset = "0x53982A0", VA = "0x1853990A0")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class LMNFCEAAQVE<a, b, c> : JJFNUFKEFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a RBMMNFPTPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b RAWRVLIBMXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c RBBYSSBYWIP;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a DJPLFEHAUQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAC7D40", Offset = "0xAC6F40", VA = "0x180AC7D40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC68A0", VA = "0x180AC76A0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b DJKEHXNDLFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xC79970", Offset = "0xC78B70", VA = "0x180C79970", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2838410", Offset = "0x2837610", VA = "0x182838410", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c DJEXKQTGBUE
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xABF5C0", Offset = "0xABE7C0", VA = "0x180ABF5C0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xABF5E0", Offset = "0xABE7E0", VA = "0x180ABF5E0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a HQBAGJDVNQK
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x5380930", Offset = "0x537FB30", VA = "0x185380930")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b HPVTJCJYEFB
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x14B8130", Offset = "0x14B7330", VA = "0x1814B8130")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c HPQMLVQAUTS
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x53897A0", Offset = "0x53889A0", VA = "0x1853897A0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object OAVHUUDPALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5380AE0", Offset = "0x537FCE0", VA = "0x185380AE0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x53894B0", Offset = "0x53886B0", VA = "0x1853894B0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5388C70", Offset = "0x5387E70", VA = "0x185388C70", Slot = "9")]
		protected override bool AAIFTDEXDKH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x538A4E0", Offset = "0x53896E0", VA = "0x18538A4E0")]
		protected LMNFCEAAQVE([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x538A5C0", Offset = "0x53897C0", VA = "0x18538A5C0")]
		protected LMNFCEAAQVE(HJIMNRPSBJR a, BAHQEQVTEDE b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, BHDECTQSWEE j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5380930", Offset = "0x537FB30", VA = "0x185380930")]
		public a LGJXMBZERIH()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5388E00", Offset = "0x5388000", VA = "0x185388E00")]
		public void EKKNKGOHLBR(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x14B8130", Offset = "0x14B7330", VA = "0x1814B8130")]
		public b LGPEJITCATQ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x53890F0", Offset = "0x53882F0", VA = "0x1853890F0")]
		public void EKPUHNIEUNA(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x53897A0", Offset = "0x53889A0", VA = "0x1853897A0")]
		public c LGULGPMZKEZ()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x53892B0", Offset = "0x53884B0", VA = "0x1853892B0")]
		public void EKVBEUCCDYJ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5389B80", Offset = "0x5388D80", VA = "0x185389B80")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class LNCZTYHSTDF<a, b, c, d> : JJFNUFKEFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a RBMMNFPTPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b RAWRVLIBMXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c RBBYSSBYWIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d RAMEAXUGUAO;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a DJPLFEHAUQW
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xCEE400", Offset = "0xCED600", VA = "0x180CEE400", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x53A5D80", Offset = "0x53A4F80", VA = "0x1853A5D80", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b DJKEHXNDLFN
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x1246CF0", Offset = "0x1245EF0", VA = "0x181246CF0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x1245D80", Offset = "0x1244F80", VA = "0x181245D80", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c DJEXKQTGBUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x12B2F90", Offset = "0x12B2190", VA = "0x1812B2F90", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x53AC9A0", Offset = "0x53ABBA0", VA = "0x1853AC9A0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d DKPTRMCNPVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1AD6100", Offset = "0x1AD5300", VA = "0x181AD6100", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1406840", Offset = "0x1405A40", VA = "0x181406840", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b HPVTJCJYEFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x538E930", Offset = "0x538DB30", VA = "0x18538E930")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c HPQMLVQAUTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x5389770", Offset = "0x5388970", VA = "0x185389770")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d HRBISQZIIVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x137DB40", Offset = "0x137CD40", VA = "0x18137DB40")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object OAVHUUDPALB
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x5380AE0", Offset = "0x537FCE0", VA = "0x185380AE0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x53AC240", Offset = "0x53AB440", VA = "0x1853AC240", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x53AAF30", Offset = "0x53AA130", VA = "0x1853AAF30", Slot = "9")]
		protected override bool AAIFTDEXDKH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x53AEAA0", Offset = "0x53ADCA0", VA = "0x1853AEAA0")]
		protected LNCZTYHSTDF([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x53AE760", Offset = "0x53AD960", VA = "0x1853AE760")]
		protected LNCZTYHSTDF(HJIMNRPSBJR a, BAHQEQVTEDE b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, BHDECTQSWEE k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x5380930", Offset = "0x537FB30", VA = "0x185380930")]
		public a LGJXMBZERIH()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x53AB850", Offset = "0x53AAA50", VA = "0x1853AB850")]
		public void EKKNKGOHLBR(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x538E930", Offset = "0x538DB30", VA = "0x18538E930")]
		public b LGPEJITCATQ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x53ABA00", Offset = "0x53AAC00", VA = "0x1853ABA00")]
		public void EKPUHNIEUNA(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x5389770", Offset = "0x5388970", VA = "0x185389770")]
		public c LGULGPMZKEZ()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x53ABCD0", Offset = "0x53AAED0", VA = "0x1853ABCD0")]
		public void EKVBEUCCDYJ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x137DB40", Offset = "0x137CD40", VA = "0x18137DB40")]
		public d LGZSDWGWTQI()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x53AB3C0", Offset = "0x53AA5C0", VA = "0x1853AB3C0")]
		public void EJKEXYSUPWY(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x53AD3C0", Offset = "0x53AC5C0", VA = "0x1853AD3C0")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class LMXSWRNVJRW<a, b, c, d, e> : JJFNUFKEFJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a RBMMNFPTPFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b RAWRVLIBMXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c RBBYSSBYWIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d RAMEAXUGUAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e RARKYEOEDLX;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a DJPLFEHAUQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAC7D40", Offset = "0xAC6F40", VA = "0x180AC7D40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC68A0", VA = "0x180AC76A0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b DJKEHXNDLFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xB8F920", Offset = "0xB8EB20", VA = "0x180B8F920", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x12250E0", Offset = "0x12242E0", VA = "0x1812250E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c DJEXKQTGBUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xBBEE70", Offset = "0xBBE070", VA = "0x180BBEE70", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xBC0080", Offset = "0xBBF280", VA = "0x180BC0080", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d DKPTRMCNPVP
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAD16F0", Offset = "0xAD08F0", VA = "0x180AD16F0", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAE1020", Offset = "0xAE0220", VA = "0x180AE1020", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e DKKMUFIQGKG
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAD1340", Offset = "0xAD0540", VA = "0x180AD1340", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x53A5AE0", Offset = "0x53A4CE0", VA = "0x1853A5AE0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object OAVHUUDPALB
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x5380AE0", Offset = "0x537FCE0", VA = "0x185380AE0", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x53A5660", Offset = "0x53A4860", VA = "0x1853A5660", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x53A0C30", Offset = "0x539FE30", VA = "0x1853A0C30", Slot = "9")]
		protected override bool AAIFTDEXDKH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x53A90A0", Offset = "0x53A82A0", VA = "0x1853A90A0")]
		protected LMXSWRNVJRW(HJIMNRPSBJR a, BAHQEQVTEDE b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, BHDECTQSWEE l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5380930", Offset = "0x537FB30", VA = "0x185380930")]
		public a LGJXMBZERIH()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x53A2C80", Offset = "0x53A1E80", VA = "0x1853A2C80")]
		public void EKKNKGOHLBR(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x14B8130", Offset = "0x14B7330", VA = "0x1814B8130")]
		public b LGPEJITCATQ()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x53A34F0", Offset = "0x53A26F0", VA = "0x1853A34F0")]
		public void EKPUHNIEUNA(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x53897A0", Offset = "0x53889A0", VA = "0x1853897A0")]
		public c LGULGPMZKEZ()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x53A4230", Offset = "0x53A3430", VA = "0x1853A4230")]
		public void EKVBEUCCDYJ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x137DB40", Offset = "0x137CD40", VA = "0x18137DB40")]
		public d LGZSDWGWTQI()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x53A1E70", Offset = "0x53A1070", VA = "0x1853A1E70")]
		public void EJKEXYSUPWY(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x53A5950", Offset = "0x53A4B50", VA = "0x1853A5950")]
		public e LHEZBDAUDBR()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x53A2780", Offset = "0x53A1980", VA = "0x1853A2780")]
		public void EJPLVFMRZIH(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x53A7F70", Offset = "0x53A7170", VA = "0x1853A7F70")]
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
