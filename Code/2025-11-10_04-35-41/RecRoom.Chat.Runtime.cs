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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x81560F0", Offset = "0x81554F0", VA = "0x1881560F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xACEB80", Offset = "0xACDF80", VA = "0x180ACEB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8159F20", Offset = "0x8159320", VA = "0x188159F20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x26F2710", Offset = "0x26F1B10", VA = "0x1826F2710")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : SWSHATPZEGS
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class DGZUGYUZOOX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage LHWJRCJPWEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> GREILTJPIII;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public DGZUGYUZOOX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8154550", Offset = "0x8153950", VA = "0x188154550")]
			internal BRWPWCYORRE RKOUYOHCVIC(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8154770", Offset = "0x8153B70", VA = "0x188154770")]
			internal void RKUBVVBAETL(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GZSIQPWDSFW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage LHWJRCJPWEP;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public GZSIQPWDSFW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8155150", Offset = "0x8154550", VA = "0x188155150")]
			internal void FKHRLEBVCNB(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class MTCDKCMSKAV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public ZLRHDGCNNHX.MessageContentType XALJZYAWZVR;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public MTCDKCMSKAV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8156070", Offset = "0x8155470", VA = "0x188156070")]
			internal bool WCIAWJXLUPE(LATUTIJFYGE a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly ZLRHDGCNNHX.LZBEFJRGWFT UQKBPGPBUXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int ROECQBLCXGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<LATUTIJFYGE> YXFMNNNJSCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly GPAMTLMRPTE DPKADNVHNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly NIQSDKUMLQQ HIVHMZQITVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly KXDDQWLZIWV QUZSZJNPBOE;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x81542C0", Offset = "0x81536C0", VA = "0x1881542C0")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] GPAMTLMRPTE accountsClient, [Inject(null)] NIQSDKUMLQQ chatClient, [Inject(null)] KXDDQWLZIWV clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8153DF0", Offset = "0x81531F0", VA = "0x188153DF0", Slot = "5")]
		public bool OYDUKUIMMGU(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x81535B0", Offset = "0x81529B0", VA = "0x1881535B0", Slot = "6")]
		public ChatMessage EHOXANEWKTU(long a, ZLRHDGCNNHX.LZBEFJRGWFT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8153440", Offset = "0x8152840", VA = "0x188153440", Slot = "7")]
		public SPVBYBYHFON<ZLRHDGCNNHX.QMKOIJXPSGD> BDVQOMELHYM(ZLRHDGCNNHX.LZBEFJRGWFT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8153FE0", Offset = "0x81533E0", VA = "0x188153FE0", Slot = "4")]
		public void QVKFITIYBNQ(LATUTIJFYGE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81540E0", Offset = "0x81534E0", VA = "0x1881540E0", Slot = "8")]
		public void SAWOREGDTTL(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8153730", Offset = "0x8152B30", VA = "0x188153730")]
		private ZLRHDGCNNHX.LZBEFJRGWFT KMQZPKAMHDB(ZLRHDGCNNHX.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8153C10", Offset = "0x8153010", VA = "0x188153C10")]
		private void NAEIVKMUJUY(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8153930", Offset = "0x8152D30", VA = "0x188153930")]
		private void KSUUPADZEFN(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8153B30", Offset = "0x8152F30", VA = "0x188153B30")]
		private LATUTIJFYGE MVOAOQGPLFK(int a, ZLRHDGCNNHX.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface SWSHATPZEGS
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QVKFITIYBNQ(LATUTIJFYGE a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OYDUKUIMMGU(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage EHOXANEWKTU(long a, ZLRHDGCNNHX.LZBEFJRGWFT b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		SPVBYBYHFON<ZLRHDGCNNHX.QMKOIJXPSGD> BDVQOMELHYM(ZLRHDGCNNHX.LZBEFJRGWFT a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SAWOREGDTTL(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface NHVQSQMZKTZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		KBLPOZGJAAH<NHVQSQMZKTZ> UJVOWTYBRVL
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool DXYVNJZUUSB
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<YBDQCYTCMWJ> LZHTMWWSILE
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string VQVHWHVOHGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		BRWPWCYORRE NPBUXIQCKWW();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : ZLRHDGCNNHX.LZBEFJRGWFT
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override ZLRHDGCNNHX.MessageContentType FHPZJCZLSCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "10")]
			get
			{
				return default(ZLRHDGCNNHX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8156F30", Offset = "0x8156330", VA = "0x188156F30")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8156E90", Offset = "0x8156290", VA = "0x188156E90")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : ZLRHDGCNNHX.LZBEFJRGWFT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long BCAMCTXNWLK;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override ZLRHDGCNNHX.MessageContentType FHPZJCZLSCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0", Slot = "10")]
			get
			{
				return default(ZLRHDGCNNHX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string SDZSWSQZUFX
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xBF6AF0", Offset = "0xBF5EF0", VA = "0x180BF6AF0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long ZESTXNCSBPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x8157130", Offset = "0x8156530", VA = "0x188157130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x81571F0", Offset = "0x81565F0", VA = "0x1881571F0")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x81571B0", Offset = "0x81565B0", VA = "0x1881571B0")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class HHSWLILTPAN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8155180", Offset = "0x8154580", VA = "0x188155180")]
		[CVOOPLRRRUK.Root]
		internal static void CYELLWXHWON(XRSJVGYQFTW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8155460", Offset = "0x8154860", VA = "0x188155460")]
		[UnityEngine.Scripting.Preserve]
		public HHSWLILTPAN([Inject(null)] SWSHATPZEGS chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] CAQDRPGTTRT textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class PXXAEDWZREQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class OFEBALTHFAS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public NHVQSQMZKTZ PSAREVBLKVT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool HLUZMOYWMTU;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public OFEBALTHFAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8156170", Offset = "0x8155570", VA = "0x188156170")]
			internal string VTIGQFQETMM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] IGDLMFTMVNU;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x81562D0", Offset = "0x81556D0", VA = "0x1881562D0")]
		public static SPVBYBYHFON<string> GPZNJFJVKVQ(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81563A0", Offset = "0x81557A0", VA = "0x1881563A0")]
		public static SPVBYBYHFON<string> GPZNJFJVKVQ(ZLRHDGCNNHX.LZBEFJRGWFT a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8156880", Offset = "0x8155C80", VA = "0x188156880")]
		private static string KFQFNTVUYSS(NHVQSQMZKTZ a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81561D0", Offset = "0x81555D0", VA = "0x1881561D0")]
		public static string ABZBEZWTKVK(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8156B70", Offset = "0x8155F70", VA = "0x188156B70")]
		public static string WGAKCWGSMXJ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8156810", Offset = "0x8155C10", VA = "0x188156810")]
		public static bool IXUZAVOKYFS(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8156C80", Offset = "0x8156080", VA = "0x188156C80")]
		public static bool XLAOZHHPHYB(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8156B40", Offset = "0x8155F40", VA = "0x188156B40")]
		public static bool NUFFZZLEHCG(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81566C0", Offset = "0x8155AC0", VA = "0x1881566C0")]
		public static string HKLUUTJVFPK(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : ZLRHDGCNNHX.LZBEFJRGWFT, NHVQSQMZKTZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public KBLPOZGJAAH<NHVQSQMZKTZ> UJVOWTYBRVL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<YBDQCYTCMWJ> LZHTMWWSILE
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DXYVNJZUUSB
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8158C90", Offset = "0x8158090", VA = "0x188158C90", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool TJTYNZBKWRC
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8158DD0", Offset = "0x81581D0", VA = "0x188158DD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x81595F0", Offset = "0x81589F0", VA = "0x1881595F0")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8159320", Offset = "0x8158720", VA = "0x188159320")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x81594E0", Offset = "0x81588E0", VA = "0x1881594E0")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8158BA0", Offset = "0x8157FA0", VA = "0x188158BA0", Slot = "17")]
		public void CKLOMKQZHXQ(YBDQCYTCMWJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8158E60", Offset = "0x8158260", VA = "0x188158E60", Slot = "16")]
		public BRWPWCYORRE NPBUXIQCKWW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8159230", Offset = "0x8158630", VA = "0x188159230")]
		private void QKCJFJYDIYR(YBDQCYTCMWJ a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class YBDQCYTCMWJ : IEquatable<YBDQCYTCMWJ>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public KBLPOZGJAAH<YBDQCYTCMWJ> UJVOWTYBRVL
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool DXYVNJZUUSB
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xBC19C0", Offset = "0xBC0DC0", VA = "0x180BC19C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xAA7380", Offset = "0xAA6780", VA = "0x180AA7380", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool TJTYNZBKWRC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8159CC0", Offset = "0x81590C0", VA = "0x188159CC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType IRYCWFFEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string BLFKXAUFMKS
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long EAOIUGKJOQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xAAA820", Offset = "0xAA9C20", VA = "0x180AAA820")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAAA000", Offset = "0xAA9400", VA = "0x180AAA000")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string UUDIJZTBEAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object FKNZEDJGSYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAAA810", Offset = "0xAA9C10", VA = "0x180AAA810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xAAA840", Offset = "0xAA9C40", VA = "0x180AAA840")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public BRWPWCYORRE GSJXAYQPTQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xAAA160", Offset = "0xAA9560", VA = "0x180AAA160")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAAA870", Offset = "0xAA9C70", VA = "0x180AAA870")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8159E80", Offset = "0x8159280", VA = "0x188159E80")]
		protected YBDQCYTCMWJ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8159D00", Offset = "0x8159100", VA = "0x188159D00")]
		protected YBDQCYTCMWJ(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8159DB0", Offset = "0x81591B0", VA = "0x188159DB0")]
		protected YBDQCYTCMWJ(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8159C70", Offset = "0x8159070", VA = "0x188159C70")]
		protected void MNCJSWLUWLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8159AE0", Offset = "0x8158EE0", VA = "0x188159AE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8159C40", Offset = "0x8159040", VA = "0x188159C40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8159BC0", Offset = "0x8158FC0", VA = "0x188159BC0", Slot = "4")]
		public bool Equals(YBDQCYTCMWJ other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string LYZWICUQDEB(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class WECQJZGGDBR<a, b> : YBDQCYTCMWJ where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class MWLHREALRTF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public UAAAFZPRYNF COOKTEPZGGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public WECQJZGGDBR<a, b> MXVWDMPVVWS;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public MWLHREALRTF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x57DEA40", Offset = "0x57DDE40", VA = "0x1857DEA40")]
			internal void SUPUNVNNSDR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a FKNZEDJGSYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x65A3AD0", Offset = "0x65A2ED0", VA = "0x1865A3AD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x65A3AB0", Offset = "0x65A2EB0", VA = "0x1865A3AB0")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x65A3F40", Offset = "0x65A3340", VA = "0x1865A3F40")]
		protected WECQJZGGDBR(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x65A3B20", Offset = "0x65A2F20", VA = "0x1865A3B20")]
		protected WECQJZGGDBR(string a, long b, string c, SPVBYBYHFON<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void DRHYAPAJNHC(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x65A3A60", Offset = "0x65A2E60", VA = "0x1865A3A60")]
		private void EXMHYERATND(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x65A3A40", Offset = "0x65A2E40", VA = "0x1865A3A40")]
		[CompilerGenerated]
		private void CRZNAVMFYKW(string a)
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
	public class VTJAMAVSBRT : WECQJZGGDBR<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType IRYCWFFEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB4EDA0", Offset = "0xB4E1A0", VA = "0x180B4EDA0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8159A90", Offset = "0x8158E90", VA = "0x188159A90")]
		public VTJAMAVSBRT(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8159A20", Offset = "0x8158E20", VA = "0x188159A20")]
		public VTJAMAVSBRT(string a, long b, string c, SPVBYBYHFON<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x81599B0", Offset = "0x8158DB0", VA = "0x1881599B0", Slot = "9")]
		public override string LYZWICUQDEB(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8159950", Offset = "0x8158D50", VA = "0x188159950", Slot = "10")]
		protected override void DRHYAPAJNHC(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class LGJOAGOYNSF : WECQJZGGDBR<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType IRYCWFFEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xB411C0", Offset = "0xB405C0", VA = "0x180B411C0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8155690", Offset = "0x8154A90", VA = "0x188155690")]
		public LGJOAGOYNSF(string a, long b, string c, SPVBYBYHFON<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8155600", Offset = "0x8154A00", VA = "0x188155600", Slot = "9")]
		public override string LYZWICUQDEB(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x81555B0", Offset = "0x81549B0", VA = "0x1881555B0", Slot = "10")]
		protected override void DRHYAPAJNHC(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class VKNMYNLYQSK : WECQJZGGDBR<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType IRYCWFFEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x81598E0", Offset = "0x8158CE0", VA = "0x1881598E0")]
		public VKNMYNLYQSK(string a, long b, string c, SPVBYBYHFON<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x81597F0", Offset = "0x8158BF0", VA = "0x1881597F0", Slot = "9")]
		public override string LYZWICUQDEB(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8159780", Offset = "0x8158B80", VA = "0x188159780", Slot = "10")]
		protected override void DRHYAPAJNHC(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class EXMWLGGUNOI : WECQJZGGDBR<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType IRYCWFFEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xB49F40", Offset = "0xB49340", VA = "0x180B49F40", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool TJTYNZBKWRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x8154860", Offset = "0x8153C60", VA = "0x188154860", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x81548E0", Offset = "0x8153CE0", VA = "0x1881548E0")]
		public EXMWLGGUNOI(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8154930", Offset = "0x8153D30", VA = "0x188154930")]
		public EXMWLGGUNOI(string a, long b, string c, SPVBYBYHFON<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x81547F0", Offset = "0x8153BF0", VA = "0x1881547F0", Slot = "9")]
		public override string LYZWICUQDEB(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x81547A0", Offset = "0x8153BA0", VA = "0x1881547A0", Slot = "10")]
		protected override void DRHYAPAJNHC(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class RZRYAMXZSVW : WECQJZGGDBR<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] ZAUHHKIASYS;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string PDWUIGYBAAO
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3370", Offset = "0xAA2770", VA = "0x180AA3370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3390", Offset = "0xAA2790", VA = "0x180AA3390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType IRYCWFFEKLI
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool TJTYNZBKWRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x8157860", Offset = "0x8156C60", VA = "0x188157860", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8157AE0", Offset = "0x8156EE0", VA = "0x188157AE0")]
		public RZRYAMXZSVW(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8157A70", Offset = "0x8156E70", VA = "0x188157A70")]
		public RZRYAMXZSVW(string a, long b, string c, SPVBYBYHFON<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x81577A0", Offset = "0x8156BA0", VA = "0x1881577A0", Slot = "9")]
		public override string LYZWICUQDEB(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8157720", Offset = "0x8156B20", VA = "0x188157720", Slot = "10")]
		protected override void DRHYAPAJNHC(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class KKJXCBAHVJN<a> : LATUTIJFYGE where a : ZLRHDGCNNHX.LZBEFJRGWFT, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int ZRFAADGABRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract ZLRHDGCNNHX.MessageContentType FHPZJCZLSCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x521B090", Offset = "0x521A490", VA = "0x18521B090", Slot = "7")]
		private ZLRHDGCNNHX.LZBEFJRGWFT KMOBKEQUVHW(ZLRHDGCNNHX.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x521B030", Offset = "0x521A430", VA = "0x18521B030", Slot = "6")]
		private SPVBYBYHFON<ZLRHDGCNNHX.QMKOIJXPSGD> HZKPJLHKAZR(ZLRHDGCNNHX.LZBEFJRGWFT a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x521B0B0", Offset = "0x521A4B0", VA = "0x18521B0B0", Slot = "10")]
		public virtual a KMQZPKAMHDB(ZLRHDGCNNHX.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x521AD80", Offset = "0x521A180", VA = "0x18521AD80", Slot = "11")]
		public virtual SPVBYBYHFON<ZLRHDGCNNHX.QMKOIJXPSGD> BDVQOMELHYM(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "12")]
		protected virtual void STZFQKJKHEW(a a, ZLRHDGCNNHX.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x521B190", Offset = "0x521A590", VA = "0x18521B190", Slot = "13")]
		protected virtual SPVBYBYHFON<string> TJELBPBNVII(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		protected KKJXCBAHVJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x521AF50", Offset = "0x521A350", VA = "0x18521AF50")]
		[CompilerGenerated]
		private ZLRHDGCNNHX.QMKOIJXPSGD EYVPYPRVTNW(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface LATUTIJFYGE
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int ZRFAADGABRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		ZLRHDGCNNHX.MessageContentType FHPZJCZLSCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		SPVBYBYHFON<ZLRHDGCNNHX.QMKOIJXPSGD> BDVQOMELHYM(ZLRHDGCNNHX.LZBEFJRGWFT a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		ZLRHDGCNNHX.LZBEFJRGWFT KMQZPKAMHDB(ZLRHDGCNNHX.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface CAQDRPGTTRT : LATUTIJFYGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QVQTUZMIBXW(VKCBSLIYHOM a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : KKJXCBAHVJN<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class NDZIOYTTTLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool TJTYNZBKWRC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int FQFWMSMZDFX;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string IUYIWXRLYQH
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FB0", Offset = "0xAA53B0", VA = "0x180AA5FB0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xAA5FC0", Offset = "0xAA53C0", VA = "0x180AA5FC0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType IRYCWFFEKLI
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xAAC980", Offset = "0xAABD80", VA = "0x180AAC980")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xAB2F40", Offset = "0xAB2340", VA = "0x180AB2F40")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int HYURTNQFJNT
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E64B0", VA = "0x1812E70B0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x12E70C0", Offset = "0x12E64C0", VA = "0x1812E70C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int LTZWRYLSRSS
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xB07AB0", Offset = "0xB06EB0", VA = "0x180B07AB0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string IUFWNANGQBA
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xAAA140", Offset = "0xAA9540", VA = "0x180AAA140")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xAADB00", Offset = "0xAACF00", VA = "0x180AADB00")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x13A5230", Offset = "0x13A4630", VA = "0x1813A5230")]
			public NDZIOYTTTLH()
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
		private readonly PAIIQUKGHBW ZTSQEPORQCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly GPAMTLMRPTE DPKADNVHNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly LRJWANDBBXK TVMJDBEIXYD;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int ZRFAADGABRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override ZLRHDGCNNHX.MessageContentType FHPZJCZLSCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1A0", Offset = "0xAAA5A0", VA = "0x180AAB1A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(ZLRHDGCNNHX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8155FE0", Offset = "0x81553E0", VA = "0x188155FE0")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] PAIIQUKGHBW roomsClient, [Inject(null)] GPAMTLMRPTE accountsClient, [Inject(null)] LRJWANDBBXK imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8155700", Offset = "0x8154B00", VA = "0x188155700", Slot = "11")]
		public override SPVBYBYHFON<ZLRHDGCNNHX.QMKOIJXPSGD> BDVQOMELHYM(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8155EC0", Offset = "0x81552C0", VA = "0x188155EC0", Slot = "10")]
		public override TextMessageDetails KMQZPKAMHDB(ZLRHDGCNNHX.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x8155740", Offset = "0x8154B40", VA = "0x188155740")]
		private void EMWUTWDWGXP(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : KKJXCBAHVJN<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int ZRFAADGABRE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override ZLRHDGCNNHX.MessageContentType FHPZJCZLSCW
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "9")]
			get
			{
				return default(ZLRHDGCNNHX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8156F40", Offset = "0x8156340", VA = "0x188156F40")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : KKJXCBAHVJN<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int ZRFAADGABRE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override ZLRHDGCNNHX.MessageContentType FHPZJCZLSCW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0", Slot = "9")]
			get
			{
				return default(ZLRHDGCNNHX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8157200", Offset = "0x8156600", VA = "0x188157200", Slot = "12")]
		protected override void STZFQKJKHEW(PhotoMessageDetails a, ZLRHDGCNNHX.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x81573A0", Offset = "0x81567A0", VA = "0x1881573A0")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : KKJXCBAHVJN<TextMessageDetails>, CAQDRPGTTRT, LATUTIJFYGE
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class GZSIQPWDSFW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails IOJYWEHVRDT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager MXVWDMPVVWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool JHAIOPGETQP;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public GZSIQPWDSFW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x81549A0", Offset = "0x8153DA0", VA = "0x1881549A0")]
			internal ZLRHDGCNNHX.QMKOIJXPSGD ACIEVSUOFYO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int TUDJQJEVQMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int UKCOFTBKJZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, VKCBSLIYHOM> JQXTWDNLIPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, VKCBSLIYHOM> VGAKZDKKZCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private CUWLXSYHVED<VKNMYNLYQSK> SLMQFSHDVXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private CUWLXSYHVED<RZRYAMXZSVW> ERZNXOURNOM;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int ZRFAADGABRE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override ZLRHDGCNNHX.MessageContentType FHPZJCZLSCW
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "9")]
			get
			{
				return default(ZLRHDGCNNHX.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x81582D0", Offset = "0x81576D0", VA = "0x1881582D0", Slot = "14")]
		public void QVQTUZMIBXW(VKCBSLIYHOM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8157EF0", Offset = "0x81572F0", VA = "0x188157EF0", Slot = "11")]
		public override SPVBYBYHFON<ZLRHDGCNNHX.QMKOIJXPSGD> BDVQOMELHYM(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8158660", Offset = "0x8157A60", VA = "0x188158660", Slot = "12")]
		protected override void STZFQKJKHEW(TextMessageDetails a, ZLRHDGCNNHX.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8158190", Offset = "0x8157590", VA = "0x188158190")]
		private bool MNYWHPPWVBM(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8157CB0", Offset = "0x81570B0", VA = "0x188157CB0")]
		private static int BCGWUEWREIN(TextMessageDetails a, int b, bool c, VKCBSLIYHOM d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8158A80", Offset = "0x8157E80", VA = "0x188158A80")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class XCGIYUZVZBL<a> : CUWLXSYHVED<a>, VKCBSLIYHOM, IEquatable<VKCBSLIYHOM>, IEquatable<ChatTokenType> where a : YBDQCYTCMWJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] LLNLEQAULBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string WZHRVQKOFCP;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType MYRPWPDFPGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string RROZLDYVZAT
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x3DA73F0", Offset = "0x3DA67F0", VA = "0x183DA73F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char QNAALDYIVDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char MTQSLCVIPQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType UTSLNRZQURK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x3DA7AC0", Offset = "0x3DA6EC0", VA = "0x183DA7AC0", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3DA7BD0", Offset = "0x3DA6FD0", VA = "0x183DA7BD0")]
		protected XCGIYUZVZBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3DA72F0", Offset = "0x3DA66F0", VA = "0x183DA72F0")]
		protected string IUYPGDFZLLH(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3DA7900", Offset = "0x3DA6D00", VA = "0x183DA7900", Slot = "14")]
		public bool WNIWTQLPHSC(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3DA77E0", Offset = "0x3DA6BE0", VA = "0x183DA77E0", Slot = "15")]
		public void URLNNCNJUVT(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a GRWOIJGTMUE(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6F80", Offset = "0x3DA6380", VA = "0x183DA6F80", Slot = "8")]
		private YBDQCYTCMWJ CHUYSETMUDF(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool QVXMOPOOTCX(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string YROJHXZAJBZ(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3DA7530", Offset = "0x3DA6930", VA = "0x183DA7530")]
		private bool OLRLMEVABIL(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3DA74C0", Offset = "0x3DA68C0", VA = "0x183DA74C0")]
		private string LIATMLMUSER(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3DA7610", Offset = "0x3DA6A10", VA = "0x183DA7610", Slot = "6")]
		private bool TWYHZUAPKAX(string a, [Out] YBDQCYTCMWJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3DA7170", Offset = "0x3DA6570", VA = "0x183DA7170", Slot = "7")]
		private void GAWCABMGEIG(YBDQCYTCMWJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3DA72C0", Offset = "0x3DA66C0", VA = "0x183DA72C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3DA7050", Offset = "0x3DA6450", VA = "0x183DA7050", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6FD0", Offset = "0x3DA63D0", VA = "0x183DA6FD0", Slot = "9")]
		public bool Equals(VKCBSLIYHOM other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6FA0", Offset = "0x3DA63A0", VA = "0x183DA6FA0", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : GIGYNPEFUPB<VTJAMAVSBRT>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly KXDDQWLZIWV QUZSZJNPBOE;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType MYRPWPDFPGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xB4EDA0", Offset = "0xB4E1A0", VA = "0x180B4EDA0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char QNAALDYIVDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x1BF13C0", Offset = "0x1BF07C0", VA = "0x181BF13C0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char MTQSLCVIPQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x8154390", Offset = "0x8153790", VA = "0x188154390", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x81544F0", Offset = "0x81538F0", VA = "0x1881544F0")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] KXDDQWLZIWV clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x81543A0", Offset = "0x81537A0", VA = "0x1881543A0", Slot = "19")]
		protected override VTJAMAVSBRT RVKTPDBWICI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface VKCBSLIYHOM : IEquatable<VKCBSLIYHOM>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType MYRPWPDFPGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string RROZLDYVZAT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool WNIWTQLPHSC(string a, [Out] YBDQCYTCMWJ b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void URLNNCNJUVT(YBDQCYTCMWJ a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		YBDQCYTCMWJ GRWOIJGTMUE(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface CUWLXSYHVED<a> : VKCBSLIYHOM, IEquatable<VKCBSLIYHOM>, IEquatable<ChatTokenType> where a : YBDQCYTCMWJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : GIGYNPEFUPB<LGJOAGOYNSF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly LRJWANDBBXK TVMJDBEIXYD;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType MYRPWPDFPGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xB411C0", Offset = "0xB405C0", VA = "0x180B411C0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char QNAALDYIVDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x1C00D90", Offset = "0x1C00190", VA = "0x181C00D90", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char MTQSLCVIPQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xB152A0", Offset = "0xB146A0", VA = "0x180B152A0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x81570D0", Offset = "0x81564D0", VA = "0x1881570D0")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] LRJWANDBBXK imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8156F80", Offset = "0x8156380", VA = "0x188156F80", Slot = "19")]
		protected override LGJOAGOYNSF RVKTPDBWICI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : GIGYNPEFUPB<VKNMYNLYQSK>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly GPAMTLMRPTE DPKADNVHNKF;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType MYRPWPDFPGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char QNAALDYIVDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x1C53B00", Offset = "0x1C52F00", VA = "0x181C53B00", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char MTQSLCVIPQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x81573E0", Offset = "0x81567E0", VA = "0x1881573E0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8157500", Offset = "0x8156900", VA = "0x188157500")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] GPAMTLMRPTE accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x81573F0", Offset = "0x81567F0", VA = "0x1881573F0", Slot = "19")]
		protected override VKNMYNLYQSK RVKTPDBWICI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : GIGYNPEFUPB<EXMWLGGUNOI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly EGKCYQPFQKH JYMDZJBUPDX;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType MYRPWPDFPGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xB49F40", Offset = "0xB49340", VA = "0x180B49F40", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char QNAALDYIVDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x1BF13C0", Offset = "0x1BF07C0", VA = "0x181BF13C0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char MTQSLCVIPQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8157560", Offset = "0x8156960", VA = "0x188157560", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x81576C0", Offset = "0x8156AC0", VA = "0x1881576C0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] EGKCYQPFQKH playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8157570", Offset = "0x8156970", VA = "0x188157570", Slot = "19")]
		protected override EXMWLGGUNOI RVKTPDBWICI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : GIGYNPEFUPB<RZRYAMXZSVW>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly PAIIQUKGHBW ZTSQEPORQCF;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType MYRPWPDFPGD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB4FBD0", Offset = "0xB4EFD0", VA = "0x180B4FBD0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char QNAALDYIVDA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8157B30", Offset = "0x8156F30", VA = "0x188157B30", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char MTQSLCVIPQZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x1BC5C70", Offset = "0x1BC5070", VA = "0x181BC5C70", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8157C50", Offset = "0x8157050", VA = "0x188157C50")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] PAIIQUKGHBW roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8157B40", Offset = "0x8156F40", VA = "0x188157B40", Slot = "19")]
		protected override RZRYAMXZSVW RVKTPDBWICI(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class GIGYNPEFUPB<a> : XCGIYUZVZBL<a> where a : YBDQCYTCMWJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0B10", Offset = "0x4EBFF10", VA = "0x184EC0B10", Slot = "16")]
		public override a GRWOIJGTMUE(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0C70", Offset = "0x4EC0070", VA = "0x184EC0C70", Slot = "18")]
		protected override string YROJHXZAJBZ(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0B50", Offset = "0x4EBFF50", VA = "0x184EC0B50", Slot = "17")]
		protected override bool QVXMOPOOTCX(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a RVKTPDBWICI(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4EC0D10", Offset = "0x4EC0110", VA = "0x184EC0D10")]
		protected GIGYNPEFUPB()
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
