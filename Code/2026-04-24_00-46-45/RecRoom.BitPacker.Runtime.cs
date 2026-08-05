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
		[Cpp2IlInjected.Address(RVA = "0x987F5D0", Offset = "0x987DFD0", VA = "0x18987F5D0", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int XRJGNMMOVQH = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int WOWWZHPNZNX = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int GRHEXHTKRWE = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] DYNNNWLDZNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string MMKDKPAQSJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream LEJGMYKEXTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool OHPDUIPPQPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> JEPXGEAYSMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int LHBYYIYDYWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int HMKFYFHFYXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] FWXJAVZSSUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int XXEDPETHHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int SEUUHOHHGPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int LUFMUJZZFLA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool PKQCFUIYEHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x1695C30", Offset = "0x1694630", VA = "0x181695C30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x987A960", Offset = "0x9879360", VA = "0x18987A960")]
		public static int AJSKXDYNLFN(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x987BF10", Offset = "0x987A910", VA = "0x18987BF10")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x987D570", Offset = "0x987BF70", VA = "0x18987D570")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x987AF60", Offset = "0x9879960", VA = "0x18987AF60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x987C000", Offset = "0x987AA00", VA = "0x18987C000")]
		public void PWMXHHQXMNQ(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x987D010", Offset = "0x987BA10", VA = "0x18987D010")]
		private void YIADEGIRMHJ([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x987C580", Offset = "0x987AF80", VA = "0x18987C580")]
		public int SVQIKBHYUHS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x987C5A0", Offset = "0x987AFA0", VA = "0x18987C5A0")]
		public int SVQIKBHYUHS([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x987B9E0", Offset = "0x987A3E0", VA = "0x18987B9E0")]
		public int HJPKANUMEVX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x987AED0", Offset = "0x98798D0", VA = "0x18987AED0")]
		public int DARQNWYLXRN()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x987B800", Offset = "0x987A200", VA = "0x18987B800")]
		public void GWSSDRTWLTA(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x987B720", Offset = "0x987A120", VA = "0x18987B720")]
		public void GWSSDRTWLTA(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x987B640", Offset = "0x987A040", VA = "0x18987B640")]
		public void GWSSDRTWLTA(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x987BE30", Offset = "0x987A830", VA = "0x18987BE30")]
		private void MHLHJCTVLYT(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x987B240", Offset = "0x9879C40", VA = "0x18987B240")]
		public void EZKUTUMZTMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x987C5C0", Offset = "0x987AFC0", VA = "0x18987C5C0")]
		public void TNJYICMDWYH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x987AE60", Offset = "0x9879860", VA = "0x18987AE60")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x987C300", Offset = "0x987AD00", VA = "0x18987C300")]
		public void SIEOIZCWAAI(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x987C830", Offset = "0x987B230", VA = "0x18987C830")]
		public Guid UISZZMULFEL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x987CE00", Offset = "0x987B800", VA = "0x18987CE00")]
		public void XLXRZBRDODL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x987BFE0", Offset = "0x987A9E0", VA = "0x18987BFE0")]
		public bool PLRWEWFAWOW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x987C200", Offset = "0x987AC00", VA = "0x18987C200")]
		public void SDTPDVGJMCO(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x987CD80", Offset = "0x987B780", VA = "0x18987CD80")]
		public int WVVMIIJEWWD(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x987D460", Offset = "0x987BE60", VA = "0x18987D460")]
		public void ZVLQXZDUBDR(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x987CCE0", Offset = "0x987B6E0", VA = "0x18987CCE0")]
		public void WVEEBSSWHJX(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x987CB70", Offset = "0x987B570", VA = "0x18987CB70")]
		public byte VFHRMKHLQLG(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x987B250", Offset = "0x9879C50", VA = "0x18987B250")]
		public uint GEVGIDFTRKK(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x987BD70", Offset = "0x987A770", VA = "0x18987BD70")]
		public void JZZISBGFQOH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x987C0D0", Offset = "0x987AAD0", VA = "0x18987C0D0")]
		public void QFSKRNKYSDW(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x987AE00", Offset = "0x9879800", VA = "0x18987AE00")]
		public int CQNDAJUDCBS()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x987C2A0", Offset = "0x987ACA0", VA = "0x18987C2A0")]
		public long SDZHRYVZVMZ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8827C60", Offset = "0x8826660", VA = "0x188827C60")]
		private static uint YSLCYJMQXPD(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8804CF0", Offset = "0x88036F0", VA = "0x188804CF0")]
		private static int SPCQTNEGAWF(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x987C140", Offset = "0x987AB40", VA = "0x18987C140")]
		private static ulong QUHZYXUNUGS(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x987BF00", Offset = "0x987A900", VA = "0x18987BF00")]
		private static long MLCIGNEONAO(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x987CE30", Offset = "0x987B830", VA = "0x18987CE30")]
		public void XPHUEWCPVVA(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x987ACB0", Offset = "0x98796B0", VA = "0x18987ACB0")]
		public void CJTWVZGANGT(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x987CCD0", Offset = "0x987B6D0", VA = "0x18987CCD0")]
		public uint VZEKBUMFXFV()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x987BF30", Offset = "0x987A930", VA = "0x18987BF30")]
		public ulong NKTYSFKEGUM()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x987B2D0", Offset = "0x9879CD0", VA = "0x18987B2D0")]
		public void GQQPMLJKKLL(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x987C920", Offset = "0x987B320", VA = "0x18987C920")]
		public float UKXPAEWROFM(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x987B560", Offset = "0x9879F60", VA = "0x18987B560")]
		private void GTGAEFERREX(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x987B850", Offset = "0x987A250", VA = "0x18987B850")]
		public void HCJMPXQTZER(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x987D0E0", Offset = "0x987BAE0", VA = "0x18987D0E0")]
		public float ZHITYSNDNMY(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x987BDD0", Offset = "0x987A7D0", VA = "0x18987BDD0")]
		private void KQZMPLMBGDR(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x987C9D0", Offset = "0x987B3D0", VA = "0x18987C9D0")]
		public void VCJYWFCDLPH(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x987CBF0", Offset = "0x987B5F0", VA = "0x18987CBF0")]
		public float VLJXAOCXEWI(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x987BBC0", Offset = "0x987A5C0", VA = "0x18987BBC0")]
		private void IOBOGPMHDUT(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x987AC90", Offset = "0x9879690", VA = "0x18987AC90")]
		public void BZRRZFEPHSL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x987B220", Offset = "0x9879C20", VA = "0x18987B220")]
		public float EGCLPBFDSHA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x987BCB0", Offset = "0x987A6B0", VA = "0x18987BCB0")]
		public void IWKWHQNHCTG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x987C640", Offset = "0x987B040", VA = "0x18987C640")]
		public string UAXORWQATJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3808E50", Offset = "0x3807850", VA = "0x183808E50")]
		public void VJERAZDFDGV<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x38089E0", Offset = "0x38073E0", VA = "0x1838089E0")]
		public List<c> BIDENYGCTXA<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x987BA00", Offset = "0x987A400", VA = "0x18987BA00")]
		public void HRGKYISNUXP(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x987C150", Offset = "0x987AB50", VA = "0x18987C150")]
		public Span<byte> SAPUZYIRBDE()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x987D220", Offset = "0x987BC20", VA = "0x18987D220")]
		public void ZMWMALZHOFL(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x987C450", Offset = "0x987AE50", VA = "0x18987C450")]
		public void STMHUCPRPDD(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x987CE40", Offset = "0x987B840", VA = "0x18987CE40")]
		public uint YDXMKPPQDGO(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x987AFD0", Offset = "0x98799D0", VA = "0x18987AFD0")]
		private void EADTFDHQMYU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x987AA20", Offset = "0x9879420", VA = "0x18987AA20")]
		private void BCDHFNKAITE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class BMXBPAYHLUZ
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
		[Cpp2IlInjected.Address(RVA = "0x987A280", Offset = "0x9878C80", VA = "0x18987A280")]
		public static void QFCDCBKMULL(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x987A6F0", Offset = "0x98790F0", VA = "0x18987A6F0")]
		public static void XJGKDPKNLQW(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x98799D0", Offset = "0x98783D0", VA = "0x1898799D0")]
		public static ViewId MYQSSJDQEMC(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9879BB0", Offset = "0x98785B0", VA = "0x189879BB0")]
		public static PartialViewId NSFPLLNAUXB(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9879FB0", Offset = "0x98789B0", VA = "0x189879FB0")]
		private static bool PLVXXDOKIMW(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x987A110", Offset = "0x9878B10", VA = "0x18987A110")]
		private static PartialViewId PTODELKKIFB(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9879DD0", Offset = "0x98787D0", VA = "0x189879DD0")]
		private static bool OXZZZEIYJSH(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x987A290", Offset = "0x9878C90", VA = "0x18987A290")]
		private static ViewId RCQMNQXEJZQ(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x987A480", Offset = "0x9878E80", VA = "0x18987A480")]
		private static bool SMCQILWKZZI(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9879A10", Offset = "0x9878410", VA = "0x189879A10")]
		private static ViewId MZDWIVLPXLR(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class GRALFSNQRBO : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds FPUYIWXISHU;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x987D650", Offset = "0x987C050", VA = "0x18987D650")]
		public GRALFSNQRBO(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class KITIMHVXDIS
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float YAILAMUWUQQ;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 FWZQIFHZHHK;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 YZWUGMXSAKM;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds FPUYIWXISHU;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x987EAD0", Offset = "0x987D4D0", VA = "0x18987EAD0")]
		public static void VPDBTURVTFL(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x987E110", Offset = "0x987CB10", VA = "0x18987E110")]
		public static Quaternion HUVCJQQTROG(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x987E3A0", Offset = "0x987CDA0", VA = "0x18987E3A0")]
		public static void JQFYBHBULEI(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x987DF30", Offset = "0x987C930", VA = "0x18987DF30")]
		public static Vector3 GNYDCKZMIRL(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x987EE40", Offset = "0x987D840", VA = "0x18987EE40")]
		public static void YZVLIQUEUPI(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x987F110", Offset = "0x987DB10", VA = "0x18987F110")]
		public static Vector3 ZTHRGGTAMAR(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x987ED20", Offset = "0x987D720", VA = "0x18987ED20")]
		public static void YZVLIQUEUPI(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x987EFE0", Offset = "0x987D9E0", VA = "0x18987EFE0")]
		public static Vector3 ZTHRGGTAMAR(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x987D9F0", Offset = "0x987C3F0", VA = "0x18987D9F0")]
		private static void AMTSNQKPTAP(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x987E030", Offset = "0x987CA30", VA = "0x18987E030")]
		private static Vector3 HLIOOBMETPC(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x987E640", Offset = "0x987D040", VA = "0x18987E640")]
		public static void QXIMBMTMWML(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x987E970", Offset = "0x987D370", VA = "0x18987E970")]
		public static Quaternion TNVRGRSIQPG(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x987DAB0", Offset = "0x987C4B0", VA = "0x18987DAB0")]
		public static void AUJQRBFAYRT(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x987EAA0", Offset = "0x987D4A0", VA = "0x18987EAA0")]
		public static float TVLNKHMPGKQ(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x987D6E0", Offset = "0x987C0E0", VA = "0x18987D6E0")]
		public static void AAAZYJZZTOO(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x987DBC0", Offset = "0x987C5C0", VA = "0x18987DBC0")]
		public static Vector3 EXHXXULNRER(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x987E7B0", Offset = "0x987D1B0", VA = "0x18987E7B0")]
		public static void RFOFDWLATRA(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x987D8E0", Offset = "0x987C2E0", VA = "0x18987D8E0")]
		public static Vector3 ABABXBKYWTP(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x987DAE0", Offset = "0x987C4E0", VA = "0x18987DAE0")]
		public static void CYQYIASIGJT(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x987DB40", Offset = "0x987C540", VA = "0x18987DB40")]
		public static Vector3 DNYHHANQQMY(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x987E4B0", Offset = "0x987CEB0", VA = "0x18987E4B0")]
		public static void MJBEUEEIMZF(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x987E560", Offset = "0x987CF60", VA = "0x18987E560")]
		public static Vector3 PXEUVTEQNBM(this BitPacker a, float b, float c, int d = 8)
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
