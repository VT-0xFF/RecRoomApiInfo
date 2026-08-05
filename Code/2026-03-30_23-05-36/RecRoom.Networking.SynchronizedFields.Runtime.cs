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
	public interface RTKIEPSNOHB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool UXECNMUPJQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool OAHKICAHWKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		VPDKWOIWOKH YVYGIBNOHDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		int MHFUFOETOZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		bool VEZZVSPWVPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool WFIKEOEUAPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action YTBXLMOIWQG;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void PKEEMQWSMXN();

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void LHEPKUODNZJ(object a, bool b);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void ORCEJDQCDTH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface XTOQQRLYPFK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		string FGOXRCFRNED
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool DMZNWQKPRVD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface RFDHUHLCSJJ<a> : XTOQQRLYPFK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		a BLPYHOFNUCZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EVIGUNXAYEM(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class UIKWUBMLRDC<a> : RFDHUHLCSJJ<a>, XTOQQRLYPFK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private readonly PSJXPYFPKTH<a> VTEPXOXZXRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly PSJXPYFPKTH<a> ZSIIMXNYNEQ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string FGOXRCFRNED
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD5FD70", Offset = "0xD5EB70", VA = "0x180D5FD70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BGGFONQWMTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x639E1D0", Offset = "0x639CFD0", VA = "0x18639E1D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public a FIVHWDNDWAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x639E980", Offset = "0x639D780", VA = "0x18639E980", Slot = "11")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x639D9D0", Offset = "0x639C7D0", VA = "0x18639D9D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public a BLPYHOFNUCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x639D980", Offset = "0x639C780", VA = "0x18639D980", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x639D490", Offset = "0x639C290", VA = "0x18639D490", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public a JMWYIQGMJFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x639D980", Offset = "0x639C780", VA = "0x18639D980")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x639E740", Offset = "0x639D540", VA = "0x18639E740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool DMZNWQKPRVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x639A8A0", Offset = "0x63996A0", VA = "0x18639A8A0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x639AB60", Offset = "0x6399960", VA = "0x18639AB60", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool RNZDFTPHIPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x639D8E0", Offset = "0x639C6E0", VA = "0x18639D8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x639E030", Offset = "0x639CE30", VA = "0x18639E030", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x639EC60", Offset = "0x639DA60", VA = "0x18639EC60")]
		public UIKWUBMLRDC([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x639D830", Offset = "0x639C630", VA = "0x18639D830")]
		private void IIUIVBPCIOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x639D630", Offset = "0x639C430", VA = "0x18639D630", Slot = "5")]
		public void EVIGUNXAYEM(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x639D570", Offset = "0x639C370", VA = "0x18639D570")]
		public void EVIGUNXAYEM(a a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6399CA0", Offset = "0x6398AA0", VA = "0x186399CA0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public sealed class UJARLVUDTLD<a, b> : RFDHUHLCSJJ<(a, b)>, XTOQQRLYPFK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private readonly PRUCYDXXILG<a, b> VTEPXOXZXRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly PRUCYDXXILG<a, b> ZSIIMXNYNEQ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string FGOXRCFRNED
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xD5FD70", Offset = "0xD5EB70", VA = "0x180D5FD70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool BGGFONQWMTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x63AE9F0", Offset = "0x63AD7F0", VA = "0x1863AE9F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool NNSIHZPMEKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x63A98B0", Offset = "0x63A86B0", VA = "0x1863A98B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool NNNBKSVOUYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x63A97C0", Offset = "0x63A85C0", VA = "0x1863A97C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public (a, b) FIVHWDNDWAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63AF8D0", Offset = "0x63AE6D0", VA = "0x1863AF8D0", Slot = "11")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x63AD690", Offset = "0x63AC490", VA = "0x1863AD690", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public (a, b) BLPYHOFNUCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x63ACD90", Offset = "0x63ABB90", VA = "0x1863ACD90", Slot = "4")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x63A9CA0", Offset = "0x63A8AA0", VA = "0x1863A9CA0", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public (a, b) JMWYIQGMJFT
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x63ABD60", Offset = "0x63AAB60", VA = "0x1863ABD60")]
			get
			{
				return default((a, b));
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x63AEC90", Offset = "0x63ADA90", VA = "0x1863AEC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public a UQKNNLIBSFX
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x63AABC0", Offset = "0x63A99C0", VA = "0x1863AABC0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x63AA3D0", Offset = "0x63A91D0", VA = "0x1863AA3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public a ICDXJMKOVUA
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x63ACA30", Offset = "0x63AB830", VA = "0x1863ACA30")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x63AF220", Offset = "0x63AE020", VA = "0x1863AF220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public a GVSPYJPDCVG
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63ACA30", Offset = "0x63AB830", VA = "0x1863ACA30")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x63AC6D0", Offset = "0x63AB4D0", VA = "0x1863AC6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public b UPUSVRAJPXW
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x63AACD0", Offset = "0x63A9AD0", VA = "0x1863AACD0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x63AAB30", Offset = "0x63A9930", VA = "0x1863AAB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public b ICTSBGSGYCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x63AC900", Offset = "0x63AB700", VA = "0x1863AC900")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public b GWIKQDWVFDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x63AC900", Offset = "0x63AB700", VA = "0x1863AC900")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x63AC120", Offset = "0x63AAF20", VA = "0x1863AC120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool DMZNWQKPRVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x639A8A0", Offset = "0x63996A0", VA = "0x18639A8A0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x639AB60", Offset = "0x6399960", VA = "0x18639AB60", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x63AE030", Offset = "0x63ACE30", VA = "0x1863AE030", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x63B0640", Offset = "0x63AF440", VA = "0x1863B0640")]
		public UJARLVUDTLD([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x63AB5C0", Offset = "0x63AA3C0", VA = "0x1863AB5C0")]
		private void IIUIVBPCIOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x63AF040", Offset = "0x63ADE40", VA = "0x1863AF040")]
		public void VENGVFIVPJH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x63AAE20", Offset = "0x63A9C20", VA = "0x1863AAE20")]
		public void EVIGUNXAYEM(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x63AB240", Offset = "0x63AA040", VA = "0x1863AB240", Slot = "5")]
		private void GXVYXADIVBJ((a, b) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6399CA0", Offset = "0x6398AA0", VA = "0x186399CA0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public sealed class UIVKOPAGJZU<a, b, c> : RFDHUHLCSJJ<(a, b, c)>, XTOQQRLYPFK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly PRZJVKRURWP<a, b, c> VTEPXOXZXRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly PRZJVKRURWP<a, b, c> ZSIIMXNYNEQ;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public string FGOXRCFRNED
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xD5FD70", Offset = "0xD5EB70", VA = "0x180D5FD70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool BGGFONQWMTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x63A7B50", Offset = "0x63A6950", VA = "0x1863A7B50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool NNSIHZPMEKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x63A4440", Offset = "0x63A3240", VA = "0x1863A4440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool NNNBKSVOUYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x63A3E60", Offset = "0x63A2C60", VA = "0x1863A3E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public bool NNHUNMBRLNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x63A4070", Offset = "0x63A2E70", VA = "0x1863A4070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public (a, b, c) FIVHWDNDWAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x63A85D0", Offset = "0x63A73D0", VA = "0x1863A85D0", Slot = "11")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x63A6FC0", Offset = "0x63A5DC0", VA = "0x1863A6FC0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public (a, b, c) BLPYHOFNUCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x63A6AA0", Offset = "0x63A58A0", VA = "0x1863A6AA0", Slot = "4")]
			get
			{
				return default((a, b, c));
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x63A4880", Offset = "0x63A3680", VA = "0x1863A4880", Slot = "13")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public a UQKNNLIBSFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x63A55B0", Offset = "0x63A43B0", VA = "0x1863A55B0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x63A4E40", Offset = "0x63A3C40", VA = "0x1863A4E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public a ICDXJMKOVUA
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x63A69C0", Offset = "0x63A57C0", VA = "0x1863A69C0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a GVSPYJPDCVG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x63A69C0", Offset = "0x63A57C0", VA = "0x1863A69C0")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x63A6760", Offset = "0x63A5560", VA = "0x1863A6760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public b UPUSVRAJPXW
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x63A5770", Offset = "0x63A4570", VA = "0x1863A5770")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x63A5470", Offset = "0x63A4270", VA = "0x1863A5470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public b ICTSBGSGYCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x63A68B0", Offset = "0x63A56B0", VA = "0x1863A68B0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public b GWIKQDWVFDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x63A68B0", Offset = "0x63A56B0", VA = "0x1863A68B0")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x63A61C0", Offset = "0x63A4FC0", VA = "0x1863A61C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public c UPZZSXUGZJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x63A5690", Offset = "0x63A4490", VA = "0x1863A5690")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x63A51A0", Offset = "0x63A3FA0", VA = "0x1863A51A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public c ICOLDZYJOQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x63A68E0", Offset = "0x63A56E0", VA = "0x1863A68E0")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public c GWDDSXCXVRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x63A68E0", Offset = "0x63A56E0", VA = "0x1863A68E0")]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x63A6550", Offset = "0x63A5350", VA = "0x1863A6550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool DMZNWQKPRVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x639A8A0", Offset = "0x63996A0", VA = "0x18639A8A0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x63A7AA0", Offset = "0x63A68A0", VA = "0x1863A7AA0", Slot = "10")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x63A9090", Offset = "0x63A7E90", VA = "0x1863A9090")]
		public UIVKOPAGJZU([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x63A5C70", Offset = "0x63A4A70", VA = "0x1863A5C70")]
		private void IIUIVBPCIOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x63A8090", Offset = "0x63A6E90", VA = "0x1863A8090")]
		public void VENGVFIVPJH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x63A8450", Offset = "0x63A7250", VA = "0x1863A8450")]
		public void XHFIHOSLFVA(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x63A4BC0", Offset = "0x63A39C0", VA = "0x1863A4BC0")]
		public void CSOPPXRFKSD(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x63A57A0", Offset = "0x63A45A0", VA = "0x1863A57A0")]
		public void EVIGUNXAYEM(a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x63A6160", Offset = "0x63A4F60", VA = "0x1863A6160", Slot = "5")]
		private void KBWLBHMXIEQ((a, b, c) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6399CA0", Offset = "0x6398AA0", VA = "0x186399CA0", Slot = "8")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class UHVCCHETOVB<a, b, c, d> : RFDHUHLCSJJ<(a, b, c, d)>, XTOQQRLYPFK, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly PRJPDQKCPOO<a, b, c, d> VTEPXOXZXRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly PRJPDQKCPOO<a, b, c, d> ZSIIMXNYNEQ;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string FGOXRCFRNED
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xD5FD70", Offset = "0xD5EB70", VA = "0x180D5FD70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public (a, b, c, d) BLPYHOFNUCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x639A3A0", Offset = "0x63991A0", VA = "0x18639A3A0", Slot = "4")]
			get
			{
				return default((a, b, c, d));
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x6399880", Offset = "0x6398680", VA = "0x186399880", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public b ICTSBGSGYCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x639AA50", Offset = "0x6399850", VA = "0x18639AA50")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public c ICOLDZYJOQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x639AB30", Offset = "0x6399930", VA = "0x18639AB30")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public d IBOCRSCWTLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x639A8C0", Offset = "0x63996C0", VA = "0x18639A8C0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool DMZNWQKPRVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x639A8A0", Offset = "0x63996A0", VA = "0x18639A8A0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x639AB60", Offset = "0x6399960", VA = "0x18639AB60", Slot = "10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x639B300", Offset = "0x639A100", VA = "0x18639B300")]
		public UHVCCHETOVB([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x639A290", Offset = "0x6399090", VA = "0x18639A290")]
		private void IIUIVBPCIOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x639AF50", Offset = "0x6399D50", VA = "0x18639AF50")]
		public void VENGVFIVPJH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6399FB0", Offset = "0x6398DB0", VA = "0x186399FB0")]
		public void EVIGUNXAYEM(a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x639AB80", Offset = "0x6399980", VA = "0x18639AB80", Slot = "5")]
		private void UTOOYOTGVPM((a, b, c, d) a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6399CA0", Offset = "0x6398AA0", VA = "0x186399CA0", Slot = "8")]
		public void Dispose()
		{
		}
	}
}
namespace RecRoom.Networking.Policy
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public static class XDCNJWFCYWN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x865F430", Offset = "0x865E230", VA = "0x18865F430")]
		public static string UVFYPAEFXUU(this SyncData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB32A20", Offset = "0xB31820", VA = "0x180B32A20")]
		public static NetworkSetterPermissionMode QFLSTXMFQGJ(this SyncData a)
		{
			return default(NetworkSetterPermissionMode);
		}
	}
}
namespace RecRoom.Networking.SynchronizedFields
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class PSJXPYFPKTH<a> : TRDRLDHIGUU<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5C59840", Offset = "0x5C58640", VA = "0x185C59840")]
		public PSJXPYFPKTH([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5C5A7C0", Offset = "0x5C595C0", VA = "0x185C5A7C0")]
		public PSJXPYFPKTH(OQBWNKEZELI a, VPDKWOIWOKH b, string c, a d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] XBSBJDZETNS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5C57CE0", Offset = "0x5C56AE0", VA = "0x185C57CE0")]
		public PSJXPYFPKTH(OQBWNKEZELI a, string b, a c, NetworkSetterPermissionMode d, [Optional] Action e, [Optional] XBSBJDZETNS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5C5B890", Offset = "0x5C5A690", VA = "0x185C5B890")]
		public PSJXPYFPKTH(OQBWNKEZELI a, string b, a c, NetworkSetterPermissionMode d, bool e, [Optional] Action f, [Optional] XBSBJDZETNS g)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class PRUCYDXXILG<a, b> : TRTMCXPAJCV<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5C53D80", Offset = "0x5C52B80", VA = "0x185C53D80")]
		public PRUCYDXXILG([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5C508D0", Offset = "0x5C4F6D0", VA = "0x185C508D0")]
		public PRUCYDXXILG(OQBWNKEZELI a, VPDKWOIWOKH b, string c, a d, b e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] XBSBJDZETNS h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5C535A0", Offset = "0x5C523A0", VA = "0x185C535A0")]
		public PRUCYDXXILG(OQBWNKEZELI a, string b, a c, b d, NetworkSetterPermissionMode e, [Optional] Action f, [Optional] XBSBJDZETNS g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5C532C0", Offset = "0x5C520C0", VA = "0x185C532C0")]
		public PRUCYDXXILG(OQBWNKEZELI a, string b, a c, b d, NetworkSetterPermissionMode e, bool f, [Optional] Action g, [Optional] XBSBJDZETNS h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PRZJVKRURWP<a, b, c> : TROFFQVCZRM<a, b, c>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5C560D0", Offset = "0x5C54ED0", VA = "0x185C560D0")]
		public PRZJVKRURWP([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5C56A00", Offset = "0x5C55800", VA = "0x185C56A00")]
		public PRZJVKRURWP(OQBWNKEZELI a, string b, a c, b d, c e, NetworkSetterPermissionMode f, [Optional] Action g, [Optional] XBSBJDZETNS h)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PRJPDQKCPOO<a, b, c, d> : TQNWTIZQEMT<a, b, c, d>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5C4DF20", Offset = "0x5C4CD20", VA = "0x185C4DF20")]
		public PRJPDQKCPOO([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F460", Offset = "0x5C4E260", VA = "0x185C4F460")]
		public PRJPDQKCPOO(OQBWNKEZELI a, VPDKWOIWOKH b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] XBSBJDZETNS j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F1E0", Offset = "0x5C4DFE0", VA = "0x185C4F1E0")]
		public PRJPDQKCPOO(OQBWNKEZELI a, string b, a c, b d, c e, d f, NetworkSetterPermissionMode g, [Optional] Action h, [Optional] XBSBJDZETNS i)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class PROWAXDZYZX<a, b, c, d, e> : TQIPWCFSVBK<a, b, c, d, e>
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5C50650", Offset = "0x5C4F450", VA = "0x185C50650")]
		public PROWAXDZYZX(OQBWNKEZELI a, VPDKWOIWOKH b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, [Optional] Action j, [Optional] XBSBJDZETNS k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x5C501C0", Offset = "0x5C4EFC0", VA = "0x185C501C0")]
		public PROWAXDZYZX(OQBWNKEZELI a, string b, a c, b d, c e, d f, e g, NetworkSetterPermissionMode h, [Optional] Action i, [Optional] XBSBJDZETNS j)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class QBFPPRTGBDU<a> : TRDRLDHIGUU<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2820", Offset = "0x5CD1620", VA = "0x185CD2820")]
		public QBFPPRTGBDU(VPDKWOIWOKH a, string b, a c, [Optional] Action d, [Optional] XBSBJDZETNS e)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class QBAISKZIRSL<a, b> : TRTMCXPAJCV<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5CD2290", Offset = "0x5CD1090", VA = "0x185CD2290")]
		public QBAISKZIRSL(VPDKWOIWOKH a, string b, a c, b d, [Optional] Action e, [Optional] XBSBJDZETNS f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface CBTMSMSCAQO
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "0")]
		PSJXPYFPKTH<a> CNEQFXYTYVE<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PMFSEJJWRHR : CBTMSMSCAQO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly XBSBJDZETNS OVIHKRWNXEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly OQBWNKEZELI XXDCRZIVRTB;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAD31B0", Offset = "0xAD1FB0", VA = "0x180AD31B0")]
		public PMFSEJJWRHR(XBSBJDZETNS a, OQBWNKEZELI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3987FA0", Offset = "0x3986DA0", VA = "0x183987FA0", Slot = "4")]
		public PSJXPYFPKTH<a> CNEQFXYTYVE<a>(string a, a b, NetworkSetterPermissionMode c, [Optional] Action d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface OGKQYQNISDV : OQBWNKEZELI
	{
		[Cpp2IlInjected.Token(Token = "0x17000036")]
		ViewId NSAQTSKEGJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface OQBWNKEZELI
	{
		[Cpp2IlInjected.Token(Token = "0x17000037")]
		bool LBTYBRJUQCR
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		bool GPWBJASFKJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string ONQTHCTTYFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		bool ICHVYMZPTRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RegisterDestroyHandler(RMTUHOHHKTK handler);

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UnregisterDestroyHandler(RMTUHOHHKTK handler);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class RSDITUBIAVK
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x865F180", Offset = "0x865DF80", VA = "0x18865F180")]
		public static bool UOBHZOZYUIP(this OQBWNKEZELI a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface XBSBJDZETNS : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		VPDKWOIWOKH FPSVGSDUQWG
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool RNZDFTPHIPH
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool ZXAOFJZIORO
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
		object LYJKULFVMHG(string a);

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		object JLJZAEMHRFY(VPDKWOIWOKH a, string b);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void BUYVMDSTSII(string a, object b);

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void SAEREMWPAEC(VPDKWOIWOKH a, string b, object c);

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void UKMCFYLAHLR<a>(string a, a b);

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void CRNDTMADKAB([CanBeNull] VPDKWOIWOKH photonPlayer, string a, ZNBKDMMEHNE b);

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void CNMIWTNMSKY([CanBeNull] VPDKWOIWOKH photonPlayer, string a, ZNBKDMMEHNE b);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "11")]
		b GPLTSIQATJK<b>(object a);

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(Slot = "12")]
		object ZMSYTCMPWRD<c>(c a);

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(Slot = "13")]
		object GPLTSIQATJK(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(Slot = "14")]
		object ZMSYTCMPWRD(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void UDXYQRIEAMM();

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void TVKGNHLSVIO();

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void MDSEZFRFUVX(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct SyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public VPDKWOIWOKH player;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public OQBWNKEZELI context;

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
		public XBSBJDZETNS networkBacking;

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x865F220", Offset = "0x865E020", VA = "0x18865F220")]
		public SyncData(SyncData other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x865F2A0", Offset = "0x865E0A0", VA = "0x18865F2A0")]
		public SyncData(OQBWNKEZELI context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] XBSBJDZETNS networkBacking)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x865F1D0", Offset = "0x865DFD0", VA = "0x18865F1D0")]
		public static SyncData From(OQBWNKEZELI context, string key, NetworkSetterPermissionMode permissionMode, [Optional] Action callback, [Optional] XBSBJDZETNS networkBacking)
		{
			return default(SyncData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class RJNNGBMFCSJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x3A15910", Offset = "0x3A14710", VA = "0x183A15910")]
		public static PSJXPYFPKTH<a> ZNBKDMMEHNE<a>(this SyncData a, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x3A14F00", Offset = "0x3A13D00", VA = "0x183A14F00")]
		public static PRUCYDXXILG<b, c> ZNBKDMMEHNE<b, c>(this SyncData a, b b, c c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3A14FA0", Offset = "0x3A13DA0", VA = "0x183A14FA0")]
		public static PRZJVKRURWP<d, e, f> ZNBKDMMEHNE<d, e, f>(this SyncData a, d b, e c, f d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A153C0", Offset = "0x3A141C0", VA = "0x183A153C0")]
		public static PRJPDQKCPOO<g, h, i, j> ZNBKDMMEHNE<g, h, i, j>(this SyncData a, g b, h c, i d, j e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3A13F50", Offset = "0x3A12D50", VA = "0x183A13F50")]
		public static UIKWUBMLRDC<k> KJHAMPHCCQP<k>(this SyncData a, k b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A13E00", Offset = "0x3A12C00", VA = "0x183A13E00")]
		public static UJARLVUDTLD<l, m> KJHAMPHCCQP<l, m>(this SyncData a, l b, m c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x3A13EA0", Offset = "0x3A12CA0", VA = "0x183A13EA0")]
		public static UIVKOPAGJZU<n, o, p> KJHAMPHCCQP<n, o, p>(this SyncData a, n b, o c, p d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x3A14910", Offset = "0x3A13710", VA = "0x183A14910")]
		public static UHVCCHETOVB<q, r, s, t> KJHAMPHCCQP<q, r, s, t>(this SyncData a, q b, r c, s d, t e)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public abstract class ZNBKDMMEHNE : RMTUHOHHKTK, IDisposable
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
		private static Stack<XBSBJDZETNS> XHGTLOJNALK;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool WHBHCEYHFTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		protected readonly VPDKWOIWOKH HHYPWQEBMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		protected readonly OQBWNKEZELI XXDCRZIVRTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		protected readonly string IBCPJYJQVFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		protected readonly NetworkSetterPermissionMode RGIGILRILTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		protected readonly Action ZVLGVFFRJCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		protected XBSBJDZETNS ZGFCDJZKPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Flags TUFNIJZNCDN;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public static XBSBJDZETNS QPKSCFSOKPK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8660460", Offset = "0x865F260", VA = "0x188660460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private bool QNBBDQORSME
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8660310", Offset = "0x865F110", VA = "0x188660310")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8660320", Offset = "0x865F120", VA = "0x188660320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		private bool XFPHOIJTLHZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x865FFD0", Offset = "0x865EDD0", VA = "0x18865FFD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8660210", Offset = "0x865F010", VA = "0x188660210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool AKAMSXWHDXM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8660690", Offset = "0x865F490", VA = "0x188660690")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x865FB20", Offset = "0x865E920", VA = "0x18865FB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool DMZNWQKPRVD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x86604D0", Offset = "0x865F2D0", VA = "0x1886604D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8660720", Offset = "0x865F520", VA = "0x188660720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		protected virtual object GSFISKTEGFR
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACB650", VA = "0x180ACC850", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xACC830", Offset = "0xACB630", VA = "0x180ACC830", Slot = "8")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool UCWCHQTQEYS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x8660A40", Offset = "0x865F840", VA = "0x188660A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public int GBCEIEPJCYN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xC9F980", Offset = "0xC9E780", VA = "0x180C9F980")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x188CE70", Offset = "0x188BC70", VA = "0x18188CE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public string FGOXRCFRNED
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool RNZDFTPHIPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x86601B0", Offset = "0x865EFB0", VA = "0x1886601B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x86609A0", Offset = "0x865F7A0", VA = "0x1886609A0")]
		public static void XKDGXCQNJYF(XBSBJDZETNS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool TMJIWVLRJNV();

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8660B30", Offset = "0x865F930", VA = "0x188660B30")]
		protected ZNBKDMMEHNE(VPDKWOIWOKH a, OQBWNKEZELI b, string c, NetworkSetterPermissionMode d, Action e, XBSBJDZETNS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x865FD90", Offset = "0x865EB90", VA = "0x18865FD90", Slot = "1")]
		~ZNBKDMMEHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x865F9B0", Offset = "0x865E7B0", VA = "0x18865F9B0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8660340", Offset = "0x865F140", VA = "0x188660340")]
		private void NLOQQOJCBIR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x86604E0", Offset = "0x865F2E0", VA = "0x1886604E0")]
		private object RRFKMSSKEOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x865FFE0", Offset = "0x865EDE0", VA = "0x18865FFE0")]
		protected void Initialize(bool enforceInitialValue, object initialValue, bool initialValueIsDefaultValue = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8660650", Offset = "0x865F450", VA = "0x188660650")]
		protected void Set(object newValue, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x865FB40", Offset = "0x865E940", VA = "0x18865FB40")]
		protected void FZAKHLUPDCQ(object a, bool b, bool c, bool d = false, bool e = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x86603E0", Offset = "0x865F1E0", VA = "0x1886603E0")]
		internal void PALMUPZNLTM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x865F5D0", Offset = "0x865E3D0", VA = "0x18865F5D0")]
		private void BLNASGWWFLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x865F950", Offset = "0x865E750", VA = "0x18865F950")]
		private void DPEJXIQIXPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x86606B0", Offset = "0x865F4B0", VA = "0x1886606B0", Slot = "4")]
		private void UNNMUFWYGXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x86606A0", Offset = "0x865F4A0", VA = "0x1886606A0", Slot = "5")]
		private void THTWFRTKAVC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x865F810", Offset = "0x865E610", VA = "0x18865F810")]
		public bool DKYXPMQTGNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x865FE10", Offset = "0x865EC10", VA = "0x18865FE10")]
		public bool HFLNLKXIYIC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x865F6C0", Offset = "0x865E4C0", VA = "0x18865F6C0")]
		private bool DDSXDWPMLVP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x86608F0", Offset = "0x865F6F0", VA = "0x1886608F0")]
		internal void XEXTCKQSLIS(object a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x86607E0", Offset = "0x865F5E0", VA = "0x1886607E0")]
		private void VIZFECLUVGK(object a, bool b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8660200", Offset = "0x865F000", VA = "0x188660200")]
		private bool JHZQBECNQIW(Flags a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x865FDF0", Offset = "0x865EBF0", VA = "0x18865FDF0")]
		private void GDBQQVCLPEO(Flags a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x865F630", Offset = "0x865E430", VA = "0x18865F630")]
		public static string CPIVCVBORHG(VPDKWOIWOKH a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8660230", Offset = "0x865F030", VA = "0x188660230")]
		public static string JSXSEURJTPW(OQBWNKEZELI a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x865F470", Offset = "0x865E270", VA = "0x18865F470")]
		public static bool ACKCSVGEFWK(object a, object b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class MBWLMZSXZFC : XBSBJDZETNS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly Dictionary<object, object> DOHCAPYUBZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly List<string> KYVMRSSQLFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly Dictionary<object, object> OLUWDLSXULJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly List<string> XPQCJPWDOBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private bool ROXLLTQYQAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		protected readonly Dictionary<string, object> CMBSGELUWLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		protected readonly Dictionary<VPDKWOIWOKH, Dictionary<string, object>> PNVRIVGPRMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly HashSet<string> AKSPBHTLEPE;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public abstract Dictionary<object, object> KHDDEPKURPI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public abstract int IPAHBCSBDPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract VPDKWOIWOKH FPSVGSDUQWG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public abstract bool RNZDFTPHIPH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract bool ZXAOFJZIORO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public virtual bool TLNRFMFHCQX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xAE24A0", Offset = "0xAE12A0", VA = "0x180AE24A0", Slot = "28")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public bool VPERIKUXOYP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB20690", Offset = "0xB1F490", VA = "0x180B20690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x3879050", Offset = "0x3877E50", VA = "0x183879050", Slot = "12")]
		public void UKMCFYLAHLR<a>(string a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x865E110", Offset = "0x865CF10", VA = "0x18865E110", Slot = "11")]
		public void SAEREMWPAEC(VPDKWOIWOKH a, string b, object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x865D560", Offset = "0x865C360", VA = "0x18865D560", Slot = "9")]
		public object JLJZAEMHRFY(VPDKWOIWOKH a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x865CA40", Offset = "0x865B840", VA = "0x18865CA40", Slot = "10")]
		public void BUYVMDSTSII(string a, object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x865D980", Offset = "0x865C780", VA = "0x18865D980", Slot = "8")]
		public object LYJKULFVMHG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x865CEA0", Offset = "0x865BCA0", VA = "0x18865CEA0", Slot = "13")]
		public void CRNDTMADKAB(VPDKWOIWOKH a, string b, ZNBKDMMEHNE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x865CB60", Offset = "0x865B960", VA = "0x18865CB60", Slot = "14")]
		public void CNMIWTNMSKY(VPDKWOIWOKH a, string b, ZNBKDMMEHNE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x865DCA0", Offset = "0x865CAA0", VA = "0x18865DCA0")]
		private void MRLBVMHNNAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x865DF60", Offset = "0x865CD60", VA = "0x18865DF60")]
		private void NRWEFDHEBNQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x865ED60", Offset = "0x865DB60", VA = "0x18865ED60")]
		private void ZBAXWIAJVJH(VPDKWOIWOKH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x865D850", Offset = "0x865C650", VA = "0x18865D850")]
		protected void LUBGQNOOHVL(VPDKWOIWOKH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x865CFB0", Offset = "0x865BDB0", VA = "0x18865CFB0")]
		protected void CXQKEHMHNMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x865D970", Offset = "0x865C770", VA = "0x18865D970")]
		protected void LUJFKHJHBLN(IDictionary<object, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x865ECF0", Offset = "0x865DAF0", VA = "0x18865ECF0")]
		protected void VVUPCNXSIQR(VPDKWOIWOKH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x865DFB0", Offset = "0x865CDB0", VA = "0x18865DFB0")]
		protected void PBSNPMLCQMJ(VPDKWOIWOKH a, IDictionary<object, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x865E880", Offset = "0x865D680", VA = "0x18865E880")]
		private void VQJYAXSNUZS(IDictionary<object, object> a, Dictionary<string, object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x865D650", Offset = "0x865C450", VA = "0x18865D650")]
		private static void JRNRDKCZTDG(object a, object b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x865E480", Offset = "0x865D280", VA = "0x18865E480")]
		private static void SPDPKSDSZMD(Dictionary<string, object> a, string b, ZNBKDMMEHNE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x865EDC0", Offset = "0x865DBC0", VA = "0x18865EDC0")]
		private static void ZHIFCZLWONQ(Dictionary<string, object> a, string b, ZNBKDMMEHNE c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x865E780", Offset = "0x865D580", VA = "0x18865E780", Slot = "19")]
		public void UDXYQRIEAMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "29")]
		protected abstract void GHSHZHYDENT(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x865E6A0", Offset = "0x865D4A0", VA = "0x18865E6A0", Slot = "20")]
		public void TVKGNHLSVIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(Slot = "30")]
		protected abstract void GAPSSXNFZQD(Dictionary<object, object> a);

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x865E260", Offset = "0x865D060", VA = "0x18865E260")]
		private void SJFUESQSMTI(Dictionary<object, object> a, List<string> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x865DCF0", Offset = "0x865CAF0", VA = "0x18865DCF0")]
		private void NPVIIZCGDNB(IDictionary<object, object> a, [Out] int b, [Out] string[] c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x865C9B0", Offset = "0x865B7B0", VA = "0x18865C9B0")]
		public void APAXBZVJXUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x865E040", Offset = "0x865CE40", VA = "0x18865E040")]
		public void RUQJBGACIWM(VPDKWOIWOKH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x865D200", Offset = "0x865C000", VA = "0x18865D200")]
		public void HYRTFFFXLVR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "31")]
		protected abstract HashSet<int> JWPUHIRNHAZ(bool a, bool b);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x865DA20", Offset = "0x865C820", VA = "0x18865DA20", Slot = "21")]
		public void MDSEZFRFUVX(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x865CE10", Offset = "0x865BC10", VA = "0x18865CE10")]
		protected string CPIVCVBORHG(VPDKWOIWOKH a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "32")]
		public abstract object ZMSYTCMPWRD<b>(b a);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "33")]
		public abstract c GPLTSIQATJK<c>(object a);

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "34")]
		public abstract object ZMSYTCMPWRD(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "35")]
		public abstract object GPLTSIQATJK(object a, Type b);

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "36")]
		public virtual void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x865D0A0", Offset = "0x865BEA0", VA = "0x18865D0A0", Slot = "22")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "37")]
		protected virtual void UOTXAMRPRSM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x865EF90", Offset = "0x865DD90", VA = "0x18865EF90")]
		protected MBWLMZSXZFC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class TRDRLDHIGUU<a> : ZNBKDMMEHNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private a UHBZWQSAVWR;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		protected virtual a ASYQXVJCKXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x61481B0", Offset = "0x6146FB0", VA = "0x1861481B0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x6142B30", Offset = "0x6141930", VA = "0x186142B30", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		protected override object GSFISKTEGFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x612E220", Offset = "0x612D020", VA = "0x18612E220", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x6147F50", Offset = "0x6146D50", VA = "0x186147F50", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6146FD0", Offset = "0x6145DD0", VA = "0x186146FD0", Slot = "9")]
		protected override bool TMJIWVLRJNV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6148E00", Offset = "0x6147C00", VA = "0x186148E00")]
		protected TRDRLDHIGUU([In] SyncData data, a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x61495C0", Offset = "0x61483C0", VA = "0x1861495C0")]
		protected TRDRLDHIGUU(VPDKWOIWOKH a, OQBWNKEZELI b, string c, a d, NetworkSetterPermissionMode e, bool f, Action g, XBSBJDZETNS h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x612DFE0", Offset = "0x612CDE0", VA = "0x18612DFE0")]
		public a Get()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6144C60", Offset = "0x6143A60", VA = "0x186144C60")]
		public void Set(a newValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6144970", Offset = "0x6143770", VA = "0x186144970")]
		public void Set(a newValue, bool checkPermission, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class TRTMCXPAJCV<a, b> : ZNBKDMMEHNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private a UHBZWQSAVWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private b UGMFEWKITOQ;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		protected virtual a ASYQXVJCKXE
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0xEC5150", Offset = "0xEC3F50", VA = "0x180EC5150", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x1091900", Offset = "0x1090700", VA = "0x181091900", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		protected virtual b ASTKAOPFBLV
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x303B960", Offset = "0x303A760", VA = "0x18303B960", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x6158F70", Offset = "0x6157D70", VA = "0x186158F70", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public b FWFSZSNQYTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x14F24C0", Offset = "0x14F12C0", VA = "0x1814F24C0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		protected override object GSFISKTEGFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x612E220", Offset = "0x612D020", VA = "0x18612E220", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x615F1E0", Offset = "0x615DFE0", VA = "0x18615F1E0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x615DD00", Offset = "0x615CB00", VA = "0x18615DD00", Slot = "9")]
		protected override bool TMJIWVLRJNV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x61648A0", Offset = "0x61636A0", VA = "0x1861648A0")]
		protected TRTMCXPAJCV([In] SyncData data, a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6162B70", Offset = "0x6161970", VA = "0x186162B70")]
		protected TRTMCXPAJCV(VPDKWOIWOKH a, OQBWNKEZELI b, string c, a d, b e, NetworkSetterPermissionMode f, bool g, Action h, XBSBJDZETNS i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x612DFE0", Offset = "0x612CDE0", VA = "0x18612DFE0")]
		public a MNMSKSXPGHJ()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6161840", Offset = "0x6160640", VA = "0x186161840")]
		public void XJAMEMLLKKH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x14F24C0", Offset = "0x14F12C0", VA = "0x1814F24C0")]
		public b MNRZHZRMPSS()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6161D60", Offset = "0x6160B60", VA = "0x186161D60")]
		public void XJFTBTFITVQ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x615BD10", Offset = "0x615AB10", VA = "0x18615BD10")]
		public void Set(a newValue1, b newValue2, bool checkPermission = true, bool suppressCallback = false, bool requireModified = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class TROFFQVCZRM<a, b, c> : ZNBKDMMEHNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private a UHBZWQSAVWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private b UGMFEWKITOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private c UGRMCDEGCZZ;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		protected virtual a ASYQXVJCKXE
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAD9740", Offset = "0xAD8540", VA = "0x180AD9740", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xAD9690", Offset = "0xAD8490", VA = "0x180AD9690", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		protected virtual b ASTKAOPFBLV
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xCC0170", Offset = "0xCBEF70", VA = "0x180CC0170", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x286E490", Offset = "0x286D290", VA = "0x18286E490", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		protected virtual c ASODDHVHSAM
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xAC63F0", Offset = "0xAC51F0", VA = "0x180AC63F0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xAC6150", Offset = "0xAC4F50", VA = "0x180AC6150", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public a FWKZWZHOIFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x612DFE0", Offset = "0x612CDE0", VA = "0x18612DFE0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public b FWFSZSNQYTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x14F24C0", Offset = "0x14F12C0", VA = "0x1814F24C0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public c FWAMCLTTPII
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x5C9F430", Offset = "0x5C9E230", VA = "0x185C9F430")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		protected override object GSFISKTEGFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x612E220", Offset = "0x612D020", VA = "0x18612E220", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x6152CD0", Offset = "0x6151AD0", VA = "0x186152CD0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6150C50", Offset = "0x614FA50", VA = "0x186150C50", Slot = "9")]
		protected override bool TMJIWVLRJNV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6155740", Offset = "0x6154540", VA = "0x186155740")]
		protected TROFFQVCZRM([In] SyncData data, a a, b b, c c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6155820", Offset = "0x6154620", VA = "0x186155820")]
		protected TROFFQVCZRM(VPDKWOIWOKH a, OQBWNKEZELI b, string c, a d, b e, c f, NetworkSetterPermissionMode g, bool h, Action i, XBSBJDZETNS j)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x612DFE0", Offset = "0x612CDE0", VA = "0x18612DFE0")]
		public a MNMSKSXPGHJ()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6153BC0", Offset = "0x61529C0", VA = "0x186153BC0")]
		public void XJAMEMLLKKH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x14F24C0", Offset = "0x14F12C0", VA = "0x1814F24C0")]
		public b MNRZHZRMPSS()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6154520", Offset = "0x6153320", VA = "0x186154520")]
		public void XJFTBTFITVQ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x5C9F430", Offset = "0x5C9E230", VA = "0x185C9F430")]
		public c MNXGFGLJZEB()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6155520", Offset = "0x6154320", VA = "0x186155520")]
		public void XJKZYZZGDGZ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x614F2F0", Offset = "0x614E0F0", VA = "0x18614F2F0")]
		public void Set(a newValue1, b newValue2, c newValue3, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public abstract class TQNWTIZQEMT<a, b, c, d> : ZNBKDMMEHNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private a UHBZWQSAVWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private b UGMFEWKITOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private c UGRMCDEGCZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private d UHRUOKZSYES;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		protected virtual a ASYQXVJCKXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0xD20090", Offset = "0xD1EE90", VA = "0x180D20090", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x612DBB0", Offset = "0x612C9B0", VA = "0x18612DBB0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		protected virtual b ASTKAOPFBLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1266F50", Offset = "0x1265D50", VA = "0x181266F50", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x1261F40", Offset = "0x1260D40", VA = "0x181261F40", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected virtual c ASODDHVHSAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x12EA470", Offset = "0x12E9270", VA = "0x1812EA470", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x6137560", Offset = "0x6136360", VA = "0x186137560", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected virtual d ASIWGBBKIPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x1B1AB20", Offset = "0x1B19920", VA = "0x181B1AB20", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x14490A0", Offset = "0x1447EA0", VA = "0x1814490A0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public b FWFSZSNQYTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x612E0A0", Offset = "0x612CEA0", VA = "0x18612E0A0")]
			get
			{
				return (b)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public c FWAMCLTTPII
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x6137830", Offset = "0x6136630", VA = "0x186137830")]
			get
			{
				return (c)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public d FVVFFEZWFWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x139D7A0", Offset = "0x139C5A0", VA = "0x18139D7A0")]
			get
			{
				return (d)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected override object GSFISKTEGFR
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x612E220", Offset = "0x612D020", VA = "0x18612E220", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x613CF00", Offset = "0x613BD00", VA = "0x18613CF00", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x613BD40", Offset = "0x613AB40", VA = "0x18613BD40", Slot = "9")]
		protected override bool TMJIWVLRJNV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x6140F10", Offset = "0x613FD10", VA = "0x186140F10")]
		protected TQNWTIZQEMT([In] SyncData data, a a, b b, c c, d d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x6140BD0", Offset = "0x613F9D0", VA = "0x186140BD0")]
		protected TQNWTIZQEMT(VPDKWOIWOKH a, OQBWNKEZELI b, string c, a d, b e, c f, d g, NetworkSetterPermissionMode h, bool i, Action j, XBSBJDZETNS k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x612DFE0", Offset = "0x612CDE0", VA = "0x18612DFE0")]
		public a MNMSKSXPGHJ()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x613E140", Offset = "0x613CF40", VA = "0x18613E140")]
		public void XJAMEMLLKKH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x612E0A0", Offset = "0x612CEA0", VA = "0x18612E0A0")]
		public b MNRZHZRMPSS()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x613EB00", Offset = "0x613D900", VA = "0x18613EB00")]
		public void XJFTBTFITVQ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6137830", Offset = "0x6136630", VA = "0x186137830")]
		public c MNXGFGLJZEB()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x613F4A0", Offset = "0x613E2A0", VA = "0x18613F4A0")]
		public void XJKZYZZGDGZ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x139D7A0", Offset = "0x139C5A0", VA = "0x18139D7A0")]
		public d MMMJYLCCLCQ()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x613FC50", Offset = "0x613EA50", VA = "0x18613FC50")]
		public void XJQGWGTDMSI(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x613A490", Offset = "0x6139290", VA = "0x18613A490")]
		public void Set(a newValue1, b newValue2, c newValue3, d newValue4, bool checkPermission = true)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public abstract class TQIPWCFSVBK<a, b, c, d, e> : ZNBKDMMEHNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private a UHBZWQSAVWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private b UGMFEWKITOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private c UGRMCDEGCZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private d UHRUOKZSYES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private e UHXBLRTQHQB;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected virtual a ASYQXVJCKXE
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xAD9740", Offset = "0xAD8540", VA = "0x180AD9740", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0xAD9690", Offset = "0xAD8490", VA = "0x180AD9690", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected virtual b ASTKAOPFBLV
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0xBBFDB0", Offset = "0xBBEBB0", VA = "0x180BBFDB0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x127C6A0", Offset = "0x127B4A0", VA = "0x18127C6A0", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected virtual c ASODDHVHSAM
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xBD7B00", Offset = "0xBD6900", VA = "0x180BD7B00", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return (c)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0xBD7830", Offset = "0xBD6630", VA = "0x180BD7830", Slot = "15")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected virtual d ASIWGBBKIPD
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xAE2870", Offset = "0xAE1670", VA = "0x180AE2870", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return (d)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAF1DE0", Offset = "0xAF0BE0", VA = "0x180AF1DE0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected virtual e ASDPIUHMZDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAE24B0", Offset = "0xAE12B0", VA = "0x180AE24B0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return (e)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x612DBC0", Offset = "0x612C9C0", VA = "0x18612DBC0", Slot = "19")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected override object GSFISKTEGFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x612E220", Offset = "0x612D020", VA = "0x18612E220", Slot = "7")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x61328B0", Offset = "0x61316B0", VA = "0x1861328B0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6130F50", Offset = "0x612FD50", VA = "0x186130F50", Slot = "9")]
		protected override bool TMJIWVLRJNV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x6135830", Offset = "0x6134630", VA = "0x186135830")]
		protected TQIPWCFSVBK(VPDKWOIWOKH a, OQBWNKEZELI b, string c, a d, b e, c f, d g, e h, NetworkSetterPermissionMode i, bool j, Action k, XBSBJDZETNS l)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x612DFE0", Offset = "0x612CDE0", VA = "0x18612DFE0")]
		public a MNMSKSXPGHJ()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x6133830", Offset = "0x6132630", VA = "0x186133830")]
		public void XJAMEMLLKKH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x14F24C0", Offset = "0x14F12C0", VA = "0x1814F24C0")]
		public b MNRZHZRMPSS()
		{
			return (b)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6133ED0", Offset = "0x6132CD0", VA = "0x186133ED0")]
		public void XJFTBTFITVQ(b a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x5C9F430", Offset = "0x5C9E230", VA = "0x185C9F430")]
		public c MNXGFGLJZEB()
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x6134170", Offset = "0x6132F70", VA = "0x186134170")]
		public void XJKZYZZGDGZ(c a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x139D7A0", Offset = "0x139C5A0", VA = "0x18139D7A0")]
		public d MMMJYLCCLCQ()
		{
			return (d)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x6134FB0", Offset = "0x6133DB0", VA = "0x186134FB0")]
		public void XJQGWGTDMSI(d a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x612DF20", Offset = "0x612CD20", VA = "0x18612DF20")]
		public e MMRQVRVZUNZ()
		{
			return (e)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x61350A0", Offset = "0x6133EA0", VA = "0x1861350A0")]
		public void XJVNTNNAWDR(e a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x612F780", Offset = "0x612E580", VA = "0x18612F780")]
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
