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
		[Cpp2IlInjected.Address(RVA = "0x986DF80", Offset = "0x986CF80", VA = "0x18986DF80", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int IFZGDSVMRUP = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int IAREOIDPQUV = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int HAYXSICVBXC = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] ALAGERBPNDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string RFFSYPPPNQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream TWLZGRHKBWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool EFTAGUAJFSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> TPDALQXGJSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int TQTOMLSAYKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int EFITWMKNSFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] WVBSYTICLMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int ZECQGTLFKRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int LNHRQWIAAND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int LSIJAFCSVAG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool PAOIERXZTHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x166C540", Offset = "0x166B540", VA = "0x18166C540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x986BA20", Offset = "0x986AA20", VA = "0x18986BA20")]
		public static int EAZJXKHZDLB(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x986C590", Offset = "0x986B590", VA = "0x18986C590")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x986DE10", Offset = "0x986CE10", VA = "0x18986DE10")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x986B9B0", Offset = "0x986A9B0", VA = "0x18986B9B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x986D710", Offset = "0x986C710", VA = "0x18986D710")]
		public void YMWJOZIFYVA(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x986D940", Offset = "0x986C940", VA = "0x18986D940")]
		private void YYVZSUVTMCL([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x986C020", Offset = "0x986B020", VA = "0x18986C020")]
		public int JSRZLTTNLIU()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x986C040", Offset = "0x986B040", VA = "0x18986C040")]
		public int JSRZLTTNLIU([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x986D370", Offset = "0x986C370", VA = "0x18986D370")]
		public int VSGIMUDUZKR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x986C500", Offset = "0x986B500", VA = "0x18986C500")]
		public int MSZAGIMVWMD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x986D240", Offset = "0x986C240", VA = "0x18986D240")]
		public void UFGDKOIGRAG(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x986D290", Offset = "0x986C290", VA = "0x18986D290")]
		public void UFGDKOIGRAG(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x986D160", Offset = "0x986C160", VA = "0x18986D160")]
		public void UFGDKOIGRAG(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x986D390", Offset = "0x986C390", VA = "0x18986D390")]
		private void WTGPBUZTRRB(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x986C010", Offset = "0x986B010", VA = "0x18986C010")]
		public void HEQGHSDEDWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x986BBD0", Offset = "0x986ABD0", VA = "0x18986BBD0")]
		public void EZMFQZVHIYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x986B750", Offset = "0x986A750", VA = "0x18986B750")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x986D7E0", Offset = "0x986C7E0", VA = "0x18986D7E0")]
		public void YOTQZHRNFXW(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x986BAE0", Offset = "0x986AAE0", VA = "0x18986BAE0")]
		public Guid EVBCBKSKVSH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x986CE90", Offset = "0x986BE90", VA = "0x18986CE90")]
		public void SXLCKZFIWFP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x986DD00", Offset = "0x986CD00", VA = "0x18986DD00")]
		public bool ZXZYGUDANCS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x986D470", Offset = "0x986C470", VA = "0x18986D470")]
		public void XBZMJMQYWBI(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x986CE10", Offset = "0x986BE10", VA = "0x18986CE10")]
		public int SRZOMTPTEDB(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x986C9F0", Offset = "0x986B9F0", VA = "0x18986C9F0")]
		public void PZDIXEUNSRJ(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x986BF70", Offset = "0x986AF70", VA = "0x18986BF70")]
		public void HDGKNGINROV(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x986B7C0", Offset = "0x986A7C0", VA = "0x18986B7C0")]
		public byte DGUODXJFDUA(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x986B840", Offset = "0x986A840", VA = "0x18986B840")]
		public uint DNWHJBHEMIK(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x986C230", Offset = "0x986B230", VA = "0x18986C230")]
		public void KTHTSHEGMFZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x986C830", Offset = "0x986B830", VA = "0x18986C830")]
		public void OFKHOZDXZZW(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x986D6B0", Offset = "0x986C6B0", VA = "0x18986D6B0")]
		public int XSXMZXXVXAY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x986DCA0", Offset = "0x986CCA0", VA = "0x18986DCA0")]
		public long ZAWSPRQWNON()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x88152D0", Offset = "0x88142D0", VA = "0x1888152D0")]
		private static uint WCKXKJAQYKB(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87F2390", Offset = "0x87F1390", VA = "0x1887F2390")]
		private static int XUMRIMUVPFL(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x986C6F0", Offset = "0x986B6F0", VA = "0x18986C6F0")]
		private static ulong OEHUKXINVBQ(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x986CE00", Offset = "0x986BE00", VA = "0x18986CE00")]
		private static long SQKHIUUENGC(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x986D930", Offset = "0x986C930", VA = "0x18986D930")]
		public void YUJQANUWRCG(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x986C8A0", Offset = "0x986B8A0", VA = "0x18986C8A0")]
		public void PVBKVIITRMP(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x986D460", Offset = "0x986C460", VA = "0x18986D460")]
		public uint XAMJLVGAHYP()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x986D0B0", Offset = "0x986C0B0", VA = "0x18986D0B0")]
		public ulong TWMTFJUDMQE()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x986DA10", Offset = "0x986CA10", VA = "0x18986DA10")]
		public void YZWBUEPKKUB(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x986BEA0", Offset = "0x986AEA0", VA = "0x18986BEA0")]
		public float FYYGRWFVQZM(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x986B610", Offset = "0x986A610", VA = "0x18986B610")]
		private void BCAAKRYGIPV(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x986CC70", Offset = "0x986BC70", VA = "0x18986CC70")]
		public void RTDSJJLJJQZ(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x986C5B0", Offset = "0x986B5B0", VA = "0x18986C5B0")]
		public float OBANQRRAPHK(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x986B6F0", Offset = "0x986A6F0", VA = "0x18986B6F0")]
		private void CUJYHMKPPKH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x986D510", Offset = "0x986C510", VA = "0x18986D510")]
		public void XINRIBJZKTD(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x986BD00", Offset = "0x986AD00", VA = "0x18986BD00")]
		public float FQAVAZDEULO(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x986B8C0", Offset = "0x986A8C0", VA = "0x18986B8C0")]
		private void DRVKDABRKWD(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x986CC50", Offset = "0x986BC50", VA = "0x18986CC50")]
		public void RSVJGBCLLGT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x986BF50", Offset = "0x986AF50", VA = "0x18986BF50")]
		public float HBTAWYGKUPA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x986BDE0", Offset = "0x986ADE0", VA = "0x18986BDE0")]
		public void FTZSUUIGOUU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x986CEC0", Offset = "0x986BEC0", VA = "0x18986CEC0")]
		public string TFPPGMPYPED()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37CC9B0", Offset = "0x37CB9B0", VA = "0x1837CC9B0")]
		public void QUSBMWRKLIZ<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x37CC540", Offset = "0x37CB540", VA = "0x1837CC540")]
		public List<c> HJUEEVJVJNE<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x986B200", Offset = "0x986A200", VA = "0x18986B200")]
		public void AFTIHZFNPQJ(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x986BC50", Offset = "0x986AC50", VA = "0x18986BC50")]
		public Span<byte> FJYKEDHWFAK()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x986CA10", Offset = "0x986BA10", VA = "0x18986CA10")]
		public void QALWJFLTEAV(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x986C700", Offset = "0x986B700", VA = "0x18986C700")]
		public void OEZSGADWXFH(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x986C060", Offset = "0x986B060", VA = "0x18986C060")]
		public uint KQBLNDLQRNA(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x986B3C0", Offset = "0x986A3C0", VA = "0x18986B3C0")]
		private void AOWWLAHPLZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x986C290", Offset = "0x986B290", VA = "0x18986C290")]
		private void LCTRKSVWGBA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class AIFFARAVHOV
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
		[Cpp2IlInjected.Address(RVA = "0x9868C00", Offset = "0x9867C00", VA = "0x189868C00")]
		public static void ULDYLSSILFL(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x98690A0", Offset = "0x98680A0", VA = "0x1898690A0")]
		public static void WUHONSKGITM(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9868700", Offset = "0x9867700", VA = "0x189868700")]
		public static ViewId JNYQASTCWVA(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9868E80", Offset = "0x9867E80", VA = "0x189868E80")]
		public static PartialViewId WQETOUFPMXJ(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9868AA0", Offset = "0x9867AA0", VA = "0x189868AA0")]
		private static bool QXYRXTVRBZY(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9868740", Offset = "0x9867740", VA = "0x189868740")]
		private static PartialViewId KECIRGFOZAP(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9868520", Offset = "0x9867520", VA = "0x189868520")]
		private static bool IKLLWGKSRXV(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x98688B0", Offset = "0x98678B0", VA = "0x1898688B0")]
		private static ViewId LDLOOWRRUMO(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9868C10", Offset = "0x9867C10", VA = "0x189868C10")]
		private static bool VULQCCZZWYG(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9868380", Offset = "0x9867380", VA = "0x189868380")]
		private static ViewId BSHMSEGFFPR(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KRCXBHXJKXG : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds UYWBOKXDVTY;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x986DEF0", Offset = "0x986CEF0", VA = "0x18986DEF0")]
		public KRCXBHXJKXG(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class BFZSEJLGHES
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float UDBSHKAIXKQ;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 PQIQCWYEJEI;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 GBRMSWRFFQE;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds UYWBOKXDVTY;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x986A010", Offset = "0x9869010", VA = "0x18986A010")]
		public static void RUDLNKRXYNX(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x986A910", Offset = "0x9869910", VA = "0x18986A910")]
		public static Quaternion WGAVEXAOHQC(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9869DD0", Offset = "0x9868DD0", VA = "0x189869DD0")]
		public static void QVDREYPOISY(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9869C20", Offset = "0x9868C20", VA = "0x189869C20")]
		public static Vector3 MOROWVVPDCN(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x986AE30", Offset = "0x9869E30", VA = "0x18986AE30")]
		public static void ZBPKEWOORGO(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9869440", Offset = "0x9868440", VA = "0x189869440")]
		public static Vector3 DXJWGTQCHQF(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x986AD10", Offset = "0x9869D10", VA = "0x18986AD10")]
		public static void ZBPKEWOORGO(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9869310", Offset = "0x9868310", VA = "0x189869310")]
		public static Vector3 DXJWGTQCHQF(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x986A850", Offset = "0x9869850", VA = "0x18986A850")]
		private static void THKVEDMHKGX(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x98698C0", Offset = "0x98688C0", VA = "0x1898698C0")]
		private static Vector3 GDDDWSHXUJS(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x986ABA0", Offset = "0x9869BA0", VA = "0x18986ABA0")]
		public static void WVILQMIUABR(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9869EE0", Offset = "0x9868EE0", VA = "0x189869EE0")]
		public static Quaternion QXWTKSRUYKY(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x98699A0", Offset = "0x98689A0", VA = "0x1898699A0")]
		public static void GNXLUARWHJX(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9869BF0", Offset = "0x9868BF0", VA = "0x189869BF0")]
		public static float LSNFEUTHXTS(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x986A650", Offset = "0x9869650", VA = "0x18986A650")]
		public static void SRMLHITSWAG(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x986A2E0", Offset = "0x98692E0", VA = "0x18986A2E0")]
		public static Vector3 SCALKFOUGEV(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x98699D0", Offset = "0x98689D0", VA = "0x1898699D0")]
		public static void GVLMDSKNRLM(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x98697B0", Offset = "0x98687B0", VA = "0x1898697B0")]
		public static Vector3 EALXBLQOPUB(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9869B90", Offset = "0x9868B90", VA = "0x189869B90")]
		public static void HVEUEYXGHMB(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x986A260", Offset = "0x9869260", VA = "0x18986A260")]
		public static Vector3 SBJMOKXOZZS(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9869D20", Offset = "0x9868D20", VA = "0x189869D20")]
		public static void NAJEMBHDMLJ(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x986AFD0", Offset = "0x9869FD0", VA = "0x18986AFD0")]
		public static Vector3 ZJPMEHNARSS(this BitPacker a, float b, float c, int d = 8)
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
