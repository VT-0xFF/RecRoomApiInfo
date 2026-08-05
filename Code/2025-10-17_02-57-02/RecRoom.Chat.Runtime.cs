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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83D8580", Offset = "0x83D6B80", VA = "0x1883D8580")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
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
		[Cpp2IlInjected.Address(RVA = "0x83DC260", Offset = "0x83DA860", VA = "0x1883DC260", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2980B40", Offset = "0x297F140", VA = "0x182980B40")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : OXXFIKBTYBG
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class IKYMTVTNISZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage FDUUUVPEUHX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> LGRJBCZOLCO;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public IKYMTVTNISZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x83D68F0", Offset = "0x83D4EF0", VA = "0x1883D68F0")]
			internal VCIEUBMMHTW NISENMKMAUM(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x83D6B10", Offset = "0x83D5110", VA = "0x1883D6B10")]
			internal void NIXLKTEJKFV(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class RBIUPPLHNXI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage FDUUUVPEUHX;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RBIUPPLHNXI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x83D9790", Offset = "0x83D7D90", VA = "0x1883D9790")]
			internal void TMPCKHDKTKF(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class SXOZHASCAVJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public EVXIRGERBJR.MessageContentType MONHAEZZWOJ;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SXOZHASCAVJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x83D9D70", Offset = "0x83D8370", VA = "0x1883D9D70")]
			internal bool PYPMPVDPFFW(DSTWPYTBKAC a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly EVXIRGERBJR.JXMFOSWQNFB MFTWUTDEALO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int BUCYYCNFXRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<DSTWPYTBKAC> RBZEQCENLOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly UCJWGSBJAXC CBPBOKSFKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly QWKEAPSAYVU SUOHNSPOVDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly XMLZEWDRUPR NWAAREWCWYO;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83D6660", Offset = "0x83D4C60", VA = "0x1883D6660")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] UCJWGSBJAXC accountsClient, [Inject(null)] QWKEAPSAYVU chatClient, [Inject(null)] XMLZEWDRUPR clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83D5DB0", Offset = "0x83D43B0", VA = "0x1883D5DB0", Slot = "5")]
		public bool GUYZXRQLCTA(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83D5FA0", Offset = "0x83D45A0", VA = "0x1883D5FA0", Slot = "6")]
		public ChatMessage HMOKRUNEFBC(long a, EVXIRGERBJR.JXMFOSWQNFB b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83D6220", Offset = "0x83D4820", VA = "0x1883D6220", Slot = "7")]
		public NDLOPTUCVYP<EVXIRGERBJR.FRRUVBUVFER> XVJMIPCWDJQ(EVXIRGERBJR.JXMFOSWQNFB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83D6120", Offset = "0x83D4720", VA = "0x1883D6120", Slot = "4")]
		public void SZGJLOFBSVC(DSTWPYTBKAC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83D5CC0", Offset = "0x83D42C0", VA = "0x1883D5CC0", Slot = "8")]
		public void FJHRTXRYNTN(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83D57E0", Offset = "0x83D3DE0", VA = "0x1883D57E0")]
		private EVXIRGERBJR.JXMFOSWQNFB AFDPOGYDWLP(EVXIRGERBJR.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83D6390", Offset = "0x83D4990", VA = "0x1883D6390")]
		private void YRBHOJFSICW(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83D59E0", Offset = "0x83D3FE0", VA = "0x1883D59E0")]
		private void BKOUZWHPOIZ(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83D5BE0", Offset = "0x83D41E0", VA = "0x1883D5BE0")]
		private DSTWPYTBKAC FHDWQAZMNZM(int a, EVXIRGERBJR.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface OXXFIKBTYBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SZGJLOFBSVC(DSTWPYTBKAC a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool GUYZXRQLCTA(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage HMOKRUNEFBC(long a, EVXIRGERBJR.JXMFOSWQNFB b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		NDLOPTUCVYP<EVXIRGERBJR.FRRUVBUVFER> XVJMIPCWDJQ(EVXIRGERBJR.JXMFOSWQNFB a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FJHRTXRYNTN(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface KNREEEYGMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		YQBTYEHUFCJ<KNREEEYGMMJ> JVIZWFQAZTF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool UDBHSFERRUX
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<XJWMJDYGDPZ> ASXXGTWUDOA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string EPIXYLBKGFW
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		VCIEUBMMHTW RFJYITYFQSE();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : EVXIRGERBJR.JXMFOSWQNFB
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override EVXIRGERBJR.MessageContentType VDKOZRQAPMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "10")]
			get
			{
				return default(EVXIRGERBJR.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83D87F0", Offset = "0x83D6DF0", VA = "0x1883D87F0")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83D8750", Offset = "0x83D6D50", VA = "0x1883D8750")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : EVXIRGERBJR.JXMFOSWQNFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long KOBJFCNAHDE;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override EVXIRGERBJR.MessageContentType VDKOZRQAPMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB02440", Offset = "0xB00A40", VA = "0x180B02440", Slot = "10")]
			get
			{
				return default(EVXIRGERBJR.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string XUTFSMOWUBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xB674E0", Offset = "0xB65AE0", VA = "0x180B674E0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long ZMPFCLZHQQZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x83D89F0", Offset = "0x83D6FF0", VA = "0x1883D89F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83D8AB0", Offset = "0x83D70B0", VA = "0x1883D8AB0")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83D8A70", Offset = "0x83D7070", VA = "0x1883D8A70")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class RKANEDIWOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83D97C0", Offset = "0x83D7DC0", VA = "0x1883D97C0")]
		[ZOKCDQOPSGU.Root]
		internal static void KQPBNJXDMTF(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83D9AA0", Offset = "0x83D80A0", VA = "0x1883D9AA0")]
		[UnityEngine.Scripting.Preserve]
		public RKANEDIWOBN([Inject(null)] OXXFIKBTYBG chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] MXJIKQBDLVV textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class MUQXGHHQZRE
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class AUWAEQXFGZW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public KNREEEYGMMJ GTTRQBAVLXJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool TWLKONODLOI;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public AUWAEQXFGZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x83D5780", Offset = "0x83D3D80", VA = "0x1883D5780")]
			internal string MQDALWHFJBI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] SGGOHTAZFVS;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83D7B40", Offset = "0x83D6140", VA = "0x1883D7B40")]
		public static NDLOPTUCVYP<string> IBCMFKDWIDK(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83D7C10", Offset = "0x83D6210", VA = "0x1883D7C10")]
		public static NDLOPTUCVYP<string> IBCMFKDWIDK(EVXIRGERBJR.JXMFOSWQNFB a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83D7F60", Offset = "0x83D6560", VA = "0x1883D7F60")]
		private static string SVKLJDBDXWY(KNREEEYGMMJ a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83D7A40", Offset = "0x83D6040", VA = "0x1883D7A40")]
		public static string AWJYJDLSILQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83D7930", Offset = "0x83D5F30", VA = "0x1883D7930")]
		public static string ARSBZMJRLFH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83D8370", Offset = "0x83D6970", VA = "0x1883D8370")]
		public static bool ZDXKMNRRHPI(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83D78C0", Offset = "0x83D5EC0", VA = "0x1883D78C0")]
		public static bool AAUQDYRVVCP(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83D7F30", Offset = "0x83D6530", VA = "0x1883D7F30")]
		public static bool LAGBZRLBYPK(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83D8220", Offset = "0x83D6820", VA = "0x1883D8220")]
		public static string VCCYRONFOQC(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : EVXIRGERBJR.JXMFOSWQNFB, KNREEEYGMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public YQBTYEHUFCJ<KNREEEYGMMJ> JVIZWFQAZTF
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<XJWMJDYGDPZ> ASXXGTWUDOA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool UDBHSFERRUX
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x83DB1A0", Offset = "0x83D97A0", VA = "0x1883DB1A0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool HFYUEIOIRYO
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x83DB3D0", Offset = "0x83D99D0", VA = "0x1883DB3D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83DB730", Offset = "0x83D9D30", VA = "0x1883DB730")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83DB460", Offset = "0x83D9A60", VA = "0x1883DB460")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83DB620", Offset = "0x83D9C20", VA = "0x1883DB620")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83DB0B0", Offset = "0x83D96B0", VA = "0x1883DB0B0", Slot = "17")]
		public void ROWEVUQQJAU(XJWMJDYGDPZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83DACE0", Offset = "0x83D92E0", VA = "0x1883DACE0", Slot = "16")]
		public VCIEUBMMHTW RFJYITYFQSE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83DB2E0", Offset = "0x83D98E0", VA = "0x1883DB2E0")]
		private void UNKMRJYEEJZ(XJWMJDYGDPZ a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class XJWMJDYGDPZ : IEquatable<XJWMJDYGDPZ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public YQBTYEHUFCJ<XJWMJDYGDPZ> JVIZWFQAZTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool UDBHSFERRUX
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB90C00", Offset = "0xB8F200", VA = "0x180B90C00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAB3D10", Offset = "0xAB2310", VA = "0x180AB3D10", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool HFYUEIOIRYO
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x83DBC70", Offset = "0x83DA270", VA = "0x1883DBC70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string BUGNXTPWRLO
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA7770", Offset = "0xAA5D70", VA = "0x180AA7770")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long QQXLFAIIAYI
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EF0", Offset = "0xAAF4F0", VA = "0x180AB0EF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string CUHMVJLQTEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object VVXYXOQLONQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEE0", Offset = "0xAAE4E0", VA = "0x180AAFEE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAB0770", Offset = "0xAAED70", VA = "0x180AB0770")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public VCIEUBMMHTW VKPLRIDTHVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAB0EE0", Offset = "0xAAF4E0", VA = "0x180AB0EE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAB1500", Offset = "0xAAFB00", VA = "0x180AB1500")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83DBD60", Offset = "0x83DA360", VA = "0x1883DBD60")]
		protected XJWMJDYGDPZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x83DBCB0", Offset = "0x83DA2B0", VA = "0x1883DBCB0")]
		protected XJWMJDYGDPZ(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x83DBE00", Offset = "0x83DA400", VA = "0x1883DBE00")]
		protected XJWMJDYGDPZ(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x83DBBF0", Offset = "0x83DA1F0", VA = "0x1883DBBF0")]
		protected void FVYAYNUGGFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x83DBA90", Offset = "0x83DA090", VA = "0x1883DBA90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x83DBC40", Offset = "0x83DA240", VA = "0x1883DBC40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x83DBB70", Offset = "0x83DA170", VA = "0x1883DBB70", Slot = "4")]
		public bool Equals(XJWMJDYGDPZ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string OVDGTZCAPFZ(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class PKDFPNNSPAN<a, b> : XJWMJDYGDPZ where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class TBDIAOPJOEZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public FOBJSUETHEV ZAKDGHJZJJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public PKDFPNNSPAN<a, b> CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public TBDIAOPJOEZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x6128060", Offset = "0x6126660", VA = "0x186128060")]
			internal void LZTFVDTSQKB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a VVXYXOQLONQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5C82230", Offset = "0x5C80830", VA = "0x185C82230")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x5C821C0", Offset = "0x5C807C0", VA = "0x185C821C0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5C822A0", Offset = "0x5C808A0", VA = "0x185C822A0")]
		protected PKDFPNNSPAN(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5C82350", Offset = "0x5C80950", VA = "0x185C82350")]
		protected PKDFPNNSPAN(string a, long b, string c, NDLOPTUCVYP<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void TUNUYSYZSWG(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5C821E0", Offset = "0x5C807E0", VA = "0x185C821E0")]
		private void OYSXWUNXCOH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5C82280", Offset = "0x5C80880", VA = "0x185C82280")]
		[CompilerGenerated]
		private void ZFHDQXAZAUQ(string a)
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
	public class ZBZFYRSWOTJ : PKDFPNNSPAN<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xDED9C0", Offset = "0xDEBFC0", VA = "0x180DED9C0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83DBFA0", Offset = "0x83DA5A0", VA = "0x1883DBFA0")]
		public ZBZFYRSWOTJ(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x83DBFF0", Offset = "0x83DA5F0", VA = "0x1883DBFF0")]
		public ZBZFYRSWOTJ(string a, long b, string c, NDLOPTUCVYP<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x83DBED0", Offset = "0x83DA4D0", VA = "0x1883DBED0", Slot = "9")]
		public override string OVDGTZCAPFZ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x83DBF40", Offset = "0x83DA540", VA = "0x1883DBF40", Slot = "10")]
		protected override void TUNUYSYZSWG(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class OUZONAHFAHB : PKDFPNNSPAN<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD8C2E0", Offset = "0xD8A8E0", VA = "0x180D8C2E0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83D86E0", Offset = "0x83D6CE0", VA = "0x1883D86E0")]
		public OUZONAHFAHB(string a, long b, string c, NDLOPTUCVYP<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83D8600", Offset = "0x83D6C00", VA = "0x1883D8600", Slot = "9")]
		public override string OVDGTZCAPFZ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83D8690", Offset = "0x83D6C90", VA = "0x1883D8690", Slot = "10")]
		protected override void TUNUYSYZSWG(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class XFIHWKOAAPK : PKDFPNNSPAN<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB02440", Offset = "0xB00A40", VA = "0x180B02440", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x83DBA20", Offset = "0x83DA020", VA = "0x1883DBA20")]
		public XFIHWKOAAPK(string a, long b, string c, NDLOPTUCVYP<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x83DB8C0", Offset = "0x83D9EC0", VA = "0x1883DB8C0", Slot = "9")]
		public override string OVDGTZCAPFZ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83DB9B0", Offset = "0x83D9FB0", VA = "0x1883DB9B0", Slot = "10")]
		protected override void TUNUYSYZSWG(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ZSEPCBDBCIO : PKDFPNNSPAN<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xC1A480", Offset = "0xC18A80", VA = "0x180C1A480", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool HFYUEIOIRYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x83DC120", Offset = "0x83DA720", VA = "0x1883DC120", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x83DC1A0", Offset = "0x83DA7A0", VA = "0x1883DC1A0")]
		public ZSEPCBDBCIO(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83DC1F0", Offset = "0x83DA7F0", VA = "0x1883DC1F0")]
		public ZSEPCBDBCIO(string a, long b, string c, NDLOPTUCVYP<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83DC060", Offset = "0x83DA660", VA = "0x1883DC060", Slot = "9")]
		public override string OVDGTZCAPFZ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83DC0D0", Offset = "0x83DA6D0", VA = "0x1883DC0D0", Slot = "10")]
		protected override void TUNUYSYZSWG(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class JIDGNNFTYNY : PKDFPNNSPAN<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] UTCGEHPUYVC;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string RCLTRCAKXFS
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAACD40", Offset = "0xAAB340", VA = "0x180AACD40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAACAB0", Offset = "0xAAB0B0", VA = "0x180AACAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType BTZTINVWBHG
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool HFYUEIOIRYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x83D6C80", Offset = "0x83D5280", VA = "0x1883D6C80", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83D6F00", Offset = "0x83D5500", VA = "0x1883D6F00")]
		public JIDGNNFTYNY(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83D6E90", Offset = "0x83D5490", VA = "0x1883D6E90")]
		public JIDGNNFTYNY(string a, long b, string c, NDLOPTUCVYP<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83D6B40", Offset = "0x83D5140", VA = "0x1883D6B40", Slot = "9")]
		public override string OVDGTZCAPFZ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83D6C00", Offset = "0x83D5200", VA = "0x1883D6C00", Slot = "10")]
		protected override void TUNUYSYZSWG(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class TNBLZSZIZQN<a> : DSTWPYTBKAC where a : EVXIRGERBJR.JXMFOSWQNFB, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int QKLWEKEWKXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract EVXIRGERBJR.MessageContentType VDKOZRQAPMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x61CC9A0", Offset = "0x61CAFA0", VA = "0x1861CC9A0", Slot = "7")]
		private EVXIRGERBJR.JXMFOSWQNFB DEYOCWKPGNQ(EVXIRGERBJR.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x61CCAA0", Offset = "0x61CB0A0", VA = "0x1861CCAA0", Slot = "6")]
		private NDLOPTUCVYP<EVXIRGERBJR.FRRUVBUVFER> LPYJIKQPXSR(EVXIRGERBJR.JXMFOSWQNFB a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x61CC8C0", Offset = "0x61CAEC0", VA = "0x1861CC8C0", Slot = "10")]
		public virtual a AFDPOGYDWLP(EVXIRGERBJR.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x61CCB80", Offset = "0x61CB180", VA = "0x1861CCB80", Slot = "11")]
		public virtual NDLOPTUCVYP<EVXIRGERBJR.FRRUVBUVFER> XVJMIPCWDJQ(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "12")]
		protected virtual void GLXKXRWJHAU(a a, EVXIRGERBJR.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x61CCB00", Offset = "0x61CB100", VA = "0x1861CCB00", Slot = "13")]
		protected virtual NDLOPTUCVYP<string> QTDXRUWWMCW(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		protected TNBLZSZIZQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x61CC9C0", Offset = "0x61CAFC0", VA = "0x1861CC9C0")]
		[CompilerGenerated]
		private EVXIRGERBJR.FRRUVBUVFER DHYTSDXCMSG(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface DSTWPYTBKAC
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int QKLWEKEWKXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		EVXIRGERBJR.MessageContentType VDKOZRQAPMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NDLOPTUCVYP<EVXIRGERBJR.FRRUVBUVFER> XVJMIPCWDJQ(EVXIRGERBJR.JXMFOSWQNFB a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		EVXIRGERBJR.JXMFOSWQNFB AFDPOGYDWLP(EVXIRGERBJR.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface MXJIKQBDLVV : DSTWPYTBKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IACITMZSRMK(FQZKIJIOMOW a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : TNBLZSZIZQN<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class ETZBXJPRQDR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool HFYUEIOIRYO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int KRAJPOMGSJR;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string QHZJCNFXTTX
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType BTZTINVWBHG
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xAAA9D0", Offset = "0xAA8FD0", VA = "0x180AAA9D0")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6A0", Offset = "0xAA9CA0", VA = "0x180AAB6A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int GTQGPSNANRV
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x1658470", Offset = "0x1656A70", VA = "0x181658470")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x1658460", Offset = "0x1656A60", VA = "0x181658460")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int CCYADJXGRDO
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xAB7670", Offset = "0xAB5C70", VA = "0x180AB7670")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xAFA730", Offset = "0xAF8D30", VA = "0x180AFA730")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string NCHKXUFJXGM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xAAB6C0", Offset = "0xAA9CC0", VA = "0x180AAB6C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xAAA9B0", Offset = "0xAA8FB0", VA = "0x180AAA9B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x16DF550", Offset = "0x16DDB50", VA = "0x1816DF550")]
			public ETZBXJPRQDR()
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
		private readonly CEZFUKFGJPE FZBLNVCLTYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly UCJWGSBJAXC CBPBOKSFKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly YRLXKMOPLTY YGGQELRZNUN;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int QKLWEKEWKXG
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override EVXIRGERBJR.MessageContentType VDKOZRQAPMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAA7700", Offset = "0xAA5D00", VA = "0x180AA7700", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(EVXIRGERBJR.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x83D7830", Offset = "0x83D5E30", VA = "0x1883D7830")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] CEZFUKFGJPE roomsClient, [Inject(null)] UCJWGSBJAXC accountsClient, [Inject(null)] YRLXKMOPLTY imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x83D77F0", Offset = "0x83D5DF0", VA = "0x1883D77F0", Slot = "11")]
		public override NDLOPTUCVYP<EVXIRGERBJR.FRRUVBUVFER> XVJMIPCWDJQ(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x83D6F50", Offset = "0x83D5550", VA = "0x1883D6F50", Slot = "10")]
		public override TextMessageDetails AFDPOGYDWLP(EVXIRGERBJR.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x83D7070", Offset = "0x83D5670", VA = "0x1883D7070")]
		private void MYJMXQMODJV(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : TNBLZSZIZQN<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int QKLWEKEWKXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override EVXIRGERBJR.MessageContentType VDKOZRQAPMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "9")]
			get
			{
				return default(EVXIRGERBJR.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x83D8800", Offset = "0x83D6E00", VA = "0x1883D8800")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : TNBLZSZIZQN<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int QKLWEKEWKXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override EVXIRGERBJR.MessageContentType VDKOZRQAPMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB02440", Offset = "0xB00A40", VA = "0x180B02440", Slot = "9")]
			get
			{
				return default(EVXIRGERBJR.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83D8AC0", Offset = "0x83D70C0", VA = "0x1883D8AC0", Slot = "12")]
		protected override void GLXKXRWJHAU(PhotoMessageDetails a, EVXIRGERBJR.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83D8C60", Offset = "0x83D7260", VA = "0x1883D8C60")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : TNBLZSZIZQN<TextMessageDetails>, MXJIKQBDLVV, DSTWPYTBKAC
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class RBIUPPLHNXI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails MPZKLQFYNSH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool AHABORFANUZ;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public RBIUPPLHNXI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x83D8FE0", Offset = "0x83D75E0", VA = "0x1883D8FE0")]
			internal EVXIRGERBJR.FRRUVBUVFER AHFJXROHBNC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int XLYSWWTDWKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int FQNNTPFZTMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, FQZKIJIOMOW> ECUDHLISIUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, FQZKIJIOMOW> KTUIEAETFAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private LGMBIWWOVBX<XFIHWKOAAPK> UNDFDDGIJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private LGMBIWWOVBX<JIDGNNFTYNY> MRGMHDIDLTI;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int QKLWEKEWKXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB02440", Offset = "0xB00A40", VA = "0x180B02440", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override EVXIRGERBJR.MessageContentType VDKOZRQAPMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860", Slot = "9")]
			get
			{
				return default(EVXIRGERBJR.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x83DA210", Offset = "0x83D8810", VA = "0x1883DA210", Slot = "14")]
		public void IACITMZSRMK(FQZKIJIOMOW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83DA920", Offset = "0x83D8F20", VA = "0x1883DA920", Slot = "11")]
		public override NDLOPTUCVYP<EVXIRGERBJR.FRRUVBUVFER> XVJMIPCWDJQ(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83D9DF0", Offset = "0x83D83F0", VA = "0x1883D9DF0", Slot = "12")]
		protected override void GLXKXRWJHAU(TextMessageDetails a, EVXIRGERBJR.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x83DA5A0", Offset = "0x83D8BA0", VA = "0x1883DA5A0")]
		private bool MUNVHVNFPOE(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83DA6E0", Offset = "0x83D8CE0", VA = "0x1883DA6E0")]
		private static int NFCHJOMKVYL(TextMessageDetails a, int b, bool c, FQZKIJIOMOW d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83DABC0", Offset = "0x83D91C0", VA = "0x1883DABC0")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class AAIWRMRYTGL<a> : LGMBIWWOVBX<a>, FQZKIJIOMOW, IEquatable<FQZKIJIOMOW>, IEquatable<ChatTokenType> where a : XJWMJDYGDPZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] ZUJKZYWQYZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string AFNDRSMVRWR;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType ZQXWNTNSLMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string AZWQPFNAQLT
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5562300", Offset = "0x5560900", VA = "0x185562300", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char BUKKXFCJXSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char YCSKPTNCNTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType FYBRYWCAGNM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x5562970", Offset = "0x5560F70", VA = "0x185562970", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5562F50", Offset = "0x5561550", VA = "0x185562F50")]
		protected AAIWRMRYTGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5562990", Offset = "0x5560F90", VA = "0x185562990")]
		protected string NYOTBBEGHMD(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5562640", Offset = "0x5560C40", VA = "0x185562640", Slot = "14")]
		public bool IXSFUJNOUNW(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5562D40", Offset = "0x5561340", VA = "0x185562D40", Slot = "15")]
		public void ZSBGJSEWTZJ(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a XSLEOAYTRSO(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5562800", Offset = "0x5560E00", VA = "0x185562800", Slot = "8")]
		private XJWMJDYGDPZ IZEMBTHGIRL(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool RQBBEHZZNEF(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string IVCPCCEYHSF(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5562C60", Offset = "0x5561260", VA = "0x185562C60")]
		private bool TJIBKZNKRWZ(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x55623D0", Offset = "0x55609D0", VA = "0x1855623D0")]
		private string CIITAGQDSMH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5562A90", Offset = "0x5561090", VA = "0x185562A90", Slot = "6")]
		private bool OJNDPSFTTFH(string a, [Out] XJWMJDYGDPZ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5562820", Offset = "0x5560E20", VA = "0x185562820", Slot = "7")]
		private void LPXEBDXDKCU(XJWMJDYGDPZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5562610", Offset = "0x5560C10", VA = "0x185562610", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5562440", Offset = "0x5560A40", VA = "0x185562440", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5562560", Offset = "0x5560B60", VA = "0x185562560", Slot = "9")]
		public bool Equals(FQZKIJIOMOW other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x55625E0", Offset = "0x5560BE0", VA = "0x1855625E0", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : WPTCNEIVNQZ<ZBZFYRSWOTJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly XMLZEWDRUPR NWAAREWCWYO;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType ZQXWNTNSLMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xDED9C0", Offset = "0xDEBFC0", VA = "0x180DED9C0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char BUKKXFCJXSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1F13F80", Offset = "0x1F12580", VA = "0x181F13F80", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char YCSKPTNCNTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x83D6730", Offset = "0x83D4D30", VA = "0x1883D6730", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x83D6890", Offset = "0x83D4E90", VA = "0x1883D6890")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] XMLZEWDRUPR clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x83D6740", Offset = "0x83D4D40", VA = "0x1883D6740", Slot = "19")]
		protected override ZBZFYRSWOTJ KLHNIGDTNIO(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface FQZKIJIOMOW : IEquatable<FQZKIJIOMOW>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType ZQXWNTNSLMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string AZWQPFNAQLT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool IXSFUJNOUNW(string a, [Out] XJWMJDYGDPZ b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void ZSBGJSEWTZJ(XJWMJDYGDPZ a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		XJWMJDYGDPZ XSLEOAYTRSO(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface LGMBIWWOVBX<a> : FQZKIJIOMOW, IEquatable<FQZKIJIOMOW>, IEquatable<ChatTokenType> where a : XJWMJDYGDPZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : WPTCNEIVNQZ<OUZONAHFAHB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly YRLXKMOPLTY YGGQELRZNUN;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType ZQXWNTNSLMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xD8C2E0", Offset = "0xD8A8E0", VA = "0x180D8C2E0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char BUKKXFCJXSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1F184C0", Offset = "0x1F16AC0", VA = "0x181F184C0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char YCSKPTNCNTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xE83250", Offset = "0xE81850", VA = "0x180E83250", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x83D8990", Offset = "0x83D6F90", VA = "0x1883D8990")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] YRLXKMOPLTY imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x83D8840", Offset = "0x83D6E40", VA = "0x1883D8840", Slot = "19")]
		protected override OUZONAHFAHB KLHNIGDTNIO(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : WPTCNEIVNQZ<XFIHWKOAAPK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly UCJWGSBJAXC CBPBOKSFKOP;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType ZQXWNTNSLMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB02440", Offset = "0xB00A40", VA = "0x180B02440", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char BUKKXFCJXSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1F665E0", Offset = "0x1F64BE0", VA = "0x181F665E0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char YCSKPTNCNTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x83D8CA0", Offset = "0x83D72A0", VA = "0x1883D8CA0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x83D8DC0", Offset = "0x83D73C0", VA = "0x1883D8DC0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] UCJWGSBJAXC accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x83D8CB0", Offset = "0x83D72B0", VA = "0x1883D8CB0", Slot = "19")]
		protected override XFIHWKOAAPK KLHNIGDTNIO(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : WPTCNEIVNQZ<ZSEPCBDBCIO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly GATXGFWKMQF BQBPEMPSIWP;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType ZQXWNTNSLMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xC1A480", Offset = "0xC18A80", VA = "0x180C1A480", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char BUKKXFCJXSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1F13F80", Offset = "0x1F12580", VA = "0x181F13F80", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char YCSKPTNCNTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x83D8E20", Offset = "0x83D7420", VA = "0x1883D8E20", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x83D8F80", Offset = "0x83D7580", VA = "0x1883D8F80")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] GATXGFWKMQF playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x83D8E30", Offset = "0x83D7430", VA = "0x1883D8E30", Slot = "19")]
		protected override ZSEPCBDBCIO KLHNIGDTNIO(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : WPTCNEIVNQZ<JIDGNNFTYNY>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly CEZFUKFGJPE FZBLNVCLTYD;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType ZQXWNTNSLMR
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xC4A0B0", Offset = "0xC486B0", VA = "0x180C4A0B0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char BUKKXFCJXSI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x83D9BF0", Offset = "0x83D81F0", VA = "0x1883D9BF0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char YCSKPTNCNTJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1EF5720", Offset = "0x1EF3D20", VA = "0x181EF5720", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83D9D10", Offset = "0x83D8310", VA = "0x1883D9D10")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] CEZFUKFGJPE roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x83D9C00", Offset = "0x83D8200", VA = "0x1883D9C00", Slot = "19")]
		protected override JIDGNNFTYNY KLHNIGDTNIO(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class WPTCNEIVNQZ<a> : AAIWRMRYTGL<a> where a : XJWMJDYGDPZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6866550", Offset = "0x6864B50", VA = "0x186866550", Slot = "16")]
		public override a XSLEOAYTRSO(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6866390", Offset = "0x6864990", VA = "0x186866390", Slot = "18")]
		protected override string IVCPCCEYHSF(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6866430", Offset = "0x6864A30", VA = "0x186866430", Slot = "17")]
		protected override bool RQBBEHZZNEF(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a KLHNIGDTNIO(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6866590", Offset = "0x6864B90", VA = "0x186866590")]
		protected WPTCNEIVNQZ()
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
