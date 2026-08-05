using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecNet;
using RecNet.Events;
using RecNet.Rooms;
using RecRoom.Async;
using RecRoom.Chat.Runtime.MessagePackagers;
using RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers;
using RecRoom.Chat.Runtime.Tokens;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using UJect;
using UJect.Injection;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8098400", Offset = "0x8097000", VA = "0x188098400")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Chat_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x809C9D0", Offset = "0x809B5D0", VA = "0x18809C9D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2721D10", Offset = "0x2720910", VA = "0x182721D10")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : QUPOGSHYYSR
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class WYITCQAWRUI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage RJDPVTDBYVW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> HVBCDEGECGV;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public WYITCQAWRUI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x809B900", Offset = "0x809A500", VA = "0x18809B900")]
			internal MRIYACRIYFZ BSHTREVDJIP(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x809B8D0", Offset = "0x809A4D0", VA = "0x18809B8D0")]
			internal void BSCMTYBFZXG(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class SEWWWLJILVR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage RJDPVTDBYVW;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SEWWWLJILVR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8099940", Offset = "0x8098540", VA = "0x188099940")]
			internal void MHZCLJWVKYW(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class NLQFCTBILOG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public UJLGZAJRWKK.MessageContentType LMUIPLDKMIY;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public NLQFCTBILOG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8098380", Offset = "0x8096F80", VA = "0x188098380")]
			internal bool YWQHGGHVBSZ(YRCOWNSIBTH a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly UJLGZAJRWKK.CAAEXQJQMBC STXLZXFAWHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int CDXHCWAIMBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<YRCOWNSIBTH> MGJREWSYMTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly KIMLDTYOZSJ MYDUBOLSBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly IQZGSMYHKTV SDCQFRRGKXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly OOARLSUUKIY YOYPVAXIPGD;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8096CC0", Offset = "0x80958C0", VA = "0x188096CC0")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] KIMLDTYOZSJ accountsClient, [Inject(null)] IQZGSMYHKTV chatClient, [Inject(null)] OOARLSUUKIY clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8095FA0", Offset = "0x8094BA0", VA = "0x188095FA0", Slot = "5")]
		public bool AXDCWQGZZOJ(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8096190", Offset = "0x8094D90", VA = "0x188096190", Slot = "6")]
		public ChatMessage DCQEUQMQKBF(long a, UJLGZAJRWKK.CAAEXQJQMBC b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8095E20", Offset = "0x8094A20", VA = "0x188095E20", Slot = "7")]
		public PYAXBIZPKFO<UJLGZAJRWKK.MJHCKGCNRUI> AUQHRSHWVVV(UJLGZAJRWKK.CAAEXQJQMBC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8096710", Offset = "0x8095310", VA = "0x188096710", Slot = "4")]
		public void PRAPPBIEWSN(YRCOWNSIBTH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8096810", Offset = "0x8095410", VA = "0x188096810", Slot = "8")]
		public void RLVPJRDIIAG(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8096310", Offset = "0x8094F10", VA = "0x188096310")]
		private UJLGZAJRWKK.CAAEXQJQMBC EYXYFSIUXWY(UJLGZAJRWKK.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8096900", Offset = "0x8095500", VA = "0x188096900")]
		private void UHNSYEKDYEB(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8096510", Offset = "0x8095110", VA = "0x188096510")]
		private void GQTEYPUBACG(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8096AE0", Offset = "0x80956E0", VA = "0x188096AE0")]
		private YRCOWNSIBTH XTICQXACSUH(int a, UJLGZAJRWKK.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface QUPOGSHYYSR
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PRAPPBIEWSN(YRCOWNSIBTH a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool AXDCWQGZZOJ(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage DCQEUQMQKBF(long a, UJLGZAJRWKK.CAAEXQJQMBC b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		PYAXBIZPKFO<UJLGZAJRWKK.MJHCKGCNRUI> AUQHRSHWVVV(UJLGZAJRWKK.CAAEXQJQMBC a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RLVPJRDIIAG(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface PRZKMVLOQDI
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		NWSEZICLNSM<PRZKMVLOQDI> EGKAAOBWCXY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool RBXJEWFDMYS
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<WTSZZVFCWUO> ECQBCLPUAZN
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string TBBLLJEYAPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		MRIYACRIYFZ VHYUQJVXOZT();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : UJLGZAJRWKK.CAAEXQJQMBC
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override UJLGZAJRWKK.MessageContentType DKBEBQVFLPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB55810", Offset = "0xB54410", VA = "0x180B55810", Slot = "10")]
			get
			{
				return default(UJLGZAJRWKK.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8098520", Offset = "0x8097120", VA = "0x188098520")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8098480", Offset = "0x8097080", VA = "0x188098480")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : UJLGZAJRWKK.CAAEXQJQMBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long BUXNEBSCEDT;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override UJLGZAJRWKK.MessageContentType DKBEBQVFLPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB5A490", Offset = "0xB59090", VA = "0x180B5A490", Slot = "10")]
			get
			{
				return default(UJLGZAJRWKK.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string WYQBNEATNUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xBEC860", Offset = "0xBEB460", VA = "0x180BEC860", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long OUVYPFDOBHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8098720", Offset = "0x8097320", VA = "0x188098720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80987E0", Offset = "0x80973E0", VA = "0x1880987E0")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x80987A0", Offset = "0x80973A0", VA = "0x1880987A0")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IFJWYUFCFWE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x80971B0", Offset = "0x8095DB0", VA = "0x1880971B0")]
		[YLZSHGPPZTN.Root]
		internal static void YIYMLOHNRPA(URVRSSRGCJF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8097490", Offset = "0x8096090", VA = "0x188097490")]
		[UnityEngine.Scripting.Preserve]
		public IFJWYUFCFWE([Inject(null)] QUPOGSHYYSR chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] UIDCXVUDSGS textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class ZVZGLQUVBIZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class FWKMQDTJZYX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public PRZKMVLOQDI QMSWBHDOWHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool QPVQUIYNPOZ;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public FWKMQDTJZYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8096F50", Offset = "0x8095B50", VA = "0x188096F50")]
			internal string MOCYPHQHZCJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] LYYGVQAZBWB;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x809C010", Offset = "0x809AC10", VA = "0x18809C010")]
		public static PYAXBIZPKFO<string> DCRJMYRPZSD(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x809BCF0", Offset = "0x809A8F0", VA = "0x18809BCF0")]
		public static PYAXBIZPKFO<string> DCRJMYRPZSD(UJLGZAJRWKK.CAAEXQJQMBC a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x809C340", Offset = "0x809AF40", VA = "0x18809C340")]
		private static string OIPQITHGCPN(PRZKMVLOQDI a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x809C230", Offset = "0x809AE30", VA = "0x18809C230")]
		public static string NMXXLKCSUJH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x809C710", Offset = "0x809B310", VA = "0x18809C710")]
		public static string YROPMDIOPGG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x809C600", Offset = "0x809B200", VA = "0x18809C600")]
		public static bool RIWZWABJFGZ(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x809C6A0", Offset = "0x809B2A0", VA = "0x18809C6A0")]
		public static bool XSDEEKDRFMK(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x809C670", Offset = "0x809B270", VA = "0x18809C670")]
		public static bool XRLIZPIJMWN(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x809C0E0", Offset = "0x809ACE0", VA = "0x18809C0E0")]
		public static string DXPTRCHXZFZ(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : UJLGZAJRWKK.CAAEXQJQMBC, PRZKMVLOQDI
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public NWSEZICLNSM<PRZKMVLOQDI> EGKAAOBWCXY
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<WTSZZVFCWUO> ECQBCLPUAZN
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA98610", Offset = "0xA97210", VA = "0x180A98610", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool RBXJEWFDMYS
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x809AAE0", Offset = "0x80996E0", VA = "0x18809AAE0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool HYLNHOWUFPN
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x809AA50", Offset = "0x8099650", VA = "0x18809AA50", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x809B300", Offset = "0x8099F00", VA = "0x18809B300")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x809B020", Offset = "0x8099C20", VA = "0x18809B020")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x809B1F0", Offset = "0x8099DF0", VA = "0x18809B1F0")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x809A870", Offset = "0x8099470", VA = "0x18809A870", Slot = "17")]
		public void FTKRWAXYMFF(WTSZZVFCWUO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x809AC20", Offset = "0x8099820", VA = "0x18809AC20", Slot = "16")]
		public MRIYACRIYFZ VHYUQJVXOZT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x809A960", Offset = "0x8099560", VA = "0x18809A960")]
		private void MXCVAWYXIPW(WTSZZVFCWUO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class WTSZZVFCWUO : IEquatable<WTSZZVFCWUO>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public NWSEZICLNSM<WTSZZVFCWUO> EGKAAOBWCXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool RBXJEWFDMYS
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xBAE8E0", Offset = "0xBAD4E0", VA = "0x180BAE8E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA97500", Offset = "0xA96100", VA = "0x180A97500", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool HYLNHOWUFPN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x809B620", Offset = "0x809A220", VA = "0x18809B620", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType XSYNALKQIRF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string XWPSZNBLMQF
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA98370", Offset = "0xA96F70", VA = "0x180A98370")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long MMWALKGWPNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA98640", Offset = "0xA97240", VA = "0x180A98640")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA988C0", Offset = "0xA974C0", VA = "0x180A988C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string XONSKSBAZDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA98610", Offset = "0xA97210", VA = "0x180A98610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA9F8D0", Offset = "0xA9E4D0", VA = "0x180A9F8D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object HMKVPTKYUOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAA0C00", Offset = "0xA9F800", VA = "0x180AA0C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA98C60", Offset = "0xA97860", VA = "0x180A98C60")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public MRIYACRIYFZ RXLTEUZRWMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA988D0", Offset = "0xA974D0", VA = "0x180A988D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA988A0", Offset = "0xA974A0", VA = "0x180A988A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x809B780", Offset = "0x809A380", VA = "0x18809B780")]
		protected WTSZZVFCWUO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x809B820", Offset = "0x809A420", VA = "0x18809B820")]
		protected WTSZZVFCWUO(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x809B6B0", Offset = "0x809A2B0", VA = "0x18809B6B0")]
		protected WTSZZVFCWUO(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x809B660", Offset = "0x809A260", VA = "0x18809B660")]
		protected void UDQODBQJYXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x809B490", Offset = "0x809A090", VA = "0x18809B490", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x809B5F0", Offset = "0x809A1F0", VA = "0x18809B5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x809B570", Offset = "0x809A170", VA = "0x18809B570", Slot = "4")]
		public bool Equals(WTSZZVFCWUO other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string TCYVYFQAZKQ(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class PKLILSLAVTW<a, b> : WTSZZVFCWUO where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class NIBWJFEAYEQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public NJJRGFITQLO JDVFOVEFBCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public PKLILSLAVTW<a, b> BIVSZSMQJUR;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public NIBWJFEAYEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5797D00", Offset = "0x5796900", VA = "0x185797D00")]
			internal void CGZPPHMVDGI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a HMKVPTKYUOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x59D0800", Offset = "0x59CF400", VA = "0x1859D0800")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x59D0770", Offset = "0x59CF370", VA = "0x1859D0770")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x59D0C80", Offset = "0x59CF880", VA = "0x1859D0C80")]
		protected PKLILSLAVTW(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x59D0850", Offset = "0x59CF450", VA = "0x1859D0850")]
		protected PKLILSLAVTW(string a, long b, string c, PYAXBIZPKFO<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void XUFFRHGTHET(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x59D0790", Offset = "0x59CF390", VA = "0x1859D0790")]
		private void NRBNJUERVQG(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x59D07E0", Offset = "0x59CF3E0", VA = "0x1859D07E0")]
		[CompilerGenerated]
		private void TWOLRYHHDOP(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum ChatTokenType
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		Unknown,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		Room,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Player,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Photo,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		PlayerEvent,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Club
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class RZKYWCKOJMS : PKLILSLAVTW<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType XSYNALKQIRF
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB54950", Offset = "0xB53550", VA = "0x180B54950", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8098F30", Offset = "0x8097B30", VA = "0x188098F30")]
		public RZKYWCKOJMS(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8098F80", Offset = "0x8097B80", VA = "0x188098F80")]
		public RZKYWCKOJMS(string a, long b, string c, PYAXBIZPKFO<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8098E60", Offset = "0x8097A60", VA = "0x188098E60", Slot = "9")]
		public override string TCYVYFQAZKQ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8098ED0", Offset = "0x8097AD0", VA = "0x188098ED0", Slot = "10")]
		protected override void XUFFRHGTHET(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class QZNNOLIPHJG : PKLILSLAVTW<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType XSYNALKQIRF
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB3AFF0", Offset = "0xB39BF0", VA = "0x180B3AFF0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8098DF0", Offset = "0x80979F0", VA = "0x188098DF0")]
		public QZNNOLIPHJG(string a, long b, string c, PYAXBIZPKFO<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8098D10", Offset = "0x8097910", VA = "0x188098D10", Slot = "9")]
		public override string TCYVYFQAZKQ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8098DA0", Offset = "0x80979A0", VA = "0x188098DA0", Slot = "10")]
		protected override void XUFFRHGTHET(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class ZRWDXPOLJKN : PKLILSLAVTW<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType XSYNALKQIRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB5A490", Offset = "0xB59090", VA = "0x180B5A490", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x809BC80", Offset = "0x809A880", VA = "0x18809BC80")]
		public ZRWDXPOLJKN(string a, long b, string c, PYAXBIZPKFO<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x809BB20", Offset = "0x809A720", VA = "0x18809BB20", Slot = "9")]
		public override string TCYVYFQAZKQ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x809BC10", Offset = "0x809A810", VA = "0x18809BC10", Slot = "10")]
		protected override void XUFFRHGTHET(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class HRVPYOFDDQV : PKLILSLAVTW<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType XSYNALKQIRF
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB44D60", Offset = "0xB43960", VA = "0x180B44D60", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool HYLNHOWUFPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8096FB0", Offset = "0x8095BB0", VA = "0x188096FB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8097160", Offset = "0x8095D60", VA = "0x188097160")]
		public HRVPYOFDDQV(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x80970F0", Offset = "0x8095CF0", VA = "0x1880970F0")]
		public HRVPYOFDDQV(string a, long b, string c, PYAXBIZPKFO<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8097030", Offset = "0x8095C30", VA = "0x188097030", Slot = "9")]
		public override string TCYVYFQAZKQ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x80970A0", Offset = "0x8095CA0", VA = "0x1880970A0", Slot = "10")]
		protected override void XUFFRHGTHET(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class NDDWNJRSSUD : PKLILSLAVTW<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] IUVNQAWSATH;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string MJCEHCACZOT
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5C0", Offset = "0xA991C0", VA = "0x180A9A5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA9A5B0", Offset = "0xA991B0", VA = "0x180A9A5B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType XSYNALKQIRF
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB55810", Offset = "0xB54410", VA = "0x180B55810", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool HYLNHOWUFPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8097F50", Offset = "0x8096B50", VA = "0x188097F50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x80982C0", Offset = "0x8096EC0", VA = "0x1880982C0")]
		public NDDWNJRSSUD(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8098310", Offset = "0x8096F10", VA = "0x188098310")]
		public NDDWNJRSSUD(string a, long b, string c, PYAXBIZPKFO<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x80980D0", Offset = "0x8096CD0", VA = "0x1880980D0", Slot = "9")]
		public override string TCYVYFQAZKQ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8098190", Offset = "0x8096D90", VA = "0x188098190", Slot = "10")]
		protected override void XUFFRHGTHET(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class EDZRGTLIHWI<a> : YRCOWNSIBTH where a : UJLGZAJRWKK.CAAEXQJQMBC, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int JGSZJOSCNAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract UJLGZAJRWKK.MessageContentType DKBEBQVFLPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4669D70", Offset = "0x4668970", VA = "0x184669D70", Slot = "7")]
		private UJLGZAJRWKK.CAAEXQJQMBC JQAZOJVESOZ(UJLGZAJRWKK.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4669BB0", Offset = "0x46687B0", VA = "0x184669BB0", Slot = "6")]
		private PYAXBIZPKFO<UJLGZAJRWKK.MJHCKGCNRUI> DXTLDUYYYXA(UJLGZAJRWKK.CAAEXQJQMBC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4669C10", Offset = "0x4668810", VA = "0x184669C10", Slot = "10")]
		public virtual a EYXYFSIUXWY(UJLGZAJRWKK.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4669900", Offset = "0x4668500", VA = "0x184669900", Slot = "11")]
		public virtual PYAXBIZPKFO<UJLGZAJRWKK.MJHCKGCNRUI> AUQHRSHWVVV(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "12")]
		protected virtual void HRBFXDZYNUF(a a, UJLGZAJRWKK.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4669CF0", Offset = "0x46688F0", VA = "0x184669CF0", Slot = "13")]
		protected virtual PYAXBIZPKFO<string> FKCIEIMQVUV(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		protected EDZRGTLIHWI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4669AD0", Offset = "0x46686D0", VA = "0x184669AD0")]
		[CompilerGenerated]
		private UJLGZAJRWKK.MJHCKGCNRUI CRSYOHAVGOH(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface YRCOWNSIBTH
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int JGSZJOSCNAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		UJLGZAJRWKK.MessageContentType DKBEBQVFLPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PYAXBIZPKFO<UJLGZAJRWKK.MJHCKGCNRUI> AUQHRSHWVVV(UJLGZAJRWKK.CAAEXQJQMBC a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		UJLGZAJRWKK.CAAEXQJQMBC EYXYFSIUXWY(UJLGZAJRWKK.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface UIDCXVUDSGS : YRCOWNSIBTH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OIFOWULCEAJ(AHFTCICYEFF a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : EDZRGTLIHWI<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class NHRRJWWBWAO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool HYLNHOWUFPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int QJGTZRDVERY;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string YCXUPYKSQQK
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType XSYNALKQIRF
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xA9D1C0", Offset = "0xA9BDC0", VA = "0x180A9D1C0")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xA9F8C0", Offset = "0xA9E4C0", VA = "0x180A9F8C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int YBJWTYANQOM
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x131EB30", Offset = "0x131D730", VA = "0x18131EB30")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x131EB20", Offset = "0x131D720", VA = "0x18131EB20")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int YPPWULXSKBR
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xAA74F0", Offset = "0xAA60F0", VA = "0x180AA74F0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xAFA0D0", Offset = "0xAF8CD0", VA = "0x180AFA0D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string TYNZVMUFMCH
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xA98610", Offset = "0xA97210", VA = "0x180A98610")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xA9F8D0", Offset = "0xA9E4D0", VA = "0x180A9F8D0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x13CD2A0", Offset = "0x13CBEA0", VA = "0x1813CD2A0")]
			public NHRRJWWBWAO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum MarkupReplacementType
		{
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			Invalid,
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			Username,
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			Roomname,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			Photo
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly XAJEGOUUZKF FJRMFEBDPAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly KIMLDTYOZSJ MYDUBOLSBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly AHPYCGQXNTZ EDCWQRJUPTM;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int JGSZJOSCNAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB55810", Offset = "0xB54410", VA = "0x180B55810", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override UJLGZAJRWKK.MessageContentType DKBEBQVFLPV
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xA9F8F0", Offset = "0xA9E4F0", VA = "0x180A9F8F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(UJLGZAJRWKK.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8097EC0", Offset = "0x8096AC0", VA = "0x188097EC0")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] XAJEGOUUZKF roomsClient, [Inject(null)] KIMLDTYOZSJ accountsClient, [Inject(null)] AHPYCGQXNTZ imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x80975E0", Offset = "0x80961E0", VA = "0x1880975E0", Slot = "11")]
		public override PYAXBIZPKFO<UJLGZAJRWKK.MJHCKGCNRUI> AUQHRSHWVVV(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8097620", Offset = "0x8096220", VA = "0x188097620", Slot = "10")]
		public override TextMessageDetails EYXYFSIUXWY(UJLGZAJRWKK.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8097740", Offset = "0x8096340", VA = "0x188097740")]
		private void LXMLMKYLORK(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : EDZRGTLIHWI<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int JGSZJOSCNAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xB55810", Offset = "0xB54410", VA = "0x180B55810", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override UJLGZAJRWKK.MessageContentType DKBEBQVFLPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB55810", Offset = "0xB54410", VA = "0x180B55810", Slot = "9")]
			get
			{
				return default(UJLGZAJRWKK.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8098530", Offset = "0x8097130", VA = "0x188098530")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : EDZRGTLIHWI<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int JGSZJOSCNAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xB55810", Offset = "0xB54410", VA = "0x180B55810", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override UJLGZAJRWKK.MessageContentType DKBEBQVFLPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB5A490", Offset = "0xB59090", VA = "0x180B5A490", Slot = "9")]
			get
			{
				return default(UJLGZAJRWKK.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x80987F0", Offset = "0x80973F0", VA = "0x1880987F0", Slot = "12")]
		protected override void HRBFXDZYNUF(PhotoMessageDetails a, UJLGZAJRWKK.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8098990", Offset = "0x8097590", VA = "0x188098990")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : EDZRGTLIHWI<TextMessageDetails>, UIDCXVUDSGS, YRCOWNSIBTH
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class SEWWWLJILVR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails HJECQFCDJVI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager BIVSZSMQJUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool ZLWTUAIAUME;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SEWWWLJILVR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8099170", Offset = "0x8097D70", VA = "0x188099170")]
			internal UJLGZAJRWKK.MJHCKGCNRUI AXZOVRFVJLH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int STUXQSTPLPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int RFKBRIVYVGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, AHFTCICYEFF> ZSHHJJJXNQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, AHFTCICYEFF> IFOWQLDIINE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private XZFJDCCBKTO<ZRWDXPOLJKN> MYNFJAKDYFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private XZFJDCCBKTO<NDDWNJRSSUD> VXHSSTSDDLD;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int JGSZJOSCNAF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB5A490", Offset = "0xB59090", VA = "0x180B5A490", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override UJLGZAJRWKK.MessageContentType DKBEBQVFLPV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160", Slot = "9")]
			get
			{
				return default(UJLGZAJRWKK.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x809A180", Offset = "0x8098D80", VA = "0x18809A180", Slot = "14")]
		public void OIFOWULCEAJ(AHFTCICYEFF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8099970", Offset = "0x8098570", VA = "0x188099970", Slot = "11")]
		public override PYAXBIZPKFO<UJLGZAJRWKK.MJHCKGCNRUI> AUQHRSHWVVV(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8099C10", Offset = "0x8098810", VA = "0x188099C10", Slot = "12")]
		protected override void HRBFXDZYNUF(TextMessageDetails a, UJLGZAJRWKK.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x809A040", Offset = "0x8098C40", VA = "0x18809A040")]
		private bool HVCUYYBZZFZ(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x809A510", Offset = "0x8099110", VA = "0x18809A510")]
		private static int XMXIPPBNIGC(TextMessageDetails a, int b, bool c, AHFTCICYEFF d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x809A750", Offset = "0x8099350", VA = "0x18809A750")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class FXRHPNUOCIQ<a> : XZFJDCCBKTO<a>, AHFTCICYEFF, IEquatable<AHFTCICYEFF>, IEquatable<ChatTokenType> where a : WTSZZVFCWUO
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] QLIKQEEEXVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string UBMVEMKGPSE;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType UHOCSZLJZYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string FULZATEHYYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x4C77540", Offset = "0x4C76140", VA = "0x184C77540", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char KFMPBWWHVNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char HVYLGZJZFGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType IQFDFJLGEJR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x4C77520", Offset = "0x4C76120", VA = "0x184C77520", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4C77710", Offset = "0x4C76310", VA = "0x184C77710")]
		protected FXRHPNUOCIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4C77300", Offset = "0x4C75F00", VA = "0x184C77300")]
		protected string VYIVWYHFNIW(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4C76D90", Offset = "0x4C75990", VA = "0x184C76D90", Slot = "14")]
		public bool LMMIVTGGNIT(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4C77400", Offset = "0x4C76000", VA = "0x184C77400", Slot = "15")]
		public void XZIOFZAIQDY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a ROPPLRYXZQH(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4C76FC0", Offset = "0x4C75BC0", VA = "0x184C76FC0", Slot = "8")]
		private WTSZZVFCWUO RVZSIBBGVPC(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool QNWSIBBCADQ(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string YIFABDDWSWE(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4C76CB0", Offset = "0x4C758B0", VA = "0x184C76CB0")]
		private bool KFGWIOOLXGS(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4C76F50", Offset = "0x4C75B50", VA = "0x184C76F50")]
		private string QUCCWMWCNMA(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4C76FE0", Offset = "0x4C75BE0", VA = "0x184C76FE0", Slot = "6")]
		private bool TRVKCERYRBE(string a, [Out] WTSZZVFCWUO b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x4C771B0", Offset = "0x4C75DB0", VA = "0x184C771B0", Slot = "7")]
		private void VBUUDBGDXGV(WTSZZVFCWUO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4C76C80", Offset = "0x4C75880", VA = "0x184C76C80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4C76B60", Offset = "0x4C75760", VA = "0x184C76B60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4C76AE0", Offset = "0x4C756E0", VA = "0x184C76AE0", Slot = "9")]
		public bool Equals(AHFTCICYEFF other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4C76AB0", Offset = "0x4C756B0", VA = "0x184C76AB0", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : IOYSDBJDTRQ<RZKYWCKOJMS>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly OOARLSUUKIY YOYPVAXIPGD;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType UHOCSZLJZYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xB54950", Offset = "0xB53550", VA = "0x180B54950", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char KFMPBWWHVNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1C11130", Offset = "0x1C0FD30", VA = "0x181C11130", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char HVYLGZJZFGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8096EE0", Offset = "0x8095AE0", VA = "0x188096EE0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8096EF0", Offset = "0x8095AF0", VA = "0x188096EF0")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] OOARLSUUKIY clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8096D90", Offset = "0x8095990", VA = "0x188096D90", Slot = "19")]
		protected override RZKYWCKOJMS IJOHHCIPPEJ(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface AHFTCICYEFF : IEquatable<AHFTCICYEFF>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType UHOCSZLJZYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string FULZATEHYYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool LMMIVTGGNIT(string a, [Out] WTSZZVFCWUO b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XZIOFZAIQDY(WTSZZVFCWUO a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		WTSZZVFCWUO ROPPLRYXZQH(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface XZFJDCCBKTO<a> : AHFTCICYEFF, IEquatable<AHFTCICYEFF>, IEquatable<ChatTokenType> where a : WTSZZVFCWUO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : IOYSDBJDTRQ<QZNNOLIPHJG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly AHPYCGQXNTZ EDCWQRJUPTM;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType UHOCSZLJZYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xB3AFF0", Offset = "0xB39BF0", VA = "0x180B3AFF0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char KFMPBWWHVNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1C144E0", Offset = "0x1C130E0", VA = "0x181C144E0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char HVYLGZJZFGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xB03C20", Offset = "0xB02820", VA = "0x180B03C20", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x80986C0", Offset = "0x80972C0", VA = "0x1880986C0")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] AHPYCGQXNTZ imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8098570", Offset = "0x8097170", VA = "0x188098570", Slot = "19")]
		protected override QZNNOLIPHJG IJOHHCIPPEJ(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : IOYSDBJDTRQ<ZRWDXPOLJKN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly KIMLDTYOZSJ MYDUBOLSBIA;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType UHOCSZLJZYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB5A490", Offset = "0xB59090", VA = "0x180B5A490", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char KFMPBWWHVNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1C5CE70", Offset = "0x1C5BA70", VA = "0x181C5CE70", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char HVYLGZJZFGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x8098AE0", Offset = "0x80976E0", VA = "0x188098AE0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8098AF0", Offset = "0x80976F0", VA = "0x188098AF0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] KIMLDTYOZSJ accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x80989D0", Offset = "0x80975D0", VA = "0x1880989D0", Slot = "19")]
		protected override ZRWDXPOLJKN IJOHHCIPPEJ(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : IOYSDBJDTRQ<HRVPYOFDDQV>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly WDJZATSEHHO VVNODYKDLGE;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType UHOCSZLJZYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xB44D60", Offset = "0xB43960", VA = "0x180B44D60", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char KFMPBWWHVNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1C11130", Offset = "0x1C0FD30", VA = "0x181C11130", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char HVYLGZJZFGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8098CA0", Offset = "0x80978A0", VA = "0x188098CA0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8098CB0", Offset = "0x80978B0", VA = "0x188098CB0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] WDJZATSEHHO playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8098B50", Offset = "0x8097750", VA = "0x188098B50", Slot = "19")]
		protected override HRVPYOFDDQV IJOHHCIPPEJ(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : IOYSDBJDTRQ<NDDWNJRSSUD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly XAJEGOUUZKF FJRMFEBDPAO;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType UHOCSZLJZYI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB55810", Offset = "0xB54410", VA = "0x180B55810", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char KFMPBWWHVNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8099100", Offset = "0x8097D00", VA = "0x188099100", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char HVYLGZJZFGS
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1C007C0", Offset = "0x1BFF3C0", VA = "0x181C007C0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8099110", Offset = "0x8097D10", VA = "0x188099110")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] XAJEGOUUZKF roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8098FF0", Offset = "0x8097BF0", VA = "0x188098FF0", Slot = "19")]
		protected override NDDWNJRSSUD IJOHHCIPPEJ(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class IOYSDBJDTRQ<a> : FXRHPNUOCIQ<a> where a : WTSZZVFCWUO
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4FA92F0", Offset = "0x4FA7EF0", VA = "0x184FA92F0", Slot = "16")]
		public override a ROPPLRYXZQH(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4FA9330", Offset = "0x4FA7F30", VA = "0x184FA9330", Slot = "18")]
		protected override string YIFABDDWSWE(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4FA91D0", Offset = "0x4FA7DD0", VA = "0x184FA91D0", Slot = "17")]
		protected override bool QNWSIBBCADQ(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a IJOHHCIPPEJ(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4FA93D0", Offset = "0x4FA7FD0", VA = "0x184FA93D0")]
		protected IOYSDBJDTRQ()
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
