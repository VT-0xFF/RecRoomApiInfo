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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x845BC10", Offset = "0x845AA10", VA = "0x18845BC10")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE8B60", Offset = "0xAE7960", VA = "0x180AE8B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x8460300", Offset = "0x845F100", VA = "0x188460300", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2963E60", Offset = "0x2962C60", VA = "0x182963E60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : OHBZQFLFEWB
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class RVDZJLMSLEQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage TVKSXWCBKTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> CBFUUFAHZAN;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public RVDZJLMSLEQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x845D6D0", Offset = "0x845C4D0", VA = "0x18845D6D0")]
			internal WGVXBSAEBCD QLHTGFZXBTB(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x845D6A0", Offset = "0x845C4A0", VA = "0x18845D6A0")]
			internal void QLCMIZFZSHS(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class WLRRSVOUONV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage TVKSXWCBKTC;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WLRRSVOUONV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x84602D0", Offset = "0x845F0D0", VA = "0x1884602D0")]
			internal void EEAIRTSTRJA(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class IJGUSUENVJY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public HYWEWOFUFBQ.MessageContentType KOHMOLRFJUE;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public IJGUSUENVJY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x845B220", Offset = "0x845A020", VA = "0x18845B220")]
			internal bool TDPPTYRIEDL(BRAIOHBNGER a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly HYWEWOFUFBQ.YIZZENEWDLS EJIALLQRIQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int BHWTKNIIPVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<BRAIOHBNGER> EPGDNNMJVUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly GMLBVKNTBCB CWGGPRPHYCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly YRSGHQDBAIL IXMLZBBICRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly UPIRAKUNEKE FLNXAEZFMBZ;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x845A950", Offset = "0x8459750", VA = "0x18845A950")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] GMLBVKNTBCB accountsClient, [Inject(null)] YRSGHQDBAIL chatClient, [Inject(null)] UPIRAKUNEKE clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x845A290", Offset = "0x8459090", VA = "0x18845A290", Slot = "5")]
		public bool SVXOIMHUGIZ(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x845A030", Offset = "0x8458E30", VA = "0x18845A030", Slot = "6")]
		public ChatMessage PNBECQBNWBN(long a, HYWEWOFUFBQ.YIZZENEWDLS b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8459EB0", Offset = "0x8458CB0", VA = "0x188459EB0", Slot = "7")]
		public YLZUVDOLRNC<HYWEWOFUFBQ.FPYCSVQVDQY> LZRYSADYVPR(HYWEWOFUFBQ.YIZZENEWDLS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8459AB0", Offset = "0x84588B0", VA = "0x188459AB0", Slot = "4")]
		public void EHLPMCROBDX(BRAIOHBNGER a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8459BC0", Offset = "0x84589C0", VA = "0x188459BC0", Slot = "8")]
		public void IBXJYVSIMDI(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x845A480", Offset = "0x8459280", VA = "0x18845A480")]
		private HYWEWOFUFBQ.YIZZENEWDLS TSKMGOXVWZG(HYWEWOFUFBQ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x845A680", Offset = "0x8459480", VA = "0x18845A680")]
		private void YPDJYMVBOYR(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8459CB0", Offset = "0x8458AB0", VA = "0x188459CB0")]
		private void JVUAROOHXCK(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x845A1B0", Offset = "0x8458FB0", VA = "0x18845A1B0")]
		private BRAIOHBNGER PNQZKRVCEFF(int a, HYWEWOFUFBQ.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface OHBZQFLFEWB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EHLPMCROBDX(BRAIOHBNGER a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SVXOIMHUGIZ(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage PNBECQBNWBN(long a, HYWEWOFUFBQ.YIZZENEWDLS b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		YLZUVDOLRNC<HYWEWOFUFBQ.FPYCSVQVDQY> LZRYSADYVPR(HYWEWOFUFBQ.YIZZENEWDLS a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IBXJYVSIMDI(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface CORLQVBGFUK
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		OZAYXQWBYWY<CORLQVBGFUK> FZEKOWFXUZE
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool TSTFINVRROC
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<EUDBISHTTKG> DKWEQISZOOL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string YTUDXKSFVRJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		WGVXBSAEBCD HRPSKLVLRGF();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : HYWEWOFUFBQ.YIZZENEWDLS
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override HYWEWOFUFBQ.MessageContentType JWKEUHZLJYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "10")]
			get
			{
				return default(HYWEWOFUFBQ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x845BD30", Offset = "0x845AB30", VA = "0x18845BD30")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x845BC90", Offset = "0x845AA90", VA = "0x18845BC90")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : HYWEWOFUFBQ.YIZZENEWDLS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long JUQLAQEEITD;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override HYWEWOFUFBQ.MessageContentType JWKEUHZLJYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB16790", Offset = "0xB15590", VA = "0x180B16790", Slot = "10")]
			get
			{
				return default(HYWEWOFUFBQ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string ZQUFKFPEUSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xF184A0", Offset = "0xF172A0", VA = "0x180F184A0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long LBWLSSTFHQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x845BF30", Offset = "0x845AD30", VA = "0x18845BF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x845BFF0", Offset = "0x845ADF0", VA = "0x18845BFF0")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x845BFB0", Offset = "0x845ADB0", VA = "0x18845BFB0")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class TMTOOMGWGCI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x845DBC0", Offset = "0x845C9C0", VA = "0x18845DBC0")]
		[FDNTPBIGLET.Root]
		internal static void CPQSXQWHCVQ(FDTRVDFSBYT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x845DEA0", Offset = "0x845CCA0", VA = "0x18845DEA0")]
		[UnityEngine.Scripting.Preserve]
		public TMTOOMGWGCI([Inject(null)] OHBZQFLFEWB chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] IHAFBBOUBMC textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class RTDLBEHGLON
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class URZEQUFXAGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public CORLQVBGFUK QMYELVTIOBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool QZNZNQZVQIR;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public URZEQUFXAGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x845FAC0", Offset = "0x845E8C0", VA = "0x18845FAC0")]
			internal string RAQQXATWAKF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] EZOFAEIDBMF;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x845C9E0", Offset = "0x845B7E0", VA = "0x18845C9E0")]
		public static YLZUVDOLRNC<string> ASLDMNFIIYT(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x845CAB0", Offset = "0x845B8B0", VA = "0x18845CAB0")]
		public static YLZUVDOLRNC<string> ASLDMNFIIYT(HYWEWOFUFBQ.YIZZENEWDLS a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x845D210", Offset = "0x845C010", VA = "0x18845D210")]
		private static string YTKIYEPVFXJ(CORLQVBGFUK a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x845D000", Offset = "0x845BE00", VA = "0x18845D000")]
		public static string TNTPRPLQPCB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x845D100", Offset = "0x845BF00", VA = "0x18845D100")]
		public static string YNWKYOZXLGO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x845CDD0", Offset = "0x845BBD0", VA = "0x18845CDD0")]
		public static bool FBXUWVOQJVL(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x845CF90", Offset = "0x845BD90", VA = "0x18845CF90")]
		public static bool KHCORJCDBRI(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x845D4D0", Offset = "0x845C2D0", VA = "0x18845D4D0")]
		public static bool ZOJLSEMIGPT(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x845CE40", Offset = "0x845BC40", VA = "0x18845CE40")]
		public static string FRCPJDZLSCT(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : HYWEWOFUFBQ.YIZZENEWDLS, CORLQVBGFUK
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public OZAYXQWBYWY<CORLQVBGFUK> FZEKOWFXUZE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<EUDBISHTTKG> DKWEQISZOOL
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool TSTFINVRROC
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x845EEE0", Offset = "0x845DCE0", VA = "0x18845EEE0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool QMJEJQMQHET
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x845F4E0", Offset = "0x845E2E0", VA = "0x18845F4E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x845F930", Offset = "0x845E730", VA = "0x18845F930")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x845F660", Offset = "0x845E460", VA = "0x18845F660")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x845F820", Offset = "0x845E620", VA = "0x18845F820")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x845F3F0", Offset = "0x845E1F0", VA = "0x18845F3F0", Slot = "17")]
		public void KQGHLXMMAUP(EUDBISHTTKG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x845F020", Offset = "0x845DE20", VA = "0x18845F020", Slot = "16")]
		public WGVXBSAEBCD HRPSKLVLRGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x845F570", Offset = "0x845E370", VA = "0x18845F570")]
		private void URCHBMIHHTC(EUDBISHTTKG a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class EUDBISHTTKG : IEquatable<EUDBISHTTKG>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public OZAYXQWBYWY<EUDBISHTTKG> FZEKOWFXUZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool TSTFINVRROC
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB40C50", Offset = "0xB3FA50", VA = "0x180B40C50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xABD140", Offset = "0xABBF40", VA = "0x180ABD140", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool QMJEJQMQHET
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x845AFC0", Offset = "0x8459DC0", VA = "0x18845AFC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string OLOHOXBKCVD
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAC0640", Offset = "0xABF440", VA = "0x180AC0640")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long GHFUNLUBWKZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xABFD90", VA = "0x180AC0F90")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D00", Offset = "0xABFB00", VA = "0x180AC0D00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string VXXRPQSUAGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object CBOQGOTHUEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAC5120", Offset = "0xAC3F20", VA = "0x180AC5120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAC0FB0", Offset = "0xABFDB0", VA = "0x180AC0FB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public WGVXBSAEBCD AIPFARWPSWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D30", Offset = "0xABFB30", VA = "0x180AC0D30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAC1370", Offset = "0xAC0170", VA = "0x180AC1370")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x845B0D0", Offset = "0x8459ED0", VA = "0x18845B0D0")]
		protected EUDBISHTTKG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x845B170", Offset = "0x8459F70", VA = "0x18845B170")]
		protected EUDBISHTTKG(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x845B000", Offset = "0x8459E00", VA = "0x18845B000")]
		protected EUDBISHTTKG(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x845ADE0", Offset = "0x8459BE0", VA = "0x18845ADE0")]
		protected void EMWUSQLOWGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x845AEB0", Offset = "0x8459CB0", VA = "0x18845AEB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x845AF90", Offset = "0x8459D90", VA = "0x18845AF90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x845AE30", Offset = "0x8459C30", VA = "0x18845AE30", Slot = "4")]
		public bool Equals(EUDBISHTTKG other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAC1D20", Offset = "0xAC0B20", VA = "0x180AC1D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string ZNJJUOLXJNK(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class TIXNLCZRYZW<a, b> : EUDBISHTTKG where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class ROWRFPJNAWU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public YPTUROBCDWM RBWVUSXCLKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public TIXNLCZRYZW<a, b> WFAEFPOXIOJ;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public ROWRFPJNAWU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A040", Offset = "0x5E78E40", VA = "0x185E7A040")]
			internal void IQGVEJPXJPW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a CBOQGOTHUEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x62231B0", Offset = "0x6221FB0", VA = "0x1862231B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6223220", Offset = "0x6222020", VA = "0x186223220")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62236E0", Offset = "0x62224E0", VA = "0x1862236E0")]
		protected TIXNLCZRYZW(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6223290", Offset = "0x6222090", VA = "0x186223290")]
		protected TIXNLCZRYZW(string a, long b, string c, YLZUVDOLRNC<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void PBCJPHRSUGT(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6223240", Offset = "0x6222040", VA = "0x186223240")]
		private void RCZUYNSLCRY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6223200", Offset = "0x6222000", VA = "0x186223200")]
		[CompilerGenerated]
		private void ELLRKYUFOEX(string a)
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
	public class CYTVSKMCYOS : TIXNLCZRYZW<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xD8DD70", Offset = "0xD8CB70", VA = "0x180D8DD70", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8459A60", Offset = "0x8458860", VA = "0x188459A60")]
		public CYTVSKMCYOS(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x84599F0", Offset = "0x84587F0", VA = "0x1884599F0")]
		public CYTVSKMCYOS(string a, long b, string c, YLZUVDOLRNC<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8459980", Offset = "0x8458780", VA = "0x188459980", Slot = "9")]
		public override string ZNJJUOLXJNK(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8459870", Offset = "0x8458670", VA = "0x188459870", Slot = "10")]
		protected override void PBCJPHRSUGT(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class RXAMCULKMMM : TIXNLCZRYZW<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C9C0", VA = "0x180D3DBC0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x845D9D0", Offset = "0x845C7D0", VA = "0x18845D9D0")]
		public RXAMCULKMMM(string a, long b, string c, YLZUVDOLRNC<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x845D940", Offset = "0x845C740", VA = "0x18845D940", Slot = "9")]
		public override string ZNJJUOLXJNK(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x845D8F0", Offset = "0x845C6F0", VA = "0x18845D8F0", Slot = "10")]
		protected override void PBCJPHRSUGT(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CIUUVLBBVFP : TIXNLCZRYZW<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB16790", Offset = "0xB15590", VA = "0x180B16790", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8459800", Offset = "0x8458600", VA = "0x188459800")]
		public CIUUVLBBVFP(string a, long b, string c, YLZUVDOLRNC<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8459710", Offset = "0x8458510", VA = "0x188459710", Slot = "9")]
		public override string ZNJJUOLXJNK(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84596A0", Offset = "0x84584A0", VA = "0x1884596A0", Slot = "10")]
		protected override void PBCJPHRSUGT(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class EJGYZYGSIPD : TIXNLCZRYZW<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xBCD920", Offset = "0xBCC720", VA = "0x180BCD920", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool QMJEJQMQHET
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x845AC30", Offset = "0x8459A30", VA = "0x18845AC30", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x845AD90", Offset = "0x8459B90", VA = "0x18845AD90")]
		public EJGYZYGSIPD(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x845AD20", Offset = "0x8459B20", VA = "0x18845AD20")]
		public EJGYZYGSIPD(string a, long b, string c, YLZUVDOLRNC<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x845ACB0", Offset = "0x8459AB0", VA = "0x18845ACB0", Slot = "9")]
		public override string ZNJJUOLXJNK(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x845ABE0", Offset = "0x84599E0", VA = "0x18845ABE0", Slot = "10")]
		protected override void PBCJPHRSUGT(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class RNEQCVUZCRZ : TIXNLCZRYZW<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] GFBQVEODPQB;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string AWFHRSXNTLB
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAC31E0", Offset = "0xAC1FE0", VA = "0x180AC31E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAC31C0", Offset = "0xAC1FC0", VA = "0x180AC31C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType QCFSUOQZRCP
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool QMJEJQMQHET
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x845C650", Offset = "0x845B450", VA = "0x18845C650", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x845C990", Offset = "0x845B790", VA = "0x18845C990")]
		public RNEQCVUZCRZ(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x845C920", Offset = "0x845B720", VA = "0x18845C920")]
		public RNEQCVUZCRZ(string a, long b, string c, YLZUVDOLRNC<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x845C7C0", Offset = "0x845B5C0", VA = "0x18845C7C0", Slot = "9")]
		public override string ZNJJUOLXJNK(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x845C520", Offset = "0x845B320", VA = "0x18845C520", Slot = "10")]
		protected override void PBCJPHRSUGT(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class NYFZJMMTLIM<a> : BRAIOHBNGER where a : HYWEWOFUFBQ.YIZZENEWDLS, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int TVMQSEZQBBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract HYWEWOFUFBQ.MessageContentType JWKEUHZLJYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5B450D0", Offset = "0x5B43ED0", VA = "0x185B450D0", Slot = "7")]
		private HYWEWOFUFBQ.YIZZENEWDLS VPEGAMKQZYZ(HYWEWOFUFBQ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5B44F90", Offset = "0x5B43D90", VA = "0x185B44F90", Slot = "6")]
		private YLZUVDOLRNC<HYWEWOFUFBQ.FPYCSVQVDQY> SIQTHVXKEDI(HYWEWOFUFBQ.YIZZENEWDLS a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5B44FF0", Offset = "0x5B43DF0", VA = "0x185B44FF0", Slot = "10")]
		public virtual a TSKMGOXVWZG(HYWEWOFUFBQ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5B44CE0", Offset = "0x5B43AE0", VA = "0x185B44CE0", Slot = "11")]
		public virtual YLZUVDOLRNC<HYWEWOFUFBQ.FPYCSVQVDQY> LZRYSADYVPR(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "12")]
		protected virtual void ETAVIIPIONH(a a, HYWEWOFUFBQ.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5B44C60", Offset = "0x5B43A60", VA = "0x185B44C60", Slot = "13")]
		protected virtual YLZUVDOLRNC<string> AJVOSIYKLRL(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected NYFZJMMTLIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5B44EB0", Offset = "0x5B43CB0", VA = "0x185B44EB0")]
		[CompilerGenerated]
		private HYWEWOFUFBQ.FPYCSVQVDQY SFPRMWPROBZ(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface BRAIOHBNGER
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int TVMQSEZQBBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		HYWEWOFUFBQ.MessageContentType JWKEUHZLJYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		YLZUVDOLRNC<HYWEWOFUFBQ.FPYCSVQVDQY> LZRYSADYVPR(HYWEWOFUFBQ.YIZZENEWDLS a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		HYWEWOFUFBQ.YIZZENEWDLS TSKMGOXVWZG(HYWEWOFUFBQ.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface IHAFBBOUBMC : BRAIOHBNGER
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void REWZTFUFLEN(YLSUBHKZZKX a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : NYFZJMMTLIM<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class ISXVIJBINSG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool QMJEJQMQHET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int XTDWNSFDLTI;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string DFYCPINDDVU
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xABD130", Offset = "0xABBF30", VA = "0x180ABD130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xABD120", Offset = "0xABBF20", VA = "0x180ABD120")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType QCFSUOQZRCP
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xAC7B20", Offset = "0xAC6920", VA = "0x180AC7B20")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xACAE40", Offset = "0xAC9C40", VA = "0x180ACAE40")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int RALTSMJFDXW
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x15FD4F0", Offset = "0x15FC2F0", VA = "0x1815FD4F0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x15FD4E0", Offset = "0x15FC2E0", VA = "0x1815FD4E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int SZZFMTHWKJR
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xACF4D0", Offset = "0xACE2D0", VA = "0x180ACF4D0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xB20FD0", Offset = "0xB1FDD0", VA = "0x180B20FD0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string RTTBIFVRMXF
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xAC0F80", Offset = "0xABFD80", VA = "0x180AC0F80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xAC8C50", Offset = "0xAC7A50", VA = "0x180AC8C50")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16966B0", Offset = "0x16954B0", VA = "0x1816966B0")]
			public ISXVIJBINSG()
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
		private readonly ZAWMEKUKSAF IHDSNWDLWTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly GMLBVKNTBCB CWGGPRPHYCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly PUPCCTGWGUT VMLUILOKZLE;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int TVMQSEZQBBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override HYWEWOFUFBQ.MessageContentType JWKEUHZLJYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAC2060", Offset = "0xAC0E60", VA = "0x180AC2060", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(HYWEWOFUFBQ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x845BB80", Offset = "0x845A980", VA = "0x18845BB80")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] ZAWMEKUKSAF roomsClient, [Inject(null)] GMLBVKNTBCB accountsClient, [Inject(null)] PUPCCTGWGUT imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x845B2A0", Offset = "0x845A0A0", VA = "0x18845B2A0", Slot = "11")]
		public override YLZUVDOLRNC<HYWEWOFUFBQ.FPYCSVQVDQY> LZRYSADYVPR(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x845BA60", Offset = "0x845A860", VA = "0x18845BA60", Slot = "10")]
		public override TextMessageDetails TSKMGOXVWZG(HYWEWOFUFBQ.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x845B2E0", Offset = "0x845A0E0", VA = "0x18845B2E0")]
		private void QNGMCQTXMBS(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : NYFZJMMTLIM<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int TVMQSEZQBBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override HYWEWOFUFBQ.MessageContentType JWKEUHZLJYT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "9")]
			get
			{
				return default(HYWEWOFUFBQ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x845BD40", Offset = "0x845AB40", VA = "0x18845BD40")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : NYFZJMMTLIM<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int TVMQSEZQBBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override HYWEWOFUFBQ.MessageContentType JWKEUHZLJYT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB16790", Offset = "0xB15590", VA = "0x180B16790", Slot = "9")]
			get
			{
				return default(HYWEWOFUFBQ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x845C000", Offset = "0x845AE00", VA = "0x18845C000", Slot = "12")]
		protected override void ETAVIIPIONH(PhotoMessageDetails a, HYWEWOFUFBQ.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x845C1A0", Offset = "0x845AFA0", VA = "0x18845C1A0")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : NYFZJMMTLIM<TextMessageDetails>, IHAFBBOUBMC, BRAIOHBNGER
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class WLRRSVOUONV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails LVFNANVSRTE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager WFAEFPOXIOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool GGDAIKVWRHC;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
			public WLRRSVOUONV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x845FB20", Offset = "0x845E920", VA = "0x18845FB20")]
			internal HYWEWOFUFBQ.FPYCSVQVDQY APOIJRHAEMZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int CRTODQCJGQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int XZQTQRFODPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, YLSUBHKZZKX> MSZUZQCMRLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, YLSUBHKZZKX> OIBGUPLMPSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private XLCUCVHGSKQ<CIUUVLBBVFP> LJOGKJGDSMT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private XLCUCVHGSKQ<RNEQCVUZCRZ> DKJYDLPOKBT;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int TVMQSEZQBBL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB16790", Offset = "0xB15590", VA = "0x180B16790", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override HYWEWOFUFBQ.MessageContentType JWKEUHZLJYT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xABE8E0", Offset = "0xABD6E0", VA = "0x180ABE8E0", Slot = "9")]
			get
			{
				return default(HYWEWOFUFBQ.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x845E7F0", Offset = "0x845D5F0", VA = "0x18845E7F0", Slot = "14")]
		public void REWZTFUFLEN(YLSUBHKZZKX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x845E410", Offset = "0x845D210", VA = "0x18845E410", Slot = "11")]
		public override YLZUVDOLRNC<HYWEWOFUFBQ.FPYCSVQVDQY> LZRYSADYVPR(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x845DFF0", Offset = "0x845CDF0", VA = "0x18845DFF0", Slot = "12")]
		protected override void ETAVIIPIONH(TextMessageDetails a, HYWEWOFUFBQ.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x845E6B0", Offset = "0x845D4B0", VA = "0x18845E6B0")]
		private bool QSNUZUAPTBJ(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x845EB80", Offset = "0x845D980", VA = "0x18845EB80")]
		private static int YIFAYNHWLRA(TextMessageDetails a, int b, bool c, YLSUBHKZZKX d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x845EDC0", Offset = "0x845DBC0", VA = "0x18845EDC0")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class ORGQVTEZDOI<a> : XLCUCVHGSKQ<a>, YLSUBHKZZKX, IEquatable<YLSUBHKZZKX>, IEquatable<ChatTokenType> where a : EUDBISHTTKG
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] ZBDHIZMSWQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string UYVPXCBUXUA;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType QXDXIJPOKTO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string PVYQKLCGHSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5C6F430", Offset = "0x5C6E230", VA = "0x185C6F430", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char GLEUPSFHADF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char LKLUMMAYQLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType DZDHKXZXYYD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x5C6FDA0", Offset = "0x5C6EBA0", VA = "0x185C6FDA0", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5C700A0", Offset = "0x5C6EEA0", VA = "0x185C700A0")]
		protected ORGQVTEZDOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5C6FAE0", Offset = "0x5C6E8E0", VA = "0x185C6FAE0")]
		protected string PNFFRZZXVPA(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5C6F720", Offset = "0x5C6E520", VA = "0x185C6F720", Slot = "14")]
		public bool JWCZNXMOHLN(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5C6F9C0", Offset = "0x5C6E7C0", VA = "0x185C6F9C0", Slot = "15")]
		public void OONYVDKPHOW(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a AQHNVQXSIEL(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5C6F6D0", Offset = "0x5C6E4D0", VA = "0x185C6F6D0", Slot = "8")]
		private EUDBISHTTKG GVAFNYYELOU(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool FBBQUPAPSVM(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string RGGISADJOPC(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5C6F8E0", Offset = "0x5C6E6E0", VA = "0x185C6F8E0")]
		private bool KQZEHVHQCOO(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5C6FD30", Offset = "0x5C6EB30", VA = "0x185C6FD30")]
		private string SGGYRGOQAAM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5C6FDC0", Offset = "0x5C6EBC0", VA = "0x185C6FDC0", Slot = "6")]
		private bool XCKYLBSLFSC(string a, [Out] EUDBISHTTKG b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5C6FBE0", Offset = "0x5C6E9E0", VA = "0x185C6FBE0", Slot = "7")]
		private void QDSBVSGISJD(EUDBISHTTKG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5C6F6F0", Offset = "0x5C6E4F0", VA = "0x185C6F6F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5C6F5B0", Offset = "0x5C6E3B0", VA = "0x185C6F5B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5C6F500", Offset = "0x5C6E300", VA = "0x185C6F500", Slot = "9")]
		public bool Equals(YLSUBHKZZKX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5C6F580", Offset = "0x5C6E380", VA = "0x185C6F580", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : EADFYLOAGCC<CYTVSKMCYOS>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly UPIRAKUNEKE FLNXAEZFMBZ;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType QXDXIJPOKTO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xD8DD70", Offset = "0xD8CB70", VA = "0x180D8DD70", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char GLEUPSFHADF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1EC6CD0", Offset = "0x1EC5AD0", VA = "0x181EC6CD0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char LKLUMMAYQLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x845AA20", Offset = "0x8459820", VA = "0x18845AA20", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x845AB80", Offset = "0x8459980", VA = "0x18845AB80")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] UPIRAKUNEKE clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x845AA30", Offset = "0x8459830", VA = "0x18845AA30", Slot = "19")]
		protected override CYTVSKMCYOS ORCHYWYOMIF(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface YLSUBHKZZKX : IEquatable<YLSUBHKZZKX>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType QXDXIJPOKTO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string PVYQKLCGHSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool JWCZNXMOHLN(string a, [Out] EUDBISHTTKG b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OONYVDKPHOW(EUDBISHTTKG a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		EUDBISHTTKG AQHNVQXSIEL(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface XLCUCVHGSKQ<a> : YLSUBHKZZKX, IEquatable<YLSUBHKZZKX>, IEquatable<ChatTokenType> where a : EUDBISHTTKG
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : EADFYLOAGCC<RXAMCULKMMM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly PUPCCTGWGUT VMLUILOKZLE;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType QXDXIJPOKTO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xD3DBC0", Offset = "0xD3C9C0", VA = "0x180D3DBC0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char GLEUPSFHADF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1EC8700", Offset = "0x1EC7500", VA = "0x181EC8700", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char LKLUMMAYQLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xE25530", Offset = "0xE24330", VA = "0x180E25530", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x845BED0", Offset = "0x845ACD0", VA = "0x18845BED0")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] PUPCCTGWGUT imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x845BD80", Offset = "0x845AB80", VA = "0x18845BD80", Slot = "19")]
		protected override RXAMCULKMMM ORCHYWYOMIF(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : EADFYLOAGCC<CIUUVLBBVFP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly GMLBVKNTBCB CWGGPRPHYCI;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType QXDXIJPOKTO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB16790", Offset = "0xB15590", VA = "0x180B16790", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char GLEUPSFHADF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F18F40", Offset = "0x1F17D40", VA = "0x181F18F40", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char LKLUMMAYQLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x845C1E0", Offset = "0x845AFE0", VA = "0x18845C1E0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x845C300", Offset = "0x845B100", VA = "0x18845C300")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] GMLBVKNTBCB accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x845C1F0", Offset = "0x845AFF0", VA = "0x18845C1F0", Slot = "19")]
		protected override CIUUVLBBVFP ORCHYWYOMIF(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : EADFYLOAGCC<EJGYZYGSIPD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly BIINVPRRYUQ GAJQUPWDZHC;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType QXDXIJPOKTO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xBCD920", Offset = "0xBCC720", VA = "0x180BCD920", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char GLEUPSFHADF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1EC6CD0", Offset = "0x1EC5AD0", VA = "0x181EC6CD0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char LKLUMMAYQLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x845C360", Offset = "0x845B160", VA = "0x18845C360", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x845C4C0", Offset = "0x845B2C0", VA = "0x18845C4C0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] BIINVPRRYUQ playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x845C370", Offset = "0x845B170", VA = "0x18845C370", Slot = "19")]
		protected override EJGYZYGSIPD ORCHYWYOMIF(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : EADFYLOAGCC<RNEQCVUZCRZ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly ZAWMEKUKSAF IHDSNWDLWTU;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType QXDXIJPOKTO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xC4F2E0", Offset = "0xC4E0E0", VA = "0x180C4F2E0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char GLEUPSFHADF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x845DA40", Offset = "0x845C840", VA = "0x18845DA40", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char LKLUMMAYQLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1EB7DE0", Offset = "0x1EB6BE0", VA = "0x181EB7DE0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x845DB60", Offset = "0x845C960", VA = "0x18845DB60")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] ZAWMEKUKSAF roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x845DA50", Offset = "0x845C850", VA = "0x18845DA50", Slot = "19")]
		protected override RNEQCVUZCRZ ORCHYWYOMIF(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class EADFYLOAGCC<a> : ORGQVTEZDOI<a> where a : EUDBISHTTKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4952910", Offset = "0x4951710", VA = "0x184952910", Slot = "16")]
		public override a AQHNVQXSIEL(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4952A70", Offset = "0x4951870", VA = "0x184952A70", Slot = "18")]
		protected override string RGGISADJOPC(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4952950", Offset = "0x4951750", VA = "0x184952950", Slot = "17")]
		protected override bool FBBQUPAPSVM(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a ORCHYWYOMIF(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4952B10", Offset = "0x4951910", VA = "0x184952B10")]
		protected EADFYLOAGCC()
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
