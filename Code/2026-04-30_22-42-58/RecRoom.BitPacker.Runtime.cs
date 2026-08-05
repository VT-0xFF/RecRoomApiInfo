using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
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
		[Cpp2IlInjected.Address(RVA = "0x9652BD0", Offset = "0x9651FD0", VA = "0x189652BD0", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public uint AsUInt;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public float AsFloat;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int QMBXFMTBMJB = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int GELDBJKMFYJ = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int EVIHFCRLAIE = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] CEDQSORRBPZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string RDUWUDOUXCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream HLPZONXAPSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool NROORYJEBAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> JWZWLJNYGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int ODBTFAUYTZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int SRNIFKOQJCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] OFBRTFZTPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int NRWRWCSLVTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int OAMQJEOEQPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int ISHGPJLISJQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool IMACAOMGSWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x166F910", Offset = "0x166ED10", VA = "0x18166F910")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9650810", Offset = "0x964FC10", VA = "0x189650810")]
		public static int FLZPFVLTMPN(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x96517A0", Offset = "0x9650BA0", VA = "0x1896517A0")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9652B70", Offset = "0x9651F70", VA = "0x189652B70")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x96507A0", Offset = "0x964FBA0", VA = "0x1896507A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9651BF0", Offset = "0x9650FF0", VA = "0x189651BF0")]
		public void QJMRYRACNGC(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9651370", Offset = "0x9650770", VA = "0x189651370")]
		private void JHMREXIGGLJ([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9650BF0", Offset = "0x964FFF0", VA = "0x189650BF0")]
		public int GXBIXLKTWAA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9650BD0", Offset = "0x964FFD0", VA = "0x189650BD0")]
		public int GXBIXLKTWAA([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x964FF80", Offset = "0x964F380", VA = "0x18964FF80")]
		public int ACTVRAWSXGZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9650630", Offset = "0x964FA30", VA = "0x189650630")]
		public int DMECXFXGZXJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x96500B0", Offset = "0x964F4B0", VA = "0x1896500B0")]
		public void BVCGRRGSAWW(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9650100", Offset = "0x964F500", VA = "0x189650100")]
		public void BVCGRRGSAWW(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x964FFD0", Offset = "0x964F3D0", VA = "0x18964FFD0")]
		public void BVCGRRGSAWW(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9652750", Offset = "0x9651B50", VA = "0x189652750")]
		private void UYMXBLBZWUX(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x964FFC0", Offset = "0x964F3C0", VA = "0x18964FFC0")]
		public void BSZGNQKEAKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9651020", Offset = "0x9650420", VA = "0x189651020")]
		public void HTCUGTKMJCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x96505A0", Offset = "0x964F9A0", VA = "0x1896505A0")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9650450", Offset = "0x964F850", VA = "0x189650450")]
		public void CWABBKBDSTS(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9650920", Offset = "0x964FD20", VA = "0x189650920")]
		public Guid FUJYTNDAZLF()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9652100", Offset = "0x9651500", VA = "0x189652100")]
		public void SOHSBIPQYWF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x964FFA0", Offset = "0x964F3A0", VA = "0x18964FFA0")]
		public bool AZIQPIIKJEG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9652420", Offset = "0x9651820", VA = "0x189652420")]
		public void UNJOXADQNBU(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9650C30", Offset = "0x9650030", VA = "0x189650C30")]
		public int HITQVXUIVAL(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9650C10", Offset = "0x9650010", VA = "0x189650C10")]
		public void HHKUVERYKOH(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9651700", Offset = "0x9650B00", VA = "0x189651700")]
		public void MNUONSKDASJ(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9650A10", Offset = "0x964FE10", VA = "0x189650A10")]
		public byte FVGXJXOJVLK(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x96529B0", Offset = "0x9651DB0", VA = "0x1896529B0")]
		public uint XSXWXKWRWSO(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9650B70", Offset = "0x964FF70", VA = "0x189650B70")]
		public void GOPCJHOXWYD(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x96515A0", Offset = "0x96509A0", VA = "0x1896515A0")]
		public void LTIZTSRZSKQ(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9652A30", Offset = "0x9651E30", VA = "0x189652A30")]
		public int ZNTXMCFFCCA()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9651310", Offset = "0x9650710", VA = "0x189651310")]
		public long JHAUNRQLFSF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8610C60", Offset = "0x8610060", VA = "0x188610C60")]
		private static uint SLNEJUSUMOB(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85EDFE0", Offset = "0x85ED3E0", VA = "0x1885EDFE0")]
		private static int VMHIQVMEVHP(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9651450", Offset = "0x9650850", VA = "0x189651450")]
		private static ulong KNKBKJARJFQ(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9651BE0", Offset = "0x9650FE0", VA = "0x189651BE0")]
		private static long POTMUDZGXLA(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9651440", Offset = "0x9650840", VA = "0x189651440")]
		public void JUTOCITKTKW(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9652130", Offset = "0x9651530", VA = "0x189652130")]
		public void UEPQSHZREWX(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9651DA0", Offset = "0x96511A0", VA = "0x189651DA0")]
		public uint QPJYEHXWBDB()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x96501E0", Offset = "0x964F5E0", VA = "0x1896501E0")]
		public ulong BXFGBZOIWAM()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x96524C0", Offset = "0x96518C0", VA = "0x1896524C0")]
		public void UUXNXDMGYNH(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9651E60", Offset = "0x9651260", VA = "0x189651E60")]
		public float RWHHNENRFCG(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x96506C0", Offset = "0x964FAC0", VA = "0x1896506C0")]
		private void DZBAGVHRSAT(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9652820", Offset = "0x9651C20", VA = "0x189652820")]
		public void WMSSODYXFEJ(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9651460", Offset = "0x9650860", VA = "0x189651460")]
		public float KVPNHBDVQSI(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x96508C0", Offset = "0x964FCC0", VA = "0x1896508C0")]
		private void FTPXBWBRPRJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9652280", Offset = "0x9651680", VA = "0x189652280")]
		public void UJBWZVEDFZT(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9651CC0", Offset = "0x96510C0", VA = "0x189651CC0")]
		public float QKAHXGQLZGM(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9651610", Offset = "0x9650A10", VA = "0x189651610")]
		private void MDISUDAQVJJ(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9650610", Offset = "0x964FA10", VA = "0x189650610")]
		public void DJTOMBXHJAP(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9650A90", Offset = "0x964FE90", VA = "0x189650A90")]
		public float GFWQYPUNISS()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9650AB0", Offset = "0x964FEB0", VA = "0x189650AB0")]
		public void GGIJYDDSQHW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9651F10", Offset = "0x9651310", VA = "0x189651F10")]
		public string SARWKHTQHVR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37BD2A0", Offset = "0x37BC6A0", VA = "0x1837BD2A0")]
		public void ZOCLZKLCWCR<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37BCE40", Offset = "0x37BC240", VA = "0x1837BCE40")]
		public List<c> CMARJVDOIXE<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9650290", Offset = "0x964F690", VA = "0x189650290")]
		public void CCGSEVNXCTX(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9651DB0", Offset = "0x96511B0", VA = "0x189651DB0")]
		public Span<byte> RJECPIOJMRE()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9650CB0", Offset = "0x96500B0", VA = "0x189650CB0")]
		public void HJSKHERHKNT(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9650EF0", Offset = "0x96502F0", VA = "0x189650EF0")]
		public void HKQFVFCCHMZ(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x96517C0", Offset = "0x9650BC0", VA = "0x1896517C0")]
		public uint NENUTDQVJEK(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9651990", Offset = "0x9650D90", VA = "0x189651990")]
		private void OBVSYFPJAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x96510A0", Offset = "0x96504A0", VA = "0x1896510A0")]
		private void INWPQFSVJPY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class BBAWXSXJZEJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private enum CompressionType : uint
		{
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			Reference,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			Basic,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			Range,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			Full
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x964FA40", Offset = "0x964EE40", VA = "0x18964FA40")]
		public static void RGMSRIHZHEF(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x964F7D0", Offset = "0x964EBD0", VA = "0x18964F7D0")]
		public static void PPLOUUASFZU(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x964F790", Offset = "0x964EB90", VA = "0x18964F790")]
		public static ViewId KRVYXFXZFXA(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x964FA50", Offset = "0x964EE50", VA = "0x18964FA50")]
		public static PartialViewId RJDUKPBNAKT(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x964F1D0", Offset = "0x964E5D0", VA = "0x18964F1D0")]
		private static bool APDFHXQAWAO(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x964FC70", Offset = "0x964F070", VA = "0x18964FC70")]
		private static PartialViewId RSMDOCWCLWD(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x964EFF0", Offset = "0x964E3F0", VA = "0x18964EFF0")]
		private static bool AACZFJPHGFF(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x964F330", Offset = "0x964E730", VA = "0x18964F330")]
		private static ViewId BXKHHDNSULI(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x964F520", Offset = "0x964E920", VA = "0x18964F520")]
		private static bool DBPIVHFUCEO(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x964FDE0", Offset = "0x964F1E0", VA = "0x18964FDE0")]
		private static ViewId UJYHVOJIENJ(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class TPPDIYTVAKY : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds SPBGTCNNQTE;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9652CC0", Offset = "0x96520C0", VA = "0x189652CC0")]
		public TPPDIYTVAKY(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class ZTYLACSAJIK
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float AXKYWCNLPHO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 YDVFWBRFCOQ;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 PMCJWJAXYIQ;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds SPBGTCNNQTE;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9654880", Offset = "0x9653C80", VA = "0x189654880")]
		public static void ZVLHTNCTRRD(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9653E80", Offset = "0x9653280", VA = "0x189653E80")]
		public static Quaternion MPPERLBVEPI(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9653D70", Offset = "0x9653170", VA = "0x189653D70")]
		public static void LXMQJTTIZGE(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9653B70", Offset = "0x9652F70", VA = "0x189653B70")]
		public static Vector3 JQFQPLJFSIN(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9653700", Offset = "0x9652B00", VA = "0x189653700")]
		public static void FUKSSJBWALY(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9653390", Offset = "0x9652790", VA = "0x189653390")]
		public static Vector3 DWQJONDUNQF(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x96538A0", Offset = "0x9652CA0", VA = "0x1896538A0")]
		public static void FUKSSJBWALY(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9653260", Offset = "0x9652660", VA = "0x189653260")]
		public static Vector3 DWQJONDUNQF(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x96531A0", Offset = "0x96525A0", VA = "0x1896531A0")]
		private static void CTOVRJSWROL(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9653C60", Offset = "0x9653060", VA = "0x189653C60")]
		private static Vector3 JUGAVRRKOCA(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9652D50", Offset = "0x9652150", VA = "0x189652D50")]
		public static void AOYHUPONEZR(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9654480", Offset = "0x9653880", VA = "0x189654480")]
		public static Quaternion SRCJTBDQXUA(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9654770", Offset = "0x9653B70", VA = "0x189654770")]
		public static void WHFXSKQOUHP(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9653D40", Offset = "0x9653140", VA = "0x189653D40")]
		public static float KLGFSKUPAGY(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9652EC0", Offset = "0x96522C0", VA = "0x189652EC0")]
		public static void BMSNIPJOWKK(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9654110", Offset = "0x9653510", VA = "0x189654110")]
		public static Vector3 QORFFAHSMAN(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x96539C0", Offset = "0x9652DC0", VA = "0x1896539C0")]
		public static void HMQWKBULSWC(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x96545B0", Offset = "0x96539B0", VA = "0x1896545B0")]
		public static Vector3 THQGXVVRFLT(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9654820", Offset = "0x9653C20", VA = "0x189654820")]
		public static void ZQZXRFSWOXP(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x96547A0", Offset = "0x9653BA0", VA = "0x1896547A0")]
		public static Vector3 XEXKQPAJMAA(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x96546C0", Offset = "0x9653AC0", VA = "0x1896546C0")]
		public static void UTHFLPTINWH(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x96530C0", Offset = "0x96524C0", VA = "0x1896530C0")]
		public static Vector3 BWMHALZQANA(this BitPacker a, float b, float c, int d = 8)
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
