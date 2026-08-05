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
	public interface QHYSLOEGHVU
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool TWYBYCDOCIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		IReadOnlyList<KeepsakeRoomListDTO> EZAYOTYKHRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		IReadOnlyList<KeepsakeRoomListDTO> KYICUROAYZH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IReadOnlyList<KeepsakeRoomListDTO> LUHNRIGFLHF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		IReadOnlyDictionary<long, string> UENBVAPOLKK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool XILEOHCOKYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<Guid?> CEDUDQIEGJO;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action UTYKBYUYHJZ;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action ZCDPVMHIVEX;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool XEDIDRGXCLO([Optional] List<string> a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		WCGMKCSPRXW<Guid> AHTZUCQUQXH(KeepsakeCategory a);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		DQILUIFDCOX FFNGIGKKHJY(Guid a);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		DQILUIFDCOX MSDGIQZMRFD(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool ZCYFEEFNZNF(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool CWUWIWTJBOF(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool QABJLTWMPCL(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void DDUZLQVFDPB(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void YHXYLKTLCJB(KeepsakeCategory a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void FLGPZWBDFZN(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "21")]
		int VOUUQXYNNHL();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "22")]
		WCGMKCSPRXW<int> HGZWMRVMDHH(long a, long b, [Optional] KeepsakeCategory? c);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "23")]
		WCGMKCSPRXW<int> RTSYHBSQNMV(long a, long b, [Optional] KeepsakeCategory? c);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "24")]
		WCGMKCSPRXW<Dictionary<KeepsakeCategory, int>> XSKCCKNPPOC(long a, long b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		WCGMKCSPRXW<Dictionary<KeepsakeCategory, int>> EPIAUDAUYMS(long a, long b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		WCGMKCSPRXW<IEnumerable<Guid>> UIJCLMESDCZ(long a, long b, [Optional] KeepsakeCategory? c);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		WCGMKCSPRXW<IEnumerable<Guid>> UHHGHHSRISI(long a, long b, [Optional] KeepsakeCategory? c);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		string BQTNUVRBLKY(KeepsakeCategory a);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		string SWQRSPMCAZM(KeepsakeCategory a);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		List<KeepsakeCategory> YGYWNXMJKYF();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "31")]
		IComparer<KeepsakeCategory> OQDKCBIEZHN();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "33")]
		bool LVGLAHBKFLU(long a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool JRGYAGQUHWV(long a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool XWZIYWFGQPI(long a, [Out] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "36")]
		long IEGTKQPJROA(long a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "37")]
		long HUADFPOFYBK(long a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "38")]
		int WKJFFCBXQJL(long a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "39")]
		bool VNLQKELDEGI();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "40")]
		bool ARLZMVJAFQE(long a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		IReadOnlyList<long> EHUGWTDGSFR(long a);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		int CMKSATANSCK(long a);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		string DELMZXVNVXV(ProgressionEventConfigurableTextType a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		string RLVFCLFLJKP(ProgressionEventConfigurableTextType a, int b);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		string FLVPWSBHNFG(ProgressionEventConfigurableTextType a, long b);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		long OKBQWEKVIPB(long a);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "47")]
		KeepsakeCategory AJQCXRIBMHJ();
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
		[Cpp2IlInjected.Address(RVA = "0x84D0150", Offset = "0x84CEF50", VA = "0x1884D0150")]
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
