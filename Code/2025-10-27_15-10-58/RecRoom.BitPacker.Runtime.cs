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
		[Cpp2IlInjected.Address(RVA = "0x85E1B90", Offset = "0x85E0B90", VA = "0x1885E1B90", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int EHCMPUZBAXU = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int LSYMDJCYWMY = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int QCEZBSGNKTD = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] MYDSNGRWJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string ROSVZQONWPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private StreamBuffer LZBGYOWLINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Stream SEWQTVFYCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool ENOLOOYXBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Memory<byte> UNUGGCKWDFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int WXMPKEJENDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int QSQLIOUZNLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly byte[] KVPQDBIYAQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int MYBZYMINUXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int NLWFAFWFMOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int PDWVGDWXEDN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool QWQDEYNSIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xE51CF0", Offset = "0xE50CF0", VA = "0x180E51CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85DEA60", Offset = "0x85DDA60", VA = "0x1885DEA60")]
		public static int UTIRLRONRRW(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85DE2D0", Offset = "0x85DD2D0", VA = "0x1885DE2D0")]
		public static uint OSZFUTSKAZQ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x85DFC40", Offset = "0x85DEC40", VA = "0x1885DFC40")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85DD2A0", Offset = "0x85DC2A0", VA = "0x1885DD2A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85DE990", Offset = "0x85DD990", VA = "0x1885DE990")]
		public void UETDMLSOQLD(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85DE950", Offset = "0x85DD950", VA = "0x1885DE950")]
		public void UETDMLSOQLD(StreamBuffer a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85DEFB0", Offset = "0x85DDFB0", VA = "0x1885DEFB0")]
		private void VWPBQOYVDDS([Optional] StreamBuffer a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85DFB30", Offset = "0x85DEB30", VA = "0x1885DFB30")]
		public int ZINCLMLLWBL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85DFB10", Offset = "0x85DEB10", VA = "0x1885DFB10")]
		public int ZINCLMLLWBL([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85DD6C0", Offset = "0x85DC6C0", VA = "0x1885DD6C0")]
		public int GRZSRZMFBBG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85DE030", Offset = "0x85DD030", VA = "0x1885DE030")]
		public int LUSXZWJLYPM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x85DF9D0", Offset = "0x85DE9D0", VA = "0x1885DF9D0")]
		public void YGQSDHXUVKJ(StreamBuffer a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x85DF8E0", Offset = "0x85DE8E0", VA = "0x1885DF8E0")]
		public void YGQSDHXUVKJ(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x85DFA20", Offset = "0x85DEA20", VA = "0x1885DFA20")]
		public void YGQSDHXUVKJ(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85DDB40", Offset = "0x85DCB40", VA = "0x1885DDB40")]
		private void HYSRGMREUGY(int a, [Optional] StreamBuffer b, [Optional] Memory<byte>? c, [Optional] Stream d, [Optional] object e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x85DD320", Offset = "0x85DC320", VA = "0x1885DD320")]
		public void EAQUQBDOWZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85DE9D0", Offset = "0x85DD9D0", VA = "0x1885DE9D0")]
		public void UEVSKYURRSK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x85DD220", Offset = "0x85DC220", VA = "0x1885DD220")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85DE800", Offset = "0x85DD800", VA = "0x1885DE800")]
		public void TXUUEFEHYAN(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85DE1E0", Offset = "0x85DD1E0", VA = "0x1885DE1E0")]
		public Guid NZIKYOHVQVG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85DF5B0", Offset = "0x85DE5B0", VA = "0x1885DF5B0")]
		public void XFGDIISJMCM(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x85DCF00", Offset = "0x85DBF00", VA = "0x1885DCF00")]
		public bool AAPCANXPTGR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x85DD450", Offset = "0x85DC450", VA = "0x1885DD450")]
		public void FCQKSKMIKZJ(sbyte a, sbyte b, sbyte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85DD3B0", Offset = "0x85DC3B0", VA = "0x1885DD3B0")]
		public void ERUDPXOLIYB(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85DE350", Offset = "0x85DD350", VA = "0x1885DE350")]
		public sbyte QDRCETRPEAE(sbyte a, sbyte b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85DF470", Offset = "0x85DE470", VA = "0x1885DF470")]
		public int XBQNJYKUXSS(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x85DD200", Offset = "0x85DC200", VA = "0x1885DD200")]
		public void CWWUYWBZICG(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85DD900", Offset = "0x85DC900", VA = "0x1885DD900")]
		public void HJCCKZSUJOY(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85DDDF0", Offset = "0x85DCDF0", VA = "0x1885DDDF0")]
		public byte IEQZPHFXYYD(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85DD330", Offset = "0x85DC330", VA = "0x1885DD330")]
		public uint ENCUGJJSPPD(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85DD8A0", Offset = "0x85DC8A0", VA = "0x1885DD8A0")]
		public void GYFKKIKBGES(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85DDE70", Offset = "0x85DCE70", VA = "0x1885DDE70")]
		public void IKAGRMZPUGT(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85DE520", Offset = "0x85DD520", VA = "0x1885DE520")]
		public int TBWNVOIXAFZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85DF880", Offset = "0x85DE880", VA = "0x1885DF880")]
		public long XNAMPUCMRYQ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x755CA60", Offset = "0x755BA60", VA = "0x18755CA60")]
		private static uint LPPWHMUYQKS(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7539E90", Offset = "0x7538E90", VA = "0x187539E90")]
		private static int NELTCQONVXM(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85DE580", Offset = "0x85DD580", VA = "0x1885DE580")]
		private static ulong TRUHEDVBAMB(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x85DEB20", Offset = "0x85DDB20", VA = "0x1885DEB20")]
		private static long VADRIZBWPZT(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x85DDEE0", Offset = "0x85DCEE0", VA = "0x1885DDEE0")]
		public void JXDALSWMNYJ(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85DE3D0", Offset = "0x85DD3D0", VA = "0x1885DE3D0")]
		public void QPXSPMLQFTQ(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x85DD6B0", Offset = "0x85DC6B0", VA = "0x1885DD6B0")]
		public uint FNIAIRYWRXM()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85DD130", Offset = "0x85DC130", VA = "0x1885DD130")]
		public ulong ARANZCDBUVB()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85DED20", Offset = "0x85DDD20", VA = "0x1885DED20")]
		public void VVTZESKQJBO(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x85DF310", Offset = "0x85DE310", VA = "0x1885DF310")]
		public float WGLADVPALTP(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x85DE720", Offset = "0x85DD720", VA = "0x1885DE720")]
		private void TSXNLDYMAUY(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x85DE590", Offset = "0x85DD590", VA = "0x1885DE590")]
		public void TSDYRLSHMGK(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85DDEF0", Offset = "0x85DCEF0", VA = "0x1885DDEF0")]
		public float KVKRDNNBMXP(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85DE2F0", Offset = "0x85DD2F0", VA = "0x1885DE2F0")]
		private void PJFARSAAXVE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85DD9A0", Offset = "0x85DC9A0", VA = "0x1885DD9A0")]
		public void HVGCDATNUAK(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85DD050", Offset = "0x85DC050", VA = "0x1885DD050")]
		public float AKIONFRFJGB(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85DE0F0", Offset = "0x85DD0F0", VA = "0x1885DE0F0")]
		private void NQVJBIFHHRA(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85DD1E0", Offset = "0x85DC1E0", VA = "0x1885DD1E0")]
		public void CGYUIJYBRUQ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85DE0D0", Offset = "0x85DD0D0", VA = "0x1885DE0D0")]
		public float MCKVAYREGRJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85DF4F0", Offset = "0x85DE4F0", VA = "0x1885DF4F0")]
		public void XEBAQHOIYUJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85DEB30", Offset = "0x85DDB30", VA = "0x1885DEB30")]
		public string VLNDFAZCMEE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3743AB0", Offset = "0x3742AB0", VA = "0x183743AB0")]
		public void MWUWFZKNQGM<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3743E50", Offset = "0x3742E50", VA = "0x183743E50")]
		public List<c> UZNGZXMDJGV<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x85DD6E0", Offset = "0x85DC6E0", VA = "0x1885DD6E0")]
		public void GWORBFZVQAA(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85DF3C0", Offset = "0x85DE3C0", VA = "0x1885DF3C0")]
		public Span<byte> WXEFMTLKTJP()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85DD470", Offset = "0x85DC470", VA = "0x1885DD470")]
		public void FNBEFJJVOMQ(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85DCF20", Offset = "0x85DBF20", VA = "0x1885DCF20")]
		public void ADDJMXDJNTG(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85DDC20", Offset = "0x85DCC20", VA = "0x1885DDC20")]
		public uint IDWTIKAOLFP(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85DF090", Offset = "0x85DE090", VA = "0x1885DF090")]
		private void VWQGCQTJZXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85DF5E0", Offset = "0x85DE5E0", VA = "0x1885DF5E0")]
		private void XHSSWAIALCD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class QFWYTOGNTEQ
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
		[Cpp2IlInjected.Address(RVA = "0x85E20A0", Offset = "0x85E10A0", VA = "0x1885E20A0")]
		public static void HDFEMMYVICQ(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85E25D0", Offset = "0x85E15D0", VA = "0x1885E25D0")]
		public static void VYZKFQNGNGR(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85E20B0", Offset = "0x85E10B0", VA = "0x1885E20B0")]
		public static ViewId HHNNTHLVGYR(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85E1C10", Offset = "0x85E0C10", VA = "0x1885E1C10")]
		public static PartialViewId EVJILIISKZQ(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85E20F0", Offset = "0x85E10F0", VA = "0x1885E20F0")]
		private static bool LASOPHNSDZJ(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85E2A30", Offset = "0x85E1A30", VA = "0x1885E2A30")]
		private static PartialViewId YADLACPBHNC(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85E23F0", Offset = "0x85E13F0", VA = "0x1885E23F0")]
		private static bool RPPNEVYVQTE(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85E2840", Offset = "0x85E1840", VA = "0x1885E2840")]
		private static ViewId YABJIHIXBPP(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85E1E30", Offset = "0x85E0E30", VA = "0x1885E1E30")]
		private static bool EZDNAVGPXVB(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85E2250", Offset = "0x85E1250", VA = "0x1885E2250")]
		private static ViewId NZBYTKAWUAY(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ZRGZRMSNLKD : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Bounds LLWFNHMFMWX;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x85E2C20", Offset = "0x85E1C20", VA = "0x1885E2C20")]
		public ZRGZRMSNLKD(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class JJXHBOISDSN
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly float FYCYVOJVTXD;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 PBHHIVKWUEJ;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Vector3 MVZEIRFFCWX;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly Bounds LLWFNHMFMWX;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x85DFFD0", Offset = "0x85DEFD0", VA = "0x1885DFFD0")]
		public static void FKMGLYJNPIM(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85E0800", Offset = "0x85DF800", VA = "0x1885E0800")]
		public static Quaternion LZTKYWPKIQJ(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85E15C0", Offset = "0x85E05C0", VA = "0x1885E15C0")]
		public static void XHYADAJBGBV(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x85E0A90", Offset = "0x85DFA90", VA = "0x1885E0A90")]
		public static Vector3 MEFNSVXBAJC(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x85E0EC0", Offset = "0x85DFEC0", VA = "0x1885E0EC0")]
		public static void PRWILFBUSYT(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x85E0350", Offset = "0x85DF350", VA = "0x1885E0350")]
		public static Vector3 HJVBCMSQGLQ(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x85E0DA0", Offset = "0x85DFDA0", VA = "0x1885E0DA0")]
		public static void PRWILFBUSYT(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x85E0220", Offset = "0x85DF220", VA = "0x1885E0220")]
		public static Vector3 HJVBCMSQGLQ(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x85DFD20", Offset = "0x85DED20", VA = "0x1885DFD20")]
		private static void EKJUEUWDHOK(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x85E1060", Offset = "0x85E0060", VA = "0x1885E1060")]
		private static Vector3 QWEENIYVBTB(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x85E1250", Offset = "0x85E0250", VA = "0x1885E1250")]
		public static void SYIWTSWCRBA(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x85E0C70", Offset = "0x85DFC70", VA = "0x1885E0C70")]
		public static Quaternion PBSBNFWYUGX(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x85E06C0", Offset = "0x85DF6C0", VA = "0x1885E06C0")]
		public static void IDLWSUVAMFI(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x85DFDE0", Offset = "0x85DEDE0", VA = "0x1885DFDE0")]
		public static float EXLPXLBKLNX(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x85E13C0", Offset = "0x85E03C0", VA = "0x1885E13C0")]
		public static void WWPQMWITVGT(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x85E16D0", Offset = "0x85E06D0", VA = "0x1885E16D0")]
		public static Vector3 XIPMXZWXOMO(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x85DFE10", Offset = "0x85DEE10", VA = "0x1885DFE10")]
		public static void FCTMKRKNVRV(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x85E1140", Offset = "0x85E0140", VA = "0x1885E1140")]
		public static Vector3 SKCHOEGALMK(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x85E07A0", Offset = "0x85DF7A0", VA = "0x1885E07A0")]
		public static void JWYPYXJLQMC(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x85DFCA0", Offset = "0x85DECA0", VA = "0x1885DFCA0")]
		public static Vector3 AQGXMIJSEHX(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x85E06F0", Offset = "0x85DF6F0", VA = "0x1885E06F0")]
		public static void JHVXNEENUAE(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x85E0B90", Offset = "0x85DFB90", VA = "0x1885E0B90")]
		public static Vector3 OMYRQPMNTXN(this BitPacker a, float b, float c, int d = 8)
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
