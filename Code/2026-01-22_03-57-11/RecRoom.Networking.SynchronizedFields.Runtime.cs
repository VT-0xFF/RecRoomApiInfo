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
	public interface YGZFVDCCIGM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool EOIEASMYCLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool RVPSKYBUZTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		MNBQIABPYXS OOYGTNDDWRB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int PMOHFRLXVBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool PYMIJNKGAEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool BCYEHLLGPEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action NZGNOMDWELN;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void BWLMLWMYNUW();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void WDPGYKBOREY(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void XQEJYOLMODQ();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface QQSAJITWPLD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string JTDQMXNDCYS
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool XVTQVGYPXFW
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface QQMHWXTHRFU<a> : QQSAJITWPLD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a QIBEYNEVUJQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BPKFJTCUVJR(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class HJMHHHKYPDJ<a> : QQMHWXTHRFU<a>, QQSAJITWPLD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly MRBGJNBCDKU<a> ILEIYCMNZKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly MRBGJNBCDKU<a> OFBGGYOMCVD;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string JTDQMXNDCYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD15750", Offset = "0xD13F50", VA = "0x180D15750", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DJXPFDXWXMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4F36390", Offset = "0x4F34B90", VA = "0x184F36390", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a LPUBOSACNOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4F354E0", Offset = "0x4F33CE0", VA = "0x184F354E0", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x4F36070", Offset = "0x4F34870", VA = "0x184F36070", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a QIBEYNEVUJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x4F36F50", Offset = "0x4F35750", VA = "0x184F36F50", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4F37310", Offset = "0x4F35B10", VA = "0x184F37310", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a ZBQGWKFCAQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x4F36F50", Offset = "0x4F35750", VA = "0x184F36F50")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4F36A30", Offset = "0x4F35230", VA = "0x184F36A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool XVTQVGYPXFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4F35570", Offset = "0x4F33D70", VA = "0x184F35570", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x4F372F0", Offset = "0x4F35AF0", VA = "0x184F372F0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool JLRCNPTARZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x4F36F90", Offset = "0x4F35790", VA = "0x184F36F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4F371B0", Offset = "0x4F359B0", VA = "0x184F371B0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4F37430", Offset = "0x4F35C30", VA = "0x184F37430")]
		public HJMHHHKYPDJ([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4F35900", Offset = "0x4F34100", VA = "0x184F35900")]
		private void FBVHFFLETAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4F35770", Offset = "0x4F33F70", VA = "0x184F35770", Slot = "5")]
		public void BPKFJTCUVJR(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4F357D0", Offset = "0x4F33FD0", VA = "0x184F357D0")]
		public void BPKFJTCUVJR(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4F358C0", Offset = "0x4F340C0", VA = "0x184F358C0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class HJROEOEVYOS<a, b> : QQMHWXTHRFU<(a, b)>, QQSAJITWPLD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly MRRBBHIUFSV<a, b> ILEIYCMNZKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly MRRBBHIUFSV<a, b> OFBGGYOMCVD;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string JTDQMXNDCYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xD15750", Offset = "0xD13F50", VA = "0x180D15750", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool DJXPFDXWXMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4F3E7D0", Offset = "0x4F3CFD0", VA = "0x184F3E7D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool BBMEPXYPVCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4F3F630", Offset = "0x4F3DE30", VA = "0x184F3F630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool BBRLNESNENQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4F3FD10", Offset = "0x4F3E510", VA = "0x184F3FD10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) LPUBOSACNOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4F3BE00", Offset = "0x4F3A600", VA = "0x184F3BE00", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x4F3D960", Offset = "0x4F3C160", VA = "0x184F3D960", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) QIBEYNEVUJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x4F40C20", Offset = "0x4F3F420", VA = "0x184F40C20", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x4F41A00", Offset = "0x4F40200", VA = "0x184F41A00", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) ZBQGWKFCAQI
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x4F3EE90", Offset = "0x4F3D690", VA = "0x184F3EE90")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x4F3EAB0", Offset = "0x4F3D2B0", VA = "0x184F3EAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a IQBTRHLCXOK
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C640", Offset = "0x4F3AE40", VA = "0x184F3C640")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x4F402D0", Offset = "0x4F3EAD0", VA = "0x184F402D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a AHIMFNZNKER
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C230", Offset = "0x4F3AA30", VA = "0x184F3C230")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x4F3ED60", Offset = "0x4F3D560", VA = "0x184F3ED60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a KWENIJAXWPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C230", Offset = "0x4F3AA30", VA = "0x184F3C230")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x4F3D370", Offset = "0x4F3BB70", VA = "0x184F3D370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b IPWMUARFODB
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C800", Offset = "0x4F3B000", VA = "0x184F3C800")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x4F40670", Offset = "0x4F3EE70", VA = "0x184F40670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b AGSRNTRVHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C1F0", Offset = "0x4F3A9F0", VA = "0x184F3C1F0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b KWJUFPUVGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x4F3C1F0", Offset = "0x4F3A9F0", VA = "0x184F3C1F0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x4F3CE00", Offset = "0x4F3B600", VA = "0x184F3CE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool XVTQVGYPXFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x4F35570", Offset = "0x4F33D70", VA = "0x184F35570", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x4F372F0", Offset = "0x4F35AF0", VA = "0x184F372F0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4F41680", Offset = "0x4F3FE80", VA = "0x184F41680", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4F41CC0", Offset = "0x4F404C0", VA = "0x184F41CC0")]
		public HJROEOEVYOS([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4F3C9B0", Offset = "0x4F3B1B0", VA = "0x184F3C9B0")]
		private void FBVHFFLETAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4F3F3D0", Offset = "0x4F3DBD0", VA = "0x184F3F3D0")]
		public void OTTGQYYQGKY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4F3C5B0", Offset = "0x4F3ADB0", VA = "0x184F3C5B0")]
		public void BPKFJTCUVJR(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4F41210", Offset = "0x4F3FA10", VA = "0x184F41210", Slot = "5")]
		private void RRLTKHQXQKY((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4F358C0", Offset = "0x4F340C0", VA = "0x184F358C0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class HJWVBUYTIAB<a, b, c> : QQMHWXTHRFU<(a, b, c)>, QQSAJITWPLD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly MRLUEAOWWHM<a, b, c> ILEIYCMNZKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly MRLUEAOWWHM<a, b, c> OFBGGYOMCVD;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string JTDQMXNDCYS
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xD15750", Offset = "0xD13F50", VA = "0x180D15750", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool DJXPFDXWXMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x4F44DA0", Offset = "0x4F435A0", VA = "0x184F44DA0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool BBMEPXYPVCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x4F45790", Offset = "0x4F43F90", VA = "0x184F45790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool BBRLNESNENQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x4F45BF0", Offset = "0x4F443F0", VA = "0x184F45BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool BBWSKLMKNYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x4F45A50", Offset = "0x4F44250", VA = "0x184F45A50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) LPUBOSACNOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x4F42F00", Offset = "0x4F41700", VA = "0x184F42F00", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x4F44490", Offset = "0x4F42C90", VA = "0x184F44490", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) QIBEYNEVUJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x4F468F0", Offset = "0x4F450F0", VA = "0x184F468F0", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x4F46F50", Offset = "0x4F45750", VA = "0x184F46F50", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a IQBTRHLCXOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x4F43850", Offset = "0x4F42050", VA = "0x184F43850")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x4F45EF0", Offset = "0x4F446F0", VA = "0x184F45EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a AHIMFNZNKER
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x4F434C0", Offset = "0x4F41CC0", VA = "0x184F434C0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a KWENIJAXWPF
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x4F434C0", Offset = "0x4F41CC0", VA = "0x184F434C0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x4F44290", Offset = "0x4F42A90", VA = "0x184F44290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b IPWMUARFODB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x4F43930", Offset = "0x4F42130", VA = "0x184F43930")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4F45F70", Offset = "0x4F44770", VA = "0x184F45F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b AGSRNTRVHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x4F43490", Offset = "0x4F41C90", VA = "0x184F43490")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b KWJUFPUVGAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4F43490", Offset = "0x4F41C90", VA = "0x184F43490")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4F44090", Offset = "0x4F42890", VA = "0x184F44090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c IPRFWTXIERS
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x4F43A10", Offset = "0x4F42210", VA = "0x184F43A10")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x4F462B0", Offset = "0x4F44AB0", VA = "0x184F462B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c AGXYLALSRHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4F43300", Offset = "0x4F41B00", VA = "0x184F43300")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c KWPBCWOSPLX
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x4F43300", Offset = "0x4F41B00", VA = "0x184F43300")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x4F43F90", Offset = "0x4F42790", VA = "0x184F43F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool XVTQVGYPXFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x4F35570", Offset = "0x4F33D70", VA = "0x184F35570", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4F46B30", Offset = "0x4F45330", VA = "0x184F46B30", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4F472A0", Offset = "0x4F45AA0", VA = "0x184F472A0")]
		public HJWVBUYTIAB([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4F43DD0", Offset = "0x4F425D0", VA = "0x184F43DD0")]
		private void FBVHFFLETAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4F45400", Offset = "0x4F43C00", VA = "0x184F45400")]
		public void OTTGQYYQGKY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4F45350", Offset = "0x4F43B50", VA = "0x184F45350")]
		public void MYCCKMTDAJV(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4F42CC0", Offset = "0x4F414C0", VA = "0x184F42CC0")]
		public void AXTUCIQVDBQ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4F43810", Offset = "0x4F42010", VA = "0x184F43810")]
		public void BPKFJTCUVJR(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4F46EB0", Offset = "0x4F456B0", VA = "0x184F46EB0", Slot = "5")]
		private void WQKVHXBDIFP((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4F358C0", Offset = "0x4F340C0", VA = "0x184F358C0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class HKCBZBSQRLK<a, b, c, d> : QQMHWXTHRFU<(a, b, c, d)>, QQSAJITWPLD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly MQLLRSTKBCT<a, b, c, d> ILEIYCMNZKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly MQLLRSTKBCT<a, b, c, d> OFBGGYOMCVD;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string JTDQMXNDCYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD15750", Offset = "0xD13F50", VA = "0x180D15750", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) QIBEYNEVUJQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x4F48DB0", Offset = "0x4F475B0", VA = "0x184F48DB0", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x4F49160", Offset = "0x4F47960", VA = "0x184F49160", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b AGSRNTRVHWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x4F49130", Offset = "0x4F47930", VA = "0x184F49130")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c AGXYLALSRHZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4F49050", Offset = "0x4F47850", VA = "0x184F49050")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d AHYGXIHFMMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x4F48EC0", Offset = "0x4F476C0", VA = "0x184F48EC0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool XVTQVGYPXFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x4F35570", Offset = "0x4F33D70", VA = "0x184F35570", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x4F372F0", Offset = "0x4F35AF0", VA = "0x184F372F0", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4F49C30", Offset = "0x4F48430", VA = "0x184F49C30")]
		public HKCBZBSQRLK([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4F48190", Offset = "0x4F46990", VA = "0x184F48190")]
		private void FBVHFFLETAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4F48640", Offset = "0x4F46E40", VA = "0x184F48640")]
		public void OTTGQYYQGKY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4F47ED0", Offset = "0x4F466D0", VA = "0x184F47ED0")]
		public void BPKFJTCUVJR(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4F485E0", Offset = "0x4F46DE0", VA = "0x184F485E0", Slot = "5")]
		private void GPBXNEBEXHP((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4F358C0", Offset = "0x4F340C0", VA = "0x184F358C0", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class XJNCLBIRITE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x84375C0", Offset = "0x8435DC0", VA = "0x1884375C0")]
		public static string JLOPGGHVDIR(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xBC1F50", Offset = "0xBC0750", VA = "0x180BC1F50")]
		public static NetworkSetterPermissionMode WRLVAFGBQKC(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MRBGJNBCDKU<a> : VXYGHIABCQV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x57F94D0", Offset = "0x57F7CD0", VA = "0x1857F94D0")]
		public MRBGJNBCDKU([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x57FC600", Offset = "0x57FAE00", VA = "0x1857FC600")]
		public MRBGJNBCDKU(ZDTJWVAUIKL a, MNBQIABPYXS b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] PYZGQQWAFPF g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x57FD310", Offset = "0x57FBB10", VA = "0x1857FD310")]
		public MRBGJNBCDKU(ZDTJWVAUIKL a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] PYZGQQWAFPF f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x57F9500", Offset = "0x57F7D00", VA = "0x1857F9500")]
		public MRBGJNBCDKU(ZDTJWVAUIKL a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] PYZGQQWAFPF g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MRRBBHIUFSV<a, b> : VXILPNSJAIU<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5802D50", Offset = "0x5801550", VA = "0x185802D50")]
		public MRRBBHIUFSV([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x58014F0", Offset = "0x57FFCF0", VA = "0x1858014F0")]
		public MRRBBHIUFSV(ZDTJWVAUIKL a, MNBQIABPYXS b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] PYZGQQWAFPF h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5802B70", Offset = "0x5801370", VA = "0x185802B70")]
		public MRRBBHIUFSV(ZDTJWVAUIKL a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] PYZGQQWAFPF g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5801F30", Offset = "0x5800730", VA = "0x185801F30")]
		public MRRBBHIUFSV(ZDTJWVAUIKL a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] PYZGQQWAFPF h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MRLUEAOWWHM<a, b, c> : VXNSMUMGJUD<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x57FE5C0", Offset = "0x57FCDC0", VA = "0x1857FE5C0")]
		public MRLUEAOWWHM([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x57FD6B0", Offset = "0x57FBEB0", VA = "0x1857FD6B0")]
		public MRLUEAOWWHM(ZDTJWVAUIKL a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] PYZGQQWAFPF h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MQLLRSTKBCT<a, b, c, d> : VWXXVAEOHMC<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x57F8370", Offset = "0x57F6B70", VA = "0x1857F8370")]
		public MQLLRSTKBCT([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x57F8EF0", Offset = "0x57F76F0", VA = "0x1857F8EF0")]
		public MQLLRSTKBCT(ZDTJWVAUIKL a, MNBQIABPYXS b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] PYZGQQWAFPF j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x57F88B0", Offset = "0x57F70B0", VA = "0x1857F88B0")]
		public MQLLRSTKBCT(ZDTJWVAUIKL a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] PYZGQQWAFPF i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class MQGEULZMRRK<a, b, c, d, e> : VXDESGYLQXL<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x57F6320", Offset = "0x57F4B20", VA = "0x1857F6320")]
		public MQGEULZMRRK(ZDTJWVAUIKL a, MNBQIABPYXS b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] PYZGQQWAFPF k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x57F6C80", Offset = "0x57F5480", VA = "0x1857F6C80")]
		public MQGEULZMRRK(ZDTJWVAUIKL a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] PYZGQQWAFPF j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class GEBFVLQNCDZ<a> : VXYGHIABCQV<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4E94AF0", Offset = "0x4E932F0", VA = "0x184E94AF0")]
		public GEBFVLQNCDZ(MNBQIABPYXS a, string b, a c, [Optional] Action d, [Optional] PYZGQQWAFPF e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class GEGMSSKKLPI<a, b> : VXILPNSJAIU<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4E94E10", Offset = "0x4E93610", VA = "0x184E94E10")]
		public GEGMSSKKLPI(MNBQIABPYXS a, string b, a c, b d, [Optional] Action e, [Optional] PYZGQQWAFPF f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface NXPEGUNXBYN
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MRBGJNBCDKU<a> EVKQKRGHXOZ<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class UTVRRNCFPCO : NXPEGUNXBYN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly PYZGQQWAFPF UUVBNMGSHZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly ZDTJWVAUIKL CHVZLCUSNMW;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xABC070", Offset = "0xABA870", VA = "0x180ABC070")]
		public UTVRRNCFPCO(PYZGQQWAFPF a, ZDTJWVAUIKL b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3BAFAA0", Offset = "0x3BAE2A0", VA = "0x183BAFAA0", Slot = "4")]
		public MRBGJNBCDKU<a> EVKQKRGHXOZ<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface YLKOKETTTLC : ZDTJWVAUIKL
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId QNGTZDJQEUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface ZDTJWVAUIKL
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool OVOWUPSWSGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool WBLMYOMIWFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string BCBJSMYGRWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool DUNZPGKXBMV
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(ACEXMIMMHDT handler);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(ACEXMIMMHDT handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class CFTNHZEDKLT
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8434B00", Offset = "0x8433300", VA = "0x188434B00")]
		public static bool HPPDYDWYLZY(this ZDTJWVAUIKL a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface PYZGQQWAFPF : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		MNBQIABPYXS QTQDYPPCQEL
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool JLRCNPTARZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool JJAXACDEXPZ
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
		object ZUZOXDMTFUP(string a);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object WFQMWZAAIWV(MNBQIABPYXS a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void NXTISWVLMJF(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void INHIXZIKYZD(MNBQIABPYXS a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void WDLLRKNCDOW<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void LTBNOLIGADW([CanBeNull] MNBQIABPYXS photonPlayer, string a, YQUQTTWDHKX b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void OPQMCZRTCOZ([CanBeNull] MNBQIABPYXS photonPlayer, string a, YQUQTTWDHKX b);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b VKEUWUARVMH<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object GDEDHXSWASC<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void DNUQBACHUZV();

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void UWVCVQYBKJX();

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void GTHSFDWNVJO(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public MNBQIABPYXS player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public ZDTJWVAUIKL context;

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
		public PYZGQQWAFPF networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x8437540", Offset = "0x8435D40", VA = "0x188437540")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x84373A0", Offset = "0x8435BA0", VA = "0x1884373A0")]
		public SyncData(ZDTJWVAUIKL context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] PYZGQQWAFPF networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x8437350", Offset = "0x8435B50", VA = "0x188437350")]
		public static SyncData From(ZDTJWVAUIKL context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] PYZGQQWAFPF networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class HUXFWSBGVSG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x36E4570", Offset = "0x36E2D70", VA = "0x1836E4570")]
		public static MRBGJNBCDKU<a> YQUQTTWDHKX<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x36E3B60", Offset = "0x36E2360", VA = "0x1836E3B60")]
		public static MRRBBHIUFSV<b, c> YQUQTTWDHKX<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x36E3C00", Offset = "0x36E2400", VA = "0x1836E3C00")]
		public static MRLUEAOWWHM<d, e, f> YQUQTTWDHKX<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x36E4020", Offset = "0x36E2820", VA = "0x1836E4020")]
		public static MQLLRSTKBCT<g, h, i, j> YQUQTTWDHKX<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x36E2B70", Offset = "0x36E1370", VA = "0x1836E2B70")]
		public static HJMHHHKYPDJ<k> LBJBEFSKGAI<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x36E2A20", Offset = "0x36E1220", VA = "0x1836E2A20")]
		public static HJROEOEVYOS<l, m> LBJBEFSKGAI<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x36E2AC0", Offset = "0x36E12C0", VA = "0x1836E2AC0")]
		public static HJWVBUYTIAB<n, o, p> LBJBEFSKGAI<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x36E3570", Offset = "0x36E1D70", VA = "0x1836E3570")]
		public static HKCBZBSQRLK<q, r, s, t> LBJBEFSKGAI<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class YQUQTTWDHKX : ACEXMIMMHDT, IDisposable
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
		private static Stack<PYZGQQWAFPF> IJCYCEFEYBT;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool IRTZKIMDHWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly MNBQIABPYXS OFXTAYELOMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly ZDTJWVAUIKL CHVZLCUSNMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string TVIXTBMOZHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode WXQVAQIMLOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action WOJUZXZOTEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected PYZGQQWAFPF LVZTOJGNXSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags KFCEXCIBGDU;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static PYZGQQWAFPF GJEJSNHJKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x8437610", Offset = "0x8435E10", VA = "0x188437610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool SNKBCCPSMFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8437850", Offset = "0x8436050", VA = "0x188437850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8437C30", Offset = "0x8436430", VA = "0x188437C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool SDKOUOXNNCW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8437A60", Offset = "0x8436260", VA = "0x188437A60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8437EB0", Offset = "0x84366B0", VA = "0x188437EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool LXEJLURCCZN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x8437E20", Offset = "0x8436620", VA = "0x188437E20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8437E90", Offset = "0x8436690", VA = "0x188437E90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool XVTQVGYPXFW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8437600", Offset = "0x8435E00", VA = "0x188437600")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x84385A0", Offset = "0x8436DA0", VA = "0x1884385A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object FHQMLGCUYOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xAACAE0", Offset = "0xAAB2E0", VA = "0x180AACAE0", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool AEOSWQIIJKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8437690", Offset = "0x8435E90", VA = "0x188437690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int RRPAYYPGLXY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0xC16C90", Offset = "0xC15490", VA = "0x180C16C90")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x1808920", Offset = "0x1807120", VA = "0x181808920")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string JTDQMXNDCYS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool JLRCNPTARZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x8438470", Offset = "0x8436C70", VA = "0x188438470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x84378E0", Offset = "0x84360E0", VA = "0x1884378E0")]
		public static void HGERXUSPGNA(PYZGQQWAFPF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool KRALCBTAFHO();

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8438CB0", Offset = "0x84374B0", VA = "0x188438CB0")]
		protected YQUQTTWDHKX(MNBQIABPYXS a, ZDTJWVAUIKL b, string c, NetworkSetterPermissionMode d, Action e, PYZGQQWAFPF f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8437860", Offset = "0x8436060", VA = "0x188437860", Slot = "1")]
		~YQUQTTWDHKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x84376E0", Offset = "0x8435EE0", VA = "0x1884376E0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x84384C0", Offset = "0x8436CC0", VA = "0x1884384C0")]
		private void SKSIXESEBZI(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x84388D0", Offset = "0x84370D0", VA = "0x1884388D0")]
		private object ZHGWPGEIPUG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8437C50", Offset = "0x8436450", VA = "0x188437C50")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8438560", Offset = "0x8436D60", VA = "0x188438560")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8438220", Offset = "0x8436A20", VA = "0x188438220")]
		protected void QQBPQEDMHBF(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x84381A0", Offset = "0x84369A0", VA = "0x1884381A0")]
		internal void PWGIAHUZGZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8437E30", Offset = "0x8436630", VA = "0x188437E30")]
		private void JCYSCTUDDKZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x84380D0", Offset = "0x84368D0", VA = "0x1884380D0")]
		private void NIZEJZURXZC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8438130", Offset = "0x8436930", VA = "0x188438130", Slot = "4")]
		private void OLTQOVYMPLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8437680", Offset = "0x8435E80", VA = "0x188437680", Slot = "5")]
		private void DJLEJPZXWJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8437EE0", Offset = "0x84366E0", VA = "0x188437EE0")]
		public bool MOIPBBMZYYV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8437A70", Offset = "0x8436270", VA = "0x188437A70")]
		public bool IFWOWFPRMYZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8438A40", Offset = "0x8437240", VA = "0x188438A40")]
		private bool ZILNXVPBOXU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8438020", Offset = "0x8436820", VA = "0x188438020")]
		internal void NBRGVZFHPUL(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8438660", Offset = "0x8436E60", VA = "0x188438660")]
		private void TIEJCSYQHNX(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8437ED0", Offset = "0x84366D0", VA = "0x188437ED0")]
		private bool MAKUNLFCTNZ(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x84378C0", Offset = "0x84360C0", VA = "0x1884378C0")]
		private void GBYJFCGQMFR(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8438B90", Offset = "0x8437390", VA = "0x188438B90")]
		public static string ZIWAVLVHASR(MNBQIABPYXS a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x8437980", Offset = "0x8436180", VA = "0x188437980")]
		public static string HKHEAQNQTEV(ZDTJWVAUIKL a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8438770", Offset = "0x8436F70", VA = "0x188438770")]
		public static bool YBHTOZQPCMD(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class CVDWOJTRTMB : PYZGQQWAFPF, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> PCZUSQRJWZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> DCJRTTHXFWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> SOPIIGPRYCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> JFGMCYMPIVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool EWAJJDIHWIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> XUUDHENHKFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<MNBQIABPYXS, Dictionary<string, object>> LZGYXVKWPSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> AACMWUXKDGN;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> THWIWSUCIIR
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int OFFVURRCQPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract MNBQIABPYXS QTQDYPPCQEL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool JLRCNPTARZQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool JJAXACDEXPZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool PVPPPGMBPVC
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool ZMUGFMCKOPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB046C0", Offset = "0xB02EC0", VA = "0x180B046C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x34E4EB0", Offset = "0x34E36B0", VA = "0x1834E4EB0", Slot = "12")]
		public void WDLLRKNCDOW<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8435600", Offset = "0x8433E00", VA = "0x188435600", Slot = "11")]
		public void INHIXZIKYZD(MNBQIABPYXS a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8436E00", Offset = "0x8435600", VA = "0x188436E00", Slot = "9")]
		public object WFQMWZAAIWV(MNBQIABPYXS a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8435E20", Offset = "0x8434620", VA = "0x188435E20", Slot = "10")]
		public void NXTISWVLMJF(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x84370C0", Offset = "0x84358C0", VA = "0x1884370C0", Slot = "8")]
		public object ZUZOXDMTFUP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x84359A0", Offset = "0x84341A0", VA = "0x1884359A0", Slot = "13")]
		public void LTBNOLIGADW(MNBQIABPYXS a, string b, YQUQTTWDHKX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8435F40", Offset = "0x8434740", VA = "0x188435F40", Slot = "14")]
		public void OPQMCZRTCOZ(MNBQIABPYXS a, string b, YQUQTTWDHKX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8434BE0", Offset = "0x84333E0", VA = "0x188434BE0")]
		private void APMTATIMZZH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8435750", Offset = "0x8433F50", VA = "0x188435750")]
		private void KGLXTATKLED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8435BA0", Offset = "0x84343A0", VA = "0x188435BA0")]
		private void MNEVELZDFMK(MNBQIABPYXS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8436F10", Offset = "0x8435710", VA = "0x188436F10")]
		protected void YWQHCJVMNUI(MNBQIABPYXS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8435AB0", Offset = "0x84342B0", VA = "0x188435AB0")]
		protected void MAHRSYHKCAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8436F00", Offset = "0x8435700", VA = "0x188436F00")]
		protected void XGOOGETRUYY(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8436D90", Offset = "0x8435590", VA = "0x188436D90")]
		protected void UZGKQHRUVIE(MNBQIABPYXS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8434B50", Offset = "0x8433350", VA = "0x188434B50")]
		protected void AMKUNCVFTHE(MNBQIABPYXS a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8436400", Offset = "0x8434C00", VA = "0x188436400")]
		private void QBQVTXGJZAR(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x84357A0", Offset = "0x8433FA0", VA = "0x1884357A0")]
		private static void KUKNKCZFFMV(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8435C00", Offset = "0x8434400", VA = "0x188435C00")]
		private static void MXOOWBMFVVG(Dictionary<string, object> a, string b, YQUQTTWDHKX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x84351B0", Offset = "0x84339B0", VA = "0x1884351B0")]
		private static void GDUPMNJOQKX(Dictionary<string, object> a, string b, YQUQTTWDHKX c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8434CC0", Offset = "0x84334C0", VA = "0x188434CC0", Slot = "17")]
		public void DNUQBACHUZV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "27")]
		protected abstract void DPVBEBOVEHQ(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8436CB0", Offset = "0x84354B0", VA = "0x188436CB0", Slot = "18")]
		public void UWVCVQYBKJX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "28")]
		protected abstract void CIWSKBFXGCA(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x84361E0", Offset = "0x84349E0", VA = "0x1884361E0")]
		private void QAVZMNRZHIP(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8434F20", Offset = "0x8433720", VA = "0x188434F20")]
		private void FWPZFQUDCSC(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8434C30", Offset = "0x8433430", VA = "0x188434C30")]
		public void CYDYVAUERHT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8436BE0", Offset = "0x84353E0", VA = "0x188436BE0")]
		public void SQZJBYIBMUN(MNBQIABPYXS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8436880", Offset = "0x8435080", VA = "0x188436880")]
		public void QEPROLXZROC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract HashSet<int> MPXIHEIHMJY(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8435380", Offset = "0x8433B80", VA = "0x188435380", Slot = "19")]
		public void GTHSFDWNVJO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8437030", Offset = "0x8435830", VA = "0x188437030")]
		protected string ZIWAVLVHASR(MNBQIABPYXS a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "30")]
		public abstract object GDEDHXSWASC<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(Slot = "31")]
		public abstract c VKEUWUARVMH<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "32")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8434DC0", Offset = "0x84335C0", VA = "0x188434DC0", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "33")]
		protected virtual void OPJJLZXZUSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8437160", Offset = "0x8435960", VA = "0x188437160")]
		protected CVDWOJTRTMB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class VXYGHIABCQV<a> : YQUQTTWDHKX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a UPAWQZEIKKA;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a IJZJINHRHFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD7F2B0", Offset = "0xD7DAB0", VA = "0x180D7F2B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0xD7F2A0", Offset = "0xD7DAA0", VA = "0x180D7F2A0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object FHQMLGCUYOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x631E060", Offset = "0x631C860", VA = "0x18631E060", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6342430", Offset = "0x6340C30", VA = "0x186342430", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6342D00", Offset = "0x6341500", VA = "0x186342D00", Slot = "9")]
		protected override bool KRALCBTAFHO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6344FA0", Offset = "0x63437A0", VA = "0x186344FA0")]
		protected VXYGHIABCQV([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x6344D80", Offset = "0x6343580", VA = "0x186344D80")]
		protected VXYGHIABCQV(MNBQIABPYXS a, ZDTJWVAUIKL b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, PYZGQQWAFPF h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x631E030", Offset = "0x631C830", VA = "0x18631E030")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6343BB0", Offset = "0x63423B0", VA = "0x186343BB0")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x63435E0", Offset = "0x6341DE0", VA = "0x1863435E0")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class VXILPNSJAIU<a, b> : YQUQTTWDHKX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a UPAWQZEIKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b UPQRITMAMSB;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a IJZJINHRHFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xE48E60", Offset = "0xE47660", VA = "0x180E48E60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x1030BA0", Offset = "0x102F3A0", VA = "0x181030BA0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b IKEQFUBOQQW
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2FDA2D0", Offset = "0x2FD8AD0", VA = "0x182FDA2D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x632D0B0", Offset = "0x632B8B0", VA = "0x18632D0B0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b INIWBSIIFXM
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x1486CC0", Offset = "0x14854C0", VA = "0x181486CC0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object FHQMLGCUYOC
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x631E060", Offset = "0x631C860", VA = "0x18631E060", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x632A270", Offset = "0x6328A70", VA = "0x18632A270", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x632E0D0", Offset = "0x632C8D0", VA = "0x18632E0D0", Slot = "9")]
		protected override bool KRALCBTAFHO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6335CD0", Offset = "0x63344D0", VA = "0x186335CD0")]
		protected VXILPNSJAIU([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6335810", Offset = "0x6334010", VA = "0x186335810")]
		protected VXILPNSJAIU(MNBQIABPYXS a, ZDTJWVAUIKL b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, PYZGQQWAFPF i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x631DF30", Offset = "0x631C730", VA = "0x18631DF30")]
		public a UXJCJNHNPLK()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x632BC50", Offset = "0x632A450", VA = "0x18632BC50")]
		public void ENPSQMAKGBW(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x1486CC0", Offset = "0x14854C0", VA = "0x181486CC0")]
		public b UXYXBHPFRTL()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x632C440", Offset = "0x632AC40", VA = "0x18632C440")]
		public void EOFNIGICIJX(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632D810", VA = "0x18632F010")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class VXNSMUMGJUD<a, b, c> : YQUQTTWDHKX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a UPAWQZEIKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b UPQRITMAMSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c UPLKLMSDDGS;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a IJZJINHRHFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xABECE0", Offset = "0xABD4E0", VA = "0x180ABECE0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xABE700", Offset = "0xABCF00", VA = "0x180ABE700", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b IKEQFUBOQQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xC42E40", Offset = "0xC41640", VA = "0x180C42E40", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x2814190", Offset = "0x2812990", VA = "0x182814190", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c IKJXDAVMACF
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAB4120", Offset = "0xAB2920", VA = "0x180AB4120", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xAB3A00", Offset = "0xAB2200", VA = "0x180AB3A00", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a INDPELOKWMD
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x631DF30", Offset = "0x631C730", VA = "0x18631DF30")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b INIWBSIIFXM
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x1486CC0", Offset = "0x14854C0", VA = "0x181486CC0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c INOCYZCFPIV
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x5AF2940", Offset = "0x5AF1140", VA = "0x185AF2940")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object FHQMLGCUYOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x631E060", Offset = "0x631C860", VA = "0x18631E060", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x6337F40", Offset = "0x6336740", VA = "0x186337F40", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x633A730", Offset = "0x6338F30", VA = "0x18633A730", Slot = "9")]
		protected override bool KRALCBTAFHO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x63402C0", Offset = "0x633EAC0", VA = "0x1863402C0")]
		protected VXNSMUMGJUD([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6341010", Offset = "0x633F810", VA = "0x186341010")]
		protected VXNSMUMGJUD(MNBQIABPYXS a, ZDTJWVAUIKL b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, PYZGQQWAFPF j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x631DF30", Offset = "0x631C730", VA = "0x18631DF30")]
		public a UXJCJNHNPLK()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6338690", Offset = "0x6336E90", VA = "0x186338690")]
		public void ENPSQMAKGBW(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1486CC0", Offset = "0x14854C0", VA = "0x181486CC0")]
		public b UXYXBHPFRTL()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6339800", Offset = "0x6338000", VA = "0x186339800")]
		public void EOFNIGICIJX(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2940", Offset = "0x5AF1140", VA = "0x185AF2940")]
		public c UXTQEAVIIIC()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6338D70", Offset = "0x6337570", VA = "0x186338D70")]
		public void EOAGKZOEYYO(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x633C260", Offset = "0x633AA60", VA = "0x18633C260")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class VWXXVAEOHMC<a, b, c, d> : YQUQTTWDHKX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a UPAWQZEIKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b UPQRITMAMSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c UPLKLMSDDGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d UOLBZEWQIBZ;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a IJZJINHRHFN
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xCD9080", Offset = "0xCD7880", VA = "0x180CD9080", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x6319150", Offset = "0x6317950", VA = "0x186319150", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b IKEQFUBOQQW
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x1240550", Offset = "0x123ED50", VA = "0x181240550", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x123D3E0", Offset = "0x123BBE0", VA = "0x18123D3E0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c IKJXDAVMACF
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x128D370", Offset = "0x128BB70", VA = "0x18128D370", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6319300", Offset = "0x6317B00", VA = "0x186319300", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d IKPEAHPJJNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1AA5550", Offset = "0x1AA3D50", VA = "0x181AA5550", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x13E0440", Offset = "0x13DEC40", VA = "0x1813E0440", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b INIWBSIIFXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x631ADD0", Offset = "0x63195D0", VA = "0x18631ADD0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c INOCYZCFPIV
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x631ACD0", Offset = "0x63194D0", VA = "0x18631ACD0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d INTJWFWCYUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x137F270", Offset = "0x137DA70", VA = "0x18137F270")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object FHQMLGCUYOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x631E060", Offset = "0x631C860", VA = "0x18631E060", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x6315D30", Offset = "0x6314530", VA = "0x186315D30", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6319440", Offset = "0x6317C40", VA = "0x186319440", Slot = "9")]
		protected override bool KRALCBTAFHO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x631F860", Offset = "0x631E060", VA = "0x18631F860")]
		protected VWXXVAEOHMC([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x631FC30", Offset = "0x631E430", VA = "0x18631FC30")]
		protected VWXXVAEOHMC(MNBQIABPYXS a, ZDTJWVAUIKL b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, PYZGQQWAFPF k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x631DF30", Offset = "0x631C730", VA = "0x18631DF30")]
		public a UXJCJNHNPLK()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x6316FA0", Offset = "0x63157A0", VA = "0x186316FA0")]
		public void ENPSQMAKGBW(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x631ADD0", Offset = "0x63195D0", VA = "0x18631ADD0")]
		public b UXYXBHPFRTL()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6317AD0", Offset = "0x63162D0", VA = "0x186317AD0")]
		public void EOFNIGICIJX(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x631ACD0", Offset = "0x63194D0", VA = "0x18631ACD0")]
		public c UXTQEAVIIIC()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x63174C0", Offset = "0x6315CC0", VA = "0x1863174C0")]
		public void EOAGKZOEYYO(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x137F270", Offset = "0x137DA70", VA = "0x18137F270")]
		public d UWTHRSZVNDJ()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x6318C20", Offset = "0x6317420", VA = "0x186318C20")]
		public void EOQBCTVXBGP(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x631D0F0", Offset = "0x631B8F0", VA = "0x18631D0F0")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class VXDESGYLQXL<a, b, c, d, e> : YQUQTTWDHKX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a UPAWQZEIKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b UPQRITMAMSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c UPLKLMSDDGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d UOLBZEWQIBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e UOFVBYCSYQQ;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a IJZJINHRHFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xABECE0", Offset = "0xABD4E0", VA = "0x180ABECE0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xABE700", Offset = "0xABCF00", VA = "0x180ABE700", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b IKEQFUBOQQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xB5EE40", Offset = "0xB5D640", VA = "0x180B5EE40", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x11EB3A0", Offset = "0x11E9BA0", VA = "0x1811EB3A0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c IKJXDAVMACF
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xB857C0", Offset = "0xB83FC0", VA = "0x180B857C0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xB85CC0", Offset = "0xB844C0", VA = "0x180B85CC0", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d IKPEAHPJJNO
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xAC7F50", Offset = "0xAC6750", VA = "0x180AC7F50", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAD7C50", Offset = "0xAD6450", VA = "0x180AD7C50", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e IKUKXOJGSYX
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BB0", Offset = "0xAC63B0", VA = "0x180AC7BB0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x6319050", Offset = "0x6317850", VA = "0x186319050", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object FHQMLGCUYOC
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x631E060", Offset = "0x631C860", VA = "0x18631E060", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x6320A00", Offset = "0x631F200", VA = "0x186320A00", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6321A10", Offset = "0x6320210", VA = "0x186321A10", Slot = "9")]
		protected override bool KRALCBTAFHO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x63228C0", Offset = "0x63210C0", VA = "0x1863228C0")]
		protected VXDESGYLQXL(MNBQIABPYXS a, ZDTJWVAUIKL b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, PYZGQQWAFPF l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x631DF30", Offset = "0x631C730", VA = "0x18631DF30")]
		public a UXJCJNHNPLK()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6320E80", Offset = "0x631F680", VA = "0x186320E80")]
		public void ENPSQMAKGBW(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x1486CC0", Offset = "0x14854C0", VA = "0x181486CC0")]
		public b UXYXBHPFRTL()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6321200", Offset = "0x631FA00", VA = "0x186321200")]
		public void EOFNIGICIJX(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5AF2940", Offset = "0x5AF1140", VA = "0x185AF2940")]
		public c UXTQEAVIIIC()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6321040", Offset = "0x631F840", VA = "0x186321040")]
		public void EOAGKZOEYYO(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x137F270", Offset = "0x137DA70", VA = "0x18137F270")]
		public d UWTHRSZVNDJ()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6321660", Offset = "0x631FE60", VA = "0x186321660")]
		public void EOQBCTVXBGP(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x63228A0", Offset = "0x63210A0", VA = "0x1863228A0")]
		public e UWOAUMFYDSA()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x63214A0", Offset = "0x631FCA0", VA = "0x1863214A0")]
		public void EOKUFNBZRVG(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x63222C0", Offset = "0x6320AC0", VA = "0x1863222C0")]
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
