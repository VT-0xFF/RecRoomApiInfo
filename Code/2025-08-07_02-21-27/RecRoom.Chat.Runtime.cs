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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x88BA9F0", Offset = "0x88B95F0", VA = "0x1888BA9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x88BDE10", Offset = "0x88BCA10", VA = "0x1888BDE10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[UnityEngine.Scripting.Preserve]
	public class ChatMessageProcessor : RQVMBEXTNGD
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class XLYSDAWRGEK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ChatMessageProcessor VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public ChatMessage MOCCRRTYRJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public Action<ClubDetails> VNUUQCSXUEL;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XLYSDAWRGEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x88BD530", Offset = "0x88BC130", VA = "0x1888BD530")]
			internal ZPYKPRNSTIB NLIHCAUNAGB(ChatThread a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x88BD500", Offset = "0x88BC100", VA = "0x1888BD500")]
			internal void NLDAEUAPQUS(ClubDetails a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KRJUMOXJQBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ChatMessage MOCCRRTYRJE;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public KRJUMOXJQBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x88B9820", Offset = "0x88B8420", VA = "0x1888B9820")]
			internal void FGLLWMFFICI(ChatThread a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class XPNAWOTYTOA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public MTKQDCEMJGY.MessageContentType XGUKPOLHTXY;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XPNAWOTYTOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x88BD750", Offset = "0x88BC350", VA = "0x1888BD750")]
			internal bool MFEESSSHQEP(DSYXBZVGCAX a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly MTKQDCEMJGY.VGUDWZTIVPY PKPQLVLYCAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int UZIDYIEYXDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly List<DSYXBZVGCAX> JPUKPXOQVPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly UODSSUOBYQP AMZANJJSDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly AFXUUMNUWER RFSWDBMZSAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly IUEDFTPCMCW ULBBQDZMGNP;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x88B8480", Offset = "0x88B7080", VA = "0x1888B8480")]
		[UnityEngine.Scripting.Preserve]
		public ChatMessageProcessor([Inject(null)] UODSSUOBYQP accountsClient, [Inject(null)] AFXUUMNUWER chatClient, [Inject(null)] IUEDFTPCMCW clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88B7E30", Offset = "0x88B6A30", VA = "0x1888B7E30", Slot = "5")]
		public bool SSWGTTJXPGL(ChatThread a, ChatResults b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88B7BD0", Offset = "0x88B67D0", VA = "0x1888B7BD0", Slot = "6")]
		public ChatMessage NGPGJQLPTWZ(long a, MTKQDCEMJGY.VGUDWZTIVPY b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88B8210", Offset = "0x88B6E10", VA = "0x1888B8210", Slot = "7")]
		public EWYSBGHBSNQ<MTKQDCEMJGY.LCVVQLNNFLE> ZPEZMHLXPCN(MTKQDCEMJGY.VGUDWZTIVPY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88B8020", Offset = "0x88B6C20", VA = "0x1888B8020", Slot = "4")]
		public void TFLPVVXELXZ(DSYXBZVGCAX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88B8120", Offset = "0x88B6D20", VA = "0x1888B8120", Slot = "8")]
		public void YWBYNTTCWCQ(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88B77D0", Offset = "0x88B63D0", VA = "0x1888B77D0")]
		private MTKQDCEMJGY.VGUDWZTIVPY EHYEZPKZBZI(MTKQDCEMJGY.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88B75F0", Offset = "0x88B61F0", VA = "0x1888B75F0")]
		private void BUQUXKITHAH(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88B79D0", Offset = "0x88B65D0", VA = "0x1888B79D0")]
		private void HWYFPRNWPHG(ChatMessage a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88B7D50", Offset = "0x88B6950", VA = "0x1888B7D50")]
		private DSYXBZVGCAX QDJOHYYPFMZ(int a, MTKQDCEMJGY.MessageContentType b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface RQVMBEXTNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TFLPVVXELXZ(DSYXBZVGCAX a);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool SSWGTTJXPGL(ChatThread a, ChatResults b);

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		ChatMessage NGPGJQLPTWZ(long a, MTKQDCEMJGY.VGUDWZTIVPY b);

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		EWYSBGHBSNQ<MTKQDCEMJGY.LCVVQLNNFLE> ZPEZMHLXPCN(MTKQDCEMJGY.VGUDWZTIVPY a);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void YWBYNTTCWCQ(ChatMessage a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public interface FSOVRHGEGZK
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		HWNZTWGRXOC<FSOVRHGEGZK> GRBHWVJZWLS
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		bool UTRRMOJUEEU
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		HashSet<ZQAXZCKDGUA> BUDESWMIPIF
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string RXLJWTQVVNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ZPYKPRNSTIB ZHVNDQKSPNZ();
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PartyInviteMessageDetails : MTKQDCEMJGY.VGUDWZTIVPY
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override MTKQDCEMJGY.MessageContentType RCZBPDBGTRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "10")]
			get
			{
				return default(MTKQDCEMJGY.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x88BAB10", Offset = "0x88B9710", VA = "0x1888BAB10")]
		public PartyInviteMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x88BAA70", Offset = "0x88B9670", VA = "0x1888BAA70")]
		public PartyInviteMessageDetails(string localAccountDisplayName)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class PhotoMessageDetails : MTKQDCEMJGY.VGUDWZTIVPY
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private long WVVCBGIGGNB;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override MTKQDCEMJGY.MessageContentType RCZBPDBGTRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xDA5DB0", Offset = "0xDA49B0", VA = "0x180DA5DB0", Slot = "10")]
			get
			{
				return default(MTKQDCEMJGY.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public override string ORJGOPCBUGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xF6A7F0", Offset = "0xF693F0", VA = "0x180F6A7F0", Slot = "8")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public long EBRBLBOTQPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x88BAD10", Offset = "0x88B9910", VA = "0x1888BAD10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88BADD0", Offset = "0x88B99D0", VA = "0x1888BADD0")]
		public PhotoMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88BAD90", Offset = "0x88B9990", VA = "0x1888BAD90")]
		public PhotoMessageDetails(long photoId)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class GWFSNNFCRUC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x88B93F0", Offset = "0x88B7FF0", VA = "0x1888B93F0")]
		[IFIZWETSKCB.Root]
		internal static void EOCUNEIODMM(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x88B96D0", Offset = "0x88B82D0", VA = "0x1888B96D0")]
		[UnityEngine.Scripting.Preserve]
		public GWFSNNFCRUC([Inject(null)] RQVMBEXTNGD chatMessageProcessor, [Inject(null)] PartyInviteMessagePackager partyInviteMessagePackager, [Inject(null)] PhotoMessagePackager photoMessagePackager, [Inject(null)] LegacyTextChatMessagePackager legacyTextChatMessagePackager, [Inject(null)] MBPAABNOYDG textChatMessagePackager, [Inject(null)] PlayerChatTokenHandler playerChatTokenHandler, [Inject(null)] RoomChatTokenHandler roomChatTokenHandler, [Inject(null)] PlayerEventChatTokenHandler playerEventChatTokenHandler, [Inject(null)] ClubChatTokenHandler clubChatTokenHandler, [Inject(null)] PhotoChatTokenHandler photoChatTokenHandler)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class DXALADFJZGX
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public FSOVRHGEGZK ZPQVHJFNXSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public bool ARITVPVSZFV;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x88BA020", Offset = "0x88B8C20", VA = "0x1888BA020")]
			internal string SXHJZCYSTNV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly (string Value, string EscapedValue)[] NMZKLRUQCFR;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88B8820", Offset = "0x88B7420", VA = "0x1888B8820")]
		public static EWYSBGHBSNQ<string> IMAVRYCRZAJ(ChatMessage a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88B88F0", Offset = "0x88B74F0", VA = "0x1888B88F0")]
		public static EWYSBGHBSNQ<string> IMAVRYCRZAJ(MTKQDCEMJGY.VGUDWZTIVPY a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x88B8C10", Offset = "0x88B7810", VA = "0x1888B8C10")]
		private static string QSDPQLKZXAV(FSOVRHGEGZK a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x88B9130", Offset = "0x88B7D30", VA = "0x1888B9130")]
		public static string UULPDTFFGUP(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88B8710", Offset = "0x88B7310", VA = "0x1888B8710")]
		public static string CUAZQXHJHUU(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x88B9020", Offset = "0x88B7C20", VA = "0x1888B9020")]
		public static bool RTTRRNMJPLJ(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x88B9090", Offset = "0x88B7C90", VA = "0x1888B9090")]
		public static bool SFTHUMDLXXC(string a, [Out] long b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88B9100", Offset = "0x88B7D00", VA = "0x1888B9100")]
		public static bool THMQNTMPLSH(char a, bool b = true)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88B8ED0", Offset = "0x88B7AD0", VA = "0x1888B8ED0")]
		public static string RMUUTQRNCNP(string a, string b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class TextMessageDetails : MTKQDCEMJGY.VGUDWZTIVPY, FSOVRHGEGZK
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public HWNZTWGRXOC<FSOVRHGEGZK> GRBHWVJZWLS
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HashSet<ZQAXZCKDGUA> BUDESWMIPIF
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool UTRRMOJUEEU
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x88BC8E0", Offset = "0x88BB4E0", VA = "0x1888BC8E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public override bool SNDHVNFTAHT
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x88BCB10", Offset = "0x88BB710", VA = "0x1888BCB10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88BD370", Offset = "0x88BBF70", VA = "0x1888BD370")]
		public TextMessageDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88BD090", Offset = "0x88BBC90", VA = "0x1888BD090")]
		public TextMessageDetails(string text, bool sanitizeMessage = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88BD260", Offset = "0x88BBE60", VA = "0x1888BD260")]
		internal TextMessageDetails(int version, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88BCA20", Offset = "0x88BB620", VA = "0x1888BCA20", Slot = "17")]
		public void AVUDOSXTPHH(ZQAXZCKDGUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x88BCC90", Offset = "0x88BB890", VA = "0x1888BCC90", Slot = "16")]
		public ZPYKPRNSTIB ZHVNDQKSPNZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88BCBA0", Offset = "0x88BB7A0", VA = "0x1888BCBA0")]
		private void YYKAINWURWS(ZQAXZCKDGUA a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public abstract class ZQAXZCKDGUA : IEquatable<ZQAXZCKDGUA>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public HWNZTWGRXOC<ZQAXZCKDGUA> GRBHWVJZWLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public virtual bool UTRRMOJUEEU
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xB69420", Offset = "0xB68020", VA = "0x180B69420", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xB1A400", Offset = "0xB19000", VA = "0x180B1A400", Slot = "6")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public virtual bool SNDHVNFTAHT
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x88BD9D0", Offset = "0x88BC5D0", VA = "0x1888BD9D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public abstract ChatTokenType JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string WAYQLHWNAOH
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xB180B0", Offset = "0xB16CB0", VA = "0x180B180B0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public long PBUQKCPDUGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xB13130", Offset = "0xB11D30", VA = "0x180B13130")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public string FGACHKNNQCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public object WZRBGCPRRWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xB13160", Offset = "0xB11D60", VA = "0x180B13160")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public ZPYKPRNSTIB FTFNFYRKPRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xB13190", Offset = "0xB11D90", VA = "0x180B13190")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x88BDD70", Offset = "0x88BC970", VA = "0x1888BDD70")]
		protected ZQAXZCKDGUA(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x88BDCC0", Offset = "0x88BC8C0", VA = "0x1888BDCC0")]
		protected ZQAXZCKDGUA(long a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x88BDBF0", Offset = "0x88BC7F0", VA = "0x1888BDBF0")]
		protected ZQAXZCKDGUA(string a, long b, string c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x88BDA10", Offset = "0x88BC610", VA = "0x1888BDA10")]
		protected void EHSPUGVVZRJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x88BDA60", Offset = "0x88BC660", VA = "0x1888BDA60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x88BDBC0", Offset = "0x88BC7C0", VA = "0x1888BDBC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x88BDB40", Offset = "0x88BC740", VA = "0x1888BDB40", Slot = "4")]
		public bool Equals(ZQAXZCKDGUA other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract string EUSFNYKLVTM(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public abstract class IKJPXJLYUGS<a, b> : ZQAXZCKDGUA where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class HCFOWLTMZUC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public CUISEVBXVQW GRMTDKEHAFX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public IKJPXJLYUGS<a, b> VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public HCFOWLTMZUC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x546B070", Offset = "0x5469C70", VA = "0x18546B070")]
			internal void IXBYMWPECAS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public new a WZRBGCPRRWH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x555FCF0", Offset = "0x555E8F0", VA = "0x18555FCF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x555FC80", Offset = "0x555E880", VA = "0x18555FC80")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5560160", Offset = "0x555ED60", VA = "0x185560160")]
		protected IKJPXJLYUGS(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x555FD40", Offset = "0x555E940", VA = "0x18555FD40")]
		protected IKJPXJLYUGS(string a, long b, string c, EWYSBGHBSNQ<a> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void WDWPFHTLGYZ(a a);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x555FCA0", Offset = "0x555E8A0", VA = "0x18555FCA0")]
		private void MIYOAKGEGPK(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x555FC60", Offset = "0x555E860", VA = "0x18555FC60")]
		[CompilerGenerated]
		private void GXLYOZTBCSV(string a)
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
	public class RQCTPRPWEEY : IKJPXJLYUGS<Club, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public override ChatTokenType JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xDD0430", Offset = "0xDCF030", VA = "0x180DD0430", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x88BB480", Offset = "0x88BA080", VA = "0x1888BB480")]
		public RQCTPRPWEEY(Club a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x88BB4D0", Offset = "0x88BA0D0", VA = "0x1888BB4D0")]
		public RQCTPRPWEEY(string a, long b, string c, EWYSBGHBSNQ<Club> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x88BB300", Offset = "0x88B9F00", VA = "0x1888BB300", Slot = "9")]
		public override string EUSFNYKLVTM(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x88BB370", Offset = "0x88B9F70", VA = "0x1888BB370", Slot = "10")]
		protected override void WDWPFHTLGYZ(Club a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class SLPDSFZJKMC : IKJPXJLYUGS<Images.SavedImageDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public override ChatTokenType JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD93C40", Offset = "0xD92840", VA = "0x180D93C40", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x88BB7A0", Offset = "0x88BA3A0", VA = "0x1888BB7A0")]
		public SLPDSFZJKMC(string a, long b, string c, EWYSBGHBSNQ<Images.SavedImageDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x88BB6C0", Offset = "0x88BA2C0", VA = "0x1888BB6C0", Slot = "9")]
		public override string EUSFNYKLVTM(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x88BB750", Offset = "0x88BA350", VA = "0x1888BB750", Slot = "10")]
		protected override void WDWPFHTLGYZ(Images.SavedImageDTO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class SPJCIVYYYAT : IKJPXJLYUGS<Account, object>
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public override ChatTokenType JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xDA5DB0", Offset = "0xDA49B0", VA = "0x180DA5DB0", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x88BB970", Offset = "0x88BA570", VA = "0x1888BB970")]
		public SPJCIVYYYAT(string a, long b, string c, EWYSBGHBSNQ<Account> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x88BB810", Offset = "0x88BA410", VA = "0x1888BB810", Slot = "9")]
		public override string EUSFNYKLVTM(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x88BB900", Offset = "0x88BA500", VA = "0x1888BB900", Slot = "10")]
		protected override void WDWPFHTLGYZ(Account a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ZMKZAKKBXBN : IKJPXJLYUGS<PlayerEvent, object>
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public override ChatTokenType JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xC21E00", Offset = "0xC20A00", VA = "0x180C21E00", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public override bool SNDHVNFTAHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x88BD7D0", Offset = "0x88BC3D0", VA = "0x1888BD7D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x88BD980", Offset = "0x88BC580", VA = "0x1888BD980")]
		public ZMKZAKKBXBN(PlayerEvent a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x88BD910", Offset = "0x88BC510", VA = "0x1888BD910")]
		public ZMKZAKKBXBN(string a, long b, string c, EWYSBGHBSNQ<PlayerEvent> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x88BD850", Offset = "0x88BC450", VA = "0x1888BD850", Slot = "9")]
		public override string EUSFNYKLVTM(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x88BD8C0", Offset = "0x88BC4C0", VA = "0x1888BD8C0", Slot = "10")]
		protected override void WDWPFHTLGYZ(PlayerEvent a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class BYEAJUGVOZH : IKJPXJLYUGS<RoomDTO, object>
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly string[] FZFGBCFQWLN;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private string AJYQEHEPBKR
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xB13B40", Offset = "0xB12740", VA = "0x180B13B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public override ChatTokenType JGVJNZJVVLT
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "8")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public override bool SNDHVNFTAHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x88B7110", Offset = "0x88B5D10", VA = "0x1888B7110", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x88B7530", Offset = "0x88B6130", VA = "0x1888B7530")]
		public BYEAJUGVOZH(RoomDTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x88B7580", Offset = "0x88B6180", VA = "0x1888B7580")]
		public BYEAJUGVOZH(string a, long b, string c, EWYSBGHBSNQ<RoomDTO> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x88B7290", Offset = "0x88B5E90", VA = "0x1888B7290", Slot = "9")]
		public override string EUSFNYKLVTM(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x88B7350", Offset = "0x88B5F50", VA = "0x1888B7350", Slot = "10")]
		protected override void WDWPFHTLGYZ(RoomDTO a)
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class EAASNPVNGQS<a> : DSYXBZVGCAX where a : MTKQDCEMJGY.VGUDWZTIVPY, new()
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public abstract int MDWPLBPDAJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public abstract MTKQDCEMJGY.MessageContentType RCZBPDBGTRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x4CAB6C0", Offset = "0x4CAA2C0", VA = "0x184CAB6C0", Slot = "7")]
		private MTKQDCEMJGY.VGUDWZTIVPY WTQBCYKSZBV(MTKQDCEMJGY.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4CAB6E0", Offset = "0x4CAA2E0", VA = "0x184CAB6E0", Slot = "6")]
		private EWYSBGHBSNQ<MTKQDCEMJGY.LCVVQLNNFLE> XHITSIHRUMI(MTKQDCEMJGY.VGUDWZTIVPY a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4CAB500", Offset = "0x4CAA100", VA = "0x184CAB500", Slot = "10")]
		public virtual a EHYEZPKZBZI(MTKQDCEMJGY.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x4CAB740", Offset = "0x4CAA340", VA = "0x184CAB740", Slot = "11")]
		public virtual EWYSBGHBSNQ<MTKQDCEMJGY.LCVVQLNNFLE> ZPEZMHLXPCN(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "12")]
		protected virtual void KVLYZAIEIRZ(a a, MTKQDCEMJGY.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4CAB480", Offset = "0x4CAA080", VA = "0x184CAB480", Slot = "13")]
		protected virtual EWYSBGHBSNQ<string> CZADIUKEGLF(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		protected EAASNPVNGQS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4CAB5E0", Offset = "0x4CAA1E0", VA = "0x184CAB5E0")]
		[CompilerGenerated]
		private MTKQDCEMJGY.LCVVQLNNFLE PWTNYSMEOHX(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface DSYXBZVGCAX
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		int MDWPLBPDAJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		MTKQDCEMJGY.MessageContentType RCZBPDBGTRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "2")]
		EWYSBGHBSNQ<MTKQDCEMJGY.LCVVQLNNFLE> ZPEZMHLXPCN(MTKQDCEMJGY.VGUDWZTIVPY a);

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "3")]
		MTKQDCEMJGY.VGUDWZTIVPY EHYEZPKZBZI(MTKQDCEMJGY.MessageJson a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface MBPAABNOYDG : DSYXBZVGCAX
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YLWPTSIKZLB(DAUJKWTXYFX a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[UnityEngine.Scripting.Preserve]
	public class LegacyTextChatMessagePackager : EAASNPVNGQS<TextMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public class GBWCIWRLLWY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public bool SNDHVNFTAHT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int MVTXXOTLRWU;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public string HYBERPHXOAI
			{
				[Cpp2IlInjected.Token(Token = "0x600009B")]
				[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600009C")]
				[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public MarkupReplacementType JGVJNZJVVLT
			{
				[Cpp2IlInjected.Token(Token = "0x600009D")]
				[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
				[CompilerGenerated]
				get
				{
					return default(MarkupReplacementType);
				}
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xB22FF0", Offset = "0xB21BF0", VA = "0x180B22FF0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public int GCEHJTAGRJQ
			{
				[Cpp2IlInjected.Token(Token = "0x600009F")]
				[Cpp2IlInjected.Address(RVA = "0x16E6ED0", Offset = "0x16E5AD0", VA = "0x1816E6ED0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0x16E6EE0", Offset = "0x16E5AE0", VA = "0x1816E6EE0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public int SHNPKOEHQAF
			{
				[Cpp2IlInjected.Token(Token = "0x60000A1")]
				[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xB6A400", Offset = "0xB69000", VA = "0x180B6A400")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000029")]
			public string CNAABHRPTBL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A3")]
				[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xB1ACA0", Offset = "0xB198A0", VA = "0x180B1ACA0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x1774EE0", Offset = "0x1773AE0", VA = "0x181774EE0")]
			public GBWCIWRLLWY()
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
		private readonly PONTQNAFVST OZJCLAMWAUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly UODSSUOBYQP AMZANJJSDLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private readonly LWDNFWTJTIR ATKNDIXTVGE;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public override int MDWPLBPDAJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public override MTKQDCEMJGY.MessageContentType RCZBPDBGTRD
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB30", Offset = "0xB1E730", VA = "0x180B1FB30", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return default(MTKQDCEMJGY.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x88BA960", Offset = "0x88B9560", VA = "0x1888BA960")]
		[UnityEngine.Scripting.Preserve]
		public LegacyTextChatMessagePackager([Inject(null)] PONTQNAFVST roomsClient, [Inject(null)] UODSSUOBYQP accountsClient, [Inject(null)] LWDNFWTJTIR imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x88BA920", Offset = "0x88B9520", VA = "0x1888BA920", Slot = "11")]
		public override EWYSBGHBSNQ<MTKQDCEMJGY.LCVVQLNNFLE> ZPEZMHLXPCN(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x88BA080", Offset = "0x88B8C80", VA = "0x1888BA080", Slot = "10")]
		public override TextMessageDetails EHYEZPKZBZI(MTKQDCEMJGY.MessageJson a, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x88BA1A0", Offset = "0x88B8DA0", VA = "0x1888BA1A0")]
		private void PTVROINKSIO(TextMessageDetails a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[UnityEngine.Scripting.Preserve]
	public class PartyInviteMessagePackager : EAASNPVNGQS<PartyInviteMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override int MDWPLBPDAJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override MTKQDCEMJGY.MessageContentType RCZBPDBGTRD
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "9")]
			get
			{
				return default(MTKQDCEMJGY.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x88BAB20", Offset = "0x88B9720", VA = "0x1888BAB20")]
		public PartyInviteMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoMessagePackager : EAASNPVNGQS<PhotoMessageDetails>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override int MDWPLBPDAJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override MTKQDCEMJGY.MessageContentType RCZBPDBGTRD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xDA5DB0", Offset = "0xDA49B0", VA = "0x180DA5DB0", Slot = "9")]
			get
			{
				return default(MTKQDCEMJGY.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x88BADE0", Offset = "0x88B99E0", VA = "0x1888BADE0", Slot = "12")]
		protected override void KVLYZAIEIRZ(PhotoMessageDetails a, MTKQDCEMJGY.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x88BAF80", Offset = "0x88B9B80", VA = "0x1888BAF80")]
		public PhotoMessagePackager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[UnityEngine.Scripting.Preserve]
	public class TextChatMessagePackager : EAASNPVNGQS<TextMessageDetails>, MBPAABNOYDG, DSYXBZVGCAX
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class KRJUMOXJQBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public TextMessageDetails IBBTTYTYKIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public TextChatMessagePackager VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public bool KANUJUQJRNE;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public KRJUMOXJQBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x88B9850", Offset = "0x88B8450", VA = "0x1888B9850")]
			internal MTKQDCEMJGY.LCVVQLNNFLE XAETMRZWFXJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly int FUEATVFQQMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly int WKWTIPEFHCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Dictionary<ChatTokenType, DAUJKWTXYFX> KJKCQSBYBEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly Dictionary<string, DAUJKWTXYFX> LTJZMLECNOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private YMSUAOTKCMG<SPJCIVYYYAT> MFTNQPKMWWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private YMSUAOTKCMG<BYEAJUGVOZH> DDEGIQSVCMP;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override int MDWPLBPDAJV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0xDA5DB0", Offset = "0xDA49B0", VA = "0x180DA5DB0", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override MTKQDCEMJGY.MessageContentType RCZBPDBGTRD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xB16800", Offset = "0xB15400", VA = "0x180B16800", Slot = "9")]
			get
			{
				return default(MTKQDCEMJGY.MessageContentType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x88BC190", Offset = "0x88BAD90", VA = "0x1888BC190", Slot = "14")]
		public void YLWPTSIKZLB(DAUJKWTXYFX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x88BC520", Offset = "0x88BB120", VA = "0x1888BC520", Slot = "11")]
		public override EWYSBGHBSNQ<MTKQDCEMJGY.LCVVQLNNFLE> ZPEZMHLXPCN(TextMessageDetails a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x88BB9E0", Offset = "0x88BA5E0", VA = "0x1888BB9E0", Slot = "12")]
		protected override void KVLYZAIEIRZ(TextMessageDetails a, MTKQDCEMJGY.MessageJson b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x88BC050", Offset = "0x88BAC50", VA = "0x1888BC050")]
		private bool SLNSLJEMAPH(TextMessageDetails a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x88BBE10", Offset = "0x88BAA10", VA = "0x1888BBE10")]
		private static int QXSKLJLJWWA(TextMessageDetails a, int b, bool c, DAUJKWTXYFX d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x88BC7C0", Offset = "0x88BB3C0", VA = "0x1888BC7C0")]
		public TextChatMessagePackager()
		{
		}
	}
}
namespace RecRoom.Chat.Runtime.MessagePackagers.TokenHandlers
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class MLALFSKBYCK<a> : YMSUAOTKCMG<a>, DAUJKWTXYFX, IEquatable<DAUJKWTXYFX>, IEquatable<ChatTokenType> where a : ZQAXZCKDGUA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private static readonly char[] JHSATHZSOLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private string ZIJYPZOJWKO;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public abstract ChatTokenType TDXCIZWAYQS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public string LVOVUATPBFY
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x5EB3AC0", Offset = "0x5EB26C0", VA = "0x185EB3AC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		protected abstract char CCXBDOGDPDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		protected abstract char KAFCXNRIGGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private ChatTokenType SOCHGLGSVZD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x17D92D0", Offset = "0x17D7ED0", VA = "0x1817D92D0", Slot = "4")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5EB4370", Offset = "0x5EB2F70", VA = "0x185EB4370")]
		protected MLALFSKBYCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x5EB39C0", Offset = "0x5EB25C0", VA = "0x185EB39C0")]
		protected string LHUDNUVDMNC(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3D60", Offset = "0x5EB2960", VA = "0x185EB3D60", Slot = "14")]
		public bool OLZFYBCEPRL(string a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x5EB4150", Offset = "0x5EB2D50", VA = "0x185EB4150", Slot = "15")]
		public void VEGDCYQTSUU(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "16")]
		public abstract a NESWIKZBIOV(long a = -1L, [Optional] string b);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3730", Offset = "0x5EB2330", VA = "0x185EB3730", Slot = "8")]
		private ZQAXZCKDGUA BZYRTXUZOCO(long a, string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract bool IPMHCNWMEDG(string a, string b, [Out] a c);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "18")]
		protected abstract string KAWKMMIHELE(a a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x5EB4070", Offset = "0x5EB2C70", VA = "0x185EB4070")]
		private bool STMMIPSIWKE(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3920", Offset = "0x5EB2520", VA = "0x185EB3920")]
		private string FGHTTDWKGVE(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3B90", Offset = "0x5EB2790", VA = "0x185EB3B90", Slot = "6")]
		private bool MRORNLIIUHG(string a, [Out] ZQAXZCKDGUA b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3F20", Offset = "0x5EB2B20", VA = "0x185EB3F20", Slot = "7")]
		private void RXYMEGCSVTR(ZQAXZCKDGUA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3990", Offset = "0x5EB2590", VA = "0x185EB3990", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3780", Offset = "0x5EB2380", VA = "0x185EB3780", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5EB38A0", Offset = "0x5EB24A0", VA = "0x185EB38A0", Slot = "9")]
		public bool Equals(DAUJKWTXYFX other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3750", Offset = "0x5EB2350", VA = "0x185EB3750", Slot = "10")]
		public bool Equals(ChatTokenType other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[UnityEngine.Scripting.Preserve]
	public class ClubChatTokenHandler : RTJXCUFMIDS<RQCTPRPWEEY>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private readonly IUEDFTPCMCW ULBBQDZMGNP;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override ChatTokenType TDXCIZWAYQS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0xDD0430", Offset = "0xDCF030", VA = "0x180DD0430", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		protected override char CCXBDOGDPDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x21C8DA0", Offset = "0x21C79A0", VA = "0x1821C8DA0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		protected override char KAFCXNRIGGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x88B8550", Offset = "0x88B7150", VA = "0x1888B8550", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x88B86B0", Offset = "0x88B72B0", VA = "0x1888B86B0")]
		[UnityEngine.Scripting.Preserve]
		public ClubChatTokenHandler([Inject(null)] IUEDFTPCMCW clubsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x88B8560", Offset = "0x88B7160", VA = "0x1888B8560", Slot = "19")]
		protected override RQCTPRPWEEY UMKXXOVRNHV(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface DAUJKWTXYFX : IEquatable<DAUJKWTXYFX>, IEquatable<ChatTokenType>
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		ChatTokenType TDXCIZWAYQS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		string LVOVUATPBFY
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool OLZFYBCEPRL(string a, [Out] ZQAXZCKDGUA b);

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void VEGDCYQTSUU(ZQAXZCKDGUA a);

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		ZQAXZCKDGUA NESWIKZBIOV(long a = -1L, [Optional] string b);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public interface YMSUAOTKCMG<a> : DAUJKWTXYFX, IEquatable<DAUJKWTXYFX>, IEquatable<ChatTokenType> where a : ZQAXZCKDGUA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[UnityEngine.Scripting.Preserve]
	public class PhotoChatTokenHandler : RTJXCUFMIDS<SLPDSFZJKMC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private readonly LWDNFWTJTIR ATKNDIXTVGE;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override ChatTokenType TDXCIZWAYQS
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xD93C40", Offset = "0xD92840", VA = "0x180D93C40", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		protected override char CCXBDOGDPDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x21D9350", Offset = "0x21D7F50", VA = "0x1821D9350", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		protected override char KAFCXNRIGGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xE68B00", Offset = "0xE67700", VA = "0x180E68B00", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x88BACB0", Offset = "0x88B98B0", VA = "0x1888BACB0")]
		[UnityEngine.Scripting.Preserve]
		public PhotoChatTokenHandler([Inject(null)] LWDNFWTJTIR imagesClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x88BAB60", Offset = "0x88B9760", VA = "0x1888BAB60", Slot = "19")]
		protected override SLPDSFZJKMC UMKXXOVRNHV(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerChatTokenHandler : RTJXCUFMIDS<SPJCIVYYYAT>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly UODSSUOBYQP AMZANJJSDLM;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ChatTokenType TDXCIZWAYQS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0xDA5DB0", Offset = "0xDA49B0", VA = "0x180DA5DB0", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		protected override char CCXBDOGDPDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2245B40", Offset = "0x2244740", VA = "0x182245B40", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		protected override char KAFCXNRIGGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x88BAFC0", Offset = "0x88B9BC0", VA = "0x1888BAFC0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x88BB0E0", Offset = "0x88B9CE0", VA = "0x1888BB0E0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerChatTokenHandler([Inject(null)] UODSSUOBYQP accountsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x88BAFD0", Offset = "0x88B9BD0", VA = "0x1888BAFD0", Slot = "19")]
		protected override SPJCIVYYYAT UMKXXOVRNHV(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[UnityEngine.Scripting.Preserve]
	public class PlayerEventChatTokenHandler : RTJXCUFMIDS<ZMKZAKKBXBN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly HNGZNVLNDRY WPTBNKRJWMS;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override ChatTokenType TDXCIZWAYQS
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xC21E00", Offset = "0xC20A00", VA = "0x180C21E00", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		protected override char CCXBDOGDPDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x21C8DA0", Offset = "0x21C79A0", VA = "0x1821C8DA0", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		protected override char KAFCXNRIGGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x88BB140", Offset = "0x88B9D40", VA = "0x1888BB140", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x88BB2A0", Offset = "0x88B9EA0", VA = "0x1888BB2A0")]
		[UnityEngine.Scripting.Preserve]
		public PlayerEventChatTokenHandler([Inject(null)] HNGZNVLNDRY playerEventsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x88BB150", Offset = "0x88B9D50", VA = "0x1888BB150", Slot = "19")]
		protected override ZMKZAKKBXBN UMKXXOVRNHV(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[UnityEngine.Scripting.Preserve]
	public class RoomChatTokenHandler : RTJXCUFMIDS<BYEAJUGVOZH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly PONTQNAFVST OZJCLAMWAUE;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ChatTokenType TDXCIZWAYQS
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xCADC00", Offset = "0xCAC800", VA = "0x180CADC00", Slot = "11")]
			get
			{
				return default(ChatTokenType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		protected override char CCXBDOGDPDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x88BB650", Offset = "0x88BA250", VA = "0x1888BB650", Slot = "12")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		protected override char KAFCXNRIGGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x21AD9D0", Offset = "0x21AC5D0", VA = "0x1821AD9D0", Slot = "13")]
			get
			{
				return default(char);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x88BB660", Offset = "0x88BA260", VA = "0x1888BB660")]
		[UnityEngine.Scripting.Preserve]
		public RoomChatTokenHandler([Inject(null)] PONTQNAFVST roomsClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x88BB540", Offset = "0x88BA140", VA = "0x1888BB540", Slot = "19")]
		protected override BYEAJUGVOZH UMKXXOVRNHV(string a, long b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public abstract class RTJXCUFMIDS<a> : MLALFSKBYCK<a> where a : ZQAXZCKDGUA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6295D90", Offset = "0x6294990", VA = "0x186295D90", Slot = "16")]
		public override a NESWIKZBIOV(long a = -1L, [Optional] string b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6295CF0", Offset = "0x62948F0", VA = "0x186295CF0", Slot = "18")]
		protected override string KAWKMMIHELE(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6295BD0", Offset = "0x62947D0", VA = "0x186295BD0", Slot = "17")]
		protected override bool IPMHCNWMEDG(string a, string b, [Out] a c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "19")]
		protected abstract a UMKXXOVRNHV(string a, long b, string c);

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6295DD0", Offset = "0x62949D0", VA = "0x186295DD0")]
		protected RTJXCUFMIDS()
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
