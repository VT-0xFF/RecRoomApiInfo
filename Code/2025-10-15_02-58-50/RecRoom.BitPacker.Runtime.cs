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
		[Cpp2IlInjected.Address(RVA = "0x8344CA0", Offset = "0x8343AA0", VA = "0x188344CA0", Slot = "4")]
		public override void IPFDCTVTWHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BE0", Offset = "0xAC69E0", VA = "0x180AC7BE0")]
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
		private static readonly Log YLLVKVFSHML;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		protected const int FCCSKWTTIGI = 128;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		protected const int GPGDVMNZOBM = 32;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		protected const int RVGEVWENYPV = 32;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly int[] DOGQSZAGNDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private string LLEAAGWXZCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private StreamBuffer BBIFMPIYCEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private Stream BFFGSYIYJSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private bool ZJIEBTOPAQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private Memory<byte> QADITXBINGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private int GGSGGXLMUOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int OLBALOPTERE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly byte[] DTCTHHYJKJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private int CHVWNJETWRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int VUHDZIIFDTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private int LQEAFORBBSB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private bool BAQKYPMAWHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xDF9AD0", Offset = "0xDF88D0", VA = "0x180DF9AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8344710", Offset = "0x8343510", VA = "0x188344710")]
		public static int XZAUBTOLRRM(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8343B60", Offset = "0x8342960", VA = "0x188343B60")]
		public static uint PEJXPTVBCSI(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8344B30", Offset = "0x8343930", VA = "0x188344B30")]
		public BitPacker(int scratchBufferSize = 128)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8342630", Offset = "0x8341430", VA = "0x188342630", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8341FA0", Offset = "0x8340DA0", VA = "0x188341FA0")]
		public void BITHLILHIFF(Stream a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8341FE0", Offset = "0x8340DE0", VA = "0x188341FE0")]
		public void BITHLILHIFF(StreamBuffer a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8343660", Offset = "0x8342460", VA = "0x188343660")]
		private void LEDABMMAJQC([Optional] StreamBuffer a, [Optional] Memory<byte>? b, [Optional] Stream c, [Optional] object d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83435C0", Offset = "0x83423C0", VA = "0x1883435C0")]
		public int JTVWWUSEYCT()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83435A0", Offset = "0x83423A0", VA = "0x1883435A0")]
		public int JTVWWUSEYCT([Out] int a, [Out] int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8344A20", Offset = "0x8343820", VA = "0x188344A20")]
		public int ZZZZKEPXQVI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8343BA0", Offset = "0x83429A0", VA = "0x188343BA0")]
		public int RHLPKKHBKSM()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83422B0", Offset = "0x83410B0", VA = "0x1883422B0")]
		public void DBIYVLWXPWL(StreamBuffer a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8342300", Offset = "0x8341100", VA = "0x188342300")]
		public void DBIYVLWXPWL(byte[] a, [Optional] object b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83423F0", Offset = "0x83411F0", VA = "0x1883423F0")]
		public void DBIYVLWXPWL(byte[] a, int b, [Optional] object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8344230", Offset = "0x8343030", VA = "0x188344230")]
		private void UXUGJYWTJAO(int a, [Optional] StreamBuffer b, [Optional] Memory<byte>? c, [Optional] Stream d, [Optional] object e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8344690", Offset = "0x8343490", VA = "0x188344690")]
		public void WMMPPEKCWZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8343740", Offset = "0x8342540", VA = "0x188343740")]
		public void LIJLUJKKKCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8342230", Offset = "0x8341030", VA = "0x188342230")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8343370", Offset = "0x8342170", VA = "0x188343370")]
		public void JFXFCNLWFMH(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x83420E0", Offset = "0x8340EE0", VA = "0x1883420E0")]
		public Guid BUQOPJBVBGO()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8343340", Offset = "0x8342140", VA = "0x188343340")]
		public void JANGDAGITTE(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8343B80", Offset = "0x8342980", VA = "0x188343B80")]
		public bool RBOFWPIPLTV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x83440A0", Offset = "0x8342EA0", VA = "0x1883440A0")]
		public void TDVDIBDECUR(sbyte a, sbyte b, sbyte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8342D80", Offset = "0x8341B80", VA = "0x188342D80")]
		public void GHQUTQRZHPR(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83437D0", Offset = "0x83425D0", VA = "0x1883437D0")]
		public sbyte LWGNMMJCQZQ(sbyte a, sbyte b)
		{
			return default(sbyte);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8342E20", Offset = "0x8341C20", VA = "0x188342E20")]
		public int HNKGEPLYARS(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x83424E0", Offset = "0x83412E0", VA = "0x1883424E0")]
		public void DLLMSXGMSMY(byte a, byte b, byte c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8343C40", Offset = "0x8342A40", VA = "0x188343C40")]
		public void RHSUGTKRCEG(uint a, uint b, uint c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83435E0", Offset = "0x83423E0", VA = "0x1883435E0")]
		public byte KZDYTGCIYVP(byte a, byte b)
		{
			return default(byte);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83441B0", Offset = "0x8342FB0", VA = "0x1883441B0")]
		public uint UVXQFXEBPPB(uint a, uint b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8343850", Offset = "0x8342650", VA = "0x188343850")]
		public void MMHBXVWLWEY(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83446A0", Offset = "0x83434A0", VA = "0x1883446A0")]
		public void XSQZBYLKBMN(long a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83421D0", Offset = "0x8340FD0", VA = "0x1883421D0")]
		public int CSFXYQRHJCZ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8343CF0", Offset = "0x8342AF0", VA = "0x188343CF0")]
		public long ROJNKLQFFXU()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x72DAC50", Offset = "0x72D9A50", VA = "0x1872DAC50")]
		private static uint MFVAATYTPEE(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x72B80B0", Offset = "0x72B6EB0", VA = "0x1872B80B0")]
		private static int STUXZKJPDGE(uint a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8343CE0", Offset = "0x8342AE0", VA = "0x188343CE0")]
		private static ulong RLNNEOCPOQH(long a)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8341E00", Offset = "0x8340C00", VA = "0x188341E00")]
		private static long AQHXUTYNJBV(ulong a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8343190", Offset = "0x8341F90", VA = "0x188343190")]
		public void ITRDRMVVYAX(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8344540", Offset = "0x8343340", VA = "0x188344540")]
		public void WJTPOJXTXLW(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83420D0", Offset = "0x8340ED0", VA = "0x1883420D0")]
		public uint BLUGGTIWKUY()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8344310", Offset = "0x8343110", VA = "0x188344310")]
		public ulong UZISAAQTOWF()
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8342930", Offset = "0x8341730", VA = "0x188342930")]
		public void FZBUNHZAZBM(float a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8342EA0", Offset = "0x8341CA0", VA = "0x188342EA0")]
		public float IEDENXMIYEH(int a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83434C0", Offset = "0x83422C0", VA = "0x1883434C0")]
		private void JMBFMAXHSIC(float a, float b, float c, int d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8341E10", Offset = "0x8340C10", VA = "0x188341E10")]
		public void AXVZRMLVRXG(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83443C0", Offset = "0x83431C0", VA = "0x1883443C0")]
		public float UZMQCWMIPGP(float a, int b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83449C0", Offset = "0x83437C0", VA = "0x1883449C0")]
		private void ZXZUKDOJPUA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83431A0", Offset = "0x8341FA0", VA = "0x1883431A0")]
		public void IUBYGXQAXZK(float a, float b, float c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8343A80", Offset = "0x8342880", VA = "0x188343A80")]
		public float OLHCGOZYELZ(float a, float b, int c)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83440C0", Offset = "0x8342EC0", VA = "0x1883440C0")]
		private void UJITASGASYU(float a, float b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8344520", Offset = "0x8343320", VA = "0x188344520")]
		public void WFHBSREPQRQ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8344500", Offset = "0x8343300", VA = "0x188344500")]
		public float VBFPPXQHLKJ()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8343D50", Offset = "0x8342B50", VA = "0x188343D50")]
		public void RVFRQJZKHRV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x83447D0", Offset = "0x83435D0", VA = "0x1883447D0")]
		public string YOIIYVTMQBM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x36D2E50", Offset = "0x36D1C50", VA = "0x1836D2E50")]
		public void EXWFRAGXBTE<b>(IList<b> a, Action<BitPacker, b> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x36D29F0", Offset = "0x36D17F0", VA = "0x1836D29F0")]
		public List<c> CCMJTEXEHHZ<c>(Func<BitPacker, c> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8342BC0", Offset = "0x83419C0", VA = "0x188342BC0")]
		public void GBTHZTRCLDY(ReadOnlySpan<byte> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8342020", Offset = "0x8340E20", VA = "0x188342020")]
		public Span<byte> BIZMUUSTMXZ()
		{
			return default(Span<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8342F50", Offset = "0x8341D50", VA = "0x188342F50")]
		public void IIJEAWDNZJA(Span<byte> a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8342500", Offset = "0x8341300", VA = "0x188342500")]
		public void DRDTCINWUTM(uint a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83438B0", Offset = "0x83426B0", VA = "0x1883438B0")]
		public uint NYOVGMMCXKH(int a)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83426B0", Offset = "0x83414B0", VA = "0x1883426B0")]
		private void FNUDOOJTSHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8343E10", Offset = "0x8342C10", VA = "0x188343E10")]
		private void SMJQBXJATIR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class AJIZXYCXLHA
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
		[Cpp2IlInjected.Address(RVA = "0x8340E70", Offset = "0x833FC70", VA = "0x188340E70")]
		public static void DAHSRRLATRA(this BitPacker a, ViewId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8341B90", Offset = "0x8340990", VA = "0x188341B90")]
		public static void ZFPXATTFMYD(this BitPacker a, ViewId b, ViewId? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8341250", Offset = "0x8340050", VA = "0x188341250")]
		public static ViewId LTRKWDMWRFV(this BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8341430", Offset = "0x8340230", VA = "0x188341430")]
		public static PartialViewId NHNYPEAJMVK(this BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8341A30", Offset = "0x8340830", VA = "0x188341A30")]
		private static bool RZEIBWOXVKN(BitPacker a, ViewId b, ViewId c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83418C0", Offset = "0x83406C0", VA = "0x1883418C0")]
		private static PartialViewId PRJMHCCBCJI(BitPacker a)
		{
			return default(PartialViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8341070", Offset = "0x833FE70", VA = "0x188341070")]
		private static bool JHHJKMOVJXO(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8340E80", Offset = "0x833FC80", VA = "0x188340E80")]
		private static ViewId FUGXRMYDLHJ(BitPacker a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8341650", Offset = "0x8340450", VA = "0x188341650")]
		private static bool PQRAWVLFYUV(BitPacker a, ViewId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8341290", Offset = "0x8340090", VA = "0x188341290")]
		private static ViewId MHOGRBTYEEK(BitPacker a)
		{
			return default(ViewId);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class HBYPYIYTRYZ : BitPacker
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public static readonly Bounds CJJAQLYNSHL;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8344C10", Offset = "0x8343A10", VA = "0x188344C10")]
		public HBYPYIYTRYZ(int a = 128)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class UUBSRLXXJGD
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private static readonly float PPPVSNWGJUP;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		internal static readonly Vector3 RWWBCBWUUBB;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		internal static readonly Vector3 VNQRVZHZGZP;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public static readonly Bounds CJJAQLYNSHL;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83460E0", Offset = "0x8344EE0", VA = "0x1883460E0")]
		public static void QRFTXPUMFNU(this BitPacker a, Quaternion b, int c = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8344D20", Offset = "0x8343B20", VA = "0x188344D20")]
		public static Quaternion APFAYRXVDPZ(this BitPacker a, int b = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8345FD0", Offset = "0x8344DD0", VA = "0x188345FD0")]
		public static void QGDUIEBGHJD(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8345670", Offset = "0x8344470", VA = "0x188345670")]
		public static Vector3 IETOPWJPAHQ(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83459A0", Offset = "0x83447A0", VA = "0x1883459A0")]
		public static void JLNPHGAHILX(this BitPacker a, Vector3 b, Vector3 c, Vector3 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x83466D0", Offset = "0x83454D0", VA = "0x1883466D0")]
		public static Vector3 XILCEAMJEYY(this BitPacker a, Vector3 b, Vector3 c)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8345880", Offset = "0x8344680", VA = "0x188345880")]
		public static void JLNPHGAHILX(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83465A0", Offset = "0x83453A0", VA = "0x1883465A0")]
		public static Vector3 XILCEAMJEYY(this BitPacker a, Vector3 b, Vector3 c, int d)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8345D40", Offset = "0x8344B40", VA = "0x188345D40")]
		private static void LRUQFTADKLK(this BitPacker a, Vector3 b, Vector3 c, Vector3 d, int e = 22)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8345770", Offset = "0x8344570", VA = "0x188345770")]
		private static Vector3 JHGOFLBXMSV(this BitPacker a, Vector3 b, Vector3 c, int d = 22)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8345E00", Offset = "0x8344C00", VA = "0x188345E00")]
		public static void LWMTIQXGAOU(this BitPacker a, Quaternion b, bool c = true, int d = 10)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8346440", Offset = "0x8345240", VA = "0x188346440")]
		public static Quaternion SVQJQSGRNDD(this BitPacker a, [Out] bool b, int c = 10)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8345850", Offset = "0x8344650", VA = "0x188345850")]
		public static void JKTHQHVICKM(this BitPacker a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8346570", Offset = "0x8345370", VA = "0x188346570")]
		public static float VTVSRADBDKD(this BitPacker a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8345B40", Offset = "0x8344940", VA = "0x188345B40")]
		public static void KTWGYSAUWUZ(this BitPacker a, Vector3 b, float c = 1f, float d = 8f, float e = 64f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8345300", Offset = "0x8344100", VA = "0x188345300")]
		public static Vector3 GHIVELNTBHC(this BitPacker a, float b = 1f, float c = 8f, float d = 64f)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8345090", Offset = "0x8343E90", VA = "0x188345090")]
		public static void DSHIARPMFRD(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8346330", Offset = "0x8345130", VA = "0x188346330")]
		public static Vector3 RAJZBHLQPMY(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8345F70", Offset = "0x8344D70", VA = "0x188345F70")]
		public static void NFHADNQKVWM(this BitPacker a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8346A40", Offset = "0x8345840", VA = "0x188346A40")]
		public static Vector3 ZBFKVBLGELR(this BitPacker a)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8345250", Offset = "0x8344050", VA = "0x188345250")]
		public static void FGNCGTIMFAK(this BitPacker a, Vector3 b, float c, float d, int e = 8)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8344FB0", Offset = "0x8343DB0", VA = "0x188344FB0")]
		public static Vector3 CTMIZJPNPSR(this BitPacker a, float b, float c, int d = 8)
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
