using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.NoEngine.Common;
using UJect.Injection;
using Unity.Netcode;
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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AFB9A0", Offset = "0x9AFA9A0", VA = "0x189AFB9A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD34A60", Offset = "0xD33A60", VA = "0x180D34A60")]
		public NullableAttribute(byte[] P_0)
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

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD34AA0", Offset = "0xD33AA0", VA = "0x180D34AA0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB8E0", Offset = "0x9AFA8E0", VA = "0x189AFB8E0", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.RoomLoading.PhotonClients
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface WDFPTPKJYYM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object CFZWLDTPTNA(ENCTOCDBFMR a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface PFLPMHBFCSJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		WTHWEQNRTBJ FPBEGOCQCMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Task ELETPOPMQXG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task Disconnect([Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<WTHWEQNRTBJ> MYFFHLFDDYT(WTHWEQNRTBJ a, object b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task AKRBGVFPZEO([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OASFMSDWUAR(DisconnectHandler a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface ZTLEQJPTSUS
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		YZDETVQVLVA SIEERCOAYYO
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string QWJRPHQUURL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string ELZIDLQFDYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<bool> GOARBZEANBG(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task Disconnect([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class TYQACIIQAXB
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class XCJTOHJAGEC<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public TaskCompletionSource<a> VRLFPLAXGXU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TMYXSDLHSTG JHKLDYVTMCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public SEVTAIXPQCI ZEPEQNJDATU;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public XCJTOHJAGEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x510C3C0", Offset = "0x510B3C0", VA = "0x18510C3C0")]
			internal void QSLRRITZUCU(DisconnectCause a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x510C180", Offset = "0x510B180", VA = "0x18510C180")]
			internal void NTPGCGOAAAH(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x510C650", Offset = "0x510B650", VA = "0x18510C650")]
			internal void WVPPZDCKWAG(Task<a> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class XJFHWFZXXQX<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TaskCompletionSource<a> VRLFPLAXGXU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public SEVTAIXPQCI ZEPEQNJDATU;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public XJFHWFZXXQX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x51143C0", Offset = "0x51133C0", VA = "0x1851143C0")]
			internal void WEZSDIYLNGI(short a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5113D90", Offset = "0x5112D90", VA = "0x185113D90")]
			internal void CSHBMTPMJXJ(short a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x51139E0", Offset = "0x51129E0", VA = "0x1851139E0")]
			internal void AXJQLZFWIOD(Task<a> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Log AWZAYZHQABY;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3F773F0", Offset = "0x3F763F0", VA = "0x183F773F0")]
		public static void KMOFTUYOCZE<a>(this SEVTAIXPQCI a, TaskCompletionSource<a> b, [NotNull] TMYXSDLHSTG networkClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3F76E80", Offset = "0x3F75E80", VA = "0x183F76E80")]
		public static void EUTQIVTCZTX<b>(this SEVTAIXPQCI a, TaskCompletionSource<b> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface CVPAFACPWQC
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task DisconnectHandler(DisconnectCause disconnectCause);
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct VoidType : IEquatable<VoidType>
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly VoidType Default;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xD24DB0", Offset = "0xD23DB0", VA = "0x180D24DB0", Slot = "4")]
		public bool Equals(VoidType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9AFF7E0", Offset = "0x9AFE7E0", VA = "0x189AFF7E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD0AFA0", Offset = "0xD09FA0", VA = "0x180D0AFA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhotonClientException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBA20", Offset = "0x9AFAA20", VA = "0x189AFBA20")]
		public PhotonClientException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class PhotonFailedToConnectToRegionException : PhotonClientException
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class PhotonFailedToConnectToRoomException : PhotonClientException
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PhotonUnexpectedLeftRoomException : PhotonClientException
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class PhotonDisconnectException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly int? LastExceptionStatusCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly DisconnectCause DisconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBD40", Offset = "0x9AFAD40", VA = "0x189AFBD40")]
		public PhotonDisconnectException(DisconnectCause disconnectCause, Exception innerException, int? lastExceptionStatusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBA80", Offset = "0x9AFAA80", VA = "0x189AFBA80")]
		public static PhotonDisconnectException EZFNXMRNMIB(DisconnectCause a, TMYXSDLHSTG b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PhotonAuthException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBA20", Offset = "0x9AFAA20", VA = "0x189AFBA20")]
		public PhotonAuthException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PhotonRoomJoinException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly short ErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly string DebugMsg;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBF60", Offset = "0x9AFAF60", VA = "0x189AFBF60")]
		public PhotonRoomJoinException(short errorCode, string debugMsg)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class PhotonRoomCreateException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly short ErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string DebugMsg;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBE80", Offset = "0x9AFAE80", VA = "0x189AFBE80")]
		public PhotonRoomCreateException(short errorCode, string debugMsg)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PhotonInvalidNetworkQueueStateException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9AFBA20", Offset = "0x9AFAA20", VA = "0x189AFBA20")]
		public PhotonInvalidNetworkQueueStateException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PhotonFailedToLeaveRoomException : PhotonClientException
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PhotonTcsTimeoutException : TcsTimeoutException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Dictionary<string, string> AdditionalInfo;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ENCTOCDBFMR : IEquatable<ENCTOCDBFMR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string JNWZICABEQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly string? KNONPEOUPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly string? QGUZTGVZHQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly string? LKPYNPFNCMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string YWPRUTEUAYL;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB7A0", Offset = "0x9AFA7A0", VA = "0x189AFB7A0")]
		public ENCTOCDBFMR(string photonRealtimeAppId, string? a, string? b, string? c, string authToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB740", Offset = "0x9AFA740", VA = "0x189AFB740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB5C0", Offset = "0x9AFA5C0", VA = "0x189AFB5C0", Slot = "4")]
		public bool Equals(ENCTOCDBFMR? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB520", Offset = "0x9AFA520", VA = "0x189AFB520", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB650", Offset = "0x9AFA650", VA = "0x189AFB650", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class WTHWEQNRTBJ : ENCTOCDBFMR, IEquatable<WTHWEQNRTBJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly string VCOVMHXOVCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string? UVLTYPGUBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly string? TAWXAQZIDSI;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9AFFB40", Offset = "0x9AFEB40", VA = "0x189AFFB40")]
		public WTHWEQNRTBJ(string a, string b, string c, string? photonRegion, string d, string e, string? voiceConnectionInfo, string? voiceServerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9AFFAE0", Offset = "0x9AFEAE0", VA = "0x189AFFAE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9AFF920", Offset = "0x9AFE920", VA = "0x189AFF920", Slot = "5")]
		public bool Equals(WTHWEQNRTBJ? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9AFF850", Offset = "0x9AFE850", VA = "0x189AFF850", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9AFF9A0", Offset = "0x9AFE9A0", VA = "0x189AFF9A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x15A4230", Offset = "0x15A3230", VA = "0x1815A4230")]
		public static bool OOOEUMVNSLV(WTHWEQNRTBJ? a, WTHWEQNRTBJ? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[RecRoom.NoEngine.Common.Preserve]
	public class AuthPayload
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[JsonProperty(PropertyName = "AI", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public string AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[JsonProperty(PropertyName = "AT", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] AccessToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[JsonProperty(PropertyName = "VB", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] VerificationBlob
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD0C7F0", Offset = "0xD0B7F0", VA = "0x180D0C7F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] ClientKeyA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD0F400", Offset = "0xD0E400", VA = "0x180D0F400")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xD0C800", Offset = "0xD0B800", VA = "0x180D0C800")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[JsonProperty(PropertyName = "CIA", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] ClientIVA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xD0FCD0", Offset = "0xD0ECD0", VA = "0x180D0FCD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xD115A0", Offset = "0xD105A0", VA = "0x180D115A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] ClientPublicKey
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xD0F5E0", Offset = "0xD0E5E0", VA = "0x180D0F5E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public AuthPayload()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RecRoom.NoEngine.Common.Preserve]
	public class ConnectionResponsePayload
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[JsonProperty(PropertyName = "DR", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public string Reason
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD0F470", Offset = "0xD0E470", VA = "0x180D0F470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[JsonProperty(PropertyName = "KT", Required = Required.Default)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] SessionKeyB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xD0CDC0", Offset = "0xD0BDC0", VA = "0x180D0CDC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD0CA90", Offset = "0xD0BA90", VA = "0x180D0CA90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public ConnectionResponsePayload()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class TachyonClient : PFLPMHBFCSJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum ClientState
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			Disconnected,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			Connecting,
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			Connected
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <ConnectToRoomInstance>d__42 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AsyncTaskMethodBuilder<WTHWEQNRTBJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public TachyonClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public object pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public WTHWEQNRTBJ targetRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private TaskAwaiter<WTHWEQNRTBJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9AFE990", Offset = "0x9AFD990", VA = "0x189AFE990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9AFF5A0", Offset = "0x9AFE5A0", VA = "0x189AFF5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <LogWhileInRoom>d__43 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Task<VoidType> whileInRoomTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private TaskAwaiter<VoidType> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9AFF610", Offset = "0x9AFE610", VA = "0x189AFF610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xD6E050", Offset = "0xD6D050", VA = "0x180D6E050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NetworkManager HHXAXJCDZVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskCompletionSource<WTHWEQNRTBJ> WRCCEJXESAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected readonly IDLXRUJKSDP ZEPEQNJDATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		protected readonly WDFPTPKJYYM HYYSVFJFUUU;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Log AWZAYZHQABY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly HashSet<DisconnectHandler> DGIXTHBSIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ClientState VPHRCPOWBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private WTHWEQNRTBJ NPYUFLZZSMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private RSACryptoServiceProvider RQYKDMXMCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private RSACryptoServiceProvider DBFFDQNRKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private AesCryptoServiceProvider GAMLZJPUTYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private byte[] EGAGVUZNVSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskCompletionSource<VoidType> PIHIXLGVEIB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public WTHWEQNRTBJ FPBEGOCQCMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xD0F450", Offset = "0xD0E450", VA = "0x180D0F450", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Task ELETPOPMQXG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9AFC3C0", Offset = "0x9AFB3C0", VA = "0x189AFC3C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9AFDB10", Offset = "0x9AFCB10", VA = "0x189AFDB10", Slot = "8")]
		public void OASFMSDWUAR(DisconnectHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC450", Offset = "0x9AFB450", VA = "0x189AFC450", Slot = "11")]
		public bool CLQAYEGOEIP(WTHWEQNRTBJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE4A0", Offset = "0x9AFD4A0", VA = "0x189AFE4A0")]
		[RecRoom.NoEngine.Common.Preserve]
		public TachyonClient([Inject(null)] IDLXRUJKSDP networking, [Inject(null)] WDFPTPKJYYM _settingsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		private void JDMQVQGLPQS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF90", Offset = "0xD09F90", VA = "0x180D0AF90")]
		private void NYLPITRVJVF(RecRoom.Networking.ClientState a, RecRoom.Networking.ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC660", Offset = "0x9AFB660", VA = "0x189AFC660")]
		private void LJCXKXTTOJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE2B0", Offset = "0x9AFD2B0", VA = "0x189AFE2B0")]
		private void ZSHCOGIJHGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9AFDB70", Offset = "0x9AFCB70", VA = "0x189AFDB70")]
		private void RPYWSZLUPBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9AFD990", Offset = "0x9AFC990", VA = "0x189AFD990")]
		private void NetworkManager_OnClientDisconnectCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9AFDA10", Offset = "0x9AFCA10", VA = "0x189AFDA10")]
		private void NetworkManager_OnClientStopped(bool isServer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC8B0", Offset = "0x9AFB8B0", VA = "0x189AFC8B0")]
		private void MAWWZFNFBXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AFD2D0", Offset = "0x9AFC2D0", VA = "0x189AFD2D0")]
		private void NetworkManager_OnClientConnectedCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9AFDA90", Offset = "0x9AFCA90", VA = "0x189AFDA90")]
		private void NetworkManager_OnTransportFailure()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC5F0", Offset = "0x9AFB5F0", VA = "0x189AFC5F0")]
		private void IEGSLBAFBZR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC150", Offset = "0x9AFB150", VA = "0x189AFC150")]
		private void ADRNBBSAYJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE020", Offset = "0x9AFD020", VA = "0x189AFE020")]
		private void ZEMARUAWHZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9AFDEF0", Offset = "0x9AFCEF0", VA = "0x189AFDEF0")]
		private static (IPAddress, ushort) XMBESVPAQAC(string a)
		{
			return default((IPAddress, ushort));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9AFCAD0", Offset = "0x9AFBAD0", VA = "0x189AFCAD0")]
		private void MJZIUALBZCP(WTHWEQNRTBJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9AFD170", Offset = "0x9AFC170", VA = "0x189AFD170", Slot = "6")]
		[AsyncStateMachine(typeof(<ConnectToRoomInstance>d__42))]
		public Task<WTHWEQNRTBJ> MYFFHLFDDYT(WTHWEQNRTBJ a, object b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9AFDE40", Offset = "0x9AFCE40", VA = "0x189AFDE40")]
		[AsyncStateMachine(typeof(<LogWhileInRoom>d__43))]
		private void VXCCQFHVSKT(Task<VoidType> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC490", Offset = "0x9AFB490", VA = "0x189AFC490", Slot = "5")]
		public Task Disconnect([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC2D0", Offset = "0x9AFB2D0", VA = "0x189AFC2D0", Slot = "7")]
		public Task AKRBGVFPZEO([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC580", Offset = "0x9AFB580", VA = "0x189AFC580", Slot = "10")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class TachyonException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE760", Offset = "0x9AFD760", VA = "0x189AFE760")]
		public TachyonException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE7C0", Offset = "0x9AFD7C0", VA = "0x189AFE7C0")]
		public TachyonException(string message, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class TachyonFailedToConnectToVoiceException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE830", Offset = "0x9AFD830", VA = "0x189AFE830")]
		public TachyonFailedToConnectToVoiceException([NotNull] Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class TachyonFailedToStartNetworkManagerException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9AFE910", Offset = "0x9AFD910", VA = "0x189AFE910")]
		public TachyonFailedToStartNetworkManagerException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class TachyonAlreadyDisconnectedException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9AFC0D0", Offset = "0x9AFB0D0", VA = "0x189AFC0D0")]
		public TachyonAlreadyDisconnectedException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class DQHSYOQWEVN
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static AesCryptoServiceProvider YZSJTCQSFZP;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly string VGACKSKDAYQ;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly string TRFMREFXYYC;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly string OLPYPJCJGHC;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB240", Offset = "0x9AFA240", VA = "0x189AFB240")]
		public static string BGWMUDNVUQQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB290", Offset = "0x9AFA290", VA = "0x189AFB290")]
		public static string GFOGULTUGHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB2E0", Offset = "0x9AFA2E0", VA = "0x189AFB2E0")]
		public static AesCryptoServiceProvider ZUQCDDDKWUR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ALLDKJGLDOD : ZTLEQJPTSUS
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum ClientState
		{
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			Disconnected,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Connecting,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Connected
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private YZDETVQVLVA MUSORYCVIKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private NetworkManager HHXAXJCDZVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected readonly WDFPTPKJYYM HYYSVFJFUUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskCompletionSource<bool> CDJGNSZQFVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public ClientState VPHRCPOWBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RSACryptoServiceProvider RQYKDMXMCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private RSACryptoServiceProvider DBFFDQNRKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private AesCryptoServiceProvider GAMLZJPUTYG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public YZDETVQVLVA SIEERCOAYYO
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string QWJRPHQUURL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xD0F5E0", Offset = "0xD0E5E0", VA = "0x180D0F5E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string ELZIDLQFDYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9AF9950", Offset = "0x9AF8950", VA = "0x189AF9950", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9AFB0A0", Offset = "0x9AFA0A0", VA = "0x189AFB0A0")]
		[UnityEngine.Scripting.Preserve]
		public ALLDKJGLDOD([Inject(null)] WDFPTPKJYYM _settingsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9AF9A70", Offset = "0x9AF8A70", VA = "0x189AF9A70")]
		private void LJCXKXTTOJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9AFAF70", Offset = "0x9AF9F70", VA = "0x189AFAF70")]
		private void ZSHCOGIJHGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9AFA4A0", Offset = "0x9AF94A0", VA = "0x189AFA4A0")]
		private void NetworkManager_OnClientDisconnectCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9AFA8D0", Offset = "0x9AF98D0", VA = "0x189AFA8D0")]
		private void SQDEDARLKHL(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9AFA350", Offset = "0x9AF9350", VA = "0x189AFA350")]
		private void NetworkManager_OnClientConnectedCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9AFA7E0", Offset = "0x9AF97E0", VA = "0x189AFA7E0")]
		private void NetworkManager_OnTransportFailure()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9AF98E0", Offset = "0x9AF88E0", VA = "0x189AF98E0")]
		private void IEGSLBAFBZR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9AFAEB0", Offset = "0x9AF9EB0", VA = "0x189AFAEB0")]
		private void ZEMARUAWHZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9AFAD80", Offset = "0x9AF9D80", VA = "0x189AFAD80")]
		private static (IPAddress, ushort) XMBESVPAQAC(string a)
		{
			return default((IPAddress, ushort));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9AF9C60", Offset = "0x9AF8C60", VA = "0x189AF9C60")]
		private void MJZIUALBZCP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9AF9500", Offset = "0x9AF8500", VA = "0x189AF9500", Slot = "7")]
		public Task<bool> GOARBZEANBG(string a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9AF9460", Offset = "0x9AF8460", VA = "0x189AF9460", Slot = "8")]
		public Task Disconnect([Optional] CancellationToken cancellationToken)
		{
			return null;
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
