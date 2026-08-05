using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecNet;
using RecRoom.Async;
using RecRoom.ProgressionEvents;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Keepsakes
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public enum KeepsakeRoomListDisplayType
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Standard,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Premium,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		All
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface ZVFBHISGWDP
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool LRPFUYXIVEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		IReadOnlyList<KeepsakeRoomListDTO> DTGYJOFVGLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		IReadOnlyList<KeepsakeRoomListDTO> SYKIOMDFMXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IReadOnlyList<KeepsakeRoomListDTO> VJPVAVOMGDC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		IReadOnlyDictionary<long, string> DHONMGAJNEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool EAPUFGSUVUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<Guid?> PNBMMLFINSF;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action ZPKZBHFQTXK;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action HDCITCKJSPE;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool MMHLODASEZJ([Optional] List<string> a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		YHTYBMEYRGD<Guid> HTYVIMGDELI(KeepsakeCategory a);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		ILWLFVTHXJS IPUETWSBOIB(Guid a);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		ILWLFVTHXJS XZHCXZDFZPW(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool AQJECOFXKTW(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool CQGLIFDBZOU(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool RZYDNVCOLIG(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void ZHNHYKTPNVS(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void BRPIFADSHCU(KeepsakeCategory a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void GKGSTQMITNK(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "21")]
		int LARFUVISNBM();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "22")]
		YHTYBMEYRGD<int> OIBUHQZNEZM(long a, long b, [Optional] KeepsakeCategory? c);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "23")]
		YHTYBMEYRGD<int> LPBFQWRWZMG(long a, long b, [Optional] KeepsakeCategory? c);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "24")]
		YHTYBMEYRGD<Dictionary<KeepsakeCategory, int>> EUNNKVCKMSX(long a, long b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		YHTYBMEYRGD<Dictionary<KeepsakeCategory, int>> CJVPXDYUBYL(long a, long b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		YHTYBMEYRGD<IEnumerable<Guid>> BRGBCSVMMZM(long a, long b, [Optional] KeepsakeCategory? c);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		YHTYBMEYRGD<IEnumerable<Guid>> MQMGRSOMMBN(long a, long b, [Optional] KeepsakeCategory? c);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		string FPHJDWBJNAN(KeepsakeCategory a);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		string OKITBRXVTUR(KeepsakeCategory a);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		List<KeepsakeCategory> QYZCNGJVOFO();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "31")]
		IComparer<KeepsakeCategory> ATNQNKZXRIG();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "33")]
		bool DVLPSGWNOWP(long a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool VOTKFMENZXA(long a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool YSQKXNMTRUN(long a, [Out] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "36")]
		long USBSYOHCJHZ(long a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "37")]
		long TLMFIYQCNGJ(long a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "38")]
		int DBLYQKYBIHA(long a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "39")]
		bool FZJMDGBHYID();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "40")]
		bool XURSAWDKEAJ(long a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		IReadOnlyList<long> GBIZHJGMUDM(long a);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		int VVCOUIGSPNJ(long a);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		string AWBYJAXIXIC(ProgressionEventConfigurableTextType a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		string NIEDVPXCSOO(ProgressionEventConfigurableTextType a, int b);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		string HSIIZNBHECR(ProgressionEventConfigurableTextType a, long b);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		long KJERKIYXTOW(long a);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "47")]
		KeepsakeCategory YGKZCBJZFFM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct KeepsakeRoomLockStatus
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum LockContext
		{
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			LockedByTime,
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			LockedByItem
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsLocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public LockContext? LockedBy;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8573990", Offset = "0x8572790", VA = "0x188573990")]
		public KeepsakeRoomLockStatus(bool isLocked, [Optional] LockContext? lockedBy)
		{
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
