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
		[Cpp2IlInjected.Address(RVA = "0x83CE750", Offset = "0x83CCD50", VA = "0x1883CE750", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int QZXYUXDXTAV = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int FQTBZJMNRFR = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int HRSHRYLTHLY = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] NAPZXXYCRZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string DZUOGZAPTYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private StreamBuffer IUNDGOKOLXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Stream IWULLBNRRNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool EKQJZFLZDXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Memory<byte> CMLDZKLDREO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int EZGUGGNZTAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int YDLQMQDIMBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly byte[] RJFECIAAEJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int ZKPZDRBZMDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int KKLPWIMGONZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int VVHUWYPQMDG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool DHZBMKLAVSA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xE00180", Offset = "0xDFE780", VA = "0x180E00180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83CBF20", Offset = "0x83CA520", VA = "0x1883CBF20")]
		public static int WCZQUHRKKLH(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x83CA590", Offset = "0x83C8B90", VA = "0x1883CA590")]
		public static uint IVHYRAKDBFJ(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83CC830", Offset = "0x83CAE30", VA = "0x1883CC830")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83CA020", Offset = "0x83C8620", VA = "0x1883CA020", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83C9B30", Offset = "0x83C8130", VA = "0x1883C9B30")]
		public void CCMSJDSCRWU(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83C9B70", Offset = "0x83C8170", VA = "0x1883C9B70")]
		public void CCMSJDSCRWU(StreamBuffer a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83CA930", Offset = "0x83C8F30", VA = "0x1883CA930")]
		private void LDQGQYJACOJ([Optional] StreamBuffer a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83CA900", Offset = "0x83C8F00", VA = "0x1883CA900")]
		public int KZJBOHHZUHY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83CA8E0", Offset = "0x83C8EE0", VA = "0x1883CA8E0")]
		public int KZJBOHHZUHY([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83CAEE0", Offset = "0x83C94E0", VA = "0x1883CAEE0")]
		public int MKRJHQQFTTZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83CB5A0", Offset = "0x83C9BA0", VA = "0x1883CB5A0")]
		public int TLWEUFACJHT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83CAE90", Offset = "0x83C9490", VA = "0x1883CAE90")]
		public void MJELRCRCDIE(StreamBuffer a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83CADA0", Offset = "0x83C93A0", VA = "0x1883CADA0")]
		public void MJELRCRCDIE(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83CACB0", Offset = "0x83C92B0", VA = "0x1883CACB0")]
		public void MJELRCRCDIE(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x83CAB80", Offset = "0x83C9180", VA = "0x1883CAB80")]
		private void LYCRUPSOQZH(int a, [Optional] StreamBuffer b, [Optional] Memory<byte>? c, [Optional] Stream d, [Optional] object e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83CA5B0", Offset = "0x83C8BB0", VA = "0x1883CA5B0")]
		public void IZSPZTCJXPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x83CAA10", Offset = "0x83C9010", VA = "0x1883CAA10")]
		public void LIQDLPQAURT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83C9F20", Offset = "0x83C8520", VA = "0x1883C9F20")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83CC2B0", Offset = "0x83CA8B0", VA = "0x1883CC2B0")]
		public void YMIPXWGCLHA(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x83CC050", Offset = "0x83CA650", VA = "0x1883CC050")]
		public Guid WYYLTKWSCUR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x83CAC60", Offset = "0x83C9260", VA = "0x1883CAC60")]
		public void LZEMIAFSEZJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x83CAF00", Offset = "0x83C9500", VA = "0x1883CAF00")]
		public bool MZQZTTBFTHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83C9B10", Offset = "0x83C8110", VA = "0x1883C9B10")]
		public void BAJTWABLACK(sbyte a, sbyte b, sbyte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x83CA840", Offset = "0x83C8E40", VA = "0x1883CA840")]
		public void JWBXNGUTTQU(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83C9FA0", Offset = "0x83C85A0", VA = "0x1883C9FA0")]
		public sbyte DNYRGBHRFTN(sbyte a, sbyte b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83CB000", Offset = "0x83C9600", VA = "0x1883CB000")]
		public int OBHWLFFIMSR(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83CB980", Offset = "0x83C9F80", VA = "0x1883CB980")]
		public void VGQBLVASRZH(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83CB1A0", Offset = "0x83C97A0", VA = "0x1883CB1A0")]
		public void SCRTQLTNQVN(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83CBFD0", Offset = "0x83CA5D0", VA = "0x1883CBFD0")]
		public byte WDALXYULWBM(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83CA710", Offset = "0x83C8D10", VA = "0x1883CA710")]
		public uint JNDOJXVQXQY(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83CA0A0", Offset = "0x83C86A0", VA = "0x1883CA0A0")]
		public void EHDMCCKTUKJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83CC400", Offset = "0x83CAA00", VA = "0x1883CC400")]
		public void ZLQPSVJQLQO(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83CC6F0", Offset = "0x83CACF0", VA = "0x1883CC6F0")]
		public int ZYMFNHWGUYG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x83CB140", Offset = "0x83C9740", VA = "0x1883CB140")]
		public long PCSGTNISNQH()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7379960", Offset = "0x7377F60", VA = "0x187379960")]
		private static uint ZQAXJHRUMED(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7357060", Offset = "0x7355660", VA = "0x187357060")]
		private static int RAHNXVGZRZN(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83CB590", Offset = "0x83C9B90", VA = "0x1883CB590")]
		private static ulong TLFNHGQNMPC(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x83CA920", Offset = "0x83C8F20", VA = "0x1883CA920")]
		private static long LBYQMCSMIJO(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83CC2A0", Offset = "0x83CA8A0", VA = "0x1883CC2A0")]
		public void YKRRHMZYFFO(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83CA5C0", Offset = "0x83C8BC0", VA = "0x1883CA5C0")]
		public void JENDCRVAXER(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83CB130", Offset = "0x83C9730", VA = "0x1883CB130")]
		public uint ORGUXVWZDPP()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83CA790", Offset = "0x83C8D90", VA = "0x1883CA790")]
		public ulong JQXFMGVKHIK()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83CA300", Offset = "0x83C8900", VA = "0x1883CA300")]
		public void IRFWVBPMVFN(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83CB240", Offset = "0x83C9840", VA = "0x1883CB240")]
		public float SGPBOTJISYY(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83CAF20", Offset = "0x83C9520", VA = "0x1883CAF20")]
		private void NAQZFDOALYN(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83CB7F0", Offset = "0x83C9DF0", VA = "0x1883CB7F0")]
		public void UMXGFYQVURZ(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83CC160", Offset = "0x83CA760", VA = "0x1883CC160")]
		public float YGMCAPIECRA(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83CA100", Offset = "0x83C8700", VA = "0x1883CA100")]
		private void ENQZHOBCCKZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83CA160", Offset = "0x83C8760", VA = "0x1883CA160")]
		public void GSUBKNITKOH(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83CAAA0", Offset = "0x83C90A0", VA = "0x1883CAAA0")]
		public float LOZQVFPGHAC(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83CB640", Offset = "0x83C9C40", VA = "0x1883CB640")]
		private void TUEEKDDUCLL(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83CAC90", Offset = "0x83C9290", VA = "0x1883CAC90")]
		public void MCJCBGJYYWZ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83CC140", Offset = "0x83CA740", VA = "0x1883CC140")]
		public float XYITOEPGDSI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83CB730", Offset = "0x83C9D30", VA = "0x1883CB730")]
		public void UGFNLOMIPTY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83CBB60", Offset = "0x83CA160", VA = "0x1883CBB60")]
		public string VTLIOZZACOZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x36B6420", Offset = "0x36B4A20", VA = "0x1836B6420")]
		public void EVGTUCWDTPV<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x36B67C0", Offset = "0x36B4DC0", VA = "0x1836B67C0")]
		public List<c> UGGLXRCJNGM<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x83CB9A0", Offset = "0x83C9FA0", VA = "0x1883CB9A0")]
		public void VSUBVWQHROL(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83CB080", Offset = "0x83C9680", VA = "0x1883CB080")]
		public Span<byte> OLVHJTMAJAA()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83C9BB0", Offset = "0x83C81B0", VA = "0x1883C9BB0")]
		public void COWOKLFJRFB(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83C9DF0", Offset = "0x83C83F0", VA = "0x1883C9DF0")]
		public void CPBXGABOTYX(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83CBD50", Offset = "0x83CA350", VA = "0x1883CBD50")]
		public uint WBLECANMWPO(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83CC470", Offset = "0x83CAA70", VA = "0x1883CC470")]
		private void ZWHXIRIBVTE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83CB2F0", Offset = "0x83C98F0", VA = "0x1883CB2F0")]
		private void SQDBIFKKMBW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class OHDRFHEURKH
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
		[Cpp2IlInjected.Address(RVA = "0x83CE7D0", Offset = "0x83CCDD0", VA = "0x1883CE7D0")]
		public static void AHOEFIAEWXR(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83CEC70", Offset = "0x83CD270", VA = "0x1883CEC70")]
		public static void BYJNXMLVNDW(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x83CF350", Offset = "0x83CD950", VA = "0x1883CF350")]
		public static ViewId ODYKPSVRNFS(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83CEA50", Offset = "0x83CD050", VA = "0x1883CEA50")]
		public static PartialViewId ATDNGNAFFYR(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x83CF050", Offset = "0x83CD650", VA = "0x1883CF050")]
		private static bool KFEJHTCFBEE(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83CEEE0", Offset = "0x83CD4E0", VA = "0x1883CEEE0")]
		private static PartialViewId GZEOEBNUAUJ(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83CF580", Offset = "0x83CDB80", VA = "0x1883CF580")]
		private static bool THZYZVDCGUB(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83CF390", Offset = "0x83CD990", VA = "0x1883CF390")]
		private static ViewId QQUTVVZWESA(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83CE7E0", Offset = "0x83CCDE0", VA = "0x1883CE7E0")]
		private static bool AQTTSRDEJJK(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83CF1B0", Offset = "0x83CD7B0", VA = "0x1883CF1B0")]
		private static ViewId MPJMLNHMJOR(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class QORZQSMGSAK : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Bounds ESVDBKZNCNK;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x83CF7D0", Offset = "0x83CDDD0", VA = "0x1883CF7D0")]
		public QORZQSMGSAK(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class IUDUVASWTGI
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly float KLLOBYDDJHQ;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 XBMERHQOXGK;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Vector3 SUAKOEBGUOO;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly Bounds ESVDBKZNCNK;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83CE010", Offset = "0x83CC610", VA = "0x1883CE010")]
		public static void UAZZSPKZCAH(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x83CCC60", Offset = "0x83CB260", VA = "0x1883CCC60")]
		public static Quaternion ELXLVQIPRYY(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83CC890", Offset = "0x83CAE90", VA = "0x1883CC890")]
		public static void BRBGKRIZNXY(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x83CD230", Offset = "0x83CB830", VA = "0x1883CD230")]
		public static Vector3 JOYWOVFSUVJ(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83CCAC0", Offset = "0x83CB0C0", VA = "0x1883CCAC0")]
		public static void EIPIDDNNDLC(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83CD400", Offset = "0x83CBA00", VA = "0x1883CD400")]
		public static Vector3 OCJZNWHBMDJ(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x83CC9A0", Offset = "0x83CAFA0", VA = "0x1883CC9A0")]
		public static void EIPIDDNNDLC(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83CD770", Offset = "0x83CBD70", VA = "0x1883CD770")]
		public static Vector3 OCJZNWHBMDJ(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x83CD8D0", Offset = "0x83CBED0", VA = "0x1883CD8D0")]
		private static void RDXVLBPHJNP(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x83CD320", Offset = "0x83CB920", VA = "0x1883CD320")]
		private static Vector3 LFYEAFFFXVA(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x83CE260", Offset = "0x83CC860", VA = "0x1883CE260")]
		public static void ULXTNHSMQPT(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x83CCEF0", Offset = "0x83CB4F0", VA = "0x1883CCEF0")]
		public static Quaternion GVTZVCMCIXU(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x83CD8A0", Offset = "0x83CBEA0", VA = "0x1883CD8A0")]
		public static void PUVGCPHLMRF(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x83CD990", Offset = "0x83CBF90", VA = "0x1883CD990")]
		public static float ROWZPQLTEDQ(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x83CDD30", Offset = "0x83CC330", VA = "0x1883CDD30")]
		public static void TGKJVWMXLCY(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x83CD9C0", Offset = "0x83CBFC0", VA = "0x1883CD9C0")]
		public static Vector3 SLCIKZAVCRN(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x83CD080", Offset = "0x83CB680", VA = "0x1883CD080")]
		public static void JKHHBJHNJBK(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x83CE3D0", Offset = "0x83CC9D0", VA = "0x1883CE3D0")]
		public static Vector3 UOSQYEFIGIH(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x83CD020", Offset = "0x83CB620", VA = "0x1883CD020")]
		public static void IXARVGQZTMX(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x83CE4E0", Offset = "0x83CCAE0", VA = "0x1883CE4E0")]
		public static Vector3 WAZOWJUMJNQ(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x83CE560", Offset = "0x83CCB60", VA = "0x1883CE560")]
		public static void ZUPOIJDEGFL(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x83CDF30", Offset = "0x83CC530", VA = "0x1883CDF30")]
		public static Vector3 TOLKQAJRGKU(this BitPacker a, float b, float c, int d = 8)
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
