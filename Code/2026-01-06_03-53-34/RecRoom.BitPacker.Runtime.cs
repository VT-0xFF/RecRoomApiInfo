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
		[Cpp2IlInjected.Address(RVA = "0x820E130", Offset = "0x820CB30", VA = "0x18820E130", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int ZEMXNTKZHME = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int ZQEBHRWNBEW = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int CAXURVRVWQX = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] EUVSYYKVHVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string KARCCLSLYBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private Stream QWGJKTCCGUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private bool UVTYIVMAQRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Memory<byte> OXZAQMYQHWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int IQYNEEPJVUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int UHHRZRYJZQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly byte[] RHJVKJRQWUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int DRJXVWHLQPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int NWWIMFARHRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int QAAZYQFDHVH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool UQNMBOLUBON
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x1359F00", Offset = "0x1358900", VA = "0x181359F00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8209030", Offset = "0x8207A30", VA = "0x188209030")]
		public static int JACBXFIAZDM(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8209430", Offset = "0x8207E30", VA = "0x188209430")]
		public static uint NJXLXGWWXEE(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x820B280", Offset = "0x8209C80", VA = "0x18820B280")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82089B0", Offset = "0x82073B0", VA = "0x1882089B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8209E10", Offset = "0x8208810", VA = "0x188209E10")]
		public void UDXEFUOQHKD(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82094D0", Offset = "0x8207ED0", VA = "0x1882094D0")]
		private void OPIADAPQRDQ([Optional] Memory<byte>? a, [Optional] Stream b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x820ABC0", Offset = "0x82095C0", VA = "0x18820ABC0")]
		public int YYJXUSLEBUX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x820ABA0", Offset = "0x82095A0", VA = "0x18820ABA0")]
		public int YYJXUSLEBUX([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8208990", Offset = "0x8207390", VA = "0x188208990")]
		public int DXPBQEFUTUK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8209650", Offset = "0x8208050", VA = "0x188209650")]
		public int PTRETVOPAWY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x820A840", Offset = "0x8209240", VA = "0x18820A840")]
		public void YKVVPIBVQPB(Stream a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x820A970", Offset = "0x8209370", VA = "0x18820A970")]
		public void YKVVPIBVQPB(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x820A890", Offset = "0x8209290", VA = "0x18820A890")]
		public void YKVVPIBVQPB(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8209A40", Offset = "0x8208440", VA = "0x188209A40")]
		private void RBCKRUIALPE(int a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8209E00", Offset = "0x8208800", VA = "0x188209E00")]
		public void UDHLSDBHDHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8208D60", Offset = "0x8207760", VA = "0x188208D60")]
		public void IMNNXXEEACE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8208920", Offset = "0x8207320", VA = "0x188208920")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x820AA50", Offset = "0x8209450", VA = "0x18820AA50")]
		public void YOGRSICFVLF(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8209CE0", Offset = "0x82086E0", VA = "0x188209CE0")]
		public Guid TEQSOGYGJTA()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8209DD0", Offset = "0x82087D0", VA = "0x188209DD0")]
		public void TRFNXRMVMVQ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82095C0", Offset = "0x8207FC0", VA = "0x1882095C0")]
		public bool OTVJPCMAWMD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x820A4D0", Offset = "0x8208ED0", VA = "0x18820A4D0")]
		public void XDHIHZPEKDB(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8208A20", Offset = "0x8207420", VA = "0x188208A20")]
		public int EADCIDQEEXC(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x820A4B0", Offset = "0x8208EB0", VA = "0x18820A4B0")]
		public void XAADUUTADMY(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8208690", Offset = "0x8207090", VA = "0x188208690")]
		public void AECKCFSEZKS(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x820AF80", Offset = "0x8209980", VA = "0x18820AF80")]
		public byte ZHRRQYZLOCB(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8209450", Offset = "0x8207E50", VA = "0x188209450")]
		public uint OEOMEZFSJRZ(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x820A570", Offset = "0x8208F70", VA = "0x18820A570")]
		public void XHNAGXNNKPG(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82095E0", Offset = "0x8207FE0", VA = "0x1882095E0")]
		public void OWKQJHDJPHT(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82088C0", Offset = "0x82072C0", VA = "0x1882088C0")]
		public int CVHEUGEGXCF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x820A7E0", Offset = "0x82091E0", VA = "0x18820A7E0")]
		public long YJSHKQSMRQW()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x721E620", Offset = "0x721D020", VA = "0x18721E620")]
		private static uint MIFPIXLLLXS(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x71FBD40", Offset = "0x71FA740", VA = "0x1871FBD40")]
		private static int STNUOMCHAFG(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8209EE0", Offset = "0x82088E0", VA = "0x188209EE0")]
		private static ulong UESPEHAJRTJ(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x820ABE0", Offset = "0x82095E0", VA = "0x18820ABE0")]
		private static long YZEGFOFDLNR(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8209340", Offset = "0x8207D40", VA = "0x188209340")]
		public void MWAHFKSNJRV(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x820A690", Offset = "0x8209090", VA = "0x18820A690")]
		public void YHALSSQREEM(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x820A5D0", Offset = "0x8208FD0", VA = "0x18820A5D0")]
		public uint XJOVLTQBDIA()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8209C30", Offset = "0x8208630", VA = "0x188209C30")]
		public ulong SUUWGZDQIXP()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x820A030", Offset = "0x8208A30", VA = "0x18820A030")]
		public void WJDEVWQIWKS(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x820A5E0", Offset = "0x8208FE0", VA = "0x18820A5E0")]
		public float YGKEOSSRJPR(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8208C80", Offset = "0x8207680", VA = "0x188208C80")]
		private void GEJBMELQMMO(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8208730", Offset = "0x8207130", VA = "0x188208730")]
		public void AQVPXBQCXLC(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8209EF0", Offset = "0x82088F0", VA = "0x188209EF0")]
		public float VUNSDUJBWPF(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8209B10", Offset = "0x8208510", VA = "0x188209B10")]
		private void SCNCGTBEFSY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x820B000", Offset = "0x8209A00", VA = "0x18820B000")]
		public void ZJTUWBCPZDC(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8209350", Offset = "0x8207D50", VA = "0x188209350")]
		public float MZCIIMCXLYP(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x82096E0", Offset = "0x82080E0", VA = "0x1882096E0")]
		private void PWIVTPDXSUA(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82090E0", Offset = "0x8207AE0", VA = "0x1882090E0")]
		public void KEEAPRJQHXE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82095A0", Offset = "0x8207FA0", VA = "0x1882095A0")]
		public float ORBLIDSIZEJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8209B70", Offset = "0x8208570", VA = "0x188209B70")]
		public void SUFCNMFQCSL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x820A2C0", Offset = "0x8208CC0", VA = "0x18820A2C0")]
		public string WPIQFNJPLYO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3466350", Offset = "0x3464D50", VA = "0x183466350")]
		public void BCZTVSTQJGC<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x34666E0", Offset = "0x34650E0", VA = "0x1834666E0")]
		public List<c> QQJXUNEPPNJ<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x820ABF0", Offset = "0x82095F0", VA = "0x18820ABF0")]
		public void ZDDZVARRETI(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8208BD0", Offset = "0x82075D0", VA = "0x188208BD0")]
		public Span<byte> FAJBJDPXKBZ()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8209100", Offset = "0x8207B00", VA = "0x188209100")]
		public void KODPYHBLTIO(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8208AA0", Offset = "0x82074A0", VA = "0x188208AA0")]
		public void EJHBEAVLRFY(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x820ADB0", Offset = "0x82097B0", VA = "0x18820ADB0")]
		public uint ZEMGQYPHRDJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8208DE0", Offset = "0x82077E0", VA = "0x188208DE0")]
		private void IPCPIFUYJTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82097D0", Offset = "0x82081D0", VA = "0x1882097D0")]
		private void QDXTEMXJFJL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class HPIRPYENCDY
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
		[Cpp2IlInjected.Address(RVA = "0x820DD50", Offset = "0x820C750", VA = "0x18820DD50")]
		public static void JCODHSIUKJI(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x820D1A0", Offset = "0x820BBA0", VA = "0x18820D1A0")]
		public static void AAXVWRXHGHB(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x820DF00", Offset = "0x820C900", VA = "0x18820DF00")]
		public static ViewId MXOVBPZIPSP(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x820DB30", Offset = "0x820C530", VA = "0x18820DB30")]
		public static PartialViewId HTIWJOKVAPS(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x820D9D0", Offset = "0x820C3D0", VA = "0x18820D9D0")]
		private static bool HGXCJVOOCAR(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x820D410", Offset = "0x820BE10", VA = "0x18820D410")]
		private static PartialViewId EMOGSHKYEOS(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x820D7F0", Offset = "0x820C1F0", VA = "0x18820D7F0")]
		private static bool GAFCMHPRWYM(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x820DF40", Offset = "0x820C940", VA = "0x18820DF40")]
		private static ViewId OYPJALAQPWX(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x820D580", Offset = "0x820BF80", VA = "0x18820D580")]
		private static bool EZXNGVUWRLH(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x820DD60", Offset = "0x820C760", VA = "0x18820DD60")]
		private static ViewId LSBWDGHBPSO(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class VXNOYJGVJXP : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public static readonly Bounds SDYITFSGKPX;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x820E220", Offset = "0x820CC20", VA = "0x18820E220")]
		public VXNOYJGVJXP(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class GEOCXFUHXOX
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly float APJEHHQBHMT;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		internal static readonly Vector3 KHKCPWEMATZ;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 WCUUIJAVWBD;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public static readonly Bounds SDYITFSGKPX;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x820CAD0", Offset = "0x820B4D0", VA = "0x18820CAD0")]
		public static void VYCKNGCQAUG(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x820BAC0", Offset = "0x820A4C0", VA = "0x18820BAC0")]
		public static Quaternion NJLEPHULHBZ(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x820B9B0", Offset = "0x820A3B0", VA = "0x18820B9B0")]
		public static void NCKECMMBJCV(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x820B5D0", Offset = "0x8209FD0", VA = "0x18820B5D0")]
		public static Vector3 HJLDBQVLYTE(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x820B810", Offset = "0x820A210", VA = "0x18820B810")]
		public static void LEYBWJNVMNX(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x820C010", Offset = "0x820AA10", VA = "0x18820C010")]
		public static Vector3 TZVRLEDTFFW(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x820B6F0", Offset = "0x820A0F0", VA = "0x18820B6F0")]
		public static void LEYBWJNVMNX(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x820C380", Offset = "0x820AD80", VA = "0x18820C380")]
		public static Vector3 TZVRLEDTFFW(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x820CFA0", Offset = "0x820B9A0", VA = "0x18820CFA0")]
		private static void ZOCZPSMOTYI(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x820B4F0", Offset = "0x8209EF0", VA = "0x18820B4F0")]
		private static Vector3 DZAIXRQDRWF(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x820C960", Offset = "0x820B360", VA = "0x18820C960")]
		public static void VIKLYBOIPZG(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x820BE00", Offset = "0x820A800", VA = "0x18820BE00")]
		public static Quaternion QQEMAWXWXUF(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x820B6C0", Offset = "0x820A0C0", VA = "0x18820B6C0")]
		public static void IJGSCDTYPUQ(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x820C5C0", Offset = "0x820AFC0", VA = "0x18820C5C0")]
		public static float UOHUENVDWPB(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x820CD20", Offset = "0x820B720", VA = "0x18820CD20")]
		public static void WMODXOLHXTD(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x820C5F0", Offset = "0x820AFF0", VA = "0x18820C5F0")]
		public static Vector3 URUOQVQRVSQ(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x820B340", Offset = "0x8209D40", VA = "0x18820B340")]
		public static void DPBKILGGDIJ(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x820C4B0", Offset = "0x820AEB0", VA = "0x18820C4B0")]
		public static Vector3 UERTXAAOHYU(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x820B2E0", Offset = "0x8209CE0", VA = "0x18820B2E0")]
		public static void BFCMQAIBBGY(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x820CF20", Offset = "0x820B920", VA = "0x18820CF20")]
		public static Vector3 ZNFACKVRCJJ(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x820BD50", Offset = "0x820A750", VA = "0x18820BD50")]
		public static void PFDJXWZNTLY(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x820BF30", Offset = "0x820A930", VA = "0x18820BF30")]
		public static Vector3 SUSEOJDZXDD(this BitPacker a, float b, float c, int d = 8)
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
