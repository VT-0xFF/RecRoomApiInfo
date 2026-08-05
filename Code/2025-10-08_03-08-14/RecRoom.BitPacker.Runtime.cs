using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using ExitGames.Client.Photon;
using RecRoom.Foundation;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_BitPacker_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84536D0", Offset = "0x84524D0", VA = "0x1884536D0", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class BitPacker : IDisposable
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct IntFloatType
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public uint AsUInt;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public float AsFloat;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log IRJSVORGEBN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int CGJLOVBUPPC = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int NGRIOZDAMWC = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int ITTCWMECWRZ = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] EILYTMRYDDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string KUKSOBIIHMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private StreamBuffer ACRJOKRIYZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Stream IRUEBKMPKKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool OLQVVPBXTKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Memory<byte> KRYFJTCOODX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int YSJZDNQFQSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int DVUWJORDVYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly byte[] DQFMOJJZNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int UZZBFDDFZVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int JSOWGFJKKCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int YNRBVJOCFUN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool NMGHIYCSIFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD7ED30", Offset = "0xD7DB30", VA = "0x180D7ED30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x844F810", Offset = "0x844E610", VA = "0x18844F810")]
		public static int LBCJKCHZDLI(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8450E60", Offset = "0x844FC60", VA = "0x188450E60")]
		public static uint WAZMQMSXPXK(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x84516B0", Offset = "0x84504B0", VA = "0x1884516B0")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x844F060", Offset = "0x844DE60", VA = "0x18844F060", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x844F370", Offset = "0x844E170", VA = "0x18844F370")]
		public void HEBJDXLRRPF(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x844F330", Offset = "0x844E130", VA = "0x18844F330")]
		public void HEBJDXLRRPF(StreamBuffer a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x844F440", Offset = "0x844E240", VA = "0x18844F440")]
		private void JGIDAFKRFTU([Optional] StreamBuffer a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8450FF0", Offset = "0x844FDF0", VA = "0x188450FF0")]
		public int XOQQJGZRMVF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8450FD0", Offset = "0x844FDD0", VA = "0x188450FD0")]
		public int XOQQJGZRMVF([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x844F610", Offset = "0x844E410", VA = "0x18844F610")]
		public int KGRLCMUAASW()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8451010", Offset = "0x844FE10", VA = "0x188451010")]
		public int XSEPSPKSZNC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x844F9A0", Offset = "0x844E7A0", VA = "0x18844F9A0")]
		public void MABJGZEDAAL(StreamBuffer a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x844FAE0", Offset = "0x844E8E0", VA = "0x18844FAE0")]
		public void MABJGZEDAAL(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x844F9F0", Offset = "0x844E7F0", VA = "0x18844F9F0")]
		public void MABJGZEDAAL(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x844FE20", Offset = "0x844EC20", VA = "0x18844FE20")]
		private void NNRUPLFFFCS(int a, [Optional] StreamBuffer b, [Optional] Memory<byte>? c, [Optional] Stream d, [Optional] object e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x844EEB0", Offset = "0x844DCB0", VA = "0x18844EEB0")]
		public void DIVVOTIYANG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x844F3B0", Offset = "0x844E1B0", VA = "0x18844F3B0")]
		public void ICSYIGTQYYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x844EE30", Offset = "0x844DC30", VA = "0x18844EE30")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x844EA70", Offset = "0x844D870", VA = "0x18844EA70")]
		public void CDGPGIQPJVN(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84508E0", Offset = "0x844F6E0", VA = "0x1884508E0")]
		public Guid QUXLVGJEGAW()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8450D50", Offset = "0x844FB50", VA = "0x188450D50")]
		public void UQYVJDXHQMW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x844F7F0", Offset = "0x844E5F0", VA = "0x18844F7F0")]
		public bool KWBVLDINOCL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x844F630", Offset = "0x844E430", VA = "0x18844F630")]
		public void KOGOONLPNIN(sbyte a, sbyte b, sbyte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8451150", Offset = "0x844FF50", VA = "0x188451150")]
		public void YPKFSKCKMNR(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x844EBC0", Offset = "0x844D9C0", VA = "0x18844EBC0")]
		public sbyte CZCJIVWENMW(sbyte a, sbyte b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8450C70", Offset = "0x844FA70", VA = "0x188450C70")]
		public int TILYGJSFEOQ(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x844F5F0", Offset = "0x844E3F0", VA = "0x18844F5F0")]
		public void JJVYSPZABXG(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8450F30", Offset = "0x844FD30", VA = "0x188450F30")]
		public void XAQIDNNPJNI(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8450D80", Offset = "0x844FB80", VA = "0x188450D80")]
		public byte UXSQDIBNWON(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84510D0", Offset = "0x844FED0", VA = "0x1884510D0")]
		public uint YLAMDJONDWD(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x844E9B0", Offset = "0x844D7B0", VA = "0x18844E9B0")]
		public void BKJRQBSHMFO(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8450740", Offset = "0x844F540", VA = "0x188450740")]
		public void POCQKAAQRUF(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x844EA10", Offset = "0x844D810", VA = "0x18844EA10")]
		public int BSAWPCLFUIJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8450E00", Offset = "0x844FC00", VA = "0x188450E00")]
		public long UYFOLQDPSOS()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7411290", Offset = "0x7410090", VA = "0x187411290")]
		private static uint HYSHGZGPNGQ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x73EE950", Offset = "0x73ED750", VA = "0x1873EE950")]
		private static int BLJBMPYCJPC(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84500D0", Offset = "0x844EED0", VA = "0x1884500D0")]
		private static ulong NXWGHSWSIPZ(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x844F5E0", Offset = "0x844E3E0", VA = "0x18844F5E0")]
		private static long JHWBHZNAPKT(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x844F0E0", Offset = "0x844DEE0", VA = "0x18844F0E0")]
		public void EMUPPGKYJXN(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8451480", Offset = "0x8450280", VA = "0x188451480")]
		public void ZRODJEMBPOA(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x844FE10", Offset = "0x844EC10", VA = "0x18844FE10")]
		public uint MNBKKKXNXGA()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8450E80", Offset = "0x844FC80", VA = "0x188450E80")]
		public ulong WHCNIJQGXGB()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84511F0", Offset = "0x844FFF0", VA = "0x1884511F0")]
		public void ZQZIFLZCXEO(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x844F280", Offset = "0x844E080", VA = "0x18844F280")]
		public float HAWMHOUKUVF(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8450B90", Offset = "0x844F990", VA = "0x188450B90")]
		private void SXKEHSFHUEK(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x844F0F0", Offset = "0x844DEF0", VA = "0x18844F0F0")]
		public void FUTBXLPQVOQ(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8450600", Offset = "0x844F400", VA = "0x188450600")]
		public float OVTCZPSJSWD(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8450CF0", Offset = "0x844FAF0", VA = "0x188450CF0")]
		private void UOGMDNUOUIU(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x844F650", Offset = "0x844E450", VA = "0x18844F650")]
		public void KUSKVOMRSEQ(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x844F8C0", Offset = "0x844E6C0", VA = "0x18844F8C0")]
		public float LQEYPYCLDHV(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x844EF70", Offset = "0x844DD70", VA = "0x18844EF70")]
		private void DVRCHYNLAMU(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x844E990", Offset = "0x844D790", VA = "0x18844E990")]
		public void AOLKOEVNURI(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84510B0", Offset = "0x844FEB0", VA = "0x1884510B0")]
		public float XZXIDYTVHGJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x844F520", Offset = "0x844E320", VA = "0x18844F520")]
		public void JHMWJPYDWYT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x844EC40", Offset = "0x844DA40", VA = "0x18844EC40")]
		public string CZQCNHNNSPY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x36C9AE0", Offset = "0x36C88E0", VA = "0x1836C9AE0")]
		public void OXYLHTVJUEG<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x36C9670", Offset = "0x36C8470", VA = "0x1836C9670")]
		public List<c> MNKYQYWHTYP<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x84509D0", Offset = "0x844F7D0", VA = "0x1884509D0")]
		public void SKSIESLPCYK(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x844EEC0", Offset = "0x844DCC0", VA = "0x18844EEC0")]
		public Span<byte> DQADXHSYGAX()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x844FBD0", Offset = "0x844E9D0", VA = "0x18844FBD0")]
		public void MAFNQIGHACC(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x84507B0", Offset = "0x844F5B0", VA = "0x1884507B0")]
		public void QOGMPPRWXDY(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x844FF00", Offset = "0x844ED00", VA = "0x18844FF00")]
		public uint NOLSUBZCIVN(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84500E0", Offset = "0x844EEE0", VA = "0x1884500E0")]
		private void OAZDSKTHNTD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8450360", Offset = "0x844F160", VA = "0x188450360")]
		private void OHGJDRORUPX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class BXNTCJVYVMG
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private enum CompressionType : uint
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			Reference,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			Basic,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			Range,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			Full
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x844E390", Offset = "0x844D190", VA = "0x18844E390")]
		public static void TPTIBRWOCLI(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x844DBB0", Offset = "0x844C9B0", VA = "0x18844DBB0")]
		public static void FPPJISXRBFV(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x844DA00", Offset = "0x844C800", VA = "0x18844DA00")]
		public static ViewId DPNFCBUYSRR(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x844E590", Offset = "0x844D390", VA = "0x18844E590")]
		public static PartialViewId YAXHGFUQFNW(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x844DFC0", Offset = "0x844CDC0", VA = "0x18844DFC0")]
		private static bool ICRPGDDIKZD(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x844DA40", Offset = "0x844C840", VA = "0x18844DA40")]
		private static PartialViewId EWYOLOYXCLM(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x844E7B0", Offset = "0x844D5B0", VA = "0x18844E7B0")]
		private static bool YGZWXZDQOOE(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x844E3A0", Offset = "0x844D1A0", VA = "0x18844E3A0")]
		private static ViewId VJXKDHFCRAH(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x844E120", Offset = "0x844CF20", VA = "0x18844E120")]
		private static bool RHELQIECHFP(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x844DE20", Offset = "0x844CC20", VA = "0x18844DE20")]
		private static ViewId HKALYDYVKFI(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KONOLAJUWEN : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Bounds RDPYVUBSEQJ;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8453640", Offset = "0x8452440", VA = "0x188453640")]
		public KONOLAJUWEN(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class GEPHDCGZXGT
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly float YDQRTVWTJVF;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 ZQVLKUYESXV;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Vector3 BATBAPCFUNH;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly Bounds RDPYVUBSEQJ;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8451BA0", Offset = "0x84509A0", VA = "0x188451BA0")]
		public static void HNSIGESRQES(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8452D70", Offset = "0x8451B70", VA = "0x188452D70")]
		public static Quaternion PNRHMAWZAGH(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8451A90", Offset = "0x8450890", VA = "0x188451A90")]
		public static void GZZRRNWHXPX(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8452910", Offset = "0x8451710", VA = "0x188452910")]
		public static Vector3 OPYCWMZDBAK(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8452050", Offset = "0x8450E50", VA = "0x188452050")]
		public static void LXATVLPNRWN(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8452440", Offset = "0x8451240", VA = "0x188452440")]
		public static Vector3 MBORWXZHYGU(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x84521F0", Offset = "0x8450FF0", VA = "0x1884521F0")]
		public static void LXATVLPNRWN(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8452310", Offset = "0x8451110", VA = "0x188452310")]
		public static Vector3 MBORWXZHYGU(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8451F90", Offset = "0x8450D90", VA = "0x188451F90")]
		private static void LRZTIZRCXTW(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8451840", Offset = "0x8450640", VA = "0x188451840")]
		private static Vector3 DMSJZADPLAF(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8451920", Offset = "0x8450720", VA = "0x188451920")]
		public static void GQOTNFDVGUQ(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x84527B0", Offset = "0x84515B0", VA = "0x1884527B0")]
		public static Quaternion MPWUTBDJBVX(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8451F60", Offset = "0x8450D60", VA = "0x188451F60")]
		public static void LHDFZLZSAPK(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x84528E0", Offset = "0x84516E0", VA = "0x1884528E0")]
		public static float NJZVNXTSPCD(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x84530E0", Offset = "0x8451EE0", VA = "0x1884530E0")]
		public static void YDGOKSWKRPH(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8452A00", Offset = "0x8451800", VA = "0x188452A00")]
		public static Vector3 PCTLXPRAKGY(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x84532E0", Offset = "0x84520E0", VA = "0x1884532E0")]
		public static void ZTFWOMKIOUJ(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8451E50", Offset = "0x8450C50", VA = "0x188451E50")]
		public static Vector3 KQOIPXKOZPK(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8451DF0", Offset = "0x8450BF0", VA = "0x188451DF0")]
		public static void KGOFIGBQBJG(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8451710", Offset = "0x8450510", VA = "0x188451710")]
		public static Vector3 AAFUDDXGAJN(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8451790", Offset = "0x8450590", VA = "0x188451790")]
		public static void BBPMNPLHELQ(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8453000", Offset = "0x8451E00", VA = "0x188453000")]
		public static Vector3 XOOWQMUSECN(this BitPacker a, float b, float c, int d = 8)
		{
			return default(Vector3);
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
