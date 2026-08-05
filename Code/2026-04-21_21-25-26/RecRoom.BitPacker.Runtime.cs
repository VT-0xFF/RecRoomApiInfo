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
		[Cpp2IlInjected.Address(RVA = "0x9876FC0", Offset = "0x98759C0", VA = "0x189876FC0", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int MIBBDAVHVZU = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int GFGSNGVVOGU = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int NAAQJDNSRQF = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] RRHVLYLBJPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string UQXDTUSFGJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream YLWPBWKOLDX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool HDCVHPRCRRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> WKXKOCQWTZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int NIXJEDYWODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int IWSPLTXDVUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] SGWUOOAXACT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int YNSCFWUWJQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int YMKEJXSUCWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int ETYZLILSKLV;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool QABLXIYOSBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x16947D0", Offset = "0x16931D0", VA = "0x1816947D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9874230", Offset = "0x9872C30", VA = "0x189874230")]
		public static int SQTXBRINXGU(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9873CA0", Offset = "0x98726A0", VA = "0x189873CA0")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9874F60", Offset = "0x9873960", VA = "0x189874F60")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x98729A0", Offset = "0x98713A0", VA = "0x1898729A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9873820", Offset = "0x9872220", VA = "0x189873820")]
		public void KZHBUYQHHRL(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9874600", Offset = "0x9873000", VA = "0x189874600")]
		private void TFUNIDDFHMQ([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9873A70", Offset = "0x9872470", VA = "0x189873A70")]
		public int MGOOPCJSQGB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9873A50", Offset = "0x9872450", VA = "0x189873A50")]
		public int MGOOPCJSQGB([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9873EB0", Offset = "0x98728B0", VA = "0x189873EB0")]
		public int PJOOYOWAWBC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9873ED0", Offset = "0x98728D0", VA = "0x189873ED0")]
		public int PMZAMVALXHI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9873A90", Offset = "0x9872490", VA = "0x189873A90")]
		public void MJFLJESHDAF(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9873AE0", Offset = "0x98724E0", VA = "0x189873AE0")]
		public void MJFLJESHDAF(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9873BC0", Offset = "0x98725C0", VA = "0x189873BC0")]
		public void MJFLJESHDAF(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9874B40", Offset = "0x9873540", VA = "0x189874B40")]
		private void YZWMICKTSWQ(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9873950", Offset = "0x9872350", VA = "0x189873950")]
		public void MDURUAHXXRU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x98727B0", Offset = "0x98711B0", VA = "0x1898727B0")]
		public void CYTWXUVEUPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9872830", Offset = "0x9871230", VA = "0x189872830")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9872620", Offset = "0x9871020", VA = "0x189872620")]
		public void CQBCHADGYZD(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9873960", Offset = "0x9872360", VA = "0x189873960")]
		public Guid MGBYIUZGVKQ()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9873F60", Offset = "0x9872960", VA = "0x189873F60")]
		public void PRFKKNJHBCA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x98728A0", Offset = "0x98712A0", VA = "0x1898728A0")]
		public bool DMRPOXCKUAJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9872510", Offset = "0x9870F10", VA = "0x189872510")]
		public void BJRCNMZBKZH(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x98749C0", Offset = "0x98733C0", VA = "0x1898749C0")]
		public int YGIOOONRVBE(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9873E90", Offset = "0x9872890", VA = "0x189873E90")]
		public void PHVJALDVLQW(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9874560", Offset = "0x9872F60", VA = "0x189874560")]
		public void TCTXZXJIXOI(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x98730F0", Offset = "0x9871AF0", VA = "0x1898730F0")]
		public byte HZUHYQXJVSD(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x98734F0", Offset = "0x9871EF0", VA = "0x1898734F0")]
		public uint JOSGKCYHLXD(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9872D00", Offset = "0x9871700", VA = "0x189872D00")]
		public void FYNASIKQSMS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x98725B0", Offset = "0x9870FB0", VA = "0x1898725B0")]
		public void CMRERJZCGKD(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9873570", Offset = "0x9871F70", VA = "0x189873570")]
		public int JYDXORXYWLF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x98738F0", Offset = "0x98722F0", VA = "0x1898738F0")]
		public long LRXVAYWBLQI()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8820530", Offset = "0x881EF30", VA = "0x188820530")]
		private static uint RDWJPHHUXEK(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87FD5C0", Offset = "0x87FBFC0", VA = "0x1887FD5C0")]
		private static int NXXDSMRVOMO(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9874B20", Offset = "0x9873520", VA = "0x189874B20")]
		private static ulong YZOHVPVDRGR(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9874880", Offset = "0x9873280", VA = "0x189874880")]
		private static long WABOPDRXYNX(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9874B30", Offset = "0x9873530", VA = "0x189874B30")]
		public void YZTAZOTNXAB(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x98746D0", Offset = "0x98730D0", VA = "0x1898746D0")]
		public void TLJMXKSEGAS(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9874E60", Offset = "0x9873860", VA = "0x189874E60")]
		public uint ZVCSQBZGEJE()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9873F90", Offset = "0x9872990", VA = "0x189873F90")]
		public ulong QIBQPIPKHNF()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9873260", Offset = "0x9871C60", VA = "0x189873260")]
		public void JONRBOFXOQU(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9872C50", Offset = "0x9871650", VA = "0x189872C50")]
		public float EUMTWLTGXIV(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x98728C0", Offset = "0x98712C0", VA = "0x1898728C0")]
		private void DSVTPZWZPJK(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9874C10", Offset = "0x9873610", VA = "0x189874C10")]
		public void ZQPOONCVXWG(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x98740F0", Offset = "0x9872AF0", VA = "0x1898740F0")]
		public float SBQYBMVOGHX(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9874820", Offset = "0x9873220", VA = "0x189874820")]
		private void VZHANHORNJE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9872F50", Offset = "0x9871950", VA = "0x189872F50")]
		public void GVGXWTFTIJI(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9874A40", Offset = "0x9873440", VA = "0x189874A40")]
		public float YNATPPLGGXT(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9873170", Offset = "0x9871B70", VA = "0x189873170")]
		private void IEVFNEGIRYC(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9872770", Offset = "0x9871170", VA = "0x189872770")]
		public void CUXLWQMMSJK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9872790", Offset = "0x9871190", VA = "0x189872790")]
		public float CWOUIQLAAVR()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9874DA0", Offset = "0x98737A0", VA = "0x189874DA0")]
		public void ZUQIIUYABXP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9872D60", Offset = "0x9871760", VA = "0x189872D60")]
		public string FZCCFRHFRYI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3805C70", Offset = "0x3804670", VA = "0x183805C70")]
		public void XXJQLSGAGTC<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3805800", Offset = "0x3804200", VA = "0x183805800")]
		public List<c> EYZPXMFHJON<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9872350", Offset = "0x9870D50", VA = "0x189872350")]
		public void AHYNKECSLFC(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9874040", Offset = "0x9872A40", VA = "0x189874040")]
		public Span<byte> RXORNKYCXTT()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9872A10", Offset = "0x9871410", VA = "0x189872A10")]
		public void EIUZOSTGJRS(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9874890", Offset = "0x9873290", VA = "0x189874890")]
		public void WJUSEHRXXRK(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9873CC0", Offset = "0x98726C0", VA = "0x189873CC0")]
		public uint PEEVVQQGQYV(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x98735D0", Offset = "0x9871FD0", VA = "0x1898735D0")]
		private void KSNZRDXIPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x98742F0", Offset = "0x9872CF0", VA = "0x1898742F0")]
		private void TATHLNKSTWT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class TLVKJFJWCME
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
		[Cpp2IlInjected.Address(RVA = "0x98771E0", Offset = "0x9875BE0", VA = "0x1898771E0")]
		public static void GMAYFTNIQSA(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9877D60", Offset = "0x9876760", VA = "0x189877D60")]
		public static void TDXAVOOQRSR(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9877040", Offset = "0x9875A40", VA = "0x189877040")]
		public static ViewId BJDDLIUFVMV(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9877B40", Offset = "0x9876540", VA = "0x189877B40")]
		public static PartialViewId QOCKNPBWDLQ(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9877080", Offset = "0x9875A80", VA = "0x189877080")]
		private static bool DTVMKWXLJQL(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x98779D0", Offset = "0x98763D0", VA = "0x1898779D0")]
		private static PartialViewId QNCDAHDITKA(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x98777F0", Offset = "0x98761F0", VA = "0x1898777F0")]
		private static bool NQWKLMHJOGG(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9877390", Offset = "0x9875D90", VA = "0x189877390")]
		private static ViewId KHYDFAUTYGV(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9877580", Offset = "0x9875F80", VA = "0x189877580")]
		private static bool NFBDEQQYIGT(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x98771F0", Offset = "0x9875BF0", VA = "0x1898771F0")]
		private static ViewId JJRUPEJMRDO(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class CGDNNPCPEFZ : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds TKCAETURTWT;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9875040", Offset = "0x9873A40", VA = "0x189875040")]
		public CGDNNPCPEFZ(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class LMGNBTNSDGN
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float BFFDSYAYOAN;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 SSNIEIHXIHL;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 UBKCJGBHRRF;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds TKCAETURTWT;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9875450", Offset = "0x9873E50", VA = "0x189875450")]
		public static void BOWTKLRWABO(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9875A10", Offset = "0x9874410", VA = "0x189875A10")]
		public static Quaternion DVOTAYSZWZX(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9876C50", Offset = "0x9875650", VA = "0x189876C50")]
		public static void TJHFBWUVYTB(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9876910", Offset = "0x9875310", VA = "0x189876910")]
		public static Vector3 QXWDWSTAYBS(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x98751F0", Offset = "0x9873BF0", VA = "0x1898751F0")]
		public static void AREYKMVMVCL(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9876390", Offset = "0x9874D90", VA = "0x189876390")]
		public static Vector3 OCXPUGZSBRQ(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x98750D0", Offset = "0x9873AD0", VA = "0x1898750D0")]
		public static void AREYKMVMVCL(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9876260", Offset = "0x9874C60", VA = "0x189876260")]
		public static Vector3 OCXPUGZSBRQ(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9875390", Offset = "0x9873D90", VA = "0x189875390")]
		private static void ASEWHHPFODU(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9876830", Offset = "0x9875230", VA = "0x189876830")]
		private static Vector3 QRESXJYFDXZ(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x98758A0", Offset = "0x98742A0", VA = "0x1898758A0")]
		public static void DKNJFNPFAHY(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9876700", Offset = "0x9875100", VA = "0x189876700")]
		public static Quaternion OWJYCILPBZF(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9875E10", Offset = "0x9874810", VA = "0x189875E10")]
		public static void FSZUQBMDZCS(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9876D60", Offset = "0x9875760", VA = "0x189876D60")]
		public static float TZKYSKOZSTP(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x98756A0", Offset = "0x98740A0", VA = "0x1898756A0")]
		public static void CCNPWSRWGDN(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9875EF0", Offset = "0x98748F0", VA = "0x189875EF0")]
		public static Vector3 NDTJRZZGSVE(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9876A90", Offset = "0x9875490", VA = "0x189876A90")]
		public static void SNYXODQUAOX(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9875D00", Offset = "0x9874700", VA = "0x189875D00")]
		public static Vector3 ELTRUVAXRHU(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9875CA0", Offset = "0x98746A0", VA = "0x189875CA0")]
		public static void DYRXLSBYLBU(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9876A10", Offset = "0x9875410", VA = "0x189876A10")]
		public static Vector3 RSSPEOWMNZH(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9875E40", Offset = "0x9874840", VA = "0x189875E40")]
		public static void FVIEFNQFEGA(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9876D90", Offset = "0x9875790", VA = "0x189876D90")]
		public static Vector3 XSHAVGMXPUT(this BitPacker a, float b, float c, int d = 8)
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
