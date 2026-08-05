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
		[Cpp2IlInjected.Address(RVA = "0x986DFE0", Offset = "0x986CFE0", VA = "0x18986DFE0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x986BA80", Offset = "0x986AA80", VA = "0x18986BA80")]
		public static int EAZJXKHZDLB(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x986C5F0", Offset = "0x986B5F0", VA = "0x18986C5F0")]
		public static uint MaxValue(int bits)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x986DE70", Offset = "0x986CE70", VA = "0x18986DE70")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x986BA10", Offset = "0x986AA10", VA = "0x18986BA10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x986D770", Offset = "0x986C770", VA = "0x18986D770")]
		public void YMWJOZIFYVA(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x986D9A0", Offset = "0x986C9A0", VA = "0x18986D9A0")]
		private void YYVZSUVTMCL([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x986C080", Offset = "0x986B080", VA = "0x18986C080")]
		public int JSRZLTTNLIU()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x986C0A0", Offset = "0x986B0A0", VA = "0x18986C0A0")]
		public int JSRZLTTNLIU([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x986D3D0", Offset = "0x986C3D0", VA = "0x18986D3D0")]
		public int VSGIMUDUZKR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x986C560", Offset = "0x986B560", VA = "0x18986C560")]
		public int MSZAGIMVWMD()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x986D2A0", Offset = "0x986C2A0", VA = "0x18986D2A0")]
		public void UFGDKOIGRAG(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x986D2F0", Offset = "0x986C2F0", VA = "0x18986D2F0")]
		public void UFGDKOIGRAG(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x986D1C0", Offset = "0x986C1C0", VA = "0x18986D1C0")]
		public void UFGDKOIGRAG(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x986D3F0", Offset = "0x986C3F0", VA = "0x18986D3F0")]
		private void WTGPBUZTRRB(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x986C070", Offset = "0x986B070", VA = "0x18986C070")]
		public void HEQGHSDEDWD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x986BC30", Offset = "0x986AC30", VA = "0x18986BC30")]
		public void EZMFQZVHIYP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x986B7B0", Offset = "0x986A7B0", VA = "0x18986B7B0")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x986D840", Offset = "0x986C840", VA = "0x18986D840")]
		public void YOTQZHRNFXW(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x986BB40", Offset = "0x986AB40", VA = "0x18986BB40")]
		public Guid EVBCBKSKVSH()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x986CEF0", Offset = "0x986BEF0", VA = "0x18986CEF0")]
		public void SXLCKZFIWFP(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x986DD60", Offset = "0x986CD60", VA = "0x18986DD60")]
		public bool ZXZYGUDANCS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x986D4D0", Offset = "0x986C4D0", VA = "0x18986D4D0")]
		public void XBZMJMQYWBI(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x986CE70", Offset = "0x986BE70", VA = "0x18986CE70")]
		public int SRZOMTPTEDB(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x986CA50", Offset = "0x986BA50", VA = "0x18986CA50")]
		public void PZDIXEUNSRJ(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x986BFD0", Offset = "0x986AFD0", VA = "0x18986BFD0")]
		public void HDGKNGINROV(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x986B820", Offset = "0x986A820", VA = "0x18986B820")]
		public byte DGUODXJFDUA(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x986B8A0", Offset = "0x986A8A0", VA = "0x18986B8A0")]
		public uint DNWHJBHEMIK(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x986C290", Offset = "0x986B290", VA = "0x18986C290")]
		public void KTHTSHEGMFZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x986C890", Offset = "0x986B890", VA = "0x18986C890")]
		public void OFKHOZDXZZW(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x986D710", Offset = "0x986C710", VA = "0x18986D710")]
		public int XSXMZXXVXAY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x986DD00", Offset = "0x986CD00", VA = "0x18986DD00")]
		public long ZAWSPRQWNON()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8815330", Offset = "0x8814330", VA = "0x188815330")]
		private static uint WCKXKJAQYKB(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x87F23F0", Offset = "0x87F13F0", VA = "0x1887F23F0")]
		private static int XUMRIMUVPFL(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x986C750", Offset = "0x986B750", VA = "0x18986C750")]
		private static ulong OEHUKXINVBQ(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x986CE60", Offset = "0x986BE60", VA = "0x18986CE60")]
		private static long SQKHIUUENGC(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x986D990", Offset = "0x986C990", VA = "0x18986D990")]
		public void YUJQANUWRCG(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x986C900", Offset = "0x986B900", VA = "0x18986C900")]
		public void PVBKVIITRMP(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x986D4C0", Offset = "0x986C4C0", VA = "0x18986D4C0")]
		public uint XAMJLVGAHYP()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x986D110", Offset = "0x986C110", VA = "0x18986D110")]
		public ulong TWMTFJUDMQE()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x986DA70", Offset = "0x986CA70", VA = "0x18986DA70")]
		public void YZWBUEPKKUB(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x986BF00", Offset = "0x986AF00", VA = "0x18986BF00")]
		public float FYYGRWFVQZM(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x986B670", Offset = "0x986A670", VA = "0x18986B670")]
		private void BCAAKRYGIPV(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x986CCD0", Offset = "0x986BCD0", VA = "0x18986CCD0")]
		public void RTDSJJLJJQZ(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x986C610", Offset = "0x986B610", VA = "0x18986C610")]
		public float OBANQRRAPHK(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x986B750", Offset = "0x986A750", VA = "0x18986B750")]
		private void CUJYHMKPPKH(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x986D570", Offset = "0x986C570", VA = "0x18986D570")]
		public void XINRIBJZKTD(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x986BD60", Offset = "0x986AD60", VA = "0x18986BD60")]
		public float FQAVAZDEULO(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x986B920", Offset = "0x986A920", VA = "0x18986B920")]
		private void DRVKDABRKWD(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x986CCB0", Offset = "0x986BCB0", VA = "0x18986CCB0")]
		public void RSVJGBCLLGT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x986BFB0", Offset = "0x986AFB0", VA = "0x18986BFB0")]
		public float HBTAWYGKUPA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x986BE40", Offset = "0x986AE40", VA = "0x18986BE40")]
		public void FTZSUUIGOUU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x986CF20", Offset = "0x986BF20", VA = "0x18986CF20")]
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
		[Cpp2IlInjected.Address(RVA = "0x986B260", Offset = "0x986A260", VA = "0x18986B260")]
		public void AFTIHZFNPQJ(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x986BCB0", Offset = "0x986ACB0", VA = "0x18986BCB0")]
		public Span<byte> FJYKEDHWFAK()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x986CA70", Offset = "0x986BA70", VA = "0x18986CA70")]
		public void QALWJFLTEAV(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x986C760", Offset = "0x986B760", VA = "0x18986C760")]
		public void OEZSGADWXFH(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x986C0C0", Offset = "0x986B0C0", VA = "0x18986C0C0")]
		public uint KQBLNDLQRNA(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x986B420", Offset = "0x986A420", VA = "0x18986B420")]
		private void AOWWLAHPLZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x986C2F0", Offset = "0x986B2F0", VA = "0x18986C2F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9868C60", Offset = "0x9867C60", VA = "0x189868C60")]
		public static void ULDYLSSILFL(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9869100", Offset = "0x9868100", VA = "0x189869100")]
		public static void WUHONSKGITM(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9868760", Offset = "0x9867760", VA = "0x189868760")]
		public static ViewId JNYQASTCWVA(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9868EE0", Offset = "0x9867EE0", VA = "0x189868EE0")]
		public static PartialViewId WQETOUFPMXJ(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9868B00", Offset = "0x9867B00", VA = "0x189868B00")]
		private static bool QXYRXTVRBZY(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x98687A0", Offset = "0x98677A0", VA = "0x1898687A0")]
		private static PartialViewId KECIRGFOZAP(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9868580", Offset = "0x9867580", VA = "0x189868580")]
		private static bool IKLLWGKSRXV(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9868910", Offset = "0x9867910", VA = "0x189868910")]
		private static ViewId LDLOOWRRUMO(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9868C70", Offset = "0x9867C70", VA = "0x189868C70")]
		private static bool VULQCCZZWYG(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x98683E0", Offset = "0x98673E0", VA = "0x1898683E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x986DF50", Offset = "0x986CF50", VA = "0x18986DF50")]
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
		[Cpp2IlInjected.Address(RVA = "0x986A070", Offset = "0x9869070", VA = "0x18986A070")]
		public static void RUDLNKRXYNX(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x986A970", Offset = "0x9869970", VA = "0x18986A970")]
		public static Quaternion WGAVEXAOHQC(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9869E30", Offset = "0x9868E30", VA = "0x189869E30")]
		public static void QVDREYPOISY(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9869C80", Offset = "0x9868C80", VA = "0x189869C80")]
		public static Vector3 MOROWVVPDCN(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x986AE90", Offset = "0x9869E90", VA = "0x18986AE90")]
		public static void ZBPKEWOORGO(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x98694A0", Offset = "0x98684A0", VA = "0x1898694A0")]
		public static Vector3 DXJWGTQCHQF(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x986AD70", Offset = "0x9869D70", VA = "0x18986AD70")]
		public static void ZBPKEWOORGO(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9869370", Offset = "0x9868370", VA = "0x189869370")]
		public static Vector3 DXJWGTQCHQF(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x986A8B0", Offset = "0x98698B0", VA = "0x18986A8B0")]
		private static void THKVEDMHKGX(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9869920", Offset = "0x9868920", VA = "0x189869920")]
		private static Vector3 GDDDWSHXUJS(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x986AC00", Offset = "0x9869C00", VA = "0x18986AC00")]
		public static void WVILQMIUABR(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9869F40", Offset = "0x9868F40", VA = "0x189869F40")]
		public static Quaternion QXWTKSRUYKY(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9869A00", Offset = "0x9868A00", VA = "0x189869A00")]
		public static void GNXLUARWHJX(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9869C50", Offset = "0x9868C50", VA = "0x189869C50")]
		public static float LSNFEUTHXTS(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x986A6B0", Offset = "0x98696B0", VA = "0x18986A6B0")]
		public static void SRMLHITSWAG(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x986A340", Offset = "0x9869340", VA = "0x18986A340")]
		public static Vector3 SCALKFOUGEV(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9869A30", Offset = "0x9868A30", VA = "0x189869A30")]
		public static void GVLMDSKNRLM(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9869810", Offset = "0x9868810", VA = "0x189869810")]
		public static Vector3 EALXBLQOPUB(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9869BF0", Offset = "0x9868BF0", VA = "0x189869BF0")]
		public static void HVEUEYXGHMB(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x986A2C0", Offset = "0x98692C0", VA = "0x18986A2C0")]
		public static Vector3 SBJMOKXOZZS(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9869D80", Offset = "0x9868D80", VA = "0x189869D80")]
		public static void NAJEMBHDMLJ(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x986B030", Offset = "0x986A030", VA = "0x18986B030")]
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
