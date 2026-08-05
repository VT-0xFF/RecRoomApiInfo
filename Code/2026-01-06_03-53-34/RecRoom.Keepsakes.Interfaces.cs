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
	public interface ZHJTAMFGQEW
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool JCVAHPPHIWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		IReadOnlyList<KeepsakeRoomListDTO> PSNSNKRDELD
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		IReadOnlyList<KeepsakeRoomListDTO> QFVVZUKIOQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		IReadOnlyList<KeepsakeRoomListDTO> ZJJVVILXMPV
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		IReadOnlyDictionary<long, string> WCUGYTAKGLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		bool WQXHTFSTZQW
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action<Guid?> XRGCTZAIWCA;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action DHYPPCYJIJZ;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action DYPVHFUJNOP;

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		bool XCBWPIEIQBO([Optional] List<string> a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		PVOPFDWRLHK<Guid> LTBXKRDWXCR(KeepsakeCategory a);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		DNXWICJZUNF NSQIGEBYIWO(Guid a);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		DNXWICJZUNF WLUBYGJBRCV(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		bool IUDNSPCWTKP(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "16")]
		bool IHXEVEBAMVH(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "17")]
		bool SMSEUTWEWJF(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void BRYXRHNGWUX(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void IFQFAJYXAUP(KeepsakeCategory a);

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void MHBYWDYLMFV(Guid a);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "21")]
		int CIVBGPLMDUV();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "22")]
		PVOPFDWRLHK<int> BGPGYQYIOHP(long a, long b, [Optional] KeepsakeCategory? c);

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "23")]
		PVOPFDWRLHK<int> UPBSXMZWKGJ(long a, long b, [Optional] KeepsakeCategory? c);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "24")]
		PVOPFDWRLHK<Dictionary<KeepsakeCategory, int>> GBWQKMORFGO(long a, long b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "25")]
		PVOPFDWRLHK<Dictionary<KeepsakeCategory, int>> IRRXCGDWYQW(long a, long b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "26")]
		PVOPFDWRLHK<IEnumerable<Guid>> ADDEPXKENKN(long a, long b, [Optional] KeepsakeCategory? c);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		PVOPFDWRLHK<IEnumerable<Guid>> WDNZFUMCMUA(long a, long b, [Optional] KeepsakeCategory? c);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		string OFTMNPVYIKI(KeepsakeCategory a);

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		string MVRZELJCANA(KeepsakeCategory a);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		List<KeepsakeCategory> RTMTDMSWENP();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "31")]
		IComparer<KeepsakeCategory> DGLIASLDRHJ();

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "33")]
		bool KLOIFCOHOWG(long a);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "34")]
		bool REGCXIDJOZH(long a);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "35")]
		bool YURMWZRSQPM(long a, [Out] DateTime b);

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "36")]
		long TZZZTKJXJIA(long a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "37")]
		long TKXHYOVXZDW(long a);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "38")]
		int LIGVUHOPHLX(long a);

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "39")]
		bool TVJZJFTYDOA();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "40")]
		bool KAMOAKUSKGA(long a);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		IReadOnlyList<long> NWODQHKSRAD(long a);

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		int IXLGXJUNZHI(long a);

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		string IDJOCJXBTMP(ProgressionEventConfigurableTextType a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		string XTWWRWPMLGD(ProgressionEventConfigurableTextType a, int b);

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		string MHJNILHQRLW(ProgressionEventConfigurableTextType a, long b);

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		long VCZBHFPITCD(long a);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "47")]
		KeepsakeCategory UJYXFGTEBUP();
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
		[Cpp2IlInjected.Address(RVA = "0x83960D0", Offset = "0x8394AD0", VA = "0x1883960D0")]
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
