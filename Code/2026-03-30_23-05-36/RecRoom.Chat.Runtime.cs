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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x83EFF50", Offset = "0x83EED50", VA = "0x1883EFF50")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
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
		[Cpp2IlInjected.Address(RVA = "0x83F4730", Offset = "0x83F3530", VA = "0x1883F4730", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x27B5590", Offset = "0x27B4390", VA = "0x1827B5590")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : YZKDSORKOKM
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class HAZBHBNYXNH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage SOFHYLDYUKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> VQVDJXFJVDU;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HAZBHBNYXNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x83EF2B0", Offset = "0x83EE0B0", VA = "0x1883EF2B0")]
			internal ILWLFVTHXJS IMESHQABQMU(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x83EF4D0", Offset = "0x83EE2D0", VA = "0x1883EF4D0")]
			internal void IMJZEWTYZYD(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class TCCNAOAZRTA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage SOFHYLDYUKJ;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public TCCNAOAZRTA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x83F17F0", Offset = "0x83F05F0", VA = "0x1883F17F0")]
			internal void UJGMQHEYPJP(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class HENKAPLGKWX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public EJAXDRCXSMP.MessageContentType EVTTETTQAIF;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HENKAPLGKWX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x83EF500", Offset = "0x83EE300", VA = "0x1883EF500")]
			internal bool HQTUGTQIZBW(OSQZHYMUYGG a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly EJAXDRCXSMP.NRPDEURRRTN BIXNOLZEVVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int XDBGOLRZMEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<OSQZHYMUYGG> JIERHVAKIGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly EEULVBXHCRG PUPAIEIXPVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly BHWBYYQYEBM BZMBLMRDNBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly KYXEDJOYJKX XORCRGVKSYO;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x83EEBF0", Offset = "0x83ED9F0", VA = "0x1883EEBF0")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] EEULVBXHCRG accountsClient, [Inject(null)] BHWBYYQYEBM chatClient, [Inject(null)] KYXEDJOYJKX clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x83EE900", Offset = "0x83ED700", VA = "0x1883EE900", Slot = "5")]
		public bool XMSJJSQZHCW(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83EDEC0", Offset = "0x83ECCC0", VA = "0x1883EDEC0", Slot = "6")]
		public ChatMessage BSWCPLGIDYE(long a, EJAXDRCXSMP.NRPDEURRRTN b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83EDD50", Offset = "0x83ECB50", VA = "0x1883EDD50", Slot = "7")]
		public YHTYBMEYRGD<EJAXDRCXSMP.AZOPAWOIBOF> BQDAZZLIFQS(EJAXDRCXSMP.NRPDEURRRTN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83EE220", Offset = "0x83ED020", VA = "0x1883EE220", Slot = "4")]
		public void HIQJTTTSPFG(OSQZHYMUYGG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83EE330", Offset = "0x83ED130", VA = "0x1883EE330", Slot = "8")]
		public void JNYOJRFOQJV(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83EE500", Offset = "0x83ED300", VA = "0x1883EE500")]
		private EJAXDRCXSMP.NRPDEURRRTN MCMSDIWMLZH(EJAXDRCXSMP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x83EE040", Offset = "0x83ECE40", VA = "0x1883EE040")]
		private void CKKSLEDUXEW(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83EE700", Offset = "0x83ED500", VA = "0x1883EE700")]
		private void SUZZAXQSFDX(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83EE420", Offset = "0x83ED220", VA = "0x1883EE420")]
		private OSQZHYMUYGG LKADASCNJMW(int a, EJAXDRCXSMP.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface YZKDSORKOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HIQJTTTSPFG(OSQZHYMUYGG a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool XMSJJSQZHCW(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage BSWCPLGIDYE(long a, EJAXDRCXSMP.NRPDEURRRTN b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		YHTYBMEYRGD<EJAXDRCXSMP.AZOPAWOIBOF> BQDAZZLIFQS(EJAXDRCXSMP.NRPDEURRRTN a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JNYOJRFOQJV(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface XLJSHGPZBAF
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		OPVLFDQAAOV<XLJSHGPZBAF> LSECXDOTGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool UIHOWNMTYJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<RLIRVVQOHQP> VCBNYUBGHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string FFDULGKWPQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ILWLFVTHXJS HSVYWRHKJYM();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : EJAXDRCXSMP.NRPDEURRRTN
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override EJAXDRCXSMP.MessageContentType KFVIRKZPPUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB33C40", Offset = "0xB32A40", VA = "0x180B33C40", Slot = "10")]
			get
			{
				return default(EJAXDRCXSMP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83F0070", Offset = "0x83EEE70", VA = "0x1883F0070")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83EFFD0", Offset = "0x83EEDD0", VA = "0x1883EFFD0")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : EJAXDRCXSMP.NRPDEURRRTN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long KXBIKBNTFGG;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override EJAXDRCXSMP.MessageContentType KFVIRKZPPUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xB32A20", Offset = "0xB31820", VA = "0x180B32A20", Slot = "10")]
			get
			{
				return default(EJAXDRCXSMP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string FWNAXSHVBYX
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xCD1DE0", Offset = "0xCD0BE0", VA = "0x180CD1DE0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long YNFEKIOEALD
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x83F0270", Offset = "0x83EF070", VA = "0x1883F0270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83F0330", Offset = "0x83EF130", VA = "0x1883F0330")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83F02F0", Offset = "0x83EF0F0", VA = "0x1883F02F0")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ECFFYGOZVPN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x83EEE80", Offset = "0x83EDC80", VA = "0x1883EEE80")]
		[AUEAKLYJEMA.Root]
		internal static void TBDPYIBHRJV(TNEKCCANHHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83EF160", Offset = "0x83EDF60", VA = "0x1883EF160")]
		[UnityEngine.Scripting.Preserve]
		public ECFFYGOZVPN([Inject(null)] YZKDSORKOKM chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] NHTSZHTCEYL textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class VMBDBYOOUAS
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class IOBBVAODQCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public XLJSHGPZBAF WIMFSAXKAGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool XOHEEFIKENG;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public IOBBVAODQCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x83EF580", Offset = "0x83EE380", VA = "0x1883EF580")]
			internal string JQXECUKWVVY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] LACBZJCZZNS;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83F3DA0", Offset = "0x83F2BA0", VA = "0x1883F3DA0")]
		public static YHTYBMEYRGD<string> OYKSVGRDDMM(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x83F3E70", Offset = "0x83F2C70", VA = "0x1883F3E70")]
		public static YHTYBMEYRGD<string> OYKSVGRDDMM(EJAXDRCXSMP.NRPDEURRRTN a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83F3930", Offset = "0x83F2730", VA = "0x1883F3930")]
		private static string ARSSOEQCAFG(XLJSHGPZBAF a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x83F42E0", Offset = "0x83F30E0", VA = "0x1883F42E0")]
		public static string WOMHBMFAPSO(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83F3BF0", Offset = "0x83F29F0", VA = "0x1883F3BF0")]
		public static string HOUFDVLJVHL(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83F3D00", Offset = "0x83F2B00", VA = "0x1883F3D00")]
		public static bool IYILSSHMSEC(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83F38C0", Offset = "0x83F26C0", VA = "0x1883F38C0")]
		public static bool AAVXPKHQAEX(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83F3D70", Offset = "0x83F2B70", VA = "0x1883F3D70")]
		public static bool KYGKABIRGSU(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83F4190", Offset = "0x83F2F90", VA = "0x1883F4190")]
		public static string RLKXLGUKDKS(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : EJAXDRCXSMP.NRPDEURRRTN, XLJSHGPZBAF
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public OPVLFDQAAOV<XLJSHGPZBAF> LSECXDOTGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<RLIRVVQOHQP> VCBNYUBGHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool UIHOWNMTYJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x83F2870", Offset = "0x83F1670", VA = "0x1883F2870", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool CDREJRHTSIC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x83F2F90", Offset = "0x83F1D90", VA = "0x1883F2F90", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x83F3300", Offset = "0x83F2100", VA = "0x1883F3300")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83F3020", Offset = "0x83F1E20", VA = "0x1883F3020")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83F31F0", Offset = "0x83F1FF0", VA = "0x1883F31F0")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83F29B0", Offset = "0x83F17B0", VA = "0x1883F29B0", Slot = "17")]
		public void FDKQDTFXHGY(RLIRVVQOHQP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83F2AA0", Offset = "0x83F18A0", VA = "0x1883F2AA0", Slot = "16")]
		public ILWLFVTHXJS HSVYWRHKJYM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83F2EA0", Offset = "0x83F1CA0", VA = "0x1883F2EA0")]
		private void HTTHEFTXJAH(RLIRVVQOHQP a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class RLIRVVQOHQP : IEquatable<RLIRVVQOHQP>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public OPVLFDQAAOV<RLIRVVQOHQP> LSECXDOTGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool UIHOWNMTYJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xC70C00", Offset = "0xC6FA00", VA = "0x180C70C00", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xACF2E0", Offset = "0xACE0E0", VA = "0x180ACF2E0", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool CDREJRHTSIC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x83F0A40", Offset = "0x83EF840", VA = "0x1883F0A40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType ULTKTFGCAFO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string RHIFCGQFLKY
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C30", Offset = "0xAC7A30", VA = "0x180AC8C30")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long DSLOMXDZIEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xACC820", Offset = "0xACB620", VA = "0x180ACC820")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xACC840", Offset = "0xACB640", VA = "0x180ACC840")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string ZGRCCMPIFDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAD0080", Offset = "0xACEE80", VA = "0x180AD0080")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object TMZESDKXTOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xACC890", Offset = "0xACB690", VA = "0x180ACC890")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public ILWLFVTHXJS CQVKQRFBEOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACB650", VA = "0x180ACC850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xACC830", Offset = "0xACB630", VA = "0x180ACC830")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x83F0B30", Offset = "0x83EF930", VA = "0x1883F0B30")]
		protected RLIRVVQOHQP(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x83F0A80", Offset = "0x83EF880", VA = "0x1883F0A80")]
		protected RLIRVVQOHQP(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x83F0BD0", Offset = "0x83EF9D0", VA = "0x1883F0BD0")]
		protected RLIRVVQOHQP(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x83F09F0", Offset = "0x83EF7F0", VA = "0x1883F09F0")]
		protected void SLMJTGNCELO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x83F0860", Offset = "0x83EF660", VA = "0x1883F0860", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x83F09C0", Offset = "0x83EF7C0", VA = "0x1883F09C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x83F0940", Offset = "0x83EF740", VA = "0x1883F0940", Slot = "4")]
		public bool Equals(RLIRVVQOHQP other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string SWRDUKASPSX(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class XEPHNXQVLIF<a, b> : RLIRVVQOHQP where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class XYXNNUGHFKB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public OHONQDGFHPH QQPVPNCDQOW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public XEPHNXQVLIF<a, b> FNBWZDPUGEI;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public XYXNNUGHFKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x3EE1620", Offset = "0x3EE0420", VA = "0x183EE1620")]
			internal void OVYPHHURQRD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a TMZESDKXTOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x3ECBE00", Offset = "0x3ECAC00", VA = "0x183ECBE00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x3ECBDC0", Offset = "0x3ECABC0", VA = "0x183ECBDC0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3ECC2A0", Offset = "0x3ECB0A0", VA = "0x183ECC2A0")]
		protected XEPHNXQVLIF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x3ECBE50", Offset = "0x3ECAC50", VA = "0x183ECBE50")]
		protected XEPHNXQVLIF(string a, long b, string c, YHTYBMEYRGD<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void VHYCAGCYUQC(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x3ECBD70", Offset = "0x3ECAB70", VA = "0x183ECBD70")]
		private void HSHVHMCSXZN(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3ECBDE0", Offset = "0x3ECABE0", VA = "0x183ECBDE0")]
		[CompilerGenerated]
		private void IVLAIXELGZG(string a)
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
	public class YEVCIBPXWCL : XEPHNXQVLIF<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType ULTKTFGCAFO
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB32C10", Offset = "0xB31A10", VA = "0x180B32C10", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83F46E0", Offset = "0x83F34E0", VA = "0x1883F46E0")]
		public YEVCIBPXWCL(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x83F4670", Offset = "0x83F3470", VA = "0x1883F4670")]
		public YEVCIBPXWCL(string a, long b, string c, YHTYBMEYRGD<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x83F45A0", Offset = "0x83F33A0", VA = "0x1883F45A0", Slot = "9")]
		public override string SWRDUKASPSX(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x83F4610", Offset = "0x83F3410", VA = "0x1883F4610", Slot = "10")]
		protected override void VHYCAGCYUQC(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class TOIHWLDBJKP : XEPHNXQVLIF<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType ULTKTFGCAFO
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB4BC40", Offset = "0xB4AA40", VA = "0x180B4BC40", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x83F1900", Offset = "0x83F0700", VA = "0x1883F1900")]
		public TOIHWLDBJKP(string a, long b, string c, YHTYBMEYRGD<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x83F1820", Offset = "0x83F0620", VA = "0x1883F1820", Slot = "9")]
		public override string SWRDUKASPSX(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83F18B0", Offset = "0x83F06B0", VA = "0x1883F18B0", Slot = "10")]
		protected override void VHYCAGCYUQC(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class BKWXHZZKCMQ : XEPHNXQVLIF<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType ULTKTFGCAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB32A20", Offset = "0xB31820", VA = "0x180B32A20", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x83EDCE0", Offset = "0x83ECAE0", VA = "0x1883EDCE0")]
		public BKWXHZZKCMQ(string a, long b, string c, YHTYBMEYRGD<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x83EDB80", Offset = "0x83EC980", VA = "0x1883EDB80", Slot = "9")]
		public override string SWRDUKASPSX(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x83EDC70", Offset = "0x83ECA70", VA = "0x1883EDC70", Slot = "10")]
		protected override void VHYCAGCYUQC(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class RQZJHVGCCSS : XEPHNXQVLIF<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType ULTKTFGCAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB36890", Offset = "0xB35690", VA = "0x180B36890", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool CDREJRHTSIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x83F0CA0", Offset = "0x83EFAA0", VA = "0x1883F0CA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x83F0DE0", Offset = "0x83EFBE0", VA = "0x1883F0DE0")]
		public RQZJHVGCCSS(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x83F0E30", Offset = "0x83EFC30", VA = "0x1883F0E30")]
		public RQZJHVGCCSS(string a, long b, string c, YHTYBMEYRGD<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x83F0D20", Offset = "0x83EFB20", VA = "0x1883F0D20", Slot = "9")]
		public override string SWRDUKASPSX(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x83F0D90", Offset = "0x83EFB90", VA = "0x1883F0D90", Slot = "10")]
		protected override void VHYCAGCYUQC(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class UVUDEFERXUG : XEPHNXQVLIF<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] FTPOYTAAEXO;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string QDLCBVKUCFW
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAC63E0", Offset = "0xAC51E0", VA = "0x180AC63E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAC63D0", Offset = "0xAC51D0", VA = "0x180AC63D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType ULTKTFGCAFO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB33C40", Offset = "0xB32A40", VA = "0x180B33C40", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool CDREJRHTSIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x83F3490", Offset = "0x83F2290", VA = "0x1883F3490", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x83F3870", Offset = "0x83F2670", VA = "0x1883F3870")]
		public UVUDEFERXUG(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x83F3800", Offset = "0x83F2600", VA = "0x1883F3800")]
		public UVUDEFERXUG(string a, long b, string c, YHTYBMEYRGD<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x83F3610", Offset = "0x83F2410", VA = "0x1883F3610", Slot = "9")]
		public override string SWRDUKASPSX(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83F36D0", Offset = "0x83F24D0", VA = "0x1883F36D0", Slot = "10")]
		protected override void VHYCAGCYUQC(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class NFFXLYXMSKF<a> : OSQZHYMUYGG where a : EJAXDRCXSMP.NRPDEURRRTN, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int GCSZPDIVSGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract EJAXDRCXSMP.MessageContentType KFVIRKZPPUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x59E7170", Offset = "0x59E5F70", VA = "0x1859E7170", Slot = "7")]
		private EJAXDRCXSMP.NRPDEURRRTN PYENLVZHRGK(EJAXDRCXSMP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x59E6F50", Offset = "0x59E5D50", VA = "0x1859E6F50", Slot = "6")]
		private YHTYBMEYRGD<EJAXDRCXSMP.AZOPAWOIBOF> FWVPEZQJMSN(EJAXDRCXSMP.NRPDEURRRTN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x59E7090", Offset = "0x59E5E90", VA = "0x1859E7090", Slot = "10")]
		public virtual a MCMSDIWMLZH(EJAXDRCXSMP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x59E6D80", Offset = "0x59E5B80", VA = "0x1859E6D80", Slot = "11")]
		public virtual YHTYBMEYRGD<EJAXDRCXSMP.AZOPAWOIBOF> BQDAZZLIFQS(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "12")]
		protected virtual void CRRZEOTWNNS(a a, EJAXDRCXSMP.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x59E7190", Offset = "0x59E5F90", VA = "0x1859E7190", Slot = "13")]
		protected virtual YHTYBMEYRGD<string> UZFCWMWYYBQ(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		protected NFFXLYXMSKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x59E6FB0", Offset = "0x59E5DB0", VA = "0x1859E6FB0")]
		[CompilerGenerated]
		private EJAXDRCXSMP.AZOPAWOIBOF JMOGMQOSTEG(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface OSQZHYMUYGG
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int GCSZPDIVSGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		EJAXDRCXSMP.MessageContentType KFVIRKZPPUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		YHTYBMEYRGD<EJAXDRCXSMP.AZOPAWOIBOF> BQDAZZLIFQS(EJAXDRCXSMP.NRPDEURRRTN a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		EJAXDRCXSMP.NRPDEURRRTN MCMSDIWMLZH(EJAXDRCXSMP.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface NHTSZHTCEYL : OSQZHYMUYGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ONTGOAKUUAW(RHTJUSVCXKC a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : NFFXLYXMSKF<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class FPOMHEHOETZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool CDREJRHTSIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int DQUBLQJCBAP;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string RLSRKXOCSMJ
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType ULTKTFGCAFO
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xAD4260", Offset = "0xAD3060", VA = "0x180AD4260")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAD4960", Offset = "0xAD3760", VA = "0x180AD4960")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int NUEPYIFWCPF
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x14078F0", Offset = "0x14066F0", VA = "0x1814078F0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x1407900", Offset = "0x1406700", VA = "0x181407900")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int POJIWLPCLEM
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xAD8650", Offset = "0xAD7450", VA = "0x180AD8650")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xB27AC0", Offset = "0xB268C0", VA = "0x180B27AC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string JLQTOJSHIFC
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xAD0080", Offset = "0xACEE80", VA = "0x180AD0080")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x1480D10", Offset = "0x147FB10", VA = "0x181480D10")]
			public FPOMHEHOETZ()
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
		private readonly TYEJFIXAOPA ERZGHLUXXJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly EEULVBXHCRG PUPAIEIXPVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly XYGRTXERWZA WABLKZEKMYR;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int GCSZPDIVSGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB33C40", Offset = "0xB32A40", VA = "0x180B33C40", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override EJAXDRCXSMP.MessageContentType KFVIRKZPPUU
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAD3AA0", Offset = "0xAD28A0", VA = "0x180AD3AA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(EJAXDRCXSMP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x83EFEC0", Offset = "0x83EECC0", VA = "0x1883EFEC0")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] TYEJFIXAOPA roomsClient, [Inject(null)] EEULVBXHCRG accountsClient, [Inject(null)] XYGRTXERWZA imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x83EF5E0", Offset = "0x83EE3E0", VA = "0x1883EF5E0", Slot = "11")]
		public override YHTYBMEYRGD<EJAXDRCXSMP.AZOPAWOIBOF> BQDAZZLIFQS(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x83EF620", Offset = "0x83EE420", VA = "0x1883EF620", Slot = "10")]
		public override TextMessageDetails MCMSDIWMLZH(EJAXDRCXSMP.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x83EF740", Offset = "0x83EE540", VA = "0x1883EF740")]
		private void WMFLQLBJNDB(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : NFFXLYXMSKF<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int GCSZPDIVSGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xB33C40", Offset = "0xB32A40", VA = "0x180B33C40", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override EJAXDRCXSMP.MessageContentType KFVIRKZPPUU
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB33C40", Offset = "0xB32A40", VA = "0x180B33C40", Slot = "9")]
			get
			{
				return default(EJAXDRCXSMP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x83F0080", Offset = "0x83EEE80", VA = "0x1883F0080")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : NFFXLYXMSKF<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int GCSZPDIVSGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xB33C40", Offset = "0xB32A40", VA = "0x180B33C40", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override EJAXDRCXSMP.MessageContentType KFVIRKZPPUU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xB32A20", Offset = "0xB31820", VA = "0x180B32A20", Slot = "9")]
			get
			{
				return default(EJAXDRCXSMP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x83F0340", Offset = "0x83EF140", VA = "0x1883F0340", Slot = "12")]
		protected override void CRRZEOTWNNS(PhotoMessageDetails a, EJAXDRCXSMP.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x83F04E0", Offset = "0x83EF2E0", VA = "0x1883F04E0")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : NFFXLYXMSKF<TextMessageDetails>, NHTSZHTCEYL, OSQZHYMUYGG
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class TCCNAOAZRTA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails ADCPUPPAFBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool PCYGQTREUBL;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public TCCNAOAZRTA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x83F1020", Offset = "0x83EFE20", VA = "0x1883F1020")]
			internal EJAXDRCXSMP.AZOPAWOIBOF NXXQCMTPNSA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int BYFONLSNAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int HRXXPINFLOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, RHTJUSVCXKC> UONXPGCHAFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, RHTJUSVCXKC> HVFDWASBVXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private NVLGUUWSICR<BKWXHZZKCMQ> HLTEMAOZWAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private NVLGUUWSICR<UVUDEFERXUG> TVSXUJUQNCS;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int GCSZPDIVSGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xB32A20", Offset = "0xB31820", VA = "0x180B32A20", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override EJAXDRCXSMP.MessageContentType KFVIRKZPPUU
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AB0", Offset = "0xAC68B0", VA = "0x180AC7AB0", Slot = "9")]
			get
			{
				return default(EJAXDRCXSMP.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x83F23C0", Offset = "0x83F11C0", VA = "0x1883F23C0", Slot = "14")]
		public void ONTGOAKUUAW(RHTJUSVCXKC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x83F1970", Offset = "0x83F0770", VA = "0x1883F1970", Slot = "11")]
		public override YHTYBMEYRGD<EJAXDRCXSMP.AZOPAWOIBOF> BQDAZZLIFQS(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x83F1C10", Offset = "0x83F0A10", VA = "0x1883F1C10", Slot = "12")]
		protected override void CRRZEOTWNNS(TextMessageDetails a, EJAXDRCXSMP.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x83F2280", Offset = "0x83F1080", VA = "0x1883F2280")]
		private bool NWZMJPBARMY(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x83F2040", Offset = "0x83F0E40", VA = "0x1883F2040")]
		private static int GGCSJRLZGFN(TextMessageDetails a, int b, bool c, RHTJUSVCXKC d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x83F2750", Offset = "0x83F1550", VA = "0x1883F2750")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class ZWGGEUKVHLB<a> : NVLGUUWSICR<a>, RHTJUSVCXKC, IEquatable<RHTJUSVCXKC>, IEquatable<ChatTokenType> where a : RLIRVVQOHQP
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] JBXLSUHVNLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string XICUPSRLTLH;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType SVBVVTRQMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string TJYUVZOOXUN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x4020740", Offset = "0x401F540", VA = "0x184020740", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char SEBMWGTUHZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char SACIAQINOGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType AGBQYVUFKBM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x4020D40", Offset = "0x401FB40", VA = "0x184020D40", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4021020", Offset = "0x401FE20", VA = "0x184021020")]
		protected ZWGGEUKVHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4020300", Offset = "0x401F100", VA = "0x184020300")]
		protected string CYVTOLNPURV(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4020D60", Offset = "0x401FB60", VA = "0x184020D60", Slot = "14")]
		public bool XFEWASNMRQE(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x4020B40", Offset = "0x401F940", VA = "0x184020B40", Slot = "15")]
		public void QAQCBGMLHSH(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a MEQUPVQXQIW(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4020720", Offset = "0x401F520", VA = "0x184020720", Slot = "8")]
		private RLIRVVQOHQP KGITZDQCXUR(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool SIDFIYKZOTL(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string FXPYTRWOWVL(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4020C60", Offset = "0x401FA60", VA = "0x184020C60")]
		private bool VKEAWFBPYGV(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4020680", Offset = "0x401F480", VA = "0x184020680")]
		private string FFJZIQPGMHZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4020810", Offset = "0x401F610", VA = "0x184020810", Slot = "6")]
		private bool OHLUCQAKXIB(string a, [Out] RLIRVVQOHQP b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x40209F0", Offset = "0x401F7F0", VA = "0x1840209F0", Slot = "7")]
		private void PYDSHQJADSI(RLIRVVQOHQP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x40206F0", Offset = "0x401F4F0", VA = "0x1840206F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4020500", Offset = "0x401F300", VA = "0x184020500", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4020400", Offset = "0x401F200", VA = "0x184020400", Slot = "9")]
		public bool Equals(RHTJUSVCXKC other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x40204D0", Offset = "0x401F2D0", VA = "0x1840204D0", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : ECWDPJSNCLH<YEVCIBPXWCL>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly KYXEDJOYJKX XORCRGVKSYO;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType SVBVVTRQMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xB32C10", Offset = "0xB31A10", VA = "0x180B32C10", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char SEBMWGTUHZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1D884E0", Offset = "0x1D872E0", VA = "0x181D884E0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char SACIAQINOGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x83EECC0", Offset = "0x83EDAC0", VA = "0x1883EECC0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x83EEE20", Offset = "0x83EDC20", VA = "0x1883EEE20")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] KYXEDJOYJKX clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x83EECD0", Offset = "0x83EDAD0", VA = "0x1883EECD0", Slot = "19")]
		protected override YEVCIBPXWCL WVNHVKNFEZI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface RHTJUSVCXKC : IEquatable<RHTJUSVCXKC>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType SVBVVTRQMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string TJYUVZOOXUN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool XFEWASNMRQE(string a, [Out] RLIRVVQOHQP b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void QAQCBGMLHSH(RLIRVVQOHQP a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		RLIRVVQOHQP MEQUPVQXQIW(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface NVLGUUWSICR<a> : RHTJUSVCXKC, IEquatable<RHTJUSVCXKC>, IEquatable<ChatTokenType> where a : RLIRVVQOHQP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : ECWDPJSNCLH<TOIHWLDBJKP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly XYGRTXERWZA WABLKZEKMYR;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType SVBVVTRQMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xB4BC40", Offset = "0xB4AA40", VA = "0x180B4BC40", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char SEBMWGTUHZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1D93AB0", Offset = "0x1D928B0", VA = "0x181D93AB0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char SACIAQINOGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xBE51D0", Offset = "0xBE3FD0", VA = "0x180BE51D0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x83F0210", Offset = "0x83EF010", VA = "0x1883F0210")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] XYGRTXERWZA imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x83F00C0", Offset = "0x83EEEC0", VA = "0x1883F00C0", Slot = "19")]
		protected override TOIHWLDBJKP WVNHVKNFEZI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : ECWDPJSNCLH<BKWXHZZKCMQ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly EEULVBXHCRG PUPAIEIXPVV;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType SVBVVTRQMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xB32A20", Offset = "0xB31820", VA = "0x180B32A20", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char SEBMWGTUHZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1DDB5D0", Offset = "0x1DDA3D0", VA = "0x181DDB5D0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char SACIAQINOGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x83F0520", Offset = "0x83EF320", VA = "0x1883F0520", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x83F0640", Offset = "0x83EF440", VA = "0x1883F0640")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] EEULVBXHCRG accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x83F0530", Offset = "0x83EF330", VA = "0x1883F0530", Slot = "19")]
		protected override BKWXHZZKCMQ WVNHVKNFEZI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : ECWDPJSNCLH<RQZJHVGCCSS>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly GZUHZQQRAIN JMDLHYQHVOT;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType SVBVVTRQMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xB36890", Offset = "0xB35690", VA = "0x180B36890", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char SEBMWGTUHZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1D884E0", Offset = "0x1D872E0", VA = "0x181D884E0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char SACIAQINOGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x83F06A0", Offset = "0x83EF4A0", VA = "0x1883F06A0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x83F0800", Offset = "0x83EF600", VA = "0x1883F0800")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] GZUHZQQRAIN playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x83F06B0", Offset = "0x83EF4B0", VA = "0x1883F06B0", Slot = "19")]
		protected override RQZJHVGCCSS WVNHVKNFEZI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : ECWDPJSNCLH<UVUDEFERXUG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly TYEJFIXAOPA ERZGHLUXXJZ;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType SVBVVTRQMIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB33C40", Offset = "0xB32A40", VA = "0x180B33C40", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char SEBMWGTUHZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x83F0EA0", Offset = "0x83EFCA0", VA = "0x1883F0EA0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char SACIAQINOGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1D6E470", Offset = "0x1D6D270", VA = "0x181D6E470", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83F0FC0", Offset = "0x83EFDC0", VA = "0x1883F0FC0")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] TYEJFIXAOPA roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x83F0EB0", Offset = "0x83EFCB0", VA = "0x1883F0EB0", Slot = "19")]
		protected override UVUDEFERXUG WVNHVKNFEZI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class ECWDPJSNCLH<a> : ZWGGEUKVHLB<a> where a : RLIRVVQOHQP
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4849270", Offset = "0x4848070", VA = "0x184849270", Slot = "16")]
		public override a MEQUPVQXQIW(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x48491D0", Offset = "0x4847FD0", VA = "0x1848491D0", Slot = "18")]
		protected override string FXPYTRWOWVL(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x48492B0", Offset = "0x48480B0", VA = "0x1848492B0", Slot = "17")]
		protected override bool SIDFIYKZOTL(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a WVNHVKNFEZI(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x48493D0", Offset = "0x48481D0", VA = "0x1848493D0")]
		protected ECWDPJSNCLH()
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
